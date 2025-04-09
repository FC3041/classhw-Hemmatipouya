using System.Data;

namespace Return_Value_Everywhere__2._7_;

class Program
{   public static double  absolutevalue(double x) {//part 1
    if (x>= 0) {return x;}
    else if (x<0){
        return -x;
    }
    else{
        return -1;
    }
}
    public static ulong  factorial(ulong a){//part 2
        ulong x = 1;
        for(int i=1;i<=(int)a;i++){
            x*=(ulong)i;
        }
        return x;

    }
    public static bool is_divisible(int a, int b){//part 3
       if (a%b==0) return true;
       return false;
    }
    public static bool is_prime(int a){//part 4
        for(int i=2;i<=(int)Math.Sqrt(a);i++){
            if (is_divisible(a,i)){
                return false;
            }

        }
        return true;
    }
    public static int fibonacci(int n){//part 5
        if (n ==1 || n ==2){
            return 1;
        }
        else{
            return fibonacci(n-1)+fibonacci(n-2);
        }
    }
    public static bool LeapYear(int year){
            if (year%400 ==0){
                return true;
            }
            else if((year%4==0)&&(year%100!=0)){
                return true ;
            }
            else{
                return false;
            }
        }
    public static int Day_in_month(int monthnumber){//part6
        if (monthnumber ==1) return 31;
        if (monthnumber ==2) return 28;
        if (monthnumber ==3) return 31;
        if (monthnumber ==4) return 30;
        if (monthnumber ==5) return 31;
        if (monthnumber ==6) return 30;
        if (monthnumber ==7) return 31;
        if (monthnumber ==8) return 31;
        if (monthnumber ==9) return 30;
        if (monthnumber ==10)return 31;
        if (monthnumber ==11)return 30;
        if (monthnumber ==12)return 31;
        else return -1;

        


        
    }
    public static int Days_in_month(int monthnumber,int year){//part 7
        if (monthnumber ==1) return 31;
        if (monthnumber ==2) if (LeapYear(year)) return 29;else return 28;
        if (monthnumber ==3) return 31;
        if (monthnumber ==4) return 30;
        if (monthnumber ==5) return 31;
        if (monthnumber ==6) return 30;
        if (monthnumber ==7) return 31;
        if (monthnumber ==8) return 31;
        if (monthnumber ==9) return 30;
        if (monthnumber ==10)return 31;
        if (monthnumber ==11)return 30;
        if (monthnumber ==12)return 31;
        else return -1;
            
            
}
    public static int  days_before_date(int year,int monthnumber,int daynumber){//part8
        int count =0;
        for(int i =1;i<monthnumber;i++){
            count +=Days_in_month(i,year);
        }
        count +=daynumber -1;
        return count;

    }
    public static string day_of_the_week(int year, int monthNumber, int dayNumber){//part9
        int count = days_before_date(year,monthNumber,dayNumber);
        //monday =0 tuesday =1 wednesday =2 thrusday =3 friday =4 saturday =5 sunday =6
        if (count%7==0)return "monday";
        if (count%7==1)return "tuesday";
        if (count%7==2)return "wednesday";
        if (count%7==3)return "thursday";
        if (count%7==4)return "friday";
        if (count%7==5)return "saturday";
        if (count%7==6)return "sunday";
        else return "invalid";

    }

    static void Main(string[] args)
    {
       Console.WriteLine(absolutevalue(-1100));
       Console.WriteLine(factorial(15));
       Console.WriteLine(is_divisible(12,4));
       Console.WriteLine(is_prime(2));
       Console.WriteLine(is_prime(14));
       Console.WriteLine(is_prime(25));
       Console.WriteLine(is_prime(27));
       Console.WriteLine(fibonacci(4));
       Console.WriteLine(Days_in_month(2,2001));
       Console.WriteLine(days_before_date(2016,5,15));
       Console.WriteLine(day_of_the_week(2014,1,9));
    }
}
