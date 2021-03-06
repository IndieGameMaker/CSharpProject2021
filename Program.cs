using System;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 데이터타입 변수명 = 초깃값;
            // string userName = "Zack";
            // int userLevel = 20;

            // //Console.WriteLine("Hello " + userName);
            // //Console.WriteLine($"Hello {userName} !!");
            // Console.WriteLine($"User = {userName}, Level={userLevel}");

            // int a = 5;
            // int b = 10;
            // int c = a + b;

            // Console.WriteLine($"{a} + {b} = {c}");
            
            // int max = int.MaxValue; //+21
            // int min = int.MinValue; //-21

            // Console.WriteLine($"Integer's Max = {max:#,##0}, Min = {min:#,##0}");
            // Console.WriteLine($"Max = {max.ToString("#,##0")}");

            // int score = 123;
            // Console.WriteLine($"Score : {score:000000}");
            // Console.WriteLine($"Score : {score:######}");

            // //사칙연산
            // int _a = 5;
            // int _b = 10;

            // int _c = _a - _b;
            // //타입캐스팅 (Type casting, 형변환)
            // /*
            //     1. 명시적 형변환
            //     2. 암시적 형변환
            // */
            // float d = (float)_a / (float)_b;  //명시적 형변환: 5/10 = 0, 5.0 / 10.0 = 0.5;
            // string exp = "User exp = " + 100; //암시적 형변환

            // Console.WriteLine(d);

            // //연산 우선순위
            // int x = 5;
            // int y = 4;
            // int z = 2;

            // int sum = x + y * z; 

            // //float 타입 (실수타입)

            // float damage = 10.0f;       //f
            // double xp = 20000.0d;       //d
            // decimal coin = 1000.0m;     //m

            // double a1 = 1.0d;
            // double b1 = 3.0d;
            
            // Console.WriteLine(a1/b1);

            // decimal c1 = 1.0m;
            // decimal d1 = 3.0m;

            // Console.WriteLine(c1/d1);
            double result = Cal01(2.0f);
            Console.WriteLine(result);

            // Cal02();
            // Cal03();
            // Cal05();
            // Cal06();
            Cal07();
        }

        //함수(Funcition), 메서드(Method)
        //함수 원형
        /*
            반환타입 함수명(매개변수)
            {

            } 

            void Sum()
            {

            }

            void Sum(int a, int b)
            {

            }

            int Sum(int a, int b)
            {
                return 
            }

            string GetUserName(int userID)
            {
                return
            }
        */
        const float PI = 3.14f;

        static double Cal01(float radius)
        {
            //원의 면적 계산 : PI * r ^ 2
            //float radius = 2.0f;
            double circle = PI * radius * radius; // PI * Math.Pow(radius,2);
            return circle;   
        }

        /*
            if (조건식)
            {
                조건식이 true이면 실행
            }
            else
            {
                조건식이 false일때 실행
            }
        */
        static void Cal02()
        {
            int maxPlayers = 10;
            Console.Write("입장객수를 입력하세요. ");
            string strNum = Console.ReadLine();
            //문자열을 정수로 형변환
            int players = int.Parse(strNum);

            if (players > maxPlayers)
            {
                Console.WriteLine("최대 허용수를 초과");
            }
            else
            {
                Console.WriteLine("입장가능");
            }            
        }

        //3항 연산자
        /*
            (조건식) ? 값1 : 값2;
        */
        static void Cal03()
        {
            int a = 3;
            string str = (a % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine($"a={a}, a%2={a%2}, {str}");
        }

        /*
            switch(값)
            {
                case 비교값1:
                    로직1;
                    break;
                case 비교값2:
                    로직2;
                    break;
                case 비교값3:
                    로직3;
                    break;    
                default:
                    나머지로직;                                    
            }
        */

        //열거형 데이터 구조
        enum STATE {IDLE, TRACE, ATTACK, DIE};

        static void Cal05()
        {
            STATE monsterState = STATE.TRACE;

            switch(monsterState)
            {
                case STATE.IDLE:
                    Console.WriteLine("정지 상태");
                    break;

                case STATE.TRACE:
                    Console.WriteLine("추적 상태");
                    break;

                default :
                    Console.WriteLine("나머지");
                    break;
            }
        }
    
        static void Cal06()
        {
            // for (초깃값; 조건; 증가값)
            // {
            // }
            // for (int i=2; i<10; i++)
            // {
            //     for (int j=1; j<10; j++)
            //     {
            //         Console.WriteLine($"{i} X {j} = {i*j}");
            //     }
            //     Console.WriteLine("");
            // }

            string [] items = new string[3] {"HP", "SPEED", "POWER"};
            /*
                items[0] = "HP"
                items[1] = "SPEED"
                items[2] = "POWER"
            */ 

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            for (int i=0; i<items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    

        static void Cal07()
        {
            int i = 0;
            int sum = 0;

            while (i <= 10)
            {
                sum += i++; //sum = sum + i;
                //i++;
            }

            Console.WriteLine(sum);

            i = 0; sum = 0;

            do
            {
                sum += i++;
            }while(i<=10);

            Console.WriteLine(sum);
        }
    
    }
}
