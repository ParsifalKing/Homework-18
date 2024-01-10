using System.Net.NetworkInformation;

namespace task_6;

public class Circle
{
    double radius;
    const double pi = 3.14;


    public Circle()
    {

    }
    public Circle(double _radius)
    {
        radius = _radius;
    }
    public void SetRadius(double _radius)
    {
        radius = _radius;
    }
    public double GetRadius()
    {
        return radius;
    }

    public double GetArea()
    {
        return radius * radius * pi;
    }
    public double GetDiameter()
    {
        return radius * 2;
    }
    public double GetCircumference()
    {
        return 2 * pi * radius;
    }


}
