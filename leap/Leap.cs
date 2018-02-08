using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool testOne = year % 4 == 0;
        bool testTwo = year % 100 != 0;
        bool testThree = year % 400 == 0;
        return (testOne && testTwo || testThree);



        /*if (IsLeapYear(year)) ;
        {
            Console.WriteLine("Leap Year!");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
        */
    }
}
