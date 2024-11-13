namespace books_and_records
{
    internal class Program
    {
        struct books
        { //creates a new structure for records
            public string title;
            public string author;
            public string genre;
            public int pageCount;
            public bool available; //5 attributes with their data type
            public books(string utitle, string uauthor, string ugenre, int upageCount, bool uavailable)
            { //create a method to create a new record
                title = utitle;
                author = uauthor;
                genre = ugenre;
                pageCount = upageCount;
                available = uavailable;
            }//assignes each argument to each of the attributes of the record
        }
        static void Main(string[] args)
        {
            books ofMiceAndMen = new books("Of Mice and Men", "John Steinbeck", "Classic literature", 128, true);
            books Silmarillion = new books("The Silmarillion", "J. R. R. Tolkien", "Fantasy", 448, false);
            books GOT = new books("A Game of Thrones", "George R.R. Martin", "Fantasy", 864, true);
            books Hygge = new books("The Little Book of Hygge", "Meik Wiking", "Healthy Living", 288, true); //create 4 records with their given data

            books usersBook; // blank record for a new book to add later
            Console.WriteLine("what is the title of your book");
            usersBook.title = Console.ReadLine(); //reads the users input and assignes it to the given attribute of the record
            Console.WriteLine("what is the author of your book");
            usersBook.author = Console.ReadLine(); //reads the users input and assignes it to the given attribute of the record
            Console.WriteLine("what is the genre of your book");
            usersBook.genre = Console.ReadLine(); //reads the users input and assignes it to the given attribute of the record
            Console.WriteLine("what is the page count of your book");
            usersBook.pageCount = Convert.ToInt32(Console.ReadLine()); //reads the users input and assignes it to the given attribute of the record
            usersBook.available = false;
            Console.WriteLine(usersBook.title);
            Console.WriteLine(usersBook.author);
            Console.WriteLine(usersBook.genre);
            Console.WriteLine(usersBook.pageCount);
            Console.WriteLine(usersBook.available);

            books[] libray = new books[5]; //creates an array with 5 books 
            libray[0]= ofMiceAndMen; //assigns a book one by one to the array
            libray[1] = Silmarillion;
            libray[2] = GOT;
            libray[3] = Hygge;
            libray[4].title = usersBook.title;


            books[] betterLibrary = [Silmarillion, ofMiceAndMen, Hygge, usersBook, GOT];//creates an array with 5 books and asssigns the records 
            Console.WriteLine(libray[1].title); //we can call specific attributes
            betterLibrary[3].available = true; //update the avalibility to a new value
            betterLibrary[3].pageCount = betterLibrary[3].pageCount+50; //updating value of page count by 50
        }
    }
}
