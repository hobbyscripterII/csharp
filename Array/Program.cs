using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] scores = { 50, 60, 70, 80, 90 }; // 배열 생성 및 초기화

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avg = " + (sum / scores.Length));
            Console.WriteLine("--------------------");

            String[] fruits = new string[3];
            fruits[0] = "딸기";
            fruits[1] = "키위";
            fruits[2] = "토마토";

            //Console.WriteLine(fruits[0]);
            //Console.WriteLine(fruits[1]);
            //Console.WriteLine(fruits[2]);

            fruits.ToList()
                .ForEach(n => Console.WriteLine(n));

            Console.ReadKey();
        }
    }
}
