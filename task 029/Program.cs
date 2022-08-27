/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.(Написал функцию,
которая в качестве аргумента принимает длину массива и заполняет его случайными числами.
И выводит этот массив на экран) */

void ArrayNumber (int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next();

    }

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
ArrayNumber(2);
