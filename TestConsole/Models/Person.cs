namespace TestApp.Models;
public class Person
{
    public string Name { get; set; }
    public string DepartmentName { get; set; }
    public int Age { get; set; }
    public PersonTypes PersonType { get; set; }
}

public enum PersonTypes
{
    Customer,
    Employer,
    Manager
}