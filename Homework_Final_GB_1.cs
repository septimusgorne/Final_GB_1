using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_1_GB_Homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Input Random Array
            List<string> arr = new List<string>();

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ&^)*(&^%$#@!?/{[]".ToCharArray();
            Random random = new Random();

            for (int i = 1; i <= random.Next(4, 10); i++)
            {
                string word = "";
                for (int j = 1; j <= random.Next(1, 7); j++)
                {
                    int letter_num = random.Next(0, letters.Length - 1);

                    word += letters[letter_num];
                }
                arr.Add(word);
            }

            //Original array
            Console.WriteLine("\n Исходный массив: ");
            foreach (var item in arr)
            {
                Console.WriteLine($"{item}\n");
            }


            //Filtration array
            Console.WriteLine("\nФильтрация, символы <=3");


            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Count() <= 3)
                {
                    Console.Write($"{arr[i]}  ; ");
                }
            }
            Console.ReadLine();
            
        }
    }
}
