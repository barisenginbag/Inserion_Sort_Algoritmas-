using System;

class Program
{
    static void Main()
    {
        int[] arr = { 7, 3, 5, 8, 2, 9, 4, 15, 6 };

        // Selection Sort fonksiyonu çağırılıyor
        SelectionSort(arr);

        // Sonuç gösteriliyor
        Console.WriteLine("Sıralanmış dizi:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.ReadKey();
    }

    // Selection Sort fonksiyonu
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap işlemi
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
