using System;

namespace inluppg7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in matvarorna");
            string matvaror = Console.ReadLine();
            Console.WriteLine("Skriv in priserna");
            string[] priserStr = Console.ReadLine().Split(' ');
            List<int> priserInt = new List<int>();
            foreach (string p in priserStr)
            {
                priserInt.Add(int.Parse(p));
            }

            Dictionary<string, int> matpriser = new Dictionary<string, int>();
            int count = 0;
            foreach (string s in matvaror.Split(" "))
            {
                matpriser[s] = priserInt[count];
                count++;
            }

            Console.WriteLine("Skriv in din handlingslista");
            string input = Console.ReadLine();
            List<string> handlingslista = new List<string>();
            int summa = 0;

            foreach (string h in input.Split(" "))
            {
                summa += matpriser[h];
            }

            Console.WriteLine("Totala priset är " + summa);
        }
    }
}