namespace task_7;

public class Date
{
    //fields
    int day;
    int month;
    int year;

    // properties
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    //constructor
    public Date()
    {

    }
    public Date(int _day)
    {
        day = _day;
    }
    public Date(int _day, int _month)
    {
        day = _day;
        month = _month;
    }
    public Date(int _day, int _month, int _year)
    {
        day = _day;
        month = _month;
        year = _year;
    }

    //methods
    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public void SetDay(int day)
    {
        this.day = day;
    }
    public void SetMonth(int month)
    {
        this.month = month;
    }
    public void SetDate(int year)
    {
        this.year = year;
    }
    public override string ToString()
    {
        return $"{day}/{month}/{year}";
    }



}
