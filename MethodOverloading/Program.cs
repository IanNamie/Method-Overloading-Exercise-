using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 5;
            var answer1 = Add(x, y);
           
            var dec1 = 5.2m;
            var dec2 = 5.2m;
            var answer2 = Add(dec1, dec2);
            
            var a = 1;
            var b = 0;
            var c = true;
            var answer3 = Add(a, b, c);

            Console.WriteLine($"The answer to the first one is {answer1}, and second is {answer2}, and finally {answer3}!");
           
            //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
            //you must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
           
        }
        public static int Add(int x, int y)
        { return x + y; }
        public static decimal Add(decimal x, decimal y)
        { return x + y; }
       public static string Add(int x, int y, bool a)
        {
            var add = x + y;
            if (a == true && add != 1)
            {
                return $" {add} Dollars";
            }
            else if (a == true && add == 1)
            {
                return $" {add} Dollar";
            } else { return add.ToString(); }
            



              
        }
    }
}
