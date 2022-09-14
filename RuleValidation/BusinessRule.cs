namespace RuleValidation;
public abstract class BusinessRule<R> : IBusinessRule<R>
{
    public void IsValid(R entity)
    {
        if (EnableValidation(entity))
            Validation(entity);
    }
    protected virtual void Validation(R entity) { }
    public virtual bool EnableValidation(R entity) => true;
}

