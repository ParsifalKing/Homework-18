namespace task_9;

public class Counter
{

    public int value;
    // constructor
    public Counter(int startValue)
    {
        value = startValue;
    }
    public Counter()
    {
        value = 0;
    }
    //property
    public int Value { get; set; }
    // methods
    public void Increase()
    {
        value++;
    }
    public void Decrease()
    {
        value--;
    }
    public void Increase(int increaseBy)
    {
        if (increaseBy > 0)
        {
            value += increaseBy;
        }

    }
    public void Decrease(int decreaseBy)
    {
        if (decreaseBy > 0)
        {
            value -= decreaseBy;
        }
    }

}
