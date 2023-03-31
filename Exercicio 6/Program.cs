Console.WriteLine($"Digite sua frequência em decimal (Ex: 85% = 0,85): ");
float frequência = float.Parse(Console.ReadLine());

if (frequência < 0.75F)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Reprovado !");
    Console.ResetColor();
}

Console.WriteLine($"Digite sua média");
float media = float.Parse(Console.ReadLine());

if (media <= 7 && media >= 3 && frequência >= 0.75)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Recuperação !");
    Console.ResetColor();
}
else if (media > 7 && frequência > 0.75)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Aprovado!");
    Console.ResetColor();
}


