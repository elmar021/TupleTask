namespace ConsoleApp5
{
    public  class Program
    {
        static void Main(string[] args)
        {
           
            Product product = new Product();
            Library library = new Library();

            Book book = new Book("aaaaa");
            book.Name = "test";
            book.Price = 15;

            Book book1 = new Book("bbbb");
            book1.Name = "test1";
            book1.Price = 24;

            library.AddBook(book1);
            library.AddBook(book);

            Book[] a=library.GetFiltereedBooks("aaaaa");

            Book[] b = library.GetFiltereedBooks(12, 34);

            

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i].Name);
            }

        }
    }
}