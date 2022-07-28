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

//Data Types:numbers, strings,booleans, characters, derived types
//Number: Integer (eg. 34, 55), floating point (2.23, 4.5, 111.010)
byte a = 255; //1 byte = 8 bit = 11111111 = 255 -byte holds up to 255 
short b = 32767; // 2 byte
int c = int.MaxValue; //4 byte
long d = long.MaxValue;

float e = 333.4443f; //float represent with 'f'
double f = double.MaxValue;
decimal g = 12313131231231.1231313123131313m; //decimal represent with 'm'

char h = 'r';
string i = "sanjeev shrestha";
bool j = true;

//declaring variable

byte age = 45; //Explicit type
var age1 = 45; //Implicit type

//nullable variable

float? radius = 56.75f; //null represent with '?' sign
radius = null;

// Array
//One Dimensional
byte[] scores = new byte[1000];
scores[0] = 45;
scores[999] = 50;

var x = scores[49];

byte[] scores1 = {45,20,30};
char[] scores1 = {'a','2','33'};

//multi dimensional
double[,] matrix = new double [2,3];
matrix[0, 0] = 34.5;
matrix[1, 2] = 67.1;

double[,] table ={ {2,3,4}, {4,5,6} };

//jagged aray
short[][] data = new short[3][];

short[] dp1 = { 2,3,4,5,6 };
data[0] = dp1;
