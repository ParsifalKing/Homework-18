namespace task_8;

public class Gauge
{
    public int value;
    public Gauge()
    {
        value = 0;
    }
    // methods
    public void Increase()
    {
        if (value < 5)
        {
            value++;
        }
    }
    public void Decrease()
    {
        if (value > 0)
        {
            value--;
        }
    }
    public bool Full()
    {
        if (value == 5) return true;
        else return false;
    }

    public void SetGauge(int value)
    {
        this.value = value;
    }
    public int GetGauge()
    {
        return value;
    }



}
