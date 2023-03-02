// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArray(int size, int MinValue, int MaxValue)
{
    int[] ResAr=new int[size];
    for(int i=0; i<size;i++)
    {
        ResAr[i]=new Random().Next(MinValue,MaxValue+1);
    }
    return ResAr;
}
int OddArray(int[] array)
{
    int result=0;
    for (int i =1; i < array.Length; i+=2)
    {
            result+=array[i];

    }
     return result;
}

Console.Clear();
int[] array= GetArray(10,100,1000);
Console.Write(String.Join(", ", array));
int result= OddArray(array);
Console.Write($"->{result}");

