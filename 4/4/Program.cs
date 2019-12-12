using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class MatematinisSkaiciavimas
    {
        private double s1;
        private double s2;
        private double s3;
        private double s4;
        private double s5;
        private double s6;
        private double s7;
        private double s8;
        private double s9;

        public void PradiniaiDuomenys()
        {
            s1 = -6;
            s2 = 3; 
            s3 = 5;
            s4 = 13;
            s5 = 2;
            s6 = 7;
            s7 = 20;
            s8 = 10;
            s9 = -2;

        }
        public double MatematinisVeiksmas1()
        {
            return s1 + s2 * s3;
        }
        public double MatematinisVeiksmas2()
        {
            return (s4 - s5) * s6;
        }
        public double MatematinisVeiksmas3()
        {
            return (s3 + s9) + (s7 / s8);
        }
        public void Display()
        {
            Console.WriteLine("-6 + 3 * 5 = {0}", MatematinisVeiksmas1());
            Console.WriteLine("(13 - 2) * 7 = {0}", MatematinisVeiksmas2());
            Console.WriteLine("(5 + -2) + (20 / 10)) = {0}", MatematinisVeiksmas3());
        }



        class Program
        {
            static void Main(string[] args)
            {
                MatematinisSkaiciavimas a = new MatematinisSkaiciavimas();
                a.PradiniaiDuomenys();
                a.Display();
                Console.ReadLine();
            }
            
        }

    }
}
