
namespace Hello.Models
{
    internal class Program
    {
        static void greet(string name)
        {
            Console.WriteLine("Good Morning!" + name);
        }

        static float Average(int a, int b, int c)
        {
           int sum = a + b + c;

           return sum / 3;

        }

        static float Average(int a, int b)
        {
            return (a + b) / 2;
                 
        }
        static void Main(string[] args)
        {
            // Single line Comment Example - This is important for debugging. do not remove

            /* Multi line Comment Example
             * this is a multiline comment
             * spanning multiple lines
             */

            // int kaushal = 34; // Integer variable
            // string inp = Console.ReadLine();
            // Console.WriteLine(inp);
            // Console.WriteLine("Hello World");
            // Console.Write("Hello Kaushal");
            // Console.WriteLine("I love C# and the number " + kaushal);

            /* Data types in C#:
             * Integer - int kaushal; --> 4 bytes  
             * Long - long kaushal; --> 8 bytes
             * Floating poin number - float that; --> 4 bytes
             * Double - double kaushal; --> 8 bytes
             * Character - char A = 'A'; --> 2 byte
             * Boolean - bool isGreat = true; --> 1 bit
             * String - string inp = "Kaushal"; --> 2 bytes per character
             */

            // Data Types Examples
            // int a = 34;
            // float b = 34.4F;
            // double c = 34.4D;
            // bool isGreat = true;
            // char d = 'r';
            // string e = "This is a string";
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(isGreat);
            // Console.WriteLine(d);
            // Console.WriteLine(e);

            // Type Casting
            // There are two types of type casting
            // 1. Implicit Casting
            // char to int to long to float to double
            // 2. Explicit Casting
            // int x = (int)3.5;
            // double x1 = (double)3.5;
            // Console.WriteLine(x1);

            // int x = 3;
            // double y = 4;
            // float z = 'y';
            // float varr = Convert.ToInt64(3.55);
            // Convert.ToDouble
            // Convert.ToString
            // string sx = "Random string";

            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);

            // Console.WriteLine("Enter you name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hey, " + name + " How are you?");

            // Console.WriteLine("How many candies do you want? ");
            // string can = Console.ReadLine();
            // Console.WriteLine("You will get 4 more candies: " + (Convert.ToInt32(can) + 4));

            /*Operators in C#:
             1. Arithmetic Operators
             2. Assignment Operators
             3. Logical Operators
             4. Comparison Operators
             */

            // Arithmetic operators Example:

            // int a = 4;
            // int b = 2;
            // Console.WriteLine("The value of a + b is: " + (a + b));
            // Console.WriteLine("The value of a - b is: " + (a - b));
            // Console.WriteLine("The value of a * b is: " + (a * b));
            // Console.WriteLine("The value of a / b is: " + (a / b));
            // Console.WriteLine("The value of a % b is: " + (a % b));

            // Assignment Operators Example:

            // int a = 4;
            // int b = a;
            // Console.WriteLine(b);

            // b += 4;
            // Console.WriteLine(b);

            // b -= 4;
            // Console.WriteLine(b);

            // b *= 4;
            // Console.WriteLine(b);

            // b /= 4;
            // Console.WriteLine(b);

            // b %= 4;
            // Console.WriteLine(b);

            // Logical Operators Example:

            // AND
            // Console.WriteLine("AND Operator");
            // Console.WriteLine(true && true);
            // Console.WriteLine(true && false);
            // Console.WriteLine(false && true);
            // Console.WriteLine(false && false);
            // Console.WriteLine();
            // Console.WriteLine();

            // OR
            // Console.WriteLine("OR Operator");
            // Console.WriteLine(true || true);
            // Console.WriteLine(true || false);
            // Console.WriteLine(false || true);
            // Console.WriteLine(false || false);
            // Console.WriteLine();
            // Console.WriteLine();


            // Not
            // Console.WriteLine("NOT Operator");
            // Console.WriteLine(!false);
            // Console.WriteLine(!true);


            // Comparison Operators Example:

            // Console.WriteLine(324 > 555);
            // Console.WriteLine(324 < 555);
            // Console.WriteLine(324 >= 555);
            // Console.WriteLine(324 <= 555);
            // Console.WriteLine(324 != 555);
            // Console.WriteLine(324 == 555);
            // Console.WriteLine(5 == 5);

            // Math class in C#:
            // minimum maximum value
            // int a = Math.Max(34, 345);
            // int b = Math.Min(34, 345);
            // Console.WriteLine(a);
            // Console.WriteLine(b);

            // square root value 
            // double x = Math.Sqrt(49);
            // Console.WriteLine(x);

            // Absolute 
            // int a = Math.Abs(-39);
            // Console.WriteLine(a);


            // String Methods
            // string hello = "Hello World! this is Kaushal ";
            // Console.WriteLine(hello.Length);
            // Console.WriteLine(hello.ToUpper());
            // Console.WriteLine(hello.ToLower());

            // String Concatenation
            // Console.WriteLine(hello + "you are nice.");
            // Console.WriteLine(string.Concat(hello , "you are nice."));

            // String interpolation
            // string name = Console.ReadLine();
            // string candies = Console.ReadLine();
            // Console.WriteLine($"Your name is {name}. You will get {candies} candies");

            // String access characters
            // string hello = "Hello World! this \n is \t Kaushal "; // escape sequence: \" --> ", \n --> new line., \t --> tab
            // Console.WriteLine(hello[0]);
            // Console.WriteLine(hello.IndexOf("is"));
            // Console.WriteLine(hello.Substring(5));
            // Console.WriteLine(hello);


            // If-else statements
            // Console.WriteLine("Enter your age: ");
            // string ageStr = Console.ReadLine();
            // bool isbanned = true; 
            // int age = Convert.ToInt32(ageStr);

            // if(age < 2 || isbanned)
            // {
            //    Console.WriteLine("You are just born or banned.");
            // }

            // else if(age < 10 || isbanned)
            // {
            //    Console.WriteLine("Please finish your high school or maybe you are banned");
            // }

            // else if(age < 18)
            // {
            //    Console.WriteLine("You are below 18");
            // }
            // else if(age < 75)
            // {
            //    Console.WriteLine("You can drive");
            // }

            // else
            // {
            //    Console.WriteLine("You cannot drive.");
            // }

            //Switch in C#
            //int age = 20;

            // switch (age)
            // {
            //    case 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;

            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;

            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;
            // }


            // Loops in C#

            // Console.WriteLine(1);
            // Console.WriteLine(2);
            // Console.WriteLine(3);
            // Console.WriteLine(4);
            // Console.WriteLine(5);

            // Better Alternative - Loops
            // while Loops
            // int i = 0;
            // while (i < 5000)
            // {
            //    Console.WriteLine(i+1);
            //    i++;

            // } 

            // Do while loop
            // int i = 0;
            // do
            // {
            //    Console.WriteLine(i + 1);
            //    i++;

            // } while (i < 10);

            //for loop

            // for (int i = 0; i < 10; i++)
            // {
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + 1);
            //    //break;
            // }

            // Break and Continue
            // Break - Leave this loop forever
            // Continue - Leave this particular iteration of the loop

            // Methods in C#

            // greet(" Kaushal");
            // greet(" Kritika");

            // Console.WriteLine(Average(2, 6, 8));
            // Console.WriteLine(Average(3, 3, 3));
            // Console.WriteLine(Average(2, 5));
            // float temp = Average(9, 3, 0);
            // Console.WriteLine(temp);

            // OOPs - Classes and Objects in C#
            Player tommy = new Player();
            Console.WriteLine(tommy.getHealth()); 
            tommy.setHealth(57);
            Console.WriteLine(tommy.getHealth());

        }
    }
}

