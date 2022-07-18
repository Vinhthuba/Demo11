using System;
namespace BookStore
{
    class Books
    {
        static void Main(string[] args)              
        {
            string[] bookTitle = new string[6];

            for (int i = 0; i < bookTitle.Length; i++)
            {
                Console.Write("Enter the title the book : ");
                bookTitle[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("List of books : ");
            foreach (string title in bookTitle)
            {
                Console.WriteLine(title);
            }
            bookTitle[3] = "Planet of the Apes";
            Console.WriteLine("NewLy changed title of book 4 :" + bookTitle[3]);
        }
    }
}
