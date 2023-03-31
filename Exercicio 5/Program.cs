float preco = 0.30F;
float precoComDesconto = 0.25F;

Console.WriteLine("Quantidade de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());


if (quantidade >= 12)
{
    float resultado = quantidade * precoComDesconto;
    Console.WriteLine($"O valor total da sua compra foi de R$ {resultado} !");
}

else
{
    float resultado2 = quantidade * preco;
    Console.WriteLine($"O valor total da sua compra foi de R$ {resultado2} ! ");
}





