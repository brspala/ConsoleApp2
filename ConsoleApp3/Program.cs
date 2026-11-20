using System;

class Book
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

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[3];
        books[0] = new Book("Suç ve Ceza", "Dostoyevski", 687);
        books[1] = new Book("Simyacı", "Paulo Coelho", 184);
        books[2] = new Book("1984", "George Orwell", 352);

        foreach (Book book in books)
        {
            Console.WriteLine(book.Info());
        }

        Book longest = books[0];
        foreach (Book book in books)
        {
            if (book.Pages > longest.Pages)
                longest = book;
        }

        Console.WriteLine();
        Console.WriteLine("Book with the most pages:");
        Console.WriteLine(longest.Info());
    }
}