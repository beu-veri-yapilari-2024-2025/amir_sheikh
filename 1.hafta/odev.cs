//ikili arama recusive olarak

using System;

class Program
{
    static int BinarySearch(int[] arr, int target, int left, int right)
    {
        if (left > right) return -1;
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) return mid;
        if (arr[mid] > target) return BinarySearch(arr, target, left, mid - 1);
        return BinarySearch(arr, target, mid + 1, right);
    }

    static void Main()
    {
        int[] a = { 1, 3, 5, 7, 9 };
        int idx = BinarySearch(a, 7, 0, a.Length - 1);
        Console.WriteLine(idx); // 3
    }
}





//dizilerde toplama




using System;

class Program
{
    static int SumArray(int[] arr, int n)
    {
        if (n == 0) return 0;
        return SumArray(arr, n - 1) + arr[n - 1];
    }

    static void Main()
    {
        int[] a = { 2, 4, 6, 8 };
        int sum = SumArray(a, a.Length);
        Console.WriteLine(sum); // 20
    }
}
    



//matris carpma



using System;

class Program
{
    static int[,] Multiply(int[,] A, int[,] B)
    {
        int r1 = A.GetLength(0), c1 = A.GetLength(1);
        int r2 = B.GetLength(0), c2 = B.GetLength(1);
        if (c1 != r2) throw new ArgumentException("Uyumsuz boyut");
        int[,] C = new int[r1, c2];
        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c2; j++)
                for (int k = 0; k < c1; k++)
                    C[i, j] += A[i, k] * B[k, j];
        return C;
    }

    static void PrintMatrix(int[,] M)
    {
        int r = M.GetLength(0), c = M.GetLength(1);
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++) Console.Write(M[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] A = { { 1, 2 }, { 3, 4 } };
        int[,] B = { { 5, 6 }, { 7, 8 } };
        int[,] C = Multiply(A, B);
        PrintMatrix(C);
        // Çıktı:
        // 19 22
        // 43 50
    }
}
