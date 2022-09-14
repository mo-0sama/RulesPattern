namespace RuleValidation;
public interface IBusinessRule<T>
{
    void IsValid(T entity);
    bool EnableValidation(T entity);
}