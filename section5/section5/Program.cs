using System;

namespace section5
{
    class Program
    {
        static void Main(string[] args)
        {
            calcAvg();
        }
        static void forLoop()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void doLoop()
        {
            int i = 0;
            int lengthOfText = 0;
            string wholetext = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholetext += nameOfAFriend;
            } while (lengthOfText<20);
            Console.WriteLine(wholetext);
            Console.WriteLine("thanks that was enough!");
        }
        static void whileLoop()
        {
            int i = 1;
            while(i <= 10)
            {
                string studentEntered = Console.ReadLine();
                Console.WriteLine($"Students entered: {i}");
                i++;
            }
        }
        static void breakAndContinue()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("At 3 we stop");
                    break;
                }
            }
        }
        static void calcAvg()
        {
            Console.WriteLine("Calculate avg score of students(enter -1 to end)");
            int totalGrade = 0;
            int enteredValue;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter grade");
                enteredValue = +int.Parse(Console.ReadLine());
                if (enteredValue <= 20 && enteredValue >= 0)
                {
                    counter++;
                    totalGrade += enteredValue;
                }

            } while (enteredValue != -1);

            int avg = totalGrade / counter;
            Console.WriteLine(avg);
        }
    }
}
