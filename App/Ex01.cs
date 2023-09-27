using System;

public class Ex01
{
  public static void Main()
  {
    int num1, num2, num3;


    Console.WriteLine("Informe o 1° número: ");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o 2° número ");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o 3° número ");
    num3 = int.Parse(Console.ReadLine());

    int maior = num1;

    if (num2 > maior)
    {
      maior = num2;
    }
    if (num3 > maior)
    {
      maior = num3;
    }

    int menor = num1;

    if (num2 < menor)
    {
      menor = num2;
    }
    if (num3 < menor)
    {
      menor = num3;
    }

    double media = (num1 + num2 + num3) / 3;
    Console.WriteLine($"O maior número é: {maior}");
    Console.WriteLine($"O menor número é: {menor}");
    Console.WriteLine($"A média aritmética dos três números é: {media}");

    Console.ReadLine();
  }
}