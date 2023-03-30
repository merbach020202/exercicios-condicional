Console.WriteLine("Escreva aqui os gols marcados pelo Palmeiras: ");
int pontuação1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva aqui os gols marcado pelo Sao Paulo: ");
int pontuação2 = int.Parse(Console.ReadLine());

if (pontuação1 > pontuação2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Vitoria do Palmeiras!");
    Console.ResetColor();
}
else if (pontuação1 < pontuação2)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Infelizmente não foi do Palmeiras!");
    Console.ResetColor();
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Deu empate!");
    Console.ResetColor();
}



