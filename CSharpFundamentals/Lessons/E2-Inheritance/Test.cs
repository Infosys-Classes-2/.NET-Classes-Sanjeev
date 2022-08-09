public class Rectangle
{
    void CalculateAreas()
    {
        Rectangle rect1 = new(23.4, 12.5);
        var area1 = rect1.GetArea();
        var per1 = rect1.GetPerimeter();
    }
}