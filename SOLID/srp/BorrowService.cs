// BorrowService class with single responsibility of handling book borrowing
public class BorrowService
{
    public void Borrow(Book book, string borrower)
    {
        Console.WriteLine($"{borrower} borrowed {book.Title} by {book.Author}");
    }
}