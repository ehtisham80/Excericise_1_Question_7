using System;
public class BooksDatabase
{
    struct book
    {
        public string title;
        public string author;
    }

    public static void Main()
    {
        int capacity = 1000;
        book[] books = new book[capacity];
        bool repeat = true;
        string option;
        int amount = 0;
        string search;
        bool found;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Books database");
            Console.WriteLine();
            Console.WriteLine("1- Add a new book");
            Console.WriteLine("2- Display all books");
            Console.WriteLine("3- Exact search for any book");
            Console.WriteLine("4- Partial search");
            Console.WriteLine("5- Delete a book");
            Console.WriteLine("0- Exit");
            Console.Write("Enter an option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": // Add a new book
                    if (amount < capacity)
                    {
                        Console.WriteLine("Enter data for book {0}", amount + 1);
                        Console.Write("Enter the name of the book: ");
                        /*  books[0]= array('title'=>c++, 'author'=>'qadeer');
                            books[1]= array('title'=>ssss, 'author'=>'qadeer');
                              books[2]= array('title'=>xxx, 'author'=>'qadeer');
                         */
                        books[amount].title = Console.ReadLine();
                        Console.Write("Enter the author: ");
                        books[amount].author = Console.ReadLine();
                        amount++;
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Database full");
                    break;


                case "2":  // Display all books
                    if (amount == 0) { }


                    else
                            {
                        
                                for (int i = 0; i < amount; i++)
                                    Console.WriteLine("{0}: Title = {1},  Author = {2}",
                                    i + 1, books[i].title, books[i].author);
                                Console.WriteLine();
                            }
                    break;
                case "3":  // Exact search
                    Console.WriteLine("Enter the name of the book");
                    search = Console.ReadLine();
                    found = false;

                    for (int i = 0; i < amount; i++)
                        if (books[i].title == search)
                        {
                            Console.WriteLine("Book {0} found", books[i].title);
                            found = true;
                        }

                    if (!found)
                        Console.WriteLine("Not found!");
                    Console.WriteLine();
                    break;
                case "4":  // Partial search
                    Console.WriteLine("Enter the search string");
                    search = Console.ReadLine();
                    found = false;

                    for (int i = 0; i < amount; i++)
                    {
                     
                        if (books[i].title.ToUpper().Contains(search.ToUpper())
                                         &&  books[i].author.ToUpper().Contains(search.ToUpper()))
                    {
                        Console.WriteLine("{0} found in {1}",
                        search, books[i].title);
                        found = true;
                    }


            }

            Console.WriteLine();

                    if (!found)
                        Console.WriteLine("Not found!");
                    break;
                case "5":  // Delete
                    if (amount == 0)
                        Console.WriteLine("No data to delete");
                    else
                    {
                        Console.WriteLine(
                        "Enter the number of book to delete (1 to {0})", amount);
                        int posToDelete =
                        Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int i = posToDelete; i < amount - 1; i++)
                            books[i] = books[i + 1];
                        amount--;
                    }
                    break;
                case "0":  // End
                    repeat = false;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Wrong option. Please re-enter\n");
                    break;
            }
        }
        while (repeat);
    }
}


