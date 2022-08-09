 using System;
/*Console.Write("Enter number of days: ");
double numberofdays = int.Parse(Console.ReadLine());
double years = numberofdays/365;
double months = numberofdays/30;
double weeks = numberofdays/7;
Console.WriteLine($"The {numberofdays} days is equivalent to {years} Years, {months} Months, {weeks} Weeks and {numberofdays} Days."); */
/* using System;
        int ndays, years, weeks, days, DAYSINWEEK=7;
        Console.WriteLine("Enter the number of days");
        ndays = int.Parse(Console.ReadLine());
        year = ndays / 365;
        week = (ndays % 365) / DAYSINWEEK;
        days = (ndays % 365) % DAYSINWEEK;
        Console.WriteLine("{0} is equivalent to {1}years, {2}weeks and {3}days", ndays, year, week, days); */

/*     using System;
        double num     =0;
        double years   =0;
        double months =0;
        double weeks   =0;
        double days    =0;
        
        
        Console.Write("Enter number of days: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        years = num / 365;
        months = num / 30.41;
        weeks = (num % 365) / 7;
        days  = (num % 365) % 7;

        Console.WriteLine("Years : " + years);
        Console.WriteLine("Months :" + months);
        Console.WriteLine("Weeks : " + weeks);
        Console.WriteLine("Days  : " + days ); */

// base class name 'baseClass'
class baseClass
 
{
    public void show()
    {
        Console.WriteLine("Base class");
    }
}
 
// derived class name 'derived'
// 'baseClass' inherit here
class derived : baseClass
{
     
    // overriding
    new public void show()
    {
        Console.WriteLine("Derived class");
    }
}
  
class GFG {
     
    // Main Method
    public static void Main()
    {
         
        // 'obj' is the object of
        // class 'baseClass'
        baseClass obj = new baseClass();
        
        
        // invokes the method 'show()'
        // of class 'baseClass'
        obj.show();
         
        obj = new derived();
         
        // it also invokes the method
        // 'show()' of class 'baseClass'
        obj.show();
         
    }
}