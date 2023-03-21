using System;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumNumbers = "1";
            const string CommandExitProgramm = "2";

            int[] arrayNumbers = new int[0];
            bool isOpen = true;
            string userInput;

            Console.WriteLine(" Выберите одну из доступных команд или введите любое число "); 

            while (isOpen)
            {
                Console.WriteLine("Числа");
               
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write(arrayNumbers[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine(CommandSumNumbers + "  - вывести сумму введенных чисел ");
                Console.WriteLine(CommandExitProgramm + "  - выход из программы ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSumNumbers:
                        int sum = 0;
                     
                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            sum += arrayNumbers[i];
                        }
                       
                        Console.WriteLine(" Число сум равно " + sum);
                        Console.ReadLine();
                        break;

                    case CommandExitProgramm:
                        isOpen = false;
                        break;

                    default:
                        int numbers;
                        numbers = Convert.ToInt32(userInput);
                        int[] tempNumbers = new int[arrayNumbers.Length + 1];

                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            tempNumbers[i] = arrayNumbers[i];
                        }

                        tempNumbers[tempNumbers.Length - 1] = numbers;
                        arrayNumbers = tempNumbers;
                        break;
                }
    
                Console.Clear();
            }
        }
    }
}