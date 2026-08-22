namespace CSharpPractise.DotnetLogicLab.Day04;

public class PowerFunction
{
    public int Power(int baseNumber, int power)
    {
        return baseNumber * Power(baseNumber,power-1);
    }
}
// Call:
//Console.WriteLine(Power(2, 4)); // 16