using CSharpPractise;
using CSharpPractise._02_Loops;
using CSharpPractise._04_switch;

namespace CSharpPractise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World! which is the main entry for these console applications");
            WhileLoop w = new WhileLoop();
            // w.RunForLoop();
            //w.RunWhileLoop();
            //  w.SumOfNumbers();
            // w.FactorialNumbers();
            // w.MultipleOfNumbers();
         //  Console.WriteLine("Enter the numbers to be reversed");
          //  int n = int.Parse(Console.ReadLine());
            //int result = w.ReversedNumber(n);
            // Console.WriteLine(result);
           // bool result = w.Palindrome(n);
            //Console.WriteLine(result);
            //w.CountDigits();
            SwitchExample sw = new SwitchExample();
            //sw.calculator();
           //sw.DaysoftheWeek();
           sw.GradeBased();
            Console.ReadLine();
        }
    }
}