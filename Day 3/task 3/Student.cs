namespace task_3;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Average { get; set; }

    public Student(int id, string _name, int _age, double _averageGrade)
    {
        Id = id;
        Name = _name;
        Age = _age;
        Average = _averageGrade;
    }
    //method
    public string GetInfo()
    {
        return $"Id={Id}; Name: {Name}, Age: {Age}, Average Grade: {Average}";
    }
    public bool IsExcellentStudent()
    {
        if (Average > 4.0) return true;
        else return false;
    }
}
