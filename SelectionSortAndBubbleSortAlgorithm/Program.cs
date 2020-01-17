using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortAndBubbleSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] selection_sort_numbers = { 7, 45, 4, 12, 22, 555, 1, 2, 999, 7 };
            int[] bubble_sort_numbers = { 22, 3, 77, 16, 777, 6, 9, 43, 899, 7 };
            Console.WriteLine("Here is the original array that  will be used to execute the Selection Sort Algoirthm: ");
            for (int i = 0; i < selection_sort_numbers.Length; i++)
            {
                Console.Write(" "+selection_sort_numbers[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Here is the array after the execution of the Solution Sort Algorithm: ");
            Selection_Sort(selection_sort_numbers);
            Console.WriteLine(" ");
            Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
            for (int i = 0; i < bubble_sort_numbers.Length; i++)
            {
                Console.Write(" " + bubble_sort_numbers[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
            Bubble_Sort(bubble_sort_numbers);
            for (int i = 0; i < bubble_sort_numbers.Length; i++)
            {
                Console.Write(" "+bubble_sort_numbers[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);


        }
        static void Selection_Sort(int[] ss_arr)
        {
            int min_position;
            int temp;

            for (int i = 0; i < ss_arr.Length; i++)
            {
                min_position = i;

                for (int x = i + 1; x < ss_arr.Length; x++)
                {
                    if (ss_arr[x] < ss_arr[min_position])
                    {
                        min_position = x;
                    }
                }

                if (min_position != i)
                {
                    temp = ss_arr[i];
                    ss_arr[i] = ss_arr[min_position];
                    ss_arr[min_position] = temp;
                }
                Console.Write(" " + ss_arr[i]);
            }
        }

        static void Bubble_Sort(int[] bs_arr)
        {
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {
                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    }
                }
            }
        }
    }
}
