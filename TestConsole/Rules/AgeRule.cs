namespace TestConsole.Rules;
public class AgeRule : BusinessRule<Person>
{
    public override bool EnableValidation(Person entity) => entity.PersonType != PersonTypes.Customer;
    protected override void Validation(Person entity)
    {
        if (entity.Age < 18) throw new Exception("Age is less than 18");
    }
}
