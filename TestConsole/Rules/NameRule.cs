namespace TestConsole.Rules;
public class NameRule : BusinessRule<Person>
{
    protected override void Validation(Person entity)
    {
        if (string.IsNullOrEmpty(entity.Name) || entity.Name.Length < 20) throw new Exception("Name characters length is less than 20");
    }
}
