using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace E3;

//Question0
public class Animal
{
    public Animal() { }
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}
public class Dog : Animal
{
    public Dog() : base()
    {

    }
    public override string MakeSound()
    {
        return "Woof";
    }

}




//Question1

public class MyPointType1
{

    public int X;
    public int Y;
    // public MyPointType1(int xx, int yy)
    // {
    //     this.X = xx;
    //     this.Y = yy;
    // }
}
public struct MyPointType2
{
    public int X;
    public int Y;
    // public MyPointType2(int xx, int yy)
    // {
    //     this.X = xx;
    //     this.Y = yy;
    // }
}

//Question2


public class Product:IComparable<Product>
{
    public string Name;
    public int Price;

    public int CompareTo(Product? other)
    {
        if (other == null ||other.Name==null)
        {
            return 0;
        }
        
          return this.Name.CompareTo(other.Name); 
        
        
    }
}
public class Comparer<T> where T : IComparable<T>
{
    public T x;
    public T y;
    public Comparer(T xx, T yy)
    {
        this.x = x;
        this.y = yy;
    }

    public int CompareTo(T? other)
    {
        if (other == null)
        {
            return 0;
        }
          return this.x.CompareTo(other); 
      

        

    }
    public T GetLarger()
    {
        T other = this.y;
        if (CompareTo(other) == 1)
        {
            return this.x;
        }
        else return this.y;
    }
}



//Question3








//Question4,5


public class Sale
{
    public string Category;
    public int Amount;

}
public static class LinqProblems
{

    public static IEnumerable<int> FilterAndDouble(List<int> a)
    {
        var Answer = a.Where(x => x >= 5 && x % 2 == 0)
        .Select(x => 2 * x);
        return Answer;

    }

    // public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> a)
    // {
    //     int Count = 0;
    //     var Answer1 = a.GroupBy(x => x.Category)
    //     .Select(d=>(d))
        





    // }
}



//Question6
public class Money : IEquatable<Money>
{

    public int Amount;
    public string code;
    public Money(int m, string s)
    {
        this.Amount = m;
        this.code = s;
    }

    public bool Equals(Money other)
    {
        if (other == null)
        {
            return false;
        }

        if (this.Amount == other.Amount)
        {
            return true;
        }
        return false;
        
        
    

    }
    public static Money operator +(Money other, Money x)
    {
        Money sum = new Money(other.Amount + x.Amount, "USD");

        return sum;
    }
    public static bool operator ==(Money other, Money x)
    {
        if (other != null && x != null)
            return x.Amount == other.Amount;
        return false; 
    }
    public static bool operator !=(Money other, Money x)
    {
        if (other != null)
            return x.Amount != other.Amount;
        return false;

        
    }
}




public static class DelegateProblems
{
    delegate string sh(string s);
    public static string ToUpper(string x) => x.ToUpper();
    public static string ToLower(string x) => x.ToLower();
    public static string   ProcessString(string s,Func<string,string> sh)
    {
        return  sh(s);
    }
}


public class SafeCounter()
{

    public int Count = 0;
    public object obj = new object();
    public void Increment()
    {
        lock (obj)
        {
            Count += 1;
        }
        
    }
}

public class DataService()
{
    public async Task<string> FetchDataAsync(string s)
    {
        return "Data for " + s;
    }
}






// public static class LambdaProblems
// {

//     static 







// }
public class Publisher
{


    public Publisher() { }
}
public class Subscriber
{
    public Subscriber(Publisher? publisher){}
}