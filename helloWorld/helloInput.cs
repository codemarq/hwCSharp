using System;

namspace helloInput
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep do you get?");
            int hoursOfSleep = Console.ReadLine();
        }
    }
}