// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых не привышает 3 (трех) символов.

string Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    string element = Console.ReadLine();
    return element;
}

string[] CreatArray(int size)
{
    string[] strArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        strArray[i] = Prompt("Введите строковое значение массива -> ");
    }
    return strArray;
}

void PrintStrArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t ");
    }
}

string[] FilterArrayElementSize(string[] arr)
{
    string[] newArray = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

int size = Convert.ToInt32(Prompt("Введите размер массива -> "));
string[] arr = CreatArray(size);
PrintStrArray(arr);
System.Console.WriteLine();
PrintStrArray(FilterArrayElementSize(arr));