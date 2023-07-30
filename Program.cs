// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//         Первоначальный массив можно ввести с клавиатуры,  либо задать на старте выполнения алгоритма. 
//         При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int ReadInt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void ReadArray(string[] ArrayForRead)
{
    Console.WriteLine("Строк для ввода " + ArrayForRead.Length);
    for (int i = 0; i < ArrayForRead.Length; i++)
    {
        Console.Write((i + 1) + ": ");
        ArrayForRead[i] = Console.ReadLine();
    }
}

void PrintArray(string[] ArrayForPrint)
{
    Console.WriteLine($"[{string.Join(", ", ArrayForPrint)}]");
}


//============================================================================
int size = ReadInt("Введите размер массива: ");

string[] arrayOfString = new string[size];

ReadArray(arrayOfString);
Console.Write("Исходный массив: ");
PrintArray(arrayOfString);


