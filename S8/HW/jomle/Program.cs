using System.Security.Cryptography.X509Certificates;

namespace jomle;

class Program
{   public static void sentencerevwordtartib(string s,out string b)
    {   b = "";
        
        for(int  i = s.Length-1;i>=0;i--)
        {   

            b=b+s[i];
           
        }
        
        
        Console.WriteLine(b);
        
    }
  
    public static void sentencerevword(string s, out string b)
{
    b = "";
    string word = "";

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] != ' ')
        {
            word = s[i] + word; 
            if (i==0)
            {
                b = b+' ';
                b = b+word;
                
            }
        }
        else 
        {
            
            if (b.Length >0)
            {
                int j =i;
                while (s[j] ==' '){
                b +=" "; 
                j--;
                 
                }
            }
            b =b+ word; 
            word = "";
        }
    }

    

    Console.WriteLine(b);
}

    static void Main(string[] args)
    {   string s = "ali is my favorite    friend.";
        string b;
        sentencerevwordtartib(s,out b);
        sentencerevword(s,out b);
        Console.WriteLine("Hello, World!");
    }
}
