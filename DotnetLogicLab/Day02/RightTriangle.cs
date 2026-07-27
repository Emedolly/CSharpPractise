using System.Security.Cryptography.X509Certificates;

namespace CSharpPractise.DotnetLogicLab.Day02;

public class RightTriangle
{
    public void RightTrianglePrint(int num1)
    {
        for (int i = 0; i < num1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}