//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*int [] CreateRandomArray(int size)
{
    int [] newArray = new int[size];

    for(int i = 0;i < size;i++)
    newArray[i] = new Random().Next(100,998);
    return newArray;
}

void ShowArray(int[] array) //демонстрация массива
{
    for(int i = 0;i < array.Length;i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Cratnost(int[] arrayCr)
{
    int count = 0;
    for(int i = 0;i < arrayCr.Length;i++)
    if(arrayCr[i] % 2 == 0)count++;

    return count;
}

Console.WriteLine("Imput size: ");
int user_size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(user_size);
ShowArray(array);
int Crat = Cratnost(array);
Console.WriteLine($"{Crat}");
*/


//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*int [] CreateRandomArray(int size)
{
    int [] newArray = new int[size];

    for(int i = 0;i < size;i++)
    newArray[i] = new Random().Next(100,998);
    return newArray;
}

void ShowArray(int[] array) 
{
    for(int i = 0;i < array.Length;i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Sum(int[] array1)
{
    int A = 0;
    for(int i = 0;i < array1.Length;i++)
    if(array1[i] % 2 != 0)
    A += array1[i];

    return A;
}

Console.WriteLine("Imput size: ");
int user_size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(user_size);
ShowArray(array);
int Summa = Sum(array);
Console.WriteLine($"{Summa}");
*/


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*double [] CreateRandomArray(int size)
{
    double [] newArray = new double[size];

    for(int i = 0;i < size;i++)
    {
    int A = new Random().Next(100,998); 
    double B = Math.Round(new Random().NextDouble(),2);
    newArray[i] = A + B;
    }
    return newArray;
}

void ShowArray(double[] array) 
{
    for(int i = 0;i < array.Length;i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

double FindMin(double[] array)
{
    double A = 1000;
    for(int i = 0;i < array.Length;i++)
    if(array[i] < A) A = array[i];
    return A;  
}

double FindMax(double[] array)
{
    double A = 0;
    for(int i = 0;i < array.Length;i++)
    if(array[i] > A) A = array[i];
    return A;  
}

Console.WriteLine("Imput size: ");
int user_size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomArray(user_size);
ShowArray(array);
double Max = FindMax(array);
Console.WriteLine($"Max is {Max}");
double Min = FindMin(array);
Console.WriteLine($"Min is {Min}");
double Dif = Math.Round((Max - Min),3);
Console.WriteLine($"Dif is {Dif}");
*/