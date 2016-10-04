using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //Create Empty list of type object instead of string
           List<object> mixedList = new List<object>();
           //Add the following values to list
            mixedList.Add(7);
            mixedList.Add(28);
            mixedList.Add(-1);
            mixedList.Add("true");
            mixedList.Add("Coding");
            mixedList.Add(23.1);
            mixedList.Add("Dojo");
            mixedList.Add(1);

            //Iterate through list and print all values
            foreach (var object_print in mixedList) //Here var is Type Inference   
            {
                Console.WriteLine(object_print);

            }
            Console.WriteLine("************");
            // Add all values of same type
            var sum = 0;
            int temp = 0; //Using compare type of values in list with this
            for(var i= 0; i< mixedList.Count; i++)
            {
                if(mixedList[i].GetType() == temp.GetType()) //Checking Type
                {
                    sum += (int) mixedList[i]; // To add we have to keep int in braces 
                }
            }
            Console.WriteLine(sum); //printing final sum
        }
    }
}
