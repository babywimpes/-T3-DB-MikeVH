#include <stdio.h>
#include "challenge.h"

int FindSmallestNumberThatIsRepeatedKTimes(
            int* array, int size, int k, int* smallestNumber)
{
    int count = 0;
    int smallest = 0;
    int found = 0;
    for (int i = 0; i < size; i++)
    {
        count = 0;
        for (int j = 0; j < size; j++)
        {
            if (array[i] == array[j])
            {
                count++;
            }
        }
        if (count == k)
        {
            if (found == 0)
            {
                smallest = array[i];
                found = 1;
            }
            else if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }
    }
    if (found == 0)
    {
        return -1;
    }
    *smallestNumber = smallest;
    return 0;
}

int ComputeDifferenceBetweenMaxAndMinSumOfKElements_0(
            int* array, int size, int k, int* difference)
{
    return -1;
}

int ComputeDifferenceBetweenMaxAndMinSumOfKElements_1(
            int* array, int size, int k, int* difference)
{
    return -1;
}

int ComputeDifferenceBetweenMaxAndMinSumOfKElements_2(
            int* array, int size, int k, int* difference)
{
    return -1;
}

int ComputeDifferenceBetweenMaxAndMinSumOfKElements_3(
            int* array, int size, int k, int* difference)
{
    return -1;
}
