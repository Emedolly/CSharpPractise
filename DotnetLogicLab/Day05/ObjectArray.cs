namespace CSharpPractise.DotnetLogicLab.Day05;

public class ObjectArray
{
    public void student()
    {
        Student[] students = new Student[5];
        students[0] = new Student("A", 20, 'A');
        students[1] = new Student("B", 20, 'B');
        students[2] = new Student("C", 20, 'C');
        students[3] = new Student("D", 20, 'D');
        students[4] = new Student("E", 20, 'E');
        Student best = students[0];   // assume first is best, for now
        foreach (Student student in students)
        {
            if (student.GradeRank() > best.GradeRank())
            {
                best = student;
            }
        }
        best.PrintDetails();
    }
    
}