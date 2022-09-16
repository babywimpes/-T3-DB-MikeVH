#include <stdexcept>
#include <iostream>
#include <sstream>

using namespace std;

class Cross
{ 
    private:
        int size;
    public:
        Cross(int size){
            if (size <1 || size % 2 == 0){
                throw out_of_range("Size must be odd and greater than 0");
            }
        }

        void Print(){
            for (int i = 0; i < size; i++){
                for (int j = 0; j < size; j++){
                    if (i == j || i + j == size - 1){
                        cout << "*";
                    }
                    else{
                        cout << " ";
                    }
                }
                cout << endl;
            }
        }
};
/**** insert your code here ****/


/**** ****/

void PrintError(string executable_name)
{
    cerr << "ERROR: This program requires 1 argument.\n";
    cerr << "       Usage: " << executable_name << " <size> (where size is an odd number)\n\n";
}

int main(int argc, char** argv) // argv is an array of c style strings with argc elements, an alternative declaration is: char* argv[]
{
    if (argc != 2)
    {
        PrintError(argv[0]); // argv[0] contains the name of the executable
        return 1;
    }

    int size = -1;
    stringstream s(argv[1]); // argv[1] contains the first argument
    s >> size; // no need for error check here: if conversion doesn't succeed, size will be 0

    try
    {
        Cross c(size);
        c.Print();
    }
    catch (const out_of_range& e)
    {
        PrintError(argv[0]);
    }

    return 0;
}