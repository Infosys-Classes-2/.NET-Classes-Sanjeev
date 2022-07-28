using System;
// Console.Write("Your Full Name: ");
// var fullName = Console.ReadLine();
// var len = fullName.IndexOf(" ");
// var firstName = fullName.Substring(0, len);

// Console.WriteLine($"Hello, {firstName}!");

//Class work 1
// Program to capitalize entered text.

        // Console.Write("Enter meter:");
        // int meter = Console.ReadLine();
        // var feet = meter.();
        // Console.WriteLine(uppercase);

//Class Work 2
//Program to convert meter to feet. Output: n metre = m feet

/* double meter, feet;
Console.WriteLine("please enter amount of metres");
feet = Convert.ToInt32(Console.ReadLine());
meter = feet * 3.2808399;
Console.WriteLine("\nFeet in meter : " + meter); */

Console.Write("Enter Meter:");
var length = Console.ReadLine();
var lengthNumber = double.Parse(length);
var feets = lengthNumber * 3.2808399;
Console.WriteLine($"{lengthNumber}metres = {feets} feet");
