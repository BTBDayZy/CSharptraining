using System.Collections.Generic;

namespace Task1
{
    public class Task1
    {
        public static void Main(string[] args)
        {
            string s = "Mein Kampf";
            char d = 'a';
            int i = 75;
            float f = 2.1f;
            double d2 = 300.000;
            decimal dec = 889;
            bool bl = false;

            Console.WriteLine("The string section: ");
            Console.WriteLine(s + s);

            Console.WriteLine("The char section: ");
            Console.Write(d + d);

            Console.WriteLine("The int section: ");
            Console.WriteLine(i + i);
            Console.WriteLine(i - i);
            Console.WriteLine(i * i);
            Console.WriteLine(i / i);

            Console.WriteLine("The float section: ");
            Console.WriteLine(f + f);
            Console.WriteLine(f - f);
            Console.WriteLine(f * f);
            Console.WriteLine(f / f);

            Console.WriteLine("The double section: ");
            Console.WriteLine(d2 + d2);
            Console.WriteLine(d2 - d2);
            Console.WriteLine(d2 * d2);
            Console.WriteLine(d2 / d2);

            Console.WriteLine("The decimal section: ");
            Console.WriteLine(dec + dec);
            Console.WriteLine(dec - dec);
            Console.WriteLine(dec * dec);
            Console.WriteLine(dec / dec);
            
            Console.WriteLine("The bool section: ");
            Console.WriteLine(!bl);
            Console.WriteLine(bl & bl);
            Console.WriteLine(bl | bl);
            Console.WriteLine(bl == bl);
        }
    }
}