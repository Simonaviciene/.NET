using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{

    class Veiksmai
    {
        private double x;
        private double y;

        public double Sandauga()
        {
            return x * y;
        }
        public double Dalyba()
        {
            return x / y;
        }
        public double Suma()
        {
            return x + y;
        }
        public double Skirtumas()
        {
            return x - y;
        }
        public void Display()
        {
            Console.WriteLine("Sandauga = {0}", Sandauga());
            Console.WriteLine("Dalyba = {0}", Dalyba());
            Console.WriteLine("Suma = {0}", Suma());
            Console.WriteLine("Skirtumas = {0}", Skirtumas());
        }


    class Program
    {
        static void Main(double[] args)
        {
                Console.WriteLine("Iveskite skaiciu: ");
                double x = Console.ReadLine();
                Console.WriteLine("Iveskite antra skaiciu: ");
                double y = Console.ReadLine();
                Console.WriteLine("Sandauga = {0}", Sandauga());
                Console.WriteLine("Dalyba = {0}", Dalyba());
                Console.WriteLine("Suma = {0}", Suma());
                Console.WriteLine("Skirtumas = {0}", Skirtumas());

            }

               
                Console.ReadLine();


                
        }
    }

    }

}
