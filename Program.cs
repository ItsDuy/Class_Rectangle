namespace Class_Rectangle;
public class Rectangle
{
    double width, height;
    public Rectangle()
    {
    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double GetArea()
    {
        return this.width * this.height;
    }

    public double GetPerimeter()
    {
        return (this.width + this.height) * 2;
    }

    public string Display()
    {
        return "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }
}


class Program
{
    static void Main(string[] args)
    {       
            Console.WriteLine("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle1=new Rectangle(width,height);
            Console.WriteLine(rectangle1.Display());
            Console.WriteLine($"Rectangle has an area {rectangle1.GetArea()} and a perimeter {rectangle1.GetPerimeter()}");

    }
}
