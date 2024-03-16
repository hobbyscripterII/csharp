using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using - java import 같은 느낌

namespace csharp
{
    class Program
    {
        static void Main(string[] args) // 콘솔 애플리케이션 실행 시 무조건 실행됨
        {
            Console.WriteLine("hello, C#");
            Console.WriteLine("hello, " + args[0]);
            Console.WriteLine(args.Length);
            Console.ReadKey(); // 값 받기전까지 콘솔 창 출력, 입력 시 메인 메소드 종료되며 콘솔창 꺼짐
        }
    }
}
