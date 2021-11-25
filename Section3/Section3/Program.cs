using System;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            operators();
        }
        public static void writeSomething()
        {
            Console.WriteLine("I am called from a method");
            
        }
        public static void writeSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        public static int addNum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int multiNum(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int divNum(int num1, int num2)
        {
            return num1 * num2;
        }
        public static void greetFriend(string friend)
        {
            Console.WriteLine($"Hey {friend}, my friend!");
        }
        public static void readInput()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(input1 + input2);
            Console.Read();
        }
        public static void tryCatch()
        {
            Console.WriteLine("please enter a number: ");
            try
            {
                int input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter correct data type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, too long, too short for int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value is empty");
            }
            finally
            {
                Console.WriteLine("this is called anyways");
            }
            Console.ReadKey();
        }
        public static void divideByZero()
        {
            Console.WriteLine("Write a number: ");
            int input1 = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(input1 / 0);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("You can't divide by 0");
            }
            Console.Read();
        }
        public static void operators()
        {
            int num1 = 5;
            int num2 = 2;
            int num3;

            num3 = -num1;
            Console.WriteLine(num3);

            bool isSunny = true;
            Console.WriteLine(!isSunny);

            int num = 0;
            num++;
            Console.WriteLine(num);
            // increment after
            Console.WriteLine(num++);
            // increment before
            Console.WriteLine(++num);
            // same applies for -- to decrement

            int result;
            result = num1 + num2;
            Console.WriteLine(result) ;
            
            // && = AND  ||=or

        }
    }
}
