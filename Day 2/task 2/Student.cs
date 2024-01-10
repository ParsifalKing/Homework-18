public class Student
{
    // fields
    string fullName;
    int age;
    int grade;
    // constructors
    public Student()
    { }
    public Student(string name, int _age)
    {
        fullName = name;
        age = _age;
    }
    public Student(string name, int _age, int _grade)
    {
        fullName = name;
        age = _age;
        grade = _grade;
    }
    // properties
    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public int Grade
    {
        get { return grade; }
        set { grade = value; }
    }
    // methods
    void Study()
    {
        System.Console.WriteLine($"{fullName} is studying");
    }
    void SetGrade(int newGrade)
    {
        grade = newGrade;
    }
    int GetGrade()
    {
        return grade;
    }
}

