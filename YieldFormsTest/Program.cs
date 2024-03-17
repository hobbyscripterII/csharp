using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YieldFormsTest
{
    internal class Program
    {
        private const int MAX_VALUE = 100;

        void Run()
        {
            Random random = new Random(); // Random 네임스페이스를 통해 객체 생성
            int passed = 0; // 양품
            int failed = 0; // 불량

            for (int i = 0; i <= MAX_VALUE; i++)
            {
                int randomVar = random.Next(1, 10);
                bool result = randomVar <= 8 ? true : false;

                if (result)
                {
                    passed++;
                }
                else
                {
                    failed++;
                }
                Console.WriteLine("random = " + randomVar);
                Thread.Sleep(100);
            }

            Console.WriteLine("passed cnt = " + passed);
            Console.WriteLine("failed cnt = " + failed);
            Console.ReadKey();
        }

        void doTest()
        {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        static void Main(string[] args)
        {
            new Program().doTest();
        }
    }
}
