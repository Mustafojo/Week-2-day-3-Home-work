public class Circle
{
    double _radius;
    double Pi = 3.14;
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(){}
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Pi * _radius * _radius;
    }
    public double GetDiameter()
    {
        return _radius * 2;
    }
    public double GetCircumference()
    {
        return 2 * Pi * _radius;
    }
}