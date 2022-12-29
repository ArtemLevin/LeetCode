// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
// 0 <= a, b, c, d < n
// a, b, c, and d are distinct.
// nums[a] + nums[b] + nums[c] + nums[d] == target
// You may return the answer in any order.

Console.Write("Enter the length of the array ");
int Len = int.Parse(Console.ReadLine()!);

int[] OneDimArray()
{
    int[] array = new int[Len];
    for (int i = 0; i < Len; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] array = new int[Len];
array = OneDimArray();

void PrintOneDimArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0}	", array[i]);
    }
    Console.WriteLine(" ");
}

PrintOneDimArray(array);

void Quadruplet(int[] array)
{
    Console.Write("Enter the target ");
    int target = int.Parse(Console.ReadLine()!);
    int k = 0;
    while (k != 1)
    {
        int a = new Random().Next(0, array.Length);
        int b = new Random().Next(0, array.Length);
        int c = new Random().Next(0, array.Length);
        int d = new Random().Next(0, array.Length);
        if (a != b && a != c && a != d && b != c && b != d && (array[a] + array[b] + array[c] + array[d] == target))
        {
            Console.WriteLine($"{array[a]}, {array[b]}, {array[c]}, {array[d]}");
            k = 1;
        }
    }
}

Quadruplet(array);