int lado1, lado2, lado3;
Console.WriteLine("--- Tipo de triângulo ---");

Console.WriteLine("Digite o comprimento do primeiro lado: ");
lado1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o comprimento do segundo lado: ");
lado2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terceiro lado: ");
lado3 = Convert.ToInt32(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
    Console.WriteLine("Os lados formam um triângulo");
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("É um triângulo equilátero");
    }
    else if (lado1 == lado2 && lado2 != lado3)
    {
        Console.WriteLine("É um triângulo isósceles");
    }
    else
    {
        Console.WriteLine("É um triângulo escaleno");
    }
}
else{
    Console.WriteLine("Os lados não formam um triângulo");
}