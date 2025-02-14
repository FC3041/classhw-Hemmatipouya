namespace Manipulating_Numbers_2._5_;

class Program
{   public static void FToC(double farhrenheit){//part1
    double C ;
    C = (farhrenheit-32)* 5/9;
    double cc=Math.Round(C,2);
    Console.WriteLine("cc,F : "+cc+" "+farhrenheit );

}  
    public static void CToF(double celisius)//part 2
    {
        double F = Math.Round((9/5*celisius + 32),2); 
        Console.WriteLine("c,f:"+celisius+" "+F);
        }
    public static ulong factorial(int n){//part3
        ulong x = 1;
        for(int i =1;i<=n;i++){
            x*=(ulong)i;
        }
        return x;
    }
    public static int powwwwer(int a,int b){
        int  x = 1;
        for(int i =0;i<b;i++){
            x*=a;

        }
        return x;
    }
    public static double average_of_squares0(int n)//part7
    { double x = 0;
    for(int i =0;i<n;i++){
        x+=(double)(i*i);
    }
    return (x/n);
    
    
    
    }
    public static double average_of_squares1(int n)//part8
    { double x = 0;
    for(int i =1;i<=n;i++){
        x+=(double)(i*i);
    }
    return (x/n);
    
    
    
    }

    public static void quadradic(double A,double B,double c)//part6
    {  double delta= B*B - 4 *A*c;
    double x1=0;
    double x2=0;
        if( A!= 0){
            if(( B*B- 4*A*c)>=0){
                x1 = (-B + Math.Sqrt(delta))/(2*A);
                x2 = (-B - Math.Sqrt(delta))/(2*A);
            }
            Console.WriteLine("x1:"+x1+" x2:"+x2);


        }
    }

    static void Main(string[] args)
    {
FToC(180) ;  
CToF(10); 
Console.WriteLine(factorial(5));//part 3
for(int i=1;i<=20;i++){
    Console.WriteLine(factorial(i));//part 4
}
Console.WriteLine(powwwwer(3,4));//part 5
Console.WriteLine(average_of_squares0(5));//part7
Console.WriteLine(average_of_squares1(5));//part8
quadradic(3,4,1);
}
}


