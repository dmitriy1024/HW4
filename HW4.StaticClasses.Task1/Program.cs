using System;

namespace HW4.StaticClasses.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Fifty Shades of Grey", "E. L. James");
            book.BookNotes.AddNote("It's a very bad book!");
            book.BookNotes.AddNote("Dont read it!");
            book.BookNotes.AddNote("Dont read! NEVER!");

            Console.WriteLine(book.ToString());
            Console.WriteLine("Notes:");
            string[] notes = book.BookNotes.GetAll();
            foreach (var item in notes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();            
        }
    }
}
