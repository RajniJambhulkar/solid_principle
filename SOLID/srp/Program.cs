class Program
{
    static void Main(string[] args)
    {
        Book book = new Book { Title = "1984", Author = "George" };
        BorrowService borrowService = new BorrowService();
        NotificationService notif = new NotificationService();

        borrowService.Borrow(book, "Alice");
        notif.SendNotification("The book '1984' has been borrowed.");
    }
}