#include <stdio.h>
#include "parser.h"



int ParseDataSize(int *size)
{
    if(scanf("%i", size) != 1)
    {
        return -1;
    }
   return 0;
}

int ParseData(int size, int data[], int *k, int MAX_SIZE)
{
    if( data == NULL || k == NULL || size >= MAX_SIZE)
    {
        return -1;
    }

    for (int i = 0; i < size; i++)
    {
        if(scanf("%i", &data[i]) != 1)
        {
            return -1;
        }

    }
    if(scanf("%i", k) != 1)
    {
        return -1;
    }

    //printf("size: %i" , size); 
    return 0;
}
