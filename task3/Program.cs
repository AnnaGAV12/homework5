// Написать программу копирования массива
void InputArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
    }
}
void ArrayCopying(int[] arr, int[] copy)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++) copy[i] = arr[i];
}
void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
       Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите количество элементов массива: ");
int count = int.Parse(Console.ReadLine() ?? "0");
int[] arr1 = new int[count];
int[] arr2 = new int[count];
InputArray(arr1);
Console.WriteLine("Введенный массив 1:");
PrintArray(arr1);
ArrayCopying(arr1, arr2);
Console.WriteLine("Скопированный массив:");
PrintArray(arr2);
