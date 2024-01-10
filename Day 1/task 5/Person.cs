namespace task_1;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }


    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName}";
    }
    public string GetBirthYear()
    {
        return $"My birth year is {2024 - Age}";
    }

}

