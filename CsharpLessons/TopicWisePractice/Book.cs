namespace CSharpPractise.CsharpLessons.TopicWisePractice;

public class Book
{
    private string Title;
    private string Author;
    private string ISBN;

    public Book(string title, string author, string ISBN)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = ISBN;
    }

    public virtual void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {this.Title}");
        Console.WriteLine($"Author: {this.Author}");
        Console.WriteLine($"ISBN: {this.ISBN}");
    }


}

public class Ebook : Book
{
    public double FileSizeMB{get;set;}
    public string DownloadLink{get;set;}

    public Ebook(string title, string author, string ISBN, double fileSizeMB, string downloadLink) : base(title, author,
        ISBN)
    {
        this.FileSizeMB = fileSizeMB;
        this.DownloadLink = downloadLink;
    }

    public override void DisplayBookInfo()
    {
        base.DisplayBookInfo();
        Console.WriteLine($"File size: {this.FileSizeMB}");
        Console.WriteLine($"Download link: {this.DownloadLink}");
    }
}