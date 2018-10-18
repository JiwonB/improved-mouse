using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("안녕하세요 \n 반갑습니다");
                return;
            }
            Console.WriteLine("안녕하세요,{0}!", args[0]);

        }
        
    }
}
