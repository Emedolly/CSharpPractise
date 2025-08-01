namespace CSharpPractise._04_switch;

public class SwitchExample
{
    public void calculator()
    {
        Console.WriteLine("Enter first number");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter second number");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter an operator");
       // char operation = Console.ReadKey().KeyChar;
       char operation = Console.ReadLine()[0];
       double result = 0;
       switch (operation)
       {
           case '+':
           result = number1 + number2;
               break;
           case '-':
               result = number1 - number2;
               break;
           case '*':
               result = number1 * number2;
               break;
           case '/':
               result = number1 / number2;
               break;
           default:
               break;
           
       }
       Console.WriteLine($"The result is {result}");
    }

    public void DaysoftheWeek()
    {
        Console.WriteLine("Enter days of the week");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
    }

    public void GradeBased()
    {
        Console.WriteLine("Enter the marks of a student");
        int marks = Convert.ToInt32(Console.ReadLine());
        string grade = GetGrade(marks);
        Console.WriteLine($"your grade is :{grade}");
        
    }

    private string GetGrade(int marks) => marks switch
    {
        >= 90 and <= 100 => "A",
        >= 80 and < 90 => "B",
        >= 70 and < 80 => "C",
        >= 60 and < 70 => "D",
        >= 50 and < 60 => "E",
        >= 0 and <= 70 => "F",
        _ => "Invalid Marks"

    };

}