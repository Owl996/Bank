using System;

class Program
{
    static void Main()
    {
        // Первый спортсмен
        int[] sportsman_1 = new int[] { 1, 4, 3, 5, 2 };
        // Второй спортсмен
        int[] sportsman_2 = new int[] { 2, 5, 3, 4, 1 };

        // Складываем и выводим
        int sportman_1_total = 0;
        int sportman_2_total = 0;

        foreach (int i in sportsman_1)
            sportman_1_total += i;
        foreach (int i in sportsman_2)
            sportman_2_total += i;

        Console.WriteLine("Первый спортсмен: " + sportman_1_total);
        Console.WriteLine("Второй спортсмен: " + sportman_2_total);

        Console.ReadKey();
    }
}