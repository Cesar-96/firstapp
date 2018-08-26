using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
// Alt + 9; to show the tab Version Control
// 
            int opcion = 0;
            double weightOnEarth = 0.0;
            double weightOnOther = 0.0;
            string dato = "";

            Console.WriteLine("1. Mercurio, 2. Venus 3. Marte");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            Console.WriteLine("Give me your weight on earth");
            dato = Console.ReadLine();
            weightOnEarth = Convert.ToDouble(dato);

            switch (opcion)
            {
                case 1:
                    weightOnOther = weightOnEarth * 0.38;
                    break;
                case 2:
                    weightOnOther = weightOnEarth * 0.91;
                    break;
                case 3:
                    weightOnOther = weightOnEarth * 0.48;
                    break;
            }
            Console.WriteLine("Your weight on that planet is {0}", weightOnOther);
        }

    }
}
