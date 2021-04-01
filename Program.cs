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

            //사칙연산
            int _a = 5;
            int _b = 10;

            int _c = _a - _b;
            //타입캐스팅 (Type casting, 형변환)
            /*
                1. 명시적 형변환
                2. 암시적 형변환
            */
            float d = (float)_a / (float)_b;  //명시적 형변환: 5/10 = 0, 5.0 / 10.0 = 0.5;
            string exp = "User exp = " + 100; //암시적 형변환

            Console.WriteLine(d);

            //연산 우선순위
            int x = 5;
            int y = 4;
            int z = 2;

            int sum = x + y * z; 

            //float 타입 (실수타입)

            float damage = 10.0f;       //f
            double xp = 20000.0d;       //d
            decimal coin = 1000.0m;     //m

            double a1 = 1.0d;
            double b1 = 3.0d;
            
            Console.WriteLine(a1/b1);

        }
    }
}
