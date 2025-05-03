using System.Diagnostics;

namespace While_Loops_2._10_;

class Program
{
    public static double powe(double a,int b){
    double x = 1 ;
for(int i = 1;i<=b;i++){
    x *=a;
    
}
return x;
}
    public static long factorial(int n){
   if (n==0 ||n ==1){
    return 1;

   }else if (n<0){
    return -1;
   }
   else{
    long count =1;
    for(int i=1;i<=n;i++){
        count*=(long)i;

    }
    return count;

   
   }

}
    public static double eulers_constant( double precision){//part1
        int  i =0;
        double count =0;
        while(1.0/factorial(i)>precision){
            
            count+=(double)1/factorial(i);
            i++;
        }

        return count;

    }
    public static double exp(int x,double percision){//part2
    double eX= 1;
    int i =  1 ;
    while(powe(x,i)/(factorial(i))>percision){
        eX += powe(x,i)/(factorial(i));
        i ++;


    }
    return eX;
    }
    public static double exp2(double x,double percision){//part3
    double eX = 1;
    double term = 1; 
    int i = 1;
    double fact = 1;  

    while (term > percision) {
       
        fact *= i; 
        term = 1.0;
        for (int j = 0; j < i; j++) {
            term *= x;  
        }

        term /= fact; 
     if (term >percision){

        eX += term;  
     }
        i++;  
    }

    return eX;
} public static double abs(double x){
    if (x>=0){
        return x;
    }
    else{
        return -x;
    }
}
    public static bool nearness(double x,double y,double closeness){//part3A
        double maax = 0;
        if (abs(x)>abs(y)){
            maax = abs(x);
        }
        else{
            maax = abs(y);
        }
        return abs(x-y)<(closeness*maax);


    }
    public static double  sin(double x,double precision){//part4
    
    double sn = x;
    double term = x;
    int i = 3;
    while(abs(term)>precision){
       
    
       term = -1*(term *x*x)/((i)*(i-1));
       if (abs(term)>precision){
       sn+=term;
       }
       i +=2;
    }
    return sn ;
    }
    public static double square_root(double x,double precision){//part 5
        double lowerbound = 0;
        double upperbound = x;
        double y=0;
       
        if (x>=0){
            while (upperbound - lowerbound>precision){
                y =( (upperbound+lowerbound)/2);
                if(y*y>x){
                    upperbound = y;
                    
                }
                else{
                    lowerbound = y;
                    
                }
                y = (upperbound+ lowerbound)/2;

            }
            
        }
        return y;
    }
    public static double power(double x,int n){
        double count = 1;
        for(int i = 1;i<=n;i++){
            count*=x;
        }
        return count;

    }
    public static double root(double x,int  n, double precision){//part6
        double lowerbound = 0;
        double upperbound = x;
        double y=0;
if (x>=0){
    while (upperbound - lowerbound>precision){
        y =( (upperbound+lowerbound)/2);
        if(power(y,n)>x){
            upperbound = y;
            
        }
        else{
            lowerbound = y;
            
        }
        y = (upperbound+ lowerbound)/2;
    }
    
    
}return y;
    }
    public static double ln(double x,double precision){//part 7
      double e= exp2(1,0.001);
      double upperbound = 0;
      double lowerbound = 0;
      if (x>1){
        upperbound = x;
        lowerbound = 0;
        }
      else if (x>0){
        x = 1/x;
        return -1* ln(x,precision);
      }
      double nama = (upperbound+ lowerbound)/2;
      while(upperbound-lowerbound>precision){
        if (exp2(nama,precision)>x){
            upperbound = nama;
            
        }
        else if (exp2(nama,precision)== x){
            return nama;
        }
        else{
            lowerbound = nama;
        }
        nama = (lowerbound+ upperbound)/2;
    }
    return nama ;
    }
    

    
    

    static void Main(string[] args)
    {
        Console.WriteLine(eulers_constant(0.0001));
        Console.WriteLine(exp(3,0.01));
        Console.WriteLine(exp2(3,0.01));
        Console.WriteLine(nearness(exp(3,0.01),exp2(3,0.01),0.001));//part3B
        Console.WriteLine(square_root(3,0.0001));
        Console.WriteLine(root(25,3,0.001));
        Console.WriteLine(ln(81,0.001));
        
    }

}
