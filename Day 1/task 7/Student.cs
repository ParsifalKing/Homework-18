class Student
{
    public string Name;
    public int GradeLevel;
    public List<double> TestScores;

    public double GetAverage()
    {
        double sum = 0;
        for (int i = 0; i < TestScores.Count; i++)
        {
            sum += TestScores[i];
        }
        return sum / TestScores.Count;
    }
}
