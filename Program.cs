// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}

int[] myArray = InputArray("Input array ");
PrintArray(myArray);
Positive(myArray);