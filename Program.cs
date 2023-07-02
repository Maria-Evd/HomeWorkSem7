// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, -100, 101);
// PrintArray(array);


// // Метод заполнения двумерного массива
// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m,n];
//     Random ran = new Random();
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i,j] = Math.Round(ran.Next(-100, 101) * 0.1, 1);
//         }
//     }
//     return result;
// }

// // Метод вывода двумерного массива
// void PrintArray(double[,] inArray)
// {
//     for(int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует


// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


// // Метод заполнения двумерного массива
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }

// // Метод вывода двумерного массива
// void PrintArray(int[,] inArray){
//     for(int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
            
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Введите номер строки i: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите номер столбца j: ");
// int B = int.Parse(Console.ReadLine()!);

// int resi = 0;
// int resj = 0;

// if(Search(array) == true) Console.WriteLine($"i={A}, j={B}, --> {array[resi,resj]} ");
// else Console.WriteLine("Такого элемента не существует ");

// // метод поиска элемента
// bool Search(int[,] Array) {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             resi=i;
//             resj=j;
//             if(i  == A && j  == B) return true;    
//         }
//     }
//     return false;
// }  



// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое* элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// // * Сумма всех цифр / их количество(это количество ваших строк)

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


// Метод заполнения двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Метод вывода двумерного массива
void PrintArray(int[,] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
            
        }
    Console.WriteLine();
    }
}

double sum = 0;
// метод поиска среднего арифметического
void GetSum(int [,] array) {
    // double sum = 0;
    int N = rows;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + (array[i,j]); 
        }
        sum = sum / N;
        Console.WriteLine($"Среднее арифметическое столбца № {j} равно {sum:F2}");
        sum=0;
    }
}
GetSum(array);
