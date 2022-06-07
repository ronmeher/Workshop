using System;

namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Day:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Month:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Year:");
            int year = int.Parse(Console.ReadLine());

            int y = year - ((14 - month) / 12);
            int x = y + y / 4 - y / 100 + y / 400;

            int m = month + 12 * ((14 - month) / 12) - 2;

            int d = ((day + x + 31 * m / 12) % 7);

            

            switch(d)
            { 
                case 0:
                    Console.WriteLine("Sunday");
                break;

                case 1:
                    Console.WriteLine("Monday");
                break;

                case 2:
                    Console.WriteLine("Tuesday");
                break;

                case 3:
                    Console.WriteLine("Wednesday");
                break;

                case 4:
                    Console.WriteLine("Thursday");
                break;

                case 5:
                    Console.WriteLine("Friday");
                break;

                case 6:
                    Console.WriteLine("Saturday");
                break;
}
            
            
            

            
                


        }
    }
}
