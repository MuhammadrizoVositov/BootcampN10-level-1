List<Book> b = new List<Book>()
{
    new Book
    {
        Id=1, Title="Otgan kunlar",Author="Otkir Hoshimov"
    },
    new Book
    {
        Id = 2,Title="Men",Author="Fotix Duman"
    },
    new Book
    {
        Id=3,Title="Siyosat",Author="Robin sharma"
    }
};

var library = new LibrarayManagment();
var count = 0;
foreach (var book in b)
{
    library.Book.Add(book,count);
    count++;
}


public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}
public class LibrarayManagment
{

    public Dictionary<Book, int> Book = new Dictionary<Book, int>();
    public bool CHeckoud(int bookid)
    {
       foreach(var book in Book)
        {
            if(book.Key.Id == bookid)
            {
                Book[book.Key] = book.Value-1;
                return true;
            }
        }
       return false;
    }

}