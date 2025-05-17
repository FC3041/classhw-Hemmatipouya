namespace Parameterized_RocketShip_2._3_;

class Program
{   public static void section1()

{
    Console.WriteLine("+-------+");
    for(int i =0;i<4;i++){
        Console.WriteLine("+*******+");
    }
}
    public static void section2()
{
    Console.WriteLine("+-------+");
    for(int i =0;i<6;i++){
        Console.WriteLine("+*******+");
    }

}
    public static void make_head()
{
        Console.WriteLine("    ^");
        Console.WriteLine("   /|\\");
        Console.WriteLine("  //|\\\\");
        Console.WriteLine(" ///|\\\\\\");
}
    static void Main(string[] args)
    {
        make_head();
        for(int i =0;i<2;i++){
            section1();
        }
        Console.WriteLine("+-------+");
        make_head();





        make_head();
        for(int j =0;j<4;j++){
            section1();
        }
        Console.WriteLine("+-------+");
        make_head();



    }
}
