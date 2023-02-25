// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
  int[] array = new int[size];
  Random rand = new Random();

  for (int i = 0; i < size; i++)
  {
    array[i] = rand.Next(leftRange, rightRange + 1); // [-9, 10) > -9 до 9
  }

  return array;
}

void PrintArray(int[] array)
{
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
void SumPositiveAndNegative(int[] array, out int sumPositive, out int sumNegative)
{
  sumPositive = 0;
  sumNegative = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      sumPositive += array[i]; // sumPositive = sumPositive + array[i]
    }
    else
    {
      sumNegative += array[i];
    }
  }
}

const int SIZE = 20;
const int LEFT_RANGE = -20;
const int RIGHT_RANGE = 20;

var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
SumPositiveAndNegative(myArray, out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных чисел: {sumP}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumN}");