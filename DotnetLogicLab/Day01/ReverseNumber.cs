namespace CSharpPractise.DotnetLogicLab;

public class ReverseNumber
{
    public void reverse(int number)
    {
      int reverse = 0;
      while (number != 0)
      {
          int lastdigit = number % 10;
          number = number / 10;
          reverse = reverse * 10 + lastdigit;
      }
      Console.WriteLine(reverse);
    }
}