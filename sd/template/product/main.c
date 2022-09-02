#include "stringytify.h"

#include <stdio.h>


int main(int argc, char *argv[])
{
    char perfect[] = "ButfIfmexplainftofyoufhowfallfthaisfmistakenafaideafofdenfouncinagfpleasureafndffpraisinag";
    char TooLongText[] = "ButfIfmustfexplainftofyoufhowfallfthisfmistakenfideafofdenfouncingfpleasureafndffpraisingfpainfasdfasdfasfwasfb";

    Stringitify stringitify;
    Stringitify stringitifyFaulty;

    // Stringitify test; 
    // printf("%d\n", InitializeString("stHButfIfmexplainftofyoufhowfallfthaifmsistakenafaideafofdenfouncinagfpleasureafndffpraisinagloring", &stringitify));+
    // printf("%d\n",StringInsert(&test, 5, TooLongText));
    // printf("%d\n\n",StringReplace(&test, "st", ));

    printf("Initialization of string that is has good data: %d\n", InitializeString("string", &stringitify));
    printf("Initialization of string that is has bad data: %d\n\n", InitializeString(TooLongText, &stringitifyFaulty));

    printf("str after initialization and lenghtfunction: \n%s\n%d\n\n", stringitify.str, StringLength(&stringitify));
  
    printf("str after insertion, status and lenght with data thats too long: \nCode: %d\nString:%s\n", StringInsert(&stringitify, 2, TooLongText) ,stringitify.str);
    printf("Lenght: %d\n\n" ,StringLength(&stringitify));

    printf("str after insertion, status and lenght with data thats good enough: \nCode: %d\nString:%s\n", StringInsert(&stringitify, 2, "Hello"), stringitify.str);
    printf("Lenght: %d\n\n" ,StringLength(&stringitify));
  

   
    printf("Character at index x (2 in this case): %c\n\n", CharAt(&stringitify, 2));
//111 char
    printf("str after replcaing 'el' with text that is too long for the char array: \nCode: %d\nString:%s\n", StringReplace(&stringitify, "el", TooLongText), stringitify.str);
    printf("Lenght: %d\n\n" ,StringLength(&stringitify));

    printf("str after replcaing 'el' with text that fits in the char array: \nCode: %d\nString:%s\n", StringReplace(&stringitify, "el", perfect), stringitify.str);

    printf("Lenght: %d\n" ,StringLength(&stringitify));

}


