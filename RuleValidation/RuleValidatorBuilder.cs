namespace RuleValidation;
public class RuleValidatorBuilder<R>
{
    private List<IBusinessRule<R>> Rules { get; }
    public RuleValidatorBuilder()
    {
        Rules = new List<IBusinessRule<R>>();
    }
    public RuleValidatorBuilder<R> AddAllTypeRules()
        => Add(AllBusinessRules().ToArray());
    private IEnumerable<IBusinessRule<R>> AllBusinessRules()
        => AppDomain.CurrentDomain.GetAssemblies().Distinct().SelectMany(x => x.GetTypes())
           .Where(x => x.IsAssignableTo(typeof(IBusinessRule<R>))).Select(x => (IBusinessRule<R>)Activator.CreateInstance(x));

    public RuleValidatorBuilder<R> Add(params IBusinessRule<R>[] rules)
    {
        Rules.AddRange(rules);
        return this;
    }
    public bool Validate(R request)
    {
        foreach (var rule in Rules)
            rule.IsValid(request);
        return true;
    }
}