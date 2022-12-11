// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int arrLength = inputNumber("Введите размер массива: ");
int[] arr = Auto(arrLength);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

// Функция ввода
int inputNumber(string message)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

// Функция автозаполнения массива
int[] Auto(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 9);
    }
    return arr;
}