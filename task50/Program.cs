// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//, и возвращает значение этого элемента или же указание, что такого элемента нет.
using static System.Console;
Clear();
WriteLine("Введите номер строки:");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите номер столбца:");
int m = Convert.ToInt32(ReadLine()); 
int[,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);
if(n > numbers.GetLength(0)||m > numbers.GetLength(1))
{
    WriteLine("Такого элемента нет");
}
else
{
    WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers [n-1,m-1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(-100,100)/10;
    }
    }
}

void PrintArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Write("[");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i,j]+"");
        }
        Write("]");
        WriteLine("");
    }
}
