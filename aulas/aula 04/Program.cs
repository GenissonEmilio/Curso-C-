// See https://aka.ms/new-console-template for more information
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine() ?? "";

apresentar(nome);

void apresentar(string nome)
{
    Console.WriteLine($"Olá, {nome}!");
}