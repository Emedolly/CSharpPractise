namespace CSharpPractise.DotnetLogicLab.Day02;

public class SquarePrint
{
    public void Square(int num1, int num2)
    {
        for (int i = 0; i < num1; i++)
        {
            for (int j = 0; j < num2; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}