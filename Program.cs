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








