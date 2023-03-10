/*  Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
/либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
 */

string [] array = { "Hello", "2", "world", ":-)" };


void PrintArray(string[] array)  //подзадача, которая выводит данный массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++) //циклом пробегаемся по всем элементам и показ. на экране
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine(); //пустая строка
}

string [] SortArray (string [] array)
{
	int countNecessaryValue = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) countNecessaryValue++;
	}

	string [] endArray = new string [countNecessaryValue];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			endArray[index] = array[i];
			index++;
		}
	}
	return endArray;
}

PrintArray(array);
string [] endArray = SortArray(array);
SortArray(endArray);
PrintArray(endArray);











