#include <windows.h>
#include <iostream>
using namespace std;

class Keeptime
{ public:   
    Keeptime()
    {
        m_t1 = GetTickCount64();

    }
    void for_loop()
    {   
        double d = 1.01;
        for(int i = 0;i<10000000;i++)
        {
            d *=1.01;
        }
        


    }
    void if_function()
    {
        int n = 0;
        for(int i=0;i<10000000;i++)
        {
            if (i%7 ==2)
            n+=i;
        }
    }
    void while_function()
    {
        double d = 1.01;
        int i =0;
        while(i<10000000)
        {
            d*=1.01;
            i++;
        }
        
    }

    ~Keeptime()
    {
        m_t2 = GetTickCount64();
        cout<<m_t2-m_t1<<endl;
    }
    
  private:
  ULONGLONG m_t1;
  ULONGLONG m_t2; 


};

int main()
{
    Keeptime t;
    t.if_function();
    t.while_function();
    t.for_loop();//halqe for sarie tar ast.
    
   



    return 0;
}