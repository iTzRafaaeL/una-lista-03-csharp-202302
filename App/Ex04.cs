using System;

public class Ex04
{
  public static void Main()
  {
    Console.WriteLine("Digite o indicador de operação: \n1 para perímetro do círculo \n2 para área do círculo \n3 para volume da esfera:");
    int operacao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o raio:");
    double raio = Convert.ToDouble(Console.ReadLine());

    if (operacao == 1)
    {
      double perimetro = 2 * Math.PI * raio;
      Console.WriteLine($"O perímetro do círculo é {perimetro:F2}");
    }
    else if (operacao == 2)
    {
      double area = Math.PI * raio * raio;
      Console.WriteLine($"A área do círculo é {area:F2}");
    }
    else if (operacao == 3)
    {
      double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
      Console.WriteLine($"O volume da esfera é {volume:F2}");
    }
    else
    {
      Console.WriteLine("Código de operação inválido. Os valores possíveis são: \n1 para perímetro do círculo \n2 para área do círculo \n3 para volume da esfera");
    }

    Console.ReadLine();
  }
}