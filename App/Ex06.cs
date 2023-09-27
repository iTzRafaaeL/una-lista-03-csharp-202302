using System;

public class Ex06
{
  public static void Main()
  {
    Console.WriteLine("Digite o 1º número:");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 2º número inteiro:");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int maiorNum, menorNum;

    if (n1 < n2)
    {
      menorNum = n1;
      maiorNum = n2;
    }
    else
    {
      menorNum = n2;
      maiorNum = n1;
    }

    Random random = new Random();
    int numAleatorio = random.Next(menorNum, maiorNum + 1);

    Console.WriteLine($"O número aleatório gerado é: {numAleatorio}");

    if (numAleatorio % 2 == 0)
    {
      Console.WriteLine("O número é par.");
    }
    else
    {
      Console.WriteLine("O número é ímpar.");
    }
  }
}