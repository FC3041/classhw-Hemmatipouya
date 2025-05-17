using System.Numerics;

namespace SumOFInumber;

class Program
{
    static double sum<T1,T2>(T1 a,T2 b)where T1:INumber<T1>
    where T2:INumber<T2>
    {
        double a1 = Convert.ToDouble(a);
        double a2 = Convert.ToDouble (b);
        return a1+a2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write(sum(12,3.5));
    }

}
