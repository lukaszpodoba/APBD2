﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine(getAvg(new []{1,2,3,4,5}));
Console.WriteLine(getMax(new []{1,2,3,4,5}));

static double GetAvg(int[] arr)
{
    double suma = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        suma += arr[i];
    }
    return suma / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= max)
        {
            max = arr[i];
        } 
    }
    return max;
}