public class Teacher
{
    // fields
    string fullName;
    string subject;
    int experience;
    // constructors
    public Teacher()
    { }
    public Teacher(string name, string _subject)
    {
        fullName = name;
        subject = _subject;
    }
    public Teacher(string name, string _subject, int _experience)
    {
        fullName = name;
        subject = _subject;
        experience = _experience;
    }
    // properties
    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }
    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }
    // methods
    string Teach()
    {
        return $"{fullName} is teaching {subject} ";
    }
    void SetExperience(int years)
    {
        experience = years;
    }
    int GetExperience()
    {
        return experience;
    }
}