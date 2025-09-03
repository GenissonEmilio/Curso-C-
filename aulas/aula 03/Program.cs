// See https://aka.ms/new-console-template for more information
int num = 10, count = 0;


for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        count++;
    }
}

if (count == 2)
{
    Console.WriteLine($"{num} é um número primo.");
}
else
{
    Console.WriteLine($"{num} não é um número primo.");
}