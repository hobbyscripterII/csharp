using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 주석 처리 `Ctrl + K + C`
            bool boolean = true;
            Console.WriteLine("boolean = " + boolean);
            //int i = 1;
            //Console.WriteLine("i = " + i);
            long l = 9223372036854775807L; // L suffix
            Console.WriteLine("l = " + l);
            float f = 3.402823e38f; // F suffix
            Console.WriteLine("f = " + f);
            char c = 'A';
            Console.WriteLine("c = " + c);
            double d1 = 123.45;
            Console.WriteLine("d1 = " + d1);
            double d2 = 123.45D; // D suffix
            Console.WriteLine("d2 = " + d2);
            decimal d = 123.45M; // M suffix
            Console.WriteLine("d = " + d);

            Console.WriteLine("-------------------------");

            Console.WriteLine("intMaxValue = " + int.MaxValue);
            Console.WriteLine("intMinValue = " + int.MinValue);
            Console.WriteLine("longMaxValue = " + long.MaxValue);
            Console.WriteLine("longMinValue = " + long.MinValue);
            Console.WriteLine("doubleMaxValue = " + double.MaxValue);
            Console.WriteLine("doubleMinValue = " + double.MinValue);

            String nullStr = null;
            Console.WriteLine("nullStr = " + nullStr);

            Console.WriteLine("-------------------------");

            // 변수 뒤의 '?' 키워드 - nullable 타입(valueType에 null 허용 가능)
            int? i = null;
            Console.WriteLine("(before) i = " + i);
            i = 10; // 값 제대입
            // nullable 타입을 valueType으로 변경하기 위해 Nullable의 Value 속성 사용
            Console.WriteLine("(after) i = " + i.Value);

            Console.ReadKey();
        }
    }
}
