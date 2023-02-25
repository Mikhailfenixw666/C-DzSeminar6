// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] GenerateArray(int size)
{

int[] array = new int[size];

Random rand = new Random();

for(int i = 0; i < size; i++)
{
array[i] = rand.Next(1, 34);
}
return array;
}

var myArray = GenerateArray(8);

System.Console.WriteLine("[" + string.Join(", ", myArray) + "]");