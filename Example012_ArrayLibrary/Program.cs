﻿void FillArray(int[] collection) //метод для заполнения массива слкчайными числами
{
    int length = collection.Length; // определение длины массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // присваиваем элементу массива рандомное значение
        index++;
    }
}

void PrintArray(int[] col) //метод для вывода на экран массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);