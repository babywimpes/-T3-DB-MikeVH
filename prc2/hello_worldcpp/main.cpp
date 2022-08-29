#include <iostream>

using namespace std;

class Hello
{
    public:
        Hello()
        {
            cout << "Hello world ijs constructed!\n";
        }
        void print()
        {
            cout << "Hello world \n";
        }
};

int main()
{
    Hello h;
    h.print();
    return 0;
}