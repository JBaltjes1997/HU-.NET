using System;
using System.Diagnostics;
using System.Text;

namespace Lambda
{
    static class LambdaRunner
    {
        public static string RunAllMethods(int numOne, int numTwo, int numThree)
        {
            var output = new StringBuilder();

            // TimesThree rewritten as a lambda expression would look like the following:
            // Func<int, int> timesThree = x => 3 * x;
                        
            Func<int, int> timesThree = x => 3 * x;2
            output.AppendFormat("TimesThreeWithLambda({0}) = {1}\n", numOne, timesThree(numOne));

            // ... Rewrite all the other methods as a lambda expression (or local function)

            Func<int, int, int, int> addNumbers = (x, y, z) => x + y + z;
            output.AppendFormat("AddNumberWithLambda met x:{0}, y:{1}, z:{2} = {3} \n", numOne, numTwo, numThree, addNumbers(numOne, numTwo, numThree));

            Func<int, bool> isEven = x => x % 2 == 0;
            output.AppendFormat("isEvenWithLambda: x:{0} = {1} \n", numOne,  isEven(numOne));

            Func<int, string> numToString = x => x switch
            {
                0 => "zero",
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                _ => "undefined",
            };
            output.AppendFormat("Num to String with Lambda x:={0} = {1}\n", numOne, numToString(numOne));

            Func<int, int, int, bool> inBetween = (x, y, z) => (x < y && y < z);
            output.AppendFormat("In between with Lambda x:{0} y:{1} z:{2} = {3}\n", numOne, numTwo, numThree, inBetween(numOne, numTwo, numThree));

            var p = new Person { Name = "Dirk" };
            Action<Person> resetName = p => p.Name = null;
            resetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n", p.Name == null);

            return output.ToString();
        }
    }
}
