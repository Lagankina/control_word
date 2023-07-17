// <!-- Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. -->

Console.Write("Введите длину массива: "); 
int len = int.Parse(Console.ReadLine());
string[] myArray = new string[len];

GetEllementArray(myArray);
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
Console.WriteLine();

string[] resultArray = trim(myArray);

Сonsole.WriteLine("Результирующий массив: ");
PrintArray(resultArray);
Console.WriteLine();

void GetEllementArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write("Введите " + (i + 1) + " элемент массива: ");
        myArray[i] = Console.ReadLine();
    }
}

void PrintArray(string[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write("[" + myArray[i] + "]");
    }
}
string[] trim(string[] array)
{
    int resultCount = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index].Length <= 3)
        {
            resultCount++;
        }
    }
    
    string[] resultArray = new string[resultCount];
    resultCount = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index].Length <= 3)
        {
            resultArray[resultCount++] = array[index];
        }
    } 
    return resultArray;
}










