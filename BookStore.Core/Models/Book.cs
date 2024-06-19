namespace BookStore.Core.Models;

public class Book
{
    public const int MAX_TITLE_LENGTH = 250;
    public Guid Id { get; }

    public string Title { get; }

    public string Description { get; }

    public decimal Price { get; }

    private Book(Guid id, string title, string description, decimal price)
    {
        Id = id;
        Title = title;
        Description = description;
        Price = price;
    }

    public static (Book book, string error) Create(Guid id, string title, string description, decimal price)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(title) || title.Length  > MAX_TITLE_LENGTH)
        {
            error  = "Title cannot be null or empty";
        }
        
        var book  = new Book(id, title, description, price);
        
        return (book, error);
    }
}