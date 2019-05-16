using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            int choice;
            string str;

            DisplayMenu();

            do
            {
                try
                {
                    Console.Write("Please enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                }catch(Exception ex)
                {
                    Console.Write("Please enter valid choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
                
            } while (!(choice >0 && choice < 3));


            switch (choice)
            {
                case 1 :
                    Console.Write("Please Enter integers to revese: ");
                    numbers = int.Parse(Console.ReadLine());
                    ReverseInt(numbers);
                    break;
                case 2 :
                    Console.Write("Please Enter string to revese: ");
                    str = Console.ReadLine();
                    ReverseString(str);
                    break;
                default:
                    break;

            }
                      
            Console.ReadKey();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("[REVERSE FLOW]\n\n");
            Console.WriteLine("1. Reverse numbers");
            Console.WriteLine("2. Reverse string\n");
        }

        public static void ReverseInt(int numbers)
        {

            int reverse = 0;
            while (numbers > 0)
            {
                int remainder = numbers % 10;
                reverse = (reverse * 10) + remainder;
                numbers = numbers / 10;
            }
            Console.WriteLine("Reverse number is {0}", reverse);
        }

        public static void ReverseString(string str)
        {
            string reverse = "";
            int length = str.Length-1;

            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            Console.WriteLine("Reverse string is {0}", reverse);
        }
    }
}
