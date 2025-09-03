// See https://aka.ms/new-console-template for more information
int num = 0, count = 0;

Console.Write("Digite um número: ");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        count++;
    }
}

Console.WriteLine("");
if (count == 2)
{
    Console.WriteLine($"{num} é um número primo.");
}
else
{
    Console.WriteLine($"{num} não é um número primo.");
}

Console.WriteLine($"A soma de 2 + 5 é: {somarNumeros(2, 5)}");

int somarNumeros(int num, int num2) {
    int result = num + num2;

    return result;
}