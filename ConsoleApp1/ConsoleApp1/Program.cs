// See https://aka.ms/new-console-template for more information



double average(double[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

Console.WriteLine(average([1,2,3,4,5]));