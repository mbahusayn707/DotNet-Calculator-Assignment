using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Assignment
{
    public class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("============== Calculator ==============");
            Console.WriteLine("========================================");
            firstNum = getFirstNum();
            OperatorId = getOperator();
            secondNum = getSecondNum();
            Console.WriteLine($"The result is : {getResult()}");
            Console.ReadLine();
        }

        public Double firstNum;

        public Double secondNum;

        public int OperatorId;

        public Double getFirstNum()
        {
            Double num1;
            bool isNum1Parsed = true;
            do
            {
                Console.WriteLine("Enter The first Number: ");
                isNum1Parsed = Double.TryParse(Console.ReadLine(), out num1);
                if (!isNum1Parsed)
                {
                    Console.WriteLine("The number is not valid.");
                }
            } while (!isNum1Parsed);
            return num1;
        }

        public Double getSecondNum()
        {
            Double num2;
            bool isNum2Parsed = true;
            do
            {
                Console.WriteLine("Enter The second Number: ");
                isNum2Parsed = Double.TryParse(Console.ReadLine(), out num2);
                if (!isNum2Parsed)
                {
                    Console.WriteLine("The number is not valid.");
                }
            } while (!isNum2Parsed);
            return num2;
        }

        public int getOperator()
        {
            Console.WriteLine("What Operator do you want to you use? Select a number from 1 - 5");
            Console.WriteLine("1 - Sum (+)");
            Console.WriteLine("2 - Sub (-)");
            Console.WriteLine("3 - Multiply (*)");
            Console.WriteLine("4 - Divided By (/)");
            Console.WriteLine("5 - Reminder [Modulus] (%)");

            int oprId;
            bool isOperParsed = true;
            do
            {
                isOperParsed = int.TryParse(Console.ReadLine(), out oprId);
                if (oprId > 6 || oprId < 1)
                {
                    isOperParsed = false;
                }
            } while (!isOperParsed);
            return oprId;
        }

        public Double getResult()
        {
            switch (OperatorId)
            {
                case 1:
                    return Add();

                case 2:
                    return Sub();

                case 3:
                    return Mul();

                case 4:
                    return Div();

                case 5:
                    return Mod();

                default:
                    return 0;
            }
        }

        public Double Add()
        {
            return firstNum + secondNum;
        }

        public Double Sub()
        {
            return secondNum - firstNum;
        }

        public Double Mul()
        {
            return firstNum * secondNum;
        }

        public Double Div()
        {
            return firstNum / secondNum;
        }

        public Double Mod()
        {
            return firstNum % secondNum;
        }
    }
}