using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas
{
    class Program
    {

        static void Main(string[] args)
        {
            string spalva = "";
            while (spalva != "stop")
            {
                Console.WriteLine("Kokia jusu megstamiausia spalva?");
                spalva = Console.ReadLine();
                Console.WriteLine("mano irgi megstamiausia {0} [ENTER - testi]", spalva);
            }
            Console.Clear();
            Console.WriteLine("Ate...");
            Console.ReadLine();
           
        }
    }
}
