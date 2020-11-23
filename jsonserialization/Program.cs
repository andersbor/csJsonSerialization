using System;
using Newtonsoft.Json;

namespace jsonserialization
{
    class Program
    {
        static void Main()
        {
            Author author = new Author { Name = "Anders B", YearOfBirth = 1966 };
            Book book = new Book { Title = "Make C# Great Again", Auth = author };

            // Single object

            string jsonStr = JsonConvert.SerializeObject(book);
            Console.WriteLine(jsonStr);

            Book bookCopy = JsonConvert.DeserializeObject<Book>(jsonStr);
            Console.WriteLine(bookCopy);

            // Array of objects

            Book[] books = {
                book,
                new Book {Title ="Make me great again", Auth = author}
            };

            string jsonStr2 = JsonConvert.SerializeObject(books);
            Console.WriteLine(jsonStr2);

            Book[] booksCopy = JsonConvert.DeserializeObject<Book[]>(jsonStr2);
            string booksStr = string.Join<Book>(", ", booksCopy);
            Console.WriteLine("Array: " + booksStr);
        }
    }
}
