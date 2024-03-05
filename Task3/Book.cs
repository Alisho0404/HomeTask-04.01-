namespace Task3;

public class Book : AbstarctBook, IBorrowable
{

    public void Borrow()
    {
         System.Console.WriteLine("book has been borrowed");
    }

    public void ReturnBook()
    {
        System.Console.WriteLine("book has been returned"); 
    }


}
