namespace task_1;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public string GetInfo()
    {
        return $"Name : {FirstName}\nSurname : {LastName}\nAge : {Age}";
    }
}
