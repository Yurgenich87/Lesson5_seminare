/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
		array[i] = rnd.Next(0, 10);
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
int GetSumm(int[] array)
{
	int sum = 0;

	for (int i = 1; i < array.Length; i++)
	{
		if (i % 2 != 0)
		{
			sum = sum + array[i];
		}
	}
	return sum;
}


int number = GetNumber("Введите размерность массива:");
int[] array = InitArray(number);
PrintArray(array);

int sum = GetSumm(array);
Console.WriteLine($"Сумма нечётных позиций = {sum}");

