// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

string  SearchElement (int[,] searchArray, int x, int y)
{
   if( x <= searchArray.GetLength(0) && y <= searchArray.GetLength(1)) return  "Элемент массива = "+Convert.ToString(searchArray [x,y]);
   return "Данного элемента нет в массиве";
}


int[,] array = new int [,] 
{
    {1, 4,  5,   7,  19, -23},
    {3, 23, 5,   -7, 17, 5},
    {5, 0,  10,  13, 7,  -6},
    {6, 10, -13, 5,  6,  8},
};

Console.Write(" Введите номер нужной строки = ");
int numberLine = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите номер нужного столбца = ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (SearchElement(array, numberLine, numberColumn));