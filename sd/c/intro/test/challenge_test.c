#include <string.h>

#include "challenge.h"
#include "unity.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)


void setUp(void)
{
    // This is run before EACH test
}

void tearDown(void)
{
  // This is run after EACH test
}

void test_find_smallest_number_for_number_of_wanted_occurences(void)
{
  int array[] = {10,10,2,2,1,1,1,4,5,4};
  int arraySize = sizeof(array)/sizeof(array[0]);
  int K = 2;
  int smallestNumber = 0;

  TEST_ASSERT_EQUAL(0, FindSmallestNumberThatIsRepeatedKTimes(
    array, arraySize, K, &smallestNumber) );

  TEST_ASSERT_EQUAL(2, smallestNumber);
}



int main (int argc, char * argv[])
{
    UnityBegin();

    MY_RUN_TEST(test_find_smallest_number_for_number_of_wanted_occurences);

    return UnityEnd();
}
