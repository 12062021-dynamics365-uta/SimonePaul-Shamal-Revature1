/******************************************************************************************************************************
* Class Assignment:                                                                                                           *
*                                                                                                                             *
*   Sweet-N-Salty Game:                                                                                                       *
* - Print the numbers 1 to 1000 to the console.                                                                               *
* - Print them in groups of 20 per line with one space separating each number.                                                *
* - This will require string concatenation to print the 20-number strings to the console at a time.                           *
* - When the number is a multiple of three, print “sweet” instead of the number on the console.                               *
* - If the number is a multiple of five, print “salty” (instead of the number) to the console.                                *
* - For numbers which are multiples of three and five, print “sweet'nSalty” to the console (instead of the number).           *
* - After the numbers have all been printed, print out how many "sweet"'s, how many "salty"’s, and How many "sweet’nSalty"’s. *
* - These are three separate groups, so sweet’nSalty does not increment sweet or salty (and vice versa).                      *
* - Include verbose commentary in the source code to tell me what each few lines are doing.                                   *
* - The coding Challenge is due by 10pm, Wednesday, 01.05.22.                                                                 * 
* ****************************************************************************************************************************/






var Salty = 0;
var Sweet = 0;
var SweetnSalty = 0;
var numbers = new Array();
for (var i=1; i <= 1000; i++)
{

    if (i % 3 == 0  && i % 5 == 0 )
    {
        
        numbers.push("sweet'nSalty");
        SweetnSalty++;
    }
    else if (i % 3 == 0)
    {
        
        numbers.push("Sweet");
        Sweet++;
    }
    else if (i % 5 == 0)
    {
       
        numbers.push("Salty");
        Salty++;
    }
    else
       { 
        numbers.push(i + " ");
       }

    if (i % 20 == 0)
    {
          console.log(numbers.toString());
          numbers = [];
    }
}

console.log(" ");
console.log(" SweetnSalty Appears: " + SweetnSalty + " times");
console.log(" Sweet Appears: " + Sweet + " times");
console.log("Salty Appears: " + Salty + " times");
