namespace CSharpPractise.DotnetLogicLab.Day03;

public class TransposeOfMatrix
{
    public void Transpose()
    {
        // int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
        // int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
        // for (int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for (int j = 0; j <matrix.GetLength(1); j++)
        //     {
        //         result[j,i]=matrix[i, j];
        //     }
        // }
        // Console.WriteLine(result);
        
        int[,] matrix = { {1,2,3}, {4,5,6} };
        int rows = matrix.GetLength(0);   // 2
        int cols = matrix.GetLength(1);   // 3

        int[,] transposed = new int[cols, rows]; 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // based on your answer to Step 1's question — 
                // where should matrix[i, j] go in "transposed"?
                transposed[j, i] = matrix[i, j];
            }

           
            
        }
        for (int k = 0; k < transposed.GetLength(0); k++)
        {
            for (int l = 0; l < transposed.GetLength(1); l++)
            {
                Console.Write(transposed[k, l] + " ");
            }
            Console.WriteLine();
        }
        
    }
}