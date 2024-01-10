namespace task_8;

public class Country
{
    string Name;
    string capital;
    int population;
    string officialLanguage;

    public Country(string name, string capital1, int population1, string officialLanguage1)
    {
        Name = name;
        capital = capital1;
        population = population1;
        officialLanguage = officialLanguage1;
    }
    public void SetCapital(string capital1)
    {
        capital = capital1;
    }
    public string GetCapital()
    {
        return capital;
    }
    public void SetPopulation(int population1)
    {
        population = population1;
    }
    public int GetPopulation()
    {
        return population;
    }
    public void SetOfficialLanguage(string language)
    {
        officialLanguage = language;
    }
    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }

}
