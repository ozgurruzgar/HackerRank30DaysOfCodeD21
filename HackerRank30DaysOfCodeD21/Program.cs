using System;

namespace HackerRank30DaysOfCodeD21
{
    class Program
    {
		/**
*    Name: PrintArray -- Metodun İsmi: PrintArray olacak.   
*    Print each element of the generic array on a new line. Do not return anything. -- Her bir elemanı yeni satırda yazdıracaz. Geriye bir değer döndürmeyeceğiz.
*    @param A generic array -- Parametre olarak generic bir dizi alacak.
**/
		// Write your code here

		public static void PrintArray<T>(T[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}

		static void Main(string[] args)
        {
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}

			PrintArray<Int32>(intArray);
			PrintArray<String>(stringArray);
		}
	}
    }

