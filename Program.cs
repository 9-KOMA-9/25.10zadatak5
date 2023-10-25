using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak25._10._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite dva broja odvojena razmakom prvi neka bude cijeli broj a drugi decimalan");
            string s1 = Console.ReadLine();
            string[] rijeci = s1.Split(' ');
            int cijelibroj = Convert.ToInt32(rijeci[0]);
            float decimalan = Convert.ToSingle(rijeci[1]);  
            Console.WriteLine(cijelibroj * 2);
            Console.WriteLine(decimalan * 2);
            Console.ReadKey();
        }
    }
}
