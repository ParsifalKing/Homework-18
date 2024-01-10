class Rectangle
{
    int width;
    int height;
    string color;

    //structor
    public Rectangle(int _width, int _height, string _color)
    {
        width = _width;
        height = _height;
        color = _color;
    }
    //methods
    public int GetArea()
    {
        return width * height;
    }
    public int Perimetr()
    {
        return (width + height) * 2;
    }
}
