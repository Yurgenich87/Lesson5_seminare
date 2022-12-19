/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
		array[i] = rnd.Next(99, 1000);
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

// Количество четных чисел в массиве

int GetEvenNumbers(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			sum = sum + 1;
		}
	}
	return sum;
}

int number = GetNumber("Введите размерность массива:");
int[] array = InitArray(number);
PrintArray(array);
int Summ = GetEvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве: {Summ}");



