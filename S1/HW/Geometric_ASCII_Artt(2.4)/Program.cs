namespace Geometric_ASCII_Artt_2._4_;

class Program
{  public static void left_triagnle(int base_1)//part1
{
    for(int i=1;i<=base_1;i++){
        for(int j =0;j<i;j++){
        Console.Write("*");

    }
    Console.Write("\n");
    }
} 
    public static void print_left_triangle(char x,int basex){
        for(int i=1;i<=basex;i++){
        for(int j =0;j<i;j++){
        Console.Write(x);

    }
    Console.Write("\n");
    }
    }
    public static void print_right_ytiagnle(int basex)
    {
       for (int i = 1; i <= basex; i++) {
        
        for (int j = 1; j <= basex - i; j++) {
            Console.Write(" ");
        }

        
        for (int k = 1; k <= i; k++) {
            Console.Write("*");
        }

        
        Console.Write("\n");
    }
    }
    static void Main(string[] args)
    {   int j = 5;
        left_triagnle(j);//part 1
        print_left_triangle('%',5);//part2
        print_right_ytiagnle(5);
    }
}
