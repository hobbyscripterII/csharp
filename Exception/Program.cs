using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_
{
    internal class Program
    {
        private const int MAX_VALUE = 1024;

        static void Main(string[] args)
        {
            try
            {
                int i = 2000;

                if(i > MAX_VALUE)
                {
                    throw new Exception();
                }
            } catch(Exception e)
            {
                Console.WriteLine("예외가 발생하였습니다.");
                Console.WriteLine(e);
                Console.ReadKey();
                throw e;
            }
        }
    }
}
