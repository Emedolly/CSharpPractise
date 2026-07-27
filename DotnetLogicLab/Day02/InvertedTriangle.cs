namespace CSharpPractise.DotnetLogicLab.Day02;

public class InvertedTriangle
{
   public void InvertedTrianglePrint(int n)
   {
      for (int i = 0; i <= n; i++)
      {
         for (int j = i + 1; j < n; j++)
         {
            Console.Write("* ");
         }
         Console.WriteLine();
      }
   } 
}