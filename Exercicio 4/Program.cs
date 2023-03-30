int senha = 1234;

Console.WriteLine("Digite sua senha: ");
int digitos = int.Parse(Console.ReadLine());

if (digitos == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO");   
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}



