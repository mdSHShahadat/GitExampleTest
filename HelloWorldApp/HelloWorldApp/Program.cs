using System;


namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello "+ name);
            Console.ReadKey();

        }
    }
}
