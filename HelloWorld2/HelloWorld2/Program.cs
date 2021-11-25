using System;

namespace HelloWorld2
{
    class Program
    {
        static void Int()
            {
            int num1 = 13;
            int num2 = 23;
            int num3, num4, num5;
            num2 = 100;
            int sum = num1 + num2;

            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " = " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine(dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine(fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine(dIDiv);

            Console.Read();
        }

        static void String()
        {
            string myname = "Walter";
            string msg = "My name is " + myname;
            string capsMsg = msg.ToUpper();

            string lowMsg = msg.ToLower();

            Console.WriteLine(capsMsg);
            Console.WriteLine(lowMsg);
            Console.Read();
        }

        static void ExConsole()
        {
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and press enter: ");
            int asciiValuye = Console.Read();
            Console.WriteLine("You have entered {0}", asciiValuye);
        }

        static void L21()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello Walter");
            Console.WriteLine("C# is cool!");

            Console.Read();
        }

        static void Conversion()
        {
            //implicit conversion, big to small
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            //explicit conversion, small to big
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;

            //type conversion
            string myString = myDouble.ToString();
            string floatyString = myFloat.ToString();
            bool sunIsShining = true;

            string boolString = sunIsShining.ToString();

            Console.WriteLine(floatyString.GetType());
            Console.Read();
        }
        
        static void Parsing()
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine(result);
            Console.WriteLine(resultInt);
            Console.Read();
        }

        static void Manipulation()
        {
            int age = 21;
            string name = "Walter";
            string hobby = "waterpolo";

            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello, my name is " + name + ", I am " + age + " years old.");

            Console.WriteLine("String formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old and I like {2}.",name, age, hobby);

            Console.WriteLine("string interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old and I like {hobby}.");
            
            //takes the input litterally, ignores \n terms etc.
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,
molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum
numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium
optio, eaque rerum! Provident similique accusantium nemo autem. Veritatis
obcaecati tenetur iure eius earum ut molestias architecto voluptate aliquam
nihil, eveniet aliquid culpa officia aut! Impedit sit sunt quaerat, odit,
tenetur error, harum nesciunt ipsum debitis quas aliquid. Reprehenderit,
quia. Quo neque error repudiandae fuga? Ipsa laudantium molestias eos 
sapiente officiis modi at sunt excepturi expedita sint?");
        }

        static void StringChallenge1()
        {
            string name;
            Console.Write("Enter your name and press enter: ");
            name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(0, name.Length));
        }

        static void StringChallenge2()
        {
            
            Console.Write("Enter a string here: ");
            string myString = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            string character = Console.ReadLine();
            Console.WriteLine(myString.IndexOf(character));
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");
        }

        static void DatatypesNVariables()
        {
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = -12318925;
            Console.WriteLine(myInt);
            uint myUint = 123091;
            Console.WriteLine(myUint);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUShort = 65535;
            Console.WriteLine(myUShort);
            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);
            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);
            char myCharacter = 'A';
            Console.WriteLine(myCharacter);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }

        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "14.06.2000";

        static void Constants()
        {
            Console.WriteLine($"My birthday is {birthday}");
        }
        static void Main(string[] args)
        {
            Constants();
        }
    }
}
