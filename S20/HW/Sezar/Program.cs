using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Sezar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string y = "computer";
        string y1 = y.Decoder();
        Console.WriteLine(y1);
        string x = "frpsxwhu";
        string x1 = x.Encoder();
        Console.WriteLine(x1);
        string z = "jsasdeuJKS1247ZADmnsee!";
        string z1 = z.Decoder();
        
        Console.WriteLine(z1);
    }
}
