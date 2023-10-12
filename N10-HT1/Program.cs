using N10_HT1;
using System;

class Program
{
    static void Main()
    {
        Book book1 = new Book { Id = 1, Title = " Atomic Habbits", Author = " James Clear" };
        Book book2 = new Book { Id = 2, Title = "Harry Potter", Author = "J.K.Rowling" };
        Book book3 = new Book { Id = 3, Title = "O'tgan Kunlar", Author = "Abdulla Qodiriy" };

        LibraryManagement library = new LibraryManagement();
        library.AddBook(book1, 5);
        library.AddBook(book2, 3);
        library.AddBook(book3, 2);

        // Kitoblarni olib turish
        int bookId = 5; // Olib turgan kitobning Id sini kiritamiz
        bool isSuccessfulCheckout = library.Checkout(bookId);

        if (isSuccessfulCheckout)
        {
            Console.WriteLine("Kitob muvaffaqiyatli olib turgan!");
        }
        else
        {
            Console.WriteLine("Kitob olib turganlik amalga oshmadi. Kitoblar tugagan!");
        }

    }
}
