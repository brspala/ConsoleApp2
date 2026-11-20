using System;

public class Book
{
    private int _pages;

    public string Title { get; set; }
    public string Author { get; set; }

    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Pages must be greater than 0.");
            _pages = value;
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}