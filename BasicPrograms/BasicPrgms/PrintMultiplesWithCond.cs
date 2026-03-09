namespace BasicPrograms.Topic1;

public class PrintMultiplesWithCond
{
    public void PrintMultiplesOfNumber()
    {
        
        for (int i = 1; i < 100; i++)
        {
            int a = 17;
            if (i % a == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}