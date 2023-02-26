// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] Ourarray = FoundFillArray(6,100, 999);

int[] FoundFillArray(int size, int leftrange, int rightrange)
{
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(leftrange, rightrange+1);
}
return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(",", array)+"]");
}
PrintArray(Ourarray);
void CountNumber(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 ==0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество четных чисел в масиве = {count}");
}
CountNumber(Ourarray);

