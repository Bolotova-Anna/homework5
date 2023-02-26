// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] Ourarray = FoundFillArray(7);
double[] FoundFillArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 3)*10;
    }
    return array;
}
void PrintArray(double[] array)
{
    System.Console.WriteLine("["+ string.Join("; ", array)+"]");
}
PrintArray(Ourarray);
void MinArray(double[] array, out double min)
{
    min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i]<min)
    {
        min = array[i];
    }
}
System.Console.WriteLine("Минимальное число в массиве:" + min);
}
MinArray(Ourarray, out double min);
void MaxArray(double[] array, out double max)
{
    max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
}
System.Console.WriteLine("Максимальное число в массиве: " + max);
}
MaxArray(Ourarray, out double max);

double Dif(double number1, double number2 )
{
    double diff = number1 - number2;
    System.Console.WriteLine("Разница между максимальным и минимальным числом равна: " + diff); 
    return diff;
}
Dif(max,min);
