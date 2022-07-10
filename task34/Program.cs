// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] getarray(int n)
{
    int[] arr = new int [n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

int [] array1 = getarray(12);

int even(int[] array2)
{
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if(array2[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(string.Join("|", array1));
Console.WriteLine("Количество четных чисел в массиве "+even(array1)+" раз");