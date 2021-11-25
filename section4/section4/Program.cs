using System;

namespace section4
{
    class Program
    {
        static string userName;
        static string password;

        static string hName = "Walter";
        static int highScore = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature?: ");
            String temperature = Console.ReadLine();
            tempCheck(temperature);
        }

        static void tempCheck(string sTemp)
        {
            int temp;
            int iTemp;
            string weatherNotice;
            if (int.TryParse(sTemp, out temp))
            {
                iTemp = temp;
            }
            else
            {
                iTemp = 0;
                Console.WriteLine("value entered was not a number, temp set to 0");
            }
            weatherNotice = iTemp <= 15 ? "it is too cold here" : iTemp >= 16 && iTemp <= 28 ? "it is ok" : "it is hot here";
            Console.WriteLine(weatherNotice);
        }
        
        static void weather()
        {
            Console.WriteLine("What's the temperature?: ");
            String temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("value entered was not a number, temp set to 0");
            }

            if (numTemp < 10)
            {
                Console.WriteLine("take a coat");
            }
            else if (numTemp == 10)
            {
                Console.WriteLine("temp is 10 C");
            }
            else if (numTemp > 10)
            {
                Console.WriteLine("it's cozy and warm");
            }
        }
        static void register()
        {
            Console.WriteLine("Enter username: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();
        }
        static void login()
        {
            bool login = false;
            while(login != true)
            {
                Console.WriteLine("Enter username: ");
                string inputUserName = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string inputPassword = Console.ReadLine();
                if (userName != "")
                {
                    if (inputUserName == userName && inputPassword == password)
                    {
                        Console.WriteLine("Welcome user!");
                        login = true;
                    }
                    else
                    {
                        Console.WriteLine("You have entered the wrong credentials.");
                    }
                }
            }
            
        }
        static void switchCase()
        {
            int age = 25;
            switch (age)
            {
                case 15:
                    Console.WriteLine("too young to enter the club");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("how old are you then?");
                    break;
            }

        }
        static void highScoreCheck(int score, string playerName)
        {
            if(score > highScore)
            {
                hName = playerName;
                highScore = score;
                Console.WriteLine($"New high score = {hName} with {highScore} points.");
            }
            else
            {
                Console.WriteLine($"Old high score = {hName} with {highScore} points.");
            }
        }
        static void solidCheck()
        {
            int temp = -5;
            string stateOfMatter;

            stateOfMatter = temp < 0 ? "solid" : "liquid";
            Console.WriteLine(stateOfMatter);
            temp = 35;
            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
            Console.WriteLine(stateOfMatter);
        }
    }
}
