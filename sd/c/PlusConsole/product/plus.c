#include <stdio.h>

void print_error(char* executable_name)
{
    fprintf(stderr, "ERROR: This program requires 1 argument.\n");
    fprintf(stderr, "       Usage: %s <size> (where size is an odd number)\n\n", executable_name);
}

void print_plus(int size)
{
    int i,j;
    for(i = 0; i < size; i++){
        for(j = 0; j < size; j++){
            if(i == size/2 || j == size/2){
                printf("* ");
            }else{
                printf("  ");
            }
        }
        printf("\n");
    }
}

int main(int argc, char** argv) // argv is an array of c style strings with argc elements, an alternative declaration is: char* argv[]
{
    if (argc != 2)
    {
        print_error(argv[0]); // argv[0] contains the name of the executable
        return 1;
    }

    int size = 0;
    int result = sscanf(argv[1], "%i", &size); // argv[1] contains the first argument
    if (result != 1)
    {
        print_error(argv[0]);
    }
    if(size % 2 == 0)
    {
        print_error(argv[0]);
        return 1;
    }

    //print cross based on result
    print_plus(size);

    return 0;
}