Console.WriteLine("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 1; i <= num; i++)
{
    if (num < 1)
    {
        Console.WriteLine("Número inválido. Digite um número maior que 0.");
        return;
    }
    
    if (num % i == 0)
    {
        count++;
    }
}

if (count == 2)
{
    Console.WriteLine("O número é primo.");
}
else
{
    Console.WriteLine("O número não é primo.");
}