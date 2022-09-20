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

                savedWord += input;
                switch (input)
                {
                    
                    case 0:
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine("a");
                        break;
                    case 22:
                        Console.WriteLine("b");
                        break;
                    case 222:
                        Console.WriteLine("c");
                        break;
                    case 3:
                        Console.WriteLine("d");
                        break;
                    case 33:
                        Console.WriteLine("e");
                        break;
                        
                    default:
                        break;
                        

                }
            }
            Console.WriteLine(savedWord);
        }
    }
}
