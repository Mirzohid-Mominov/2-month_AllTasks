namespace N10_HT1
{
    public class LibraryManagement
    {
        private Dictionary<int, int> Books = new Dictionary<int, int>();

        public void AddBook(Book book, int numCopies)
        {
            if (!Books.ContainsKey(book.Id))
            {
                Books.Add(book.Id, numCopies);
            }
        }
        public bool Checkout(int bookId)
        {
            if (Books.TryGetValue(bookId, out int numCopies))
            {
                if (numCopies > 0)
                {
                    Books[bookId] = numCopies - 1;
                    return true;
                }
            }
            return false;
        }


    }





}
