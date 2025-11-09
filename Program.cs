using System;
using System.Text;
//Трохи Math додав для полегшення деяких обчислень
class Program
{
    static void Main()
    {
        //1
        int[] arr1 = { 2, 3, 4, 5, 6, 2, 3 };
        int even = 0, odd = 0;
        foreach (int x in arr1)
        {
            if (x % 2 == 0) even++;
            else odd++;
        }
        int unique = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < arr1.Length; j++)
            {
                if (i != j && arr1[i] == arr1[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found) unique++;
        }
        Console.WriteLine($"\n\teven : {even}, \n\todd : {odd}, \n\tunique : {unique}");
        Console.WriteLine();
        //2
        int[] arr2 = { 1, 5, 8, 3, 10, 2, 6 };
        Console.Write("Num : ");
        int limit = int.Parse(Console.ReadLine());
        int countLess = 0;
        foreach (int x in arr2)
        {
            if (x < limit) countLess++;
        }
        Console.WriteLine($"Count elements less than {limit}: {countLess}");
        Console.WriteLine();
        //3
        Console.Write("Enter three numbers separated by spaces : ");
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int[] arr3 = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
        int seqCount = 0;
        for (int i = 0; i < arr3.Length - 2; i++)
        {
            if (arr3[i] == a && arr3[i + 1] == b && arr3[i + 2] == c)
                seqCount++;
        }
        Console.WriteLine($"Count   of sequence ({a} {b} {c}): {seqCount}");
        Console.WriteLine();
        //4
        int[] A = { 1, 2, 3, 4, 5, 6 };
        int[] B = { 4, 5, 6, 7, 8, 9 };
        int[] C = new int[Math.Min(A.Length, B.Length)];
        int k = 0;
        for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < B.Length; j++)
                if (A[i] == B[j])
                {
                    bool exists = false;
                    for (int t = 0; t < k; t++)
                        if (C[t] == A[i]) { exists = true; break; }
                    if (!exists) C[k++] = A[i];
                }

        for (int i = 0; i < k; i++)
            Console.Write(C[i] + " ");
    }
}