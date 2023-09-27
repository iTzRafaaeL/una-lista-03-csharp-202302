using System;

public class Ex05
{
  public static void Main()
  {
    Console.WriteLine("Digite o primeiro número:");
    double n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o segundo número :");
    double n2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o símbolo da operação +, -, *, / ou ^");
    char operacao = Convert.ToChar(Console.ReadLine());

    double resultado = 0.0;

    if (operacao == '+')
    {
      resultado = n1 + n2;
    }
    else if (operacao == '-')
    {
      resultado = n1 - n2;
    }
    else if (operacao == '*')
    {
      resultado = n1 * n2;
    }
    else if (operacao == '/')
    {
      if (n1 != 0)
      {
        resultado = n1 / n2;
      }
      else
      {
        Console.WriteLine("Não é possível fazer uma divisão por 0.");
        return;
      }
    }
    else if (operacao == '^')
    {
      resultado = Math.Pow(n1, n2);
    }
    else
    {
      Console.WriteLine("Erro: Símbolo da operação inválido.");
      return;
    }

    Console.WriteLine($"O resultado é: {resultado:F2}");
  }
}