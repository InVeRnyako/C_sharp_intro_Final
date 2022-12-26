// Задача: Написать программу, которая из имеющегося масива строк
// формирует массив из строк, длинна которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

string[] inputArray = {"hello", "2", "world", ":-)"}; // Исходный массив

string[] resultArray = FindShortInArray(inputArray, 3);

PrintStringArray(inputArray);
Console.Write(" -> ");
PrintStringArray(resultArray);



void PrintStringArray(string[] inputArray)
{
    bool firstElement = true;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (firstElement)
        {
            Console.Write($"[\"{inputArray[i]}\"");
            firstElement = false;
        }
        else
        {
            Console.Write($", \"{inputArray[i]}\"");
        }
    }
    Console.Write("]");
}

static string[] FindShortInArray(string[] inputArray, int sizeLimit)
{
    string[] tempArray = new string[inputArray.Length];
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= sizeLimit)
        {
            tempArray[count] = inputArray [i];
            count++;
        }
    }

    string[] outputArray = new string[count];
    for (int i = 0; i < count; i++)
    {
        outputArray[i] = tempArray[i];
    }
    return outputArray;
}