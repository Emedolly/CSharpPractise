namespace CSharpPractise.DotnetLogicLab.Day05;

public class Book
{
    private string title;
    private string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Book Author: " + author);
    }
}