// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine();
Console.WriteLine("Получен массив: ");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1) - 1; j++)
	{
		for (int k = 0; k < array.GetLength(1) - 1; k++)
		{
			if (array[i, k] < array[i, k + 1])
			{
				int temp = 0;
				temp = array[i, k];
				array[i, k] = array[i, k + 1];
				array[i, k + 1] = temp;
			}
		}
	}
}
Console.WriteLine();
Console.WriteLine("Упорядочим каждую строку массива по убыванию элементов: ");
PrintArray(array);

void FillArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		Console.Write("[ ");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.Write("]");
		Console.WriteLine("");
	}
}



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine($"\nпрямоугольный двумерный массив: ");
Console.WriteLine();
int[,] array = new int[4, 4];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
	int tempSumLine = SumLineElements(array, i);
	if (sumLine > tempSumLine)
	{
		sumLine = tempSumLine;
		minSumLine = i;
	}
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
	int sumLine = array[i, 0];
	for (int j = 1; j < array.GetLength(1); j++)
	{
		sumLine += array[i, j];
	}
	return sumLine;
}

void CreateArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 9);
		}
	}
}

void WriteArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


int[,] firstMartrix = new int[4, 4];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[4, 4];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[4, 4];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение этих двух матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < firstMartrix.GetLength(1); k++)
			{
				sum += firstMartrix[i, k] * secomdMartrix[k, j];
			}
			resultMatrix[i, j] = sum;
		}
	}
}


void CreateArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 5);
		}
	}
}

void WriteArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
	Console.Write(input);
	int output = Convert.ToInt32(Console.ReadLine());
	return output;
}

void WriteArray(int[,,] array3D)
{
	for (int i = 0; i < array3D.GetLength(0); i++)
	{
		for (int j = 0; j < array3D.GetLength(1); j++)
		{
			Console.Write($"X({i}) Y({j}) ");
			for (int k = 0; k < array3D.GetLength(2); k++)
			{
				Console.Write($"Z({k})={array3D[i, j, k]}; ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}

void CreateArray(int[,,] array3D)
{
	int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
	int number;
	for (int i = 0; i < temp.GetLength(0); i++)
	{
		temp[i] = new Random().Next(10, 100);
		number = temp[i];
		if (i >= 1)
		{
			for (int j = 0; j < i; j++)
			{
				while (temp[i] == temp[j])
				{
					temp[i] = new Random().Next(10, 100);
					j = 0;
					number = temp[i];
				}
				number = temp[i];
			}
		}
	}
	int count = 0;
	for (int x = 0; x < array3D.GetLength(0); x++)
	{
		for (int y = 0; y < array3D.GetLength(1); y++)
		{
			for (int z = 0; z < array3D.GetLength(2); z++)
			{
				array3D[x, y, z] = temp[count];
				count++;
			}
		}
	}
}



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
	sqareMatrix[i, j] = temp;
	temp++;
	if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
		j++;
	else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
		i++;
	else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
		j--;
	else
		i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[i, j] / 10 <= 0)
				Console.Write($" {array[i, j]} ");

			else Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}