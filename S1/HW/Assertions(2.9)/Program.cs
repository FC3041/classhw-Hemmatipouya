namespace Assertions_2._9_;

class Program
{   public static long factorial(int n){//part1
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
    public static bool is_prime(int num){//part2
        if (num<=1){
            return false;
        }
        else{
            for(int i =2;i<=Math.Sqrt(num);i++){
                if (num%i==0){
                    return false ;
                }
            }
            return true;
        }

    }
    static void Main(string[] args)
    {  Console.WriteLine(factorial(12));
       Console.WriteLine(is_prime(-10));
    }
}
