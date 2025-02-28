#include <iostream>
using namespace std;

class DynamicArray {
public:
    int* data;       
    int size;        
    int capacity;    

    
    void resize(int newCapacity) {
        int* newData = new int[newCapacity]; 
        for (int i = 0; i < size; i++) {
            newData[i] = data[i]; 
        }
        delete[] data; 
        data = newData;
        capacity = newCapacity;
    }

public:
    
    DynamicArray() : data(nullptr), size(0), capacity(0) {}

    
    ~DynamicArray() {
        delete[] data;
    }

    
    void push_back(int value) {
        if (size >= capacity) {
           
            resize(capacity == 0 ? 1 : capacity * 2);
        }
        data[size++] = value;
    }

    // درج عنصر در موقعیت مشخص
    void insert(int index, int value) {
        if (index < 0 || index > size) {
            throw out_of_range("Index out of range");
        }
        if (size >= capacity) {
            resize(capacity == 0 ? 1 : capacity * 2);
        }
        // جابجا کردن عناصر برای ایجاد فضای جدید
        for (int i = size; i > index; i--) {
            data[i] = data[i - 1];
        }
        data[index] = value;
        size++;
    }

    // حذف عنصر از موقعیت مشخص
    void erase(int index) {
        if (index < 0 || index >= size) {
            cout<<"nadorost"<<endl;
        }
        
        for (int i = index; i < size - 1; i++) {
            data[i] = data[i + 1];
        }
        size--;
    }

    
    void clear() {
        size = 0; 
    }

    
    int at(int index) const {
        if (index < 0 || index >= size) {
            cout<<("Index out of range")<<endl;
        }
        return data[index];
    }

    
    int getSize() const {
        return size;
    }

    
    int getCapacity() const {
        return capacity;
    }
};
class reshte {
    public:
        char* x;
    
        
        reshte(int size = 100) { 
            x = new char[size];  
            x[0] = '\0'; 
        }
    
       
        ~reshte() {
            delete[] x;  
        }
    
        
        void add_string(char* y) {
            int i = 0;
            while (y[i] != '\0') {
                x[i] = y[i];
                i++;
            }
            x[i] = '\0';  
        }
    
        
        int tool(char* z) {
            int i = 0;
            while (z[i] != '\0') {
                i++;
            }
            return i;
        }
    
       
        char* add_to_str(char* y, char* x) {
            int lenY = tool(y);
            int lenX = tool(x);
            int size = lenY + lenX + 1;  
    
            char* z = new char[size];  
    
            
            int i = 0;
            while (y[i] != '\0') {
                z[i] = y[i];
                i++;
            }
    
            
            int j = 0;
            while (x[j] != '\0') {
                z[i] = x[j];
                i++;
                j++;
            }
    
            z[i] = '\0';
    
            return z;
        }
    

        void print_reshte(char* y) {
            cout << y << " " << tool(y) << endl;
        }
    };


int main() {
    DynamicArray nums;
    nums.push_back(5);
    nums.push_back(10);

   
    for (int i = 0; i < nums.getSize(); i++) {
        cout << nums.at(i) << endl;
    }
    nums.insert(0, 2); 
    nums.erase(0);
    cout << "Capacity: " << nums.getCapacity() << endl;
    nums.clear();
    reshte r;  
    r.add_string((char*)"Hello");
    r.print_reshte(r.x);
    char u[] = "ali";
    char y[] = "akbar";
    char * h=r.add_to_str(y,u);
    cout<<h<<endl;
    delete [] h;
    return 0;
}