/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("m=");
int n = Input("n=");

double[,] number = new double[m, n];

FillRandomArrayNumbers(number);
PrintArray(number);


void FillRandomArrayNumbers(double[,] array)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = Convert.ToDouble(new Random().Next(-10,100))/10;
        }
    }

}    
void PrintArray(double[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for(int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/


/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("m=");
int n = Input("n=");
double averageSum = 0;
double total = 0;
int[,] number = new int[m, n];

FillRandomArrayNumbers(number);
PrintArray(number);

void FillRandomArrayNumbers(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(-10,100);
        }
    }

}  
void PrintArray(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for(int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();
    }
}  

Console.WriteLine();
Console.Write("Среднее арифметическое = ");

  for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            averageSum+= number[i, j];
            
            
        }
        total = Math.Round(averageSum / n,3);
        if(i != number.GetLength(0) - 1)
        {
            Console.Write($"{total}, ");

        }
        else Console.Write($"{total}. ");


    }*/


/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("m=");
int n = Input("n=");
int[,] number = new int[m, n];
int item = Input("Введите позицию элемента: ");

if(item % 10 > n || item / 10 > m )
{
       Console.Write("Такого числа в массиве нет");
       return;
}
FillRandomArrayNumbers(number);
PrintArray(number);

Console.WriteLine(number[item/10, item%10]);

void FillRandomArrayNumbers(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(-1,10);
        }
    }

}  
void PrintArray(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for(int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();
    }
}
