#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }
    void len()
    {
        int i = 0;
        while(m_PChars[i])
        {
            i++;
        }
        cout<<i<<endl;
    }
    bool checkSubstr(const char* x)
    {   int j =0;
        while(x[j])j++;
        
        for(int i=0;i<m_size-j;i++)
        {   int z = 0;
            while ((z<j)&&(x[z]==m_PChars[i+z]))
            {
                z++;
            }
            if (z==j)
            {
                return true;
            }
            
        }
        return false;
    }
    void add()
    {
        
    }

    void printStr()
    {
        cout << m_PChars << endl;
    }
};


int main()
{
    MyStr s1;

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();

    cout<<s2.checkSubstr("haji")<<endl; // TODO1
    s2.len(); //TODO2
    //s2.add(s1); // TODO3 
    
}