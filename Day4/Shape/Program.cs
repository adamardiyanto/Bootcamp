public abstract class Shape{
    public double Height{ get; set;}
    public double Width{ get; set;}

    public abstract double GetArea();
}


public class Rectangle : Shape{
    public Rectangle(double height, double width){
        Height = height;
        Width = width;
        Console.WriteLine("rectangle created with height = " + height + ", width = " + width);
    }

    public override double GetArea(){
            return Height * Width;
        }
}

public class Triangle : Shape{  

    public Triangle(double height, double width){
        Height = height;
        Width = width;
        Console.WriteLine("Triangle created with height = " + height + ", width = " + width);

    }

    public override double GetArea(){
            return (Height * Width)/2;
        }
}

public class Circle : Shape{
    public Circle(double radius){
        Width = radius;
        Console.WriteLine("Circle created with radius = " + radius);
    }

    public override double GetArea(){
            return 3.14* Width*Width;
        }
}

class Program {
    static void Main(string[] args) {
        Rectangle rect = new(10,15);
        Console.WriteLine("area Rectangle " + rect.GetArea());
        Triangle triangle = new(15,10);
        Console.WriteLine("area Triangle " + triangle.GetArea());
        Circle circle = new(15);
        Console.WriteLine("area Circle " + circle.GetArea());
    }
}