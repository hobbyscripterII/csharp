using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Variable
    {
        int globalVar; // 전역변수 선언
        const int MAX_VALUE = 1024; // 상수 선언

        public void Method1()
        {
            int localVar;
            localVar = 100; // 값 할당 안할경우 에러 발생
            Console.WriteLine("globalVar = " + globalVar);
            Console.WriteLine("Variable.MAX_VALUE = " + Variable.MAX_VALUE);
            Console.WriteLine("localVar = " + localVar);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Variable v = new Variable(); // 객체 생성
            v.Method1(); // 메소드 호출
        }
    }
}
