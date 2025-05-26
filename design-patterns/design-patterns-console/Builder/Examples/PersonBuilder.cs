namespace design_patterns_console.Builder.Examples;

public class Person
{
    public string Name;
    public int Age;
}

public class PersonBuilder
{
    private Person _person = new();

    public void NewPerson()
    {
        _person = new Person();
    }

    public PersonBuilder SetName(string name)
    {
        _person.Name = name;
        return this;
    }

    public PersonBuilder SetAge(int age)
    {
        _person.Age = age;
        return this;
    }

    public Person GetResult()
    {
        return _person;
    }
}

/*
var personBuilder = new PersonBuilder();
var person1 = personBuilder.NewPerson()
    .SetName("John")
    .SetAge(30)
    .GetResult();

personBuilder.NewPerson();

var person2 = personBuilder.SetName("Jane")
    .SetAge(25)
    .GetResult();
*/
