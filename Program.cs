//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random rnd = new Random();
int [,] nums = new int[3,4];
double mid, sum;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        nums[i, j] = rnd.Next(0, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < 4; j++)
{
    sum = 0;
    for (int i = 0; i < 3; i++) sum += nums[i, j];
    mid = sum / 3;
    Console.WriteLine($"Столбец #{j + 1}: {Math.Round(mid, 1)}");
}

