using System;

class TestClasses
{
    public static void Main()
    {
/*         Animal cow = new();
        Animal goat = new();
        Animal buffalo = new();
        Animal deer = new();
        var fish = new Animal();

        cow.weight = 345.6f;
        cow.type = "Cow";
        cow.PrintDetails(); */
        ;/* BranchesAndLoops br = new();
        br.LearLooping(); */
        MethodLearning ml = new();
        ml.PrintNepal();
        ml.PrintNepalNTimes(10);
        var x = ml.GetInitials("Saneev Shrestha");
        Console.WriteLine(x);
    }
}