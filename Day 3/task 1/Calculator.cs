namespace task_1;

public class Calculator
{
    int firstNum;
    int secondNum;


    public Calculator(int _firstNum, int _secondNum)
    {
        firstNum = _firstNum;
        secondNum = _secondNum;
    }
    public int Sum()
    {
        return firstNum + secondNum;
    }
    public int Subtract()
    {
        return firstNum - secondNum;
    }
    public int Multiplication()
    {
        return firstNum * secondNum;
    }
    public int Division()
    {
        return firstNum / secondNum;
    }
}
