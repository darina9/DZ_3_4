﻿int[]array = GetArray(8);
Console.WriteLine(string.Join("," , array));
int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0;i<size;i++)
    {
        result [i] = new Random().Next(0,34);
    }
    return result;
}