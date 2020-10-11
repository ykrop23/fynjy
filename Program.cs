using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        { 
        class Book
        {
            Title title;
            Author author;
            Content content;

            public Book(Title title, Author author, Content content)
            {
                this.title = title;
                this.author = author;
                this.content = content;
            }
            public void Show()
            {
                title.Show();
                author.Show();
                content.Show();
            }
        }
    }
    }
}
