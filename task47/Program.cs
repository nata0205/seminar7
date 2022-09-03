// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//диапазон от 10 до -10
using static System.Console;
Clear();
WriteLine("Введите число строк: ");
int m = Convert.ToInt32(ReadLine());
WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(ReadLine());
double[,] array = new double[m,n];
for(int i = 0; i < m; i++)
{
    for(int j =0; j < n; j++)
    {
        array[i,j] = new Random().NextDouble()*20-10;
        Write("{0:0.##}",array[i,j]);
        Write("");
    }
    WriteLine();
}




