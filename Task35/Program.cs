int[] numbers = new int[123];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Quantity(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 || array[i] < 100 )
        {
            quantity++;
        }
    }
    return quantity;
}

FillArray(numbers);
WriteArray(numbers);
Console.WriteLine();

int quantity = Quantity(numbers);
Console.WriteLine($"Количество элементов массива [10,99]: {quantity}");



