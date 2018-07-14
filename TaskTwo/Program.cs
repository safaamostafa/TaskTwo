using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter your name please");
            string name = Console.ReadLine();
            int result = 0;

            // Question1
            Console.WriteLine(" Q1. Which of the following is a legal identifier in java ?");
            Console.WriteLine(" a: 2variable");
            Console.WriteLine(" b: #myvar");
            Console.WriteLine(" c:+@$var");
            Console.WriteLine(" d:$_myvar");


            Console.WriteLine("Enter a, b, c or d ");

            char AnswerOne = char.Parse(Console.ReadLine());

            switch (AnswerOne)
            {
                case 'd':
                    result += 1;
                    Console.WriteLine("Your REsult=" + result);
                    break;
               default:
                    Console.WriteLine("Sorry, Try again");
                    Console.WriteLine("Enter a, b, c or d ");
                    char AnswerOne1 = char.Parse(Console.ReadLine());

                    switch (AnswerOne1)
                    {
                        case 'd':
                            result += 1;
                            Console.WriteLine("Your REsult=" + result);
                            break;

                        default:
                            Console.WriteLine(" Game over");

                            Console.ReadLine();
                            return;
                            
                    }
                    break;
            }  // Question1

            // Question2 
            Console.WriteLine(" Q2. Which of these is NOT valid keyword or reserved word in Java ?");
            Console.WriteLine(" a: default");
            Console.WriteLine(" b: null");
            Console.WriteLine(" c: String");
            Console.WriteLine(" d: volatile");


            Console.WriteLine("Enter a, b, c or d ");

            char AnswerOne21 = char.Parse(Console.ReadLine());

            switch (AnswerOne21)
            {
                case 'c':
                    result += 1;
                    Console.WriteLine("Your REsult=" + result);
                    break;
                default:
                    Console.WriteLine("Sorry, Try again");
                    Console.WriteLine("Enter a, b, c or d ");
                    char AnswerOne22 = char.Parse(Console.ReadLine());

                    switch (AnswerOne22)
                    {
                        case 'c':
                            result += 1;
                            Console.WriteLine("Your REsult=" + result);
                            break;

                        default:
                            Console.WriteLine(" Game over");

                            Console.ReadLine();
                            return;

                    }
                    break;
            }  // Question2


            // Question3 
            Console.WriteLine(" Q3. Which is the legal range of values for a short ?");
            Console.WriteLine(" a: -128 to 127");
            Console.WriteLine(" b: -256 to 255");
            Console.WriteLine(" c: -32768 to 32767");
            Console.WriteLine(" d: 0 to 65535");


            Console.WriteLine("Enter a, b, c or d ");

            char AnswerOne31 = char.Parse(Console.ReadLine());

            switch (AnswerOne31)
            {
                case 'c':
                    result += 1;
                    Console.WriteLine("Your REsult=" + result);
                    break;
                default:
                    Console.WriteLine("Sorry, Try again");
                    Console.WriteLine("Enter a, b, c or d ");
                    char AnswerOne32 = char.Parse(Console.ReadLine());

                    switch (AnswerOne32)
                    {
                        case 'c':
                            result += 1;
                            Console.WriteLine("Your REsult=" + result);
                            break;

                        default:
                            Console.WriteLine(" Game over");

                            Console.ReadLine();
                            return;

                    }
                    break;
            }  // Question3


            // Question4 
            Console.WriteLine(" Q4. Which of the following Array declaration statement is illegal ?");
            Console.WriteLine(" a: int [ ] a [ ] = new int [4] [4];");
            Console.WriteLine(" b: int a[ ][ ] = new int [4] [4];");
            Console.WriteLine(" c: int a[ ] [ ] = new int [ ] [4];");
            Console.WriteLine(" d: int [ ] a [ ] = new int [4] [ ];");


            Console.WriteLine("Enter a, b, c or d ");

            char AnswerOne41 = char.Parse(Console.ReadLine());

            switch (AnswerOne41)
            {
                case 'c':
                    result += 1;
                    Console.WriteLine("Your REsult=" + result);
                    break;
                default:
                    Console.WriteLine("Sorry, Try again");
                    Console.WriteLine("Enter a, b, c or d ");
                    char AnswerOne42 = char.Parse(Console.ReadLine());

                    switch (AnswerOne42)
                    {
                        case 'c':
                            result += 1;
                            Console.WriteLine("Your REsult=" + result);
                            break;

                        default:
                            Console.WriteLine(" Game over");

                            Console.ReadLine();
                            return;

                    }
                    break;
            }  // Question4



            // Question5 
            // Question5 
            Console.WriteLine(" Q5.Is it possible in Java to create arrays of length zero ?");
            Console.WriteLine(" a: Yes, you can create arrays of any type with length zero.");
            Console.WriteLine(" b: No, it is not possible to create arrays of length zero in Java.");


            Console.WriteLine("Enter a, b, c or d ");

            char AnswerOne51 = char.Parse(Console.ReadLine());

            switch (AnswerOne51)
            {
                case 'a':
                    result += 1;
                    Console.WriteLine("Your REsult=" + result);
                    break;
                default:
                    Console.WriteLine("Sorry, Try again");
                    Console.WriteLine("Enter a, b, c or d ");
                    char AnswerOne42 = char.Parse(Console.ReadLine());

                    switch (AnswerOne42)
                    {
                        case 'a':
                            result += 1;
                            Console.WriteLine("Your REsult=" + result);
                            break;

                        default:
                            Console.WriteLine(" Game over");

                            Console.ReadLine();
                            return;

                    }
                    break;
            }  // Question5






            Console.WriteLine("******************** RESULT*********************");
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Your REsult=" + result);
            Console.ReadLine();









        }
    }
}
