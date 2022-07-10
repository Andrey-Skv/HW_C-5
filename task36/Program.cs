// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] getarray(int n)
{
    int[] arr = new int [n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,9);
    }
    return arr;
}

int [] array1 = getarray(6);

int sumEven(int [] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(i % 2 != 0)
        count = count + array1[i];
    }
    return count;
}
int sum = sumEven(array1);
Console.WriteLine(string.Join("|",array1));
Console.WriteLine("сумма элементов стоящих на нечетных позициях "+sum);