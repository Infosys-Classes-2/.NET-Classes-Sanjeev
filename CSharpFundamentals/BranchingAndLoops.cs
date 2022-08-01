using System;

internal class BranchesAndLoops
{
    internal void LearnBranching()
    {
        /* //if-else
        var isHuman = true;
        if(2 + 2 == 4 && isHuman)// &&=logical AND, & = bitwise AND
        {
            Console.WriteLine("I am human and can calculate 2 + 2.");
        }
        else
        {
            Console.WriteLine("I am robot and don't know what 2 + 2 is.");
        } 
        Console.Write("Enter number:");
        var text = Console.ReadLine();
        var number = short.Parse(text);

        if(number == 0)
        {
            Console.WriteLine("You entered ZERO");
        }      
        else if(number < 0)
        {
            Console.WriteLine("You entered -VE number");
        }
        else
        {
            Console.WriteLine("You entered +VE number");
        } */

        //switch
        var today = DateTime.Now.DayOfWeek;
        switch(today)
        {
            case DayOfWeek.Sunday:
            Console.WriteLine("Today is Sunday");
            break;

            case DayOfWeek.Monday:
            Console.WriteLine("Today is Monday");
            break;
            
            case DayOfWeek.Tuesday:
            Console.WriteLine("Today is Tuesday");
            break;
            
            case DayOfWeek.Wednesday:
            Console.WriteLine("Today is Wednesday");
            break;
           
            case DayOfWeek.Thursday:
            Console.WriteLine("Today is Thursday");
            break;
           
            case DayOfWeek.Friday:
            Console.WriteLine("Today is Friday");
            break;
            
            case DayOfWeek.Saturday:
            Console.WriteLine("Today is Saturday");
            break;
            
        }
    }
    internal void LearLooping()
    {
        //for
        /* int p;
        p=0;
        for(short i = 1; i <= 500; i++)
        {
            {    
           if(p % i == 0)    
            {    
             Console.Write(i);    
             i=1;    
             break;    
            }    
          }    
          if (i==0)    
           Console.Write(i);  
            Console.WriteLine(i++);
        } */


        //Program to print prime numbers less than 500.
        /* int count=0;
            Console.WriteLine("Prime numbers between 1 and 500 are: ");
            for (int i = 1; i < 500; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i+"  ");
                    }
                }
            } */



            /* Program to print following pattern: 
            1
            12
            123
            1234
            12345
            123456 */
            
          /*  for(int i = 1; i < 7; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            } */


      /*   Program to print following pattern:

    *
   ***
  *****
 *******
********* 
*/
    int number, i, k, count = 1;
        Console.Write("Enter number of rows\n");
        number = int.Parse(Console.ReadLine());
        count = number - 1;
        for (k = 1; k <= number; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * k - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }

        //while
/*         ConsoleKeyInfo keyInfo = new();
        while(keyInfo.Key ! = ConsoleKey.Escape)
        {
            Console.WriteLine("Hello");
            keyInfo = Console.ReadKey();
        } */
        //do-while
        //foreach
    }
}