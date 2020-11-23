using System;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace jsonserialization
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            Author author = new Author { Name = "Anders B", YearOfBirth = 1966 };
            Book book = new Book { Title = "Make C# Great Again", Auth = author };

            string jsonStr = JsonConvert.SerializeObject(book);
            Console.WriteLine(jsonStr);

            Book bookCopy = JsonConvert.DeserializeObject<Book>(jsonStr);
            Console.WriteLine(bookCopy);

            Book[] books = {
                book,
                new Book {Title ="Make me great again", Auth = author}
            };

            string jsonStr2 = JsonConvert.SerializeObject(books);
            Console.WriteLine(jsonStr2);

            Book[] booksCopy = JsonConvert.DeserializeObject<Book[]>(jsonStr2);
            Console.WriteLine("Array: " + string.Join<Book>(", ", booksCopy));
        }
    }
}
