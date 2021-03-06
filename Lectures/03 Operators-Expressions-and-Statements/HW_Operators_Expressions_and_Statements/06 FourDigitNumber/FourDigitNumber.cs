﻿/*
Problem 6.	Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. Examples:
n	    sum of digits	reversed	last digit in front	    second and third digits exchanged
2011	4	            1102	    1201	                2101
3333	12	            3333	    3333	                3333
9876	30	            6789	    6987	                9786
*/

using System;
class FourDigitNumber
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int d = input % 10; //get the forth number
        int c = (input / 10) % 10; // get the third number
        int b = (input / 100) % 10; // get the second number
        int a = (input / 1000) % 10; // get the first number
        int sum = (a + b + c + d);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Reversed: {3}{2}{1}{0}",a, b, c, d);
        Console.WriteLine("Last digit in front: {3}{0}{1}{2}",a, b, c, d);
        Console.WriteLine("Second and third digits exchanged: {0}{2}{1}{3}", a, b, c, d);
    
    
    
    }
}