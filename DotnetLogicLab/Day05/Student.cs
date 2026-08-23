namespace CSharpPractise.DotnetLogicLab.Day05;

public class Student
{
   private string name;
   private int age;
   private char grade;

   public string Name
   {
      get {return name;}
      set {name = value;}
   }

   public int Age
   {
      get {return age;}
      set
      {
         if (value > 0 && value <= 120)
         {
            age = value;
         }
      }
   }

   public char Grade
   {
      get {return grade;}
      set
      {
         if (value == 'A' || value == 'B' || value == 'C' || value == 'D' || value == 'F'|| value=='N')
         {
            grade = value;
         }
      }
   }

   public Student(string name, int age, char grade)
   {
    Name = name;
    Age = age;
    Grade = grade;
   }

   public Student(string name)
   {
      Name = name;
      Age = 0;
      Grade = 'N';
   }

   public void PrintDetails()
   {
      Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
   }
   public int GradeRank()
   {
      if (grade == 'A')
      {
         return 4;
      }
      else if (grade == 'B')
      {
         return 3;
      }
      else if (grade == 'C')
      {
         return 2;
      }
      else if (grade == 'D')
      {
         return 1;
      }
      else
      {
         return 0;
      }
   }
}