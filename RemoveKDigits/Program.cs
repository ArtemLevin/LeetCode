
// Given string num representing a non-negative integer num, and an integer k,
// return the smallest possible integer after removing k digits from num

Console.Write("Enter tne number ");
string? num = Console.ReadLine();
Console.Write("Enter the number of removing digits ");
int k = int.Parse(Console.ReadLine()!);

int number = Convert.ToInt32(num);
int numberToDealWith = number;
int count = 0;

while (number > 0)
{
    number /= 10;
    count++;
}

Console.WriteLine("The number of digits in our number is {0}", count);

int[] array = new int[count];
int index = 0;
while (numberToDealWith > 0)
{
    array[count - index - 1] = numberToDealWith % 10;
    numberToDealWith /= 10;
    index++;
}

void PrintOneDimArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine(" ");
}

PrintOneDimArray(array);

int removeKDigits(int[] array, int k)
{
    int f = 0;
    int min = array[0];
    int p = 0;
    int counter = 0;
    for (int i = 0; i < k + 1; i++)
    {
        if (array[i] <= min)
        {
            min = array[i];
            f = i;
        }
    }
    p = f;
    if (counter == 0 && p == k)
    {
        for (int j = k; j < array.Length; j++)
        {
            Console.Write(array[j]);
        }
        Console.WriteLine("");
        return -1;
    }
    if (p < k) Console.Write(min);

    while (counter != 1)
    {
        int index = 0;
        int u = p + 1;
        min = array[u];
        for (int i = p + 1; i < p + k + 1; i++)
        {
            if (array[i] <= min)
            {
                min = array[i];
                index = i;
            }
        }
        p = index;
        Console.Write(min);

        if (p + k + 1 > array.Length)
        {
            for (int j = p + 1; j < array.Length; j++)
            {
                Console.Write(array[j]);
            }
            counter++;
        }
    }
    return -1;
}


removeKDigits(array, k);