using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas2
{

    class Matematika
    {
        private double sk1;
        private double sk2;

        public void Skaiciai()
        {
            sk1 = 24;
            sk2 = 5;
        }
        public double Dalyba()
        {
            return sk1 / sk2;
        }
        public void Isvestis()
        {
            Console.WriteLine("sk1: {0}", sk1);
            Console.WriteLine("sk2: {0}", sk2);
            Console.WriteLine("Gauname: {0}", Dalyba());
        }

    class Progarama 
        {
        static void Main(string[] args)
            {
                Matematika m = new Matematika();
                m.Skaiciai();
                m.Isvestis();
                Console.ReadLine();
            } 
            
        }
    }
}
