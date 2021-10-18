using System;

namespace Calculator
{
    class Program
    {
        public static int multiply(int x, int y)
        {
            return x * y;
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static int substract(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            int izbor, a, b;
            do
            {
                Console.WriteLine("Izaberite broj za radnju koju želite izvršiti:");
                Console.WriteLine("1 - Zbrajanje");
                Console.WriteLine("2 - Oduzimanje");
                Console.WriteLine("3 - Množenje");
                Console.WriteLine("4 - Kraj");
                izbor = Int32.Parse(Console.ReadLine());

                if (izbor != 4)
                {
                    Console.WriteLine("Unesite 1. broj:");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite 2. broj:");
                    b = Int32.Parse(Console.ReadLine());

                    switch (izbor)
                    {
                        case 1:
                            Console.WriteLine("Rezultat je:" + add(a, b));
                            break;
                        case 2:
                            Console.WriteLine("Rezultat je:" + substract(a, b));
                            break;
                        case 3:
                            Console.WriteLine("Rezultat je:" + multiply(a, b));
                            break;
                    }
                }
            } while (izbor != 4);
        }
    }
}
