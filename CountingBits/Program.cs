// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), 
// ans[i] is the number of 1's in the binary representation of i.

Console.WriteLine("Enter an integer ");
int a = int.Parse(Console.ReadLine()!);
int b = a;
int i = 0;
int counter = 0;
while (a>0)
{
    i = a%2;
    if(i == 1) counter++;
    a /=2;

}
Console.WriteLine($"Number is {b} ---> {counter}");
