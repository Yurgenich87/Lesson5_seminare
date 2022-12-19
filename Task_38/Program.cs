/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
 и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//получить размерность массива с консоли
int GetNumber(string message)
{
	int result;
	while (true)
	{
		Console.WriteLine(message);

		if (int.TryParse(Console.ReadLine(), out result) && result > 0)
		{
			break;
		}
		else
		{
			Console.WriteLine("Ввели не число. Введите корректное число");
		}
	}
	return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
	int[] array = new int[dimension];
	Random rnd = new Random();

	for (int i = 0; i < dimension; i++)
	{
		array[i] = rnd.Next(0, 100);
	}
	return array;
}

//распечатать массив на консоль
void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}

	Console.WriteLine();
}

//Найти сумму нечетных позиций в массиве
int GetDifference(int[] array)
{
	int result = 0;
	int max = array[0];
	int min = array[0];

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
		}
		if (array[i] > max)
		{
			max = array[i];
		}
		result = max - min;
	}
	return result;
}

int number = GetNumber("Введите размерность массива:");
int[] array = InitArray(number);
PrintArray(array);

int diff = GetDifference(array);
Console.WriteLine($"Разницу между максимальным и минимальным элементом = {diff}");
