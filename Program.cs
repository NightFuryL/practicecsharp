using System;
using System.Text;
//Трохи Math додав для полегшення деяких обчислень
//Трохи складненько було, а ось так
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
            for (int jj = 0; jj < arr1.Length; jj++)
            {
                if (i != jj && arr1[i] == arr1[jj])
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
        {
            for (int jj = 0; jj < B.Length; jj++)
            {
                if (A[i] == B[jj])
                {
                    bool exists = false;
                    for (int t = 0; t < k; t++)
                        if (C[t] == A[i]) { exists = true; break; }
                    if (!exists) C[k++] = A[i];
                }
            }
        }

        for (int i = 0; i < k; i++)
            Console.Write(C[i] + " ");
        //5
        int[,] arr = {
            { 5, 2, 9 },
            { 1, 7, 3 },
            { 8, 4, 6 }
        };
        int min = arr[0, 0];
        int max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int jjj = 0; jjj < arr.GetLength(1); jjj++)
            {
                if (arr[i, jjj] < min) min = arr[i, jjj];
                if (arr[i, jjj] > max) max = arr[i, jjj];
            }
        Console.WriteLine("Min : " + min);
        Console.WriteLine("Max : " + max);
        //6
        Console.Write("Sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        int wordCount = 0;
        for (int i = 0; i < words.Length; i++)
            if (words[i] != "") wordCount++;
        Console.WriteLine("Count of words: " + wordCount);
        Console.WriteLine();
        //7
        Console.Write("Sentence: ");
        string s = Console.ReadLine();
        string[] parts = s.Split(' ');
        for (int i = 0; i < parts.Length; i++)
        {
            char[] arr4 = parts[i].ToCharArray();
            for (int jjjj = 0; jjjj < arr4.Length / 2; jjjj++)
            {
                char temp = arr4[jjjj];
                arr4[jjjj] = arr4[arr4.Length - 1 - jjjj];
                arr4[arr4.Length - 1 - jjjj] = temp;
            }
            parts[i] = new string(arr4);
        }
        Console.WriteLine(string.Join(" ", parts));
        Console.WriteLine();

        //8
        Console.Write("Sentence: ");
        string text = Console.ReadLine().ToLower();
        string vowels = "aeiou";
        int count = 0;
        foreach (char cc in text)
            foreach (char ccc in vowels)
                if (cc == ccc)
                    count++;
        Console.WriteLine("Count of vowels: " + count);
        Console.WriteLine();
        //9
        Console.Write("Enter a string: ");
        string mainText = Console.ReadLine();
        Console.Write("Enter a substring to search: ");
        string sub = Console.ReadLine();
        int index = 0, total = 0;
        while (true)
        {
            int found = mainText.IndexOf(sub, index);
            if (found == -1) break;
            total++;
            index = found + sub.Length;
        }
        Console.WriteLine("Count of occurrences: " + total);
        Console.WriteLine();

        //10
        string str = Console.ReadLine();
        int n = str.Length;
        int[] indexes = new int[n];
        for (int i = 0; i < n; i++) indexes[i] = 0;

        Console.WriteLine(str);

        int j = 0;
        while (j < n)
        {
            if (indexes[j] < j)
            {
                char[] chars = str.ToCharArray();
                int swapIndex = j % 2 == 0 ? 0 : indexes[j];
                char temp = chars[swapIndex];
                chars[swapIndex] = chars[j];
                chars[j] = temp;
                str = new string(chars);
                Console.WriteLine(str);
                indexes[j]++;
                j = 0;
            }
            else
            {
                indexes[j] = 0;
                j++;
            }
        }
        Console.WriteLine();
        //11
        string textt = Console.ReadLine();
        int[] indexess = new int[256];
        char[] charss = new char[256];
        for (int i = 0; i < textt.Length; i++)
        {
            char currentChar = textt[i];
            if (currentChar == ' ') continue;

            bool found = false;
            for (int jj = 0; jj < 256; jj++)
            {
                if (charss[jj] == currentChar)
                {
                    indexess[jj]++;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                for (int jj = 0; jj < 256; jj++)
                {
                    if (charss[jj] == '\0')
                    {
                        charss[jj] = currentChar;
                        indexess[jj] = 1;
                        break;
                    }
                }
            }
        }
        for (int i = 0; i < 256; i++)
        {
            if (charss[i] != '\0')
            {
                Console.WriteLine($"{charss[i]}: {indexess[i]}");
            }
        }

    }
}