Console.WriteLine("Informe seu salário: ");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua despesa: ");
int despesa = int.Parse(Console.ReadLine());


if ((despesa - salario) > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Orcamento estourado!");
    Console.ResetColor();
}

else 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Gastos dentro do orcamento!");
    Console.ResetColor();
}













