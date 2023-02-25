



int[] array = new int[12];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10); // [-9, 10) > -9 до 9
}

System.Console.WriteLine("[" + string.Join(", ", array) + "]");

int sumPositive = 0;
int sumNegative = 0;

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

System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");