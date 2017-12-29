using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single = Singleton.GetInstance();
            single.test = 1;
            Console.WriteLine(single.test);

            Singleton single2 = Singleton.GetInstance();
            single2.test = 4;
            Console.WriteLine(single.test);

            Console.ReadKey();
        }
    }
}
