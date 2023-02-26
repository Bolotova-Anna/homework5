// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] Ourarray = FoundFillArray(6);
int[] FoundFillArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-1, 25);
    }
    return array;
}
void PrintArray(int[]array)
{
    System.Console.WriteLine("["+string.Join(",", array)+"]");
}
PrintArray(Ourarray);
void SumArray(int[] array)
{
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2 != 0)
    {
        Sum = Sum + Convert.ToInt32(Convert.ToString(array[i]));
    }
}
System.Console.WriteLine(Sum);
}
SumArray(Ourarray);
