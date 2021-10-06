using System;

namespace Taask_class_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer obj1 = new Computer("Acer", "Kingston SA400", "Windows 8", 16 );
            Computer obj2 = new Computer("Toshiba", "Samsung 980 pro", "Windows 10", 32);
            

            Console.WriteLine(obj1.Detail());
            Console.WriteLine(obj2.Detail());

        }
       

    }
}
