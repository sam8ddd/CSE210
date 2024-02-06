using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction myfrac = new Fraction();
        System.Console.WriteLine(myfrac.GetFractionString());
        System.Console.WriteLine(myfrac.GetDecimalValue());

        Fraction myfrac2 = new Fraction(5);
        System.Console.WriteLine(myfrac2.GetFractionString());
        System.Console.WriteLine(myfrac2.GetDecimalValue());

        Fraction myfrac3 = new Fraction(3,4);
        System.Console.WriteLine(myfrac3.GetFractionString());
        System.Console.WriteLine(myfrac3.GetDecimalValue());

        Fraction myfrac4 = new Fraction(1,3);
        System.Console.WriteLine(myfrac4.GetFractionString());
        System.Console.WriteLine(myfrac4.GetDecimalValue());
    }
}