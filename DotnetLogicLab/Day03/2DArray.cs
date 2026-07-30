namespace CSharpPractise.DotnetLogicLab.Day03;

public class ArrayProgramMatrix
{
   
   public void ArrayPrint()
   {
      int[,] matrix = {{1,2,3},{3,4,5}};
      int sum = 0;
      for (int row = 0; row < matrix.GetLength(0); row++)
      {
         for (int col = 0; col < matrix.GetLength(1); col++)
         {
            sum = sum + matrix[row, col];
         }
      }
      Console.WriteLine(sum);
   } 
}