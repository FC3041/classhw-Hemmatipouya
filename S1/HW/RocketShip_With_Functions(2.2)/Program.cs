namespace RocketShip_With_Functions_2._2_;

class Program
{   public static void make_head(){
    Console.WriteLine("    ^");
    Console.WriteLine("   /|\\");
    Console.WriteLine("  //|\\\\");
    Console.WriteLine(" ///|\\\\\\");

 }
    public static void make_lines(){
    Console.WriteLine("+-------+");

 }
    public static void make_body(){
    Console.WriteLine("+*******+");
    Console.WriteLine("+*******+");
    Console.WriteLine("+*******+");
    Console.WriteLine("+*******+");
 }
    static void Main(string[] args)
    {
        make_head();
        make_lines();
        make_body();
        make_lines();
        make_body();
        make_lines();
        make_head();

    }
}
