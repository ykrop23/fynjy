using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Book
    {
        class Title
        {
            public string Name { get; set; }

            public Title(string Name)
            {
                this.Name = Name;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Title: {Name}");
                Console.ResetColor();
            }
        }
        class Author
        {
           public string Name { get; set; }
           public Author(string Name)
            {
                this.Name = Name;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Author: { Name}");
                Console.ResetColor();
            }
        }
        class Conten
        {
            public string Name { get; set; }
            public Conten(string Name)
            {
                this.Name = Name;

            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Conten: {Name}");
                Console.ResetColor();
            }
        }
    }

}
    

