/* using System;
using System.Linq;

public class MethodLearning
{
    //returns nothing, take no arguments
        /* public void PrintNepal()
        {
            Console.WriteLine("Nepal");
        } */

    //returns nothing, take some arguments
        /* public void PrintNepal(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nepal");
            }
        } */

    //returns some value, take no/some arguments
        /* public int Add(int x, int y)
        {
            var sum = x + y;
            return sum;
        } */
        //Sanjeev Shrestha
            /* public string GetInitials(string fullName)
            {
                var nameParts = fullName.Split(" ");
                var len =nameParts.Length;
                var first = nameParts[0][0];
                var middle = nameParts[1][0];
                var last = nameParts[len-3][0];

                var initial = $"{first}{middle}{last}";
                return initial;
                
            } */

    //returns multiple values, take no/some arguments
    /* public (short, short) GetMinMax(short[] numbers)
        {
            //Imperative
            short max = short.MinValue;
            short min = short.MaxValue;
            foreach (short num in numbers)
            {
                if (num < min)
                min = num;
                
                if (num > max)
                max = num;
            }
            return (min, max); //tuple
        }
    public (short, short, float) GetMinMaxAverage(short[] numbers) */
        /* {
            short max = short.MinValue;
            short min = short.MaxValue;
            int sum = 0;
            int len = numbers.Length;
            foreach (short num in numbers)
            {
                if (num < min)
                min = num;
                
                if (num > max)
                max = num;

                sum = sum + num; 
            }
            return (min, max, sum/len); //tuple
        } */
        
    /* public (short, short) GetMinimumMaximum(short[] numbers)
        {
            short max = numbers.Max;
            short min = numbers.Min;
            
            return (min, max);
        } */
    //variable number of arguments, named parameters, optional parameters

   /*  public void Test()
    {
        //Named parameters
        Add(y:45, x: 23);

        Multiply(23.4, 56.7);
        Multiply(23.4, 56.7, 67.8);

        PrintText("Bishnu");
        PrintText("Ram", "Shyam", "Sita", "Gita");
    } */

   /*  public double Multiply(double x, double y, double z)
    {
        return x * y * z;
    } */

   /*  public void PrintText(params string[] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    } */

    //Expression bodies members, inline methods
   /*  public float Divide(float x, float y) => x / y; //=> is lambda operater

}*/