namespace CSharpPractise.DotnetLogicLab.Day07;

public class StudentMarks
{
    private List<int> marks = new List<int> { 85, 90, 78, 92, 60 };
    
    public void studentDetails()
    {   
        int maxium = marks[0];
        int sum = 0;
        marks.Add(111);
        marks.Remove(60);
        foreach (var mark in marks)
        {
            if ( mark> maxium)
            {
                maxium = mark;
            }
        }

        for (int i = 0; i < marks.Count; i++)
        {
            sum = sum + marks[i];
        }
        double average = (double)sum / marks.Count;
        Console.WriteLine($"Maximum:{maxium:F2}, Average:{average:F2}");
    }
}