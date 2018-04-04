using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning: Code related to the addition of Values, this part uses the GetValue method that is explained below
            double value1 = GetValue("Enter value1: "); //Using GetValue method
            double value2 = GetValue("Enter value2: "); //Using GetValue method
            double result = 0;
            //-------------------------------------------------------------------------------------------------------------
            //Beginning: Code related to the operations to be done, this part uses a switch that invokes the arithmetic methods explained below
            Console.WriteLine("Enter operation (A)Add, (S)Substract, (M)Multiply, (D)Division:");
            string operation = Console.ReadLine();
            switch (operation.ToUpper())
            {
                case "A":
                    result = Add(value1, value2); //Using add method
                    break;

                case "S":
                    result = Substract(value1, value2); //Usign substract method
                    break;

                case "M":
                    result = Multiply(value1, value2); //Using multiply method
                    break;

                case "D":
                    result = Divide(value1, value2); //Using divide method
                    break;

                default:
                    break;
            }
            Console.WriteLine("\nResult: " + result);  //Write the result
            Console.Read();
            //-------------------------------------------------------------------------------------------------------------
        }
        //Beginning: Code related to the GetValue method, this one is used to verify if the value is a number, if not it will continue asking the value
        private static double GetValue(string label)
        {
            double value;

            while (true)
            {
                Console.WriteLine(label);
                string input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Value can't be parsed as a number");
                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        //Beginning: Code related to the Aritmetic methods
        private static double Add(double value1, double value2)  //Add method
        {
            return value1 + value2;
        }
        private static double Substract(double value1, double value2)  //Substract method
        {
            return value1 - value2;
        }
        private static double Multiply(double value1, double value2)  //Multiply method
        {
            return value1 * value2;
        }
        private static double Divide(double value1, double value2)  //Divide method
        {
            if (value1 == 0 || value2 == 0) //Verify that any of elements in the division is not 0, therefore it returns 0
            {
                return 0;
            }
            else
            {
                return value1 / value2;
            }
        }
        //-------------------------------------------------------------------------------------------------------------
    }
}

