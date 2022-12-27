
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
int howMany = 0;
int p = 0;
for (int t = 0; t < count - k + howMany; t++)
{
    int min = array[t];

    for (int i = t; i < array.Length - k + howMany; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            p = i;
        }
    }
    Console.Write(min);
    howMany++;
    t = p;
}





