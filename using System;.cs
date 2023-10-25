using System;
using System.Collections.Generic;
class Fizzbuzz
{
    public string AcceptsNumber(int x)
    {
            
            if( x % 3 == 0)
            {
                return "fizz";
            }
            else if(x % 5 == 0)
            {
                return "buzz";
            }
            else if(x % 3 == 0 && x % 5 == 0)
            {
                return "fizzbuzz";
            }
            else
            {
                return "No fizz and no buzz!";
            }            
    }
    public static void Main()
    {
        Fizzbuzz fizzbuzz = new Fizzbuzz();
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.Readline());

        string result = fizzbuzz.AcceptsNumber(number);
        System.Console.WriteLine(result);
    }
}