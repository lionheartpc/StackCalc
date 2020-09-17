using StackCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //StackCalculator<int> stackCal = new StackCalculator<int>();
            //stackCal.push(1);
            //stackCal.push(1);
            //string result2 = stackCal.Add();
            //Console.WriteLine(stackCal.getStackString());

            string consoleCommandString = "";
            int consoleCommandIntArgument;
            StackCalculator<int> stackCal = new StackCalculator<int>();

            while (consoleCommandString != "exit")
                {
                consoleCommandString = Console.ReadLine();

                switch(extractCommandFromString(consoleCommandString))
                {
                    case "push":
                        consoleCommandIntArgument = extractNumericFromString(consoleCommandString);
                        Console.WriteLine(stackCal.Push(consoleCommandIntArgument));
                        break;
                    case "pop":
                        Console.WriteLine(stackCal.Pop());
                        break;
                    case "add":
                        Console.WriteLine(stackCal.Add());
                        break;
                    case "sub":
                        Console.WriteLine(stackCal.Sub());
                        break;
                    case "help":
                        Console.WriteLine("Available commands: push <value>; pop; add; sub;");
                        break;
                    default:
                        Console.WriteLine("No such command, Type help for available commands");
                        break;

                }

                }
            
        }

        private static int extractNumericFromString(string stringToExract)
        {
            int result  = Int32.Parse(Regex.Match(stringToExract, @"\d+").Value);
            return result;
        }

        private static string extractCommandFromString(string stringToExract)
        {
            string result = Regex.Match(stringToExract, @"\b[A-Za-z]+\b").Value;
            return result;
        }
    }
}
