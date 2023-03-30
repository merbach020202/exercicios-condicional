Console.Write($"Digite o valor do 1º lado do triângulo: ");
int lado1 = int.Parse(Console.ReadLine());

Console.Write($"Digite o valor do 2º lado do triângulo: ");
int lado2 = int.Parse(Console.ReadLine());

Console.Write($"Digite o valor do 3º lado do triângulo: ");
int lado3 = int.Parse(Console.ReadLine());


if (lado1 == lado2 && lado3 == lado1 && lado3 == lado2)
{
    Console.Write($"Este e um triângulo equilatero!");
}
else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
{
    Console.Write($"Este e um triângulo isoceles!");
}
else
{
    Console.Write($"Este e um triângulo escaleno!");
}









