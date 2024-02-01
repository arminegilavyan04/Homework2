/*
// Write a function To find the middle element(s) of a list
using System;
using System.Collections.Generic;

public class Program11
{
    static void Main()
    {
        List<string> strings = new List<string>
        {
            "Jane",
            "Lola",
            "Jack",
            "John",
            "Jessie"
        };

        List<string> middleElements = FindMiddleElements(strings);

        Console.WriteLine("Middle element(s): " + string.Join(", ", middleElements)); //here i use string.join method to print ',' between the middle elements, if there are more than 1 
    }

    static List<string> FindMiddleElements(List<string> lst)
    {
        int n = lst.Count;
        int middleIndex = n / 2;

        if (n == 0)
        {
            Console.WriteLine("Empty list");
            return new List<string>();
        } 
        if (n % 2 == 1)
        {
            return new List<string> { lst[middleIndex] };
        }
        return new List<string> { lst[middleIndex - 1], lst[middleIndex] };
    }
}
*/
