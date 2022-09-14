Console.WriteLine("Hello, World!");
Person person = new() { Age = 20, Name="Mohamed Osama Mohamed", PersonType= PersonTypes.Manager};
//To Add all rules realted to this type
new RuleValidatorBuilder<Person>().AddAllTypeRules().Add(new AgeRule(), new NameRule()).Validate(person);
//To add rules manual 
new RuleValidatorBuilder<Person>().Add(new AgeRule(), new NameRule()).Validate(person);
Console.WriteLine("Done Checking");
Console.ReadLine();