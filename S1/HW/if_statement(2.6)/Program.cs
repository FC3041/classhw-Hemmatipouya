using System;

namespace if_statement_2._6_
{
    class Program
    {
        public static bool LeapYear(int year){//part1
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
        public static void MoreAsciiiArt(int x)//part2
        {
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("%");
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void MyAsciiArg(int number)//part3
        {
            if (number % 2 == 1)
            {
                int x = (number - 1) / 2;
                for (int i = 0; i < x; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("^");
                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine(new string(' ', x - i) + new string('/', i) + "|" + new string('\\', i));
                }
            }
        }
        public static void print_month(int number){//part 5
            if (number ==1 )      Console.WriteLine("January");
            else if (number ==2)  Console.WriteLine("Feburary");
            else if (number ==3)  Console.WriteLine("March");
            else if (number ==4)  Console.WriteLine("April");
            else if (number ==5)  Console.WriteLine("May");
            else if (number ==6)  Console.WriteLine("June");
            else if (number ==7)  Console.WriteLine("July");
            else if (number ==8)  Console.WriteLine("August");
            else if (number ==9)  Console.WriteLine("September");
            else if (number ==10) Console.WriteLine("October");
            else if (number ==11) Console.WriteLine("November");
            else if (number ==12) Console.WriteLine("December");
            else Console.WriteLine("invalid number");
        }
        public static void  ComputeChange(int n){//part6
            int temp = 100-n;
            int nquarter =temp/25;
            temp= temp- nquarter*25;
            int ndime = temp/10;
            temp=temp - ndime*10;
            int nnickel = temp/5;
            temp = temp - nnickel *5;
            int npennies = temp/1;
            Console.WriteLine("quarter: "+nquarter+"dime: "+ndime+"nickel: "+nnickel+"pennies: "+npennies);
}       
        public static void PythagoreanTriples(){//part7
            int x;
            for(int i = 1;i<100;i++){
                for(int j=i;j<100;j++){
                    if(i+j>100){
                        x = 100;
                    }
                    else{
                        x = i+j;
                    }
                    for(int k =j;k<x;k++){
                        if (i*i+j*j==k*k){
                            Console.WriteLine(" "+i+" "+j+" "+k);
                        }
                    }
                }
            }
        } 

        static void Main(string[] args)
        {
            MoreAsciiiArt(10);
            MyAsciiArg(5);
            //part4
            for(int i=1;i<9;i++){
                MyAsciiArg(i);
            }
            ComputeChange(45);
            PythagoreanTriples();
            Console.WriteLine(LeapYear(1792));
            Console.WriteLine(LeapYear(1796));
            Console.WriteLine(LeapYear(1800));
            Console.WriteLine(LeapYear(1804));
            Console.WriteLine(LeapYear(1900));
            Console.WriteLine(LeapYear(1904));
            Console.WriteLine(LeapYear(2000));
            Console.WriteLine(LeapYear(2004));
            print_month(8);


        }
    }
}

