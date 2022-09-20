using System;

namespace TypingAnSMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int wordLenght = int.Parse(Console.ReadLine());
            string savedWord = "";

            for (int counter = 1; counter <= wordLenght; counter++)
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {

                    case 0:
                        savedWord += ' ';
                        break;

                    case 2:
                        savedWord += 'a';
                        break;
                    case 22:
                        savedWord += 'b';
                        break;
                    case 222:
                        savedWord += 'c';
                        break;

                    case 3:
                        savedWord += 'd';
                        break;
                    case 33:
                        savedWord += 'e';
                        break;
                    case 333:
                        savedWord += 'f';
                        break;

                    case 4:
                        savedWord += 'g';
                        break;
                    case 44:
                        savedWord += 'h';
                        break;
                    case 444:
                        savedWord += 'i';
                        break;


                    case 5:
                        savedWord += 'j';
                        break;
                    case 55:
                        savedWord += 'k';
                        break;
                    case 555:
                        savedWord += 'l';
                        break;

                    case 6:
                        savedWord += 'm';
                        break;
                    case 66:
                        savedWord += 'm';
                        break;
                    case 666:
                        savedWord += 'o';
                        break;

                    case 7:
                        savedWord += 'p';
                        break;
                    case 77:
                        savedWord += 'q';
                        break;
                    case 777:
                        savedWord += 'r';
                        break;
                    case 7777:
                        savedWord += 's';
                        break;

                    case 8:
                        savedWord += 't';
                        break;
                    case 88:
                        savedWord += 'u';
                        break;
                    case 888:
                        savedWord += 'v';
                        break;

                    case 9:
                        savedWord += 'w';
                        break;
                    case 99:
                        savedWord += 'x';
                        break;
                    case 999:
                        savedWord += 'y';
                        break;
                    case 9999:
                        savedWord += 'z';
                        break;
                }
            }
            Console.WriteLine(savedWord);
        }
    }
}

// Or with string 


