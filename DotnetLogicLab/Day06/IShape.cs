namespace CSharpPractise.DotnetLogicLab.Day06;

public interface IShape
{
   double CalculateArea();
}

public class Circle : IShape
{
   public double Radius;

   public Circle(double radius)
   {
      Radius = radius;
   }
   public double CalculateArea()
   {
     return Math.PI * Radius * Radius;
   }
}

public class Square : IShape
{
   public double side;

   public Square(double side)
   {
      this.side = side;
   }

   public double CalculateArea()
   {
      return side * side;
   }
}

public class print
{
   List<IShape> shapes = new List<IShape>();

   public void AddShapes()
   {
      shapes.Add( new Circle(10));
      shapes.Add( new Square(10));
   }
   public void Print()
   {
      foreach (var shape in shapes)
      {
         Console.WriteLine(shape.CalculateArea());
      }
   }
}