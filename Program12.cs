//     Write a function that takes in a list of integers and returns the largest integer in the list.
/*using System;
   using System.Collections.Generic;
   
   namespace ConsoleApp1
   {
       public class Program12
       {
           static void Main()
           {
               List<int> numbers = new List<int>{0,-5,23,-6647,886,12,34}; 
               try
               {
                   int result = FindLargestInteger(numbers);
                   Console.Write(result);
               }
               catch (Exception ex) //in this part i am creating an error message in case of having an empty list
               {
                   Console.Write(ex.Message);
               }
           }
   
           static int FindLargestInteger(List<int> lst)
           {
               if (lst.Count == 0)
               {
                   throw new InvalidOperationException("The list is empty"); //throw statement is for throwing exceptions
               }
               
               int max = lst[0];
               
               foreach (int number in lst)
               {
                   if (number > max)
                   {
                       max = number;
                   }
               }
               return max;
           }
       }
   }
   */