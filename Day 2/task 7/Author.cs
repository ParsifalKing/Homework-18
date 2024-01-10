namespace task_7;

public class Author
{
    string name;
    int age;
    string nationality;

    public Author()
    {

    }
    public Author(string _name, int _age)
    {
        name = _name;
        age = _age;
    }
    public Author(string _name, int _age, string _nationality)
    {
        name = _name;
        age = _age;
        nationality = _nationality;
    }
    //methods
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public string GetNationality()
    {
        return nationality;
    }
    public string Introduce()
    {
        return $"Меня зовут {name}. Мне {age} лет. Я из {nationality}.";
    }
    public int CelebrateBirthday()
    {
        return age + 1;
    }

}
