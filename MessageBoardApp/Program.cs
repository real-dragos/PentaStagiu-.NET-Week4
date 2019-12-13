using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoardLibrary;

namespace MessageBoardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person dragos = new Person("Dragos", "Dumitrescu", new DateTime(1997, 03, 09));
            User dragosAccount = new User(dragos, "dragos@gmail.com");

            Console.WriteLine(dragosAccount);

            Post dragosPost = new Post("Hello everyone! I am Dragos!", dragosAccount);
            Post anonPost = new Post("Hello Dragos! How are you?");

            Console.WriteLine(dragosPost);
            Console.WriteLine(anonPost);

            Board board = new Board();

            Console.ReadKey();

        }
    }
}
