namespace task_4;

public class Actor
{
    string fullName;
    int age;
    string gender;
    public List<string> moviesPleyed = new List<string>();
    // constructors
    public Actor()
    { }
    public Actor(string name, int _age, string _gender)
    {
        fullName = name;
        age = _age;
        gender = _gender;
    }
    // methods
    public void AddMovie(string movieTitle)
    {
        moviesPleyed.Add(movieTitle);
    }
    public List<string> GetMoviesPlayed()
    {
        return moviesPleyed;
    }
    public void SetAge(int _age)
    {
        age = _age;
    }
    public int GetAge()
    {
        return age;
    }
    public void SetGender(string _gender)
    {
        gender = _gender;
    }
    public string GetGender()
    {
        return gender;
    }

}
