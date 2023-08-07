List<Book> kitob = new List<Book>  // Kolleksiyalarda saqlash
{
    new Book()
    {
        Id = 1, Title="COC",Author="Jon Muller",
    },
    new Book()
    {
        Id = 2, Title="Otgan kunlar",Author="Otkir hoshimov",
    },
    new Book()
    {
        Id= 3, Title="Men",Author="Fotix Duman",
    }

};
var library = new LibraryManagment();/// object yaratish type dan 
    var cnt=0;
foreach (Book book in kitob)
{
    library.Book.Add(book,cnt);
    cnt++;
}


public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }   // Filedlar
    public string Author { get; set; }
}

public class LibraryManagment

{
    public Dictionary<Book, int> Book = new Dictionary<Book, int>();
    public bool Checkoud(bool bookid)
    {
        if (bookid.Key.Id==bookid)
        {
            Book[kitob.Key] == kitob.Value - 1;
            return true;
        }
        return false;
    }
}




