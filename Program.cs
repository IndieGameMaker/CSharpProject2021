using System;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            string userName = "Zack";
            int userLevel = 20;

            //Console.WriteLine("Hello " + userName);
            //Console.WriteLine($"Hello {userName} !!");
            Console.WriteLine($"User = {userName}, Level={userLevel}");

            int a = 5;
            int b = 10;
            int c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");
            
            int max = int.MaxValue; //+21
            int min = int.MinValue; //-21

            Console.WriteLine($"Integer's Max = {max:#,##0}, Min = {min:#,##0}");
            Console.WriteLine($"Max = {max.ToString("#,##0")}");

            int score = 123;
            Console.WriteLine($"Score : {score:000000}");
            Console.WriteLine($"Score : {score:######}");

            
        }
    }
}
