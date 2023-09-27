using System;

public class Ex03
{
  public static void Main()
  {
    Console.WriteLine("Digite os coeficientes da equação de segundo grau ");

    Console.Write("a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double delta = b * b - 4 * a * c;

    if (a == 0)
    {
      if (b == 0)
      {
        if (c != 0)
        {
          Console.WriteLine("Coeficientes informados incorretamente.");
        }
        else
        {
          Console.WriteLine("Essa é uma equação de primeiro grau.");
          double raiz = -c / b;
          Console.WriteLine($"A raiz da equação é x = {raiz:F2}");
        }
      }
      else
      {
        Console.WriteLine("Essa é uma equação de primeiro grau.");
        double raiz = -c / b;
        Console.WriteLine($"A raiz da equação é x = {raiz:F2}");
      }
    }
    else
    {
      if (delta < 0)
      {
        Console.WriteLine("Esta equação não possui raízes reais.");
      }
      else if (delta == 0)
      {
        double raiz = -b / (2 * a);
        Console.WriteLine("Esta equação possui duas raízes reais iguais.");
        Console.WriteLine($"As raízes são x1 e x2 = {raiz:F2}");
      }
      else
      {
        double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
        Console.WriteLine($"As raízes a equação são x1 = {raiz1:F2} e x2 = {raiz2:F2}");
      }
    }

    Console.ReadLine();

  }
}