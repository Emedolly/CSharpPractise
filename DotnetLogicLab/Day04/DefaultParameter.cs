namespace CSharpPractise.DotnetLogicLab.Day04;

public class DefaultParameter
{
   public void Greet(string name, string greeting = "Hello")
   {
      Console.WriteLine($"{greeting} {name}");
   } 
}