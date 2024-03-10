// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetAvg(new []{1,2,3,4,5}));
Console.WriteLine(GetMax(new []{1,2,3,4,5}));

static double GetAvg(int[] arr)
{
    double sumaElementow = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sumaElementow += arr[i];
    }
    return sumaElementow / arr.Length;
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