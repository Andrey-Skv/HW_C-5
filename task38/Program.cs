// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double [] getarray(int n)
{
    double[] array = new double [n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
    return array;
}

double [] array1 = getarray(8);

double findMax(double[] arr1)           
{
    double max = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > max) max = arr1[i];
    }
    return max;
}

double findMin(double[] arr2)          
{
    double min = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] < min) min = arr2[i];
    }
    return min;
}

Console.WriteLine(string.Join("|", array1));     
Console.WriteLine("Наибольший элемент массива " + findMax(array1)); 
Console.WriteLine("Наименьший элемент массива " + findMin(array1)); 

double difference = findMax(array1) - findMin(array1);

Console.WriteLine("Разница между наибольшим и наименьшим элементом массива " + difference);