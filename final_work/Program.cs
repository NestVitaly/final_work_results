// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.WriteLine("Введите 5 строк любых символов:");
int size = 5;
string[] array = new string[size]; 
FillArray();    // создаем массив из 5-ти введённых строк
Console.Write("Созданный массив: ");
PrintArray(array);      // выводим массив
Console.WriteLine();

string[] symbol = new string[ArrayCount()];     // создаем массив из количества вычисленных строк, которые имеют 3 символа или менее (строка 40)
FillArrayD(symbol);     // формируем массив из строк с 3-мя символами или менее (строка 54)
Console.Write("Массив из строк с длинной 3 или менее: ");
PrintArrayD(symbol);    // выводим сформированный массив

string[] FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i + 1} строка: {array[i]}");
        array[i] = Console.ReadLine();
        Console.WriteLine();

    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("{ ");
    for (int j = 0; j < array.Length; j++)
    {
        if (j != array.Length)
            Console.Write($"{array[j]}; ");
    }
    Console.Write("}");
}

int ArrayCount()
{
    int con = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            con++;
        }
    }

    return con;
}

void FillArrayD(string[] symbol)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            symbol[j] = array[i];
            j++;
        }
    }
}

void PrintArrayD(string[] symbol)
{
    Console.Write("{ ");
    for (int j = 0; j < symbol.Length; j++)
    {
        if (j != symbol.Length)
            Console.Write($"{symbol[j]}; ");
    }
    Console.Write("}");
}