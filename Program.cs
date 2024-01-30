using System;

class Program
{
    static void Main(string[] args)
    {
        #region Exercício 1
        //string[] dadosPeca1 = Console.ReadLine().Split(' ');
        //int codigoPeca1 = int.Parse(dadosPeca1[0]);
        //int numeroPecas1 = int.Parse(dadosPeca1[1]);
        //double valorUnitarioPeca1 = double.Parse(dadosPeca1[2]);

        //string[] dadosPeca2 = Console.ReadLine().Split(' ');
        //int codigoPeca2 = int.Parse(dadosPeca2[0]);
        //int numeroPecas2 = int.Parse(dadosPeca2[1]);
        //double valorUnitarioPeca2 = double.Parse(dadosPeca2[2]);

        //double totalPeca1 = numeroPecas1 * valorUnitarioPeca1;
        //double totalPeca2 = numeroPecas2 * valorUnitarioPeca2;
        //double valorTotal = totalPeca1 + totalPeca2;

        //Console.WriteLine($"VALOR A PAGAR: {valorTotal:C}");
        #endregion

        #region Exercício 2
        //double raio = double.Parse(Console.ReadLine());
        //double pi = 3.14159;
        //double area = pi * Math.Pow(raio, 2);

        //Console.WriteLine($"A={area:F4}");
        #endregion

        #region Exercício 3
        //double[] precos = { 4.00, 4.50, 5.00, 2.00, 1.50 };

        //string[] entrada = Console.ReadLine().Split(' ');

        //int codigoItem = int.Parse(entrada[0]);
        //int quantidade = int.Parse(entrada[1]);

        //if (codigoItem >= 1 && codigoItem <= 5)
        //{
        //    double precoTotal = precos[codigoItem - 1] * quantidade;
        //    Console.WriteLine($"Total: R${precoTotal:F2}");
        //}
        //else
        //    Console.WriteLine("Código de item inválido.");
        #endregion

        #region Exercício 4
        //string[] coeficientes = Console.ReadLine().Split(' ');

        //double a = double.Parse(coeficientes[0]);
        //double b = double.Parse(coeficientes[1]);
        //double c = double.Parse(coeficientes[2]);

        //double delta = b * b - 4 * a * c;

        //if (a == 0 || delta < 0)
        //{
        //    Console.WriteLine("Impossivel calcular");
        //}
        //else
        //{
        //    double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
        //    double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

        //    Console.WriteLine($"Raiz 1: {raiz1:F5}");
        //    Console.WriteLine($"Raiz 2: {raiz2:F5}");
        //}
        #endregion

        #region Exercício 5
        //int senhaCorreta = 2002;
        //int senha = int.Parse(Console.ReadLine());
        //while (senha != senhaCorreta)
        //{
        //    Console.WriteLine("Senha inválida");
        //    senha = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Acesso permitido");
        #endregion

        #region Exercício 6
        //int qtdValores = int.Parse(Console.ReadLine());
        //int[] valores = new int[qtdValores];
        //int valuesIn = 0;
        //int valuesOut = 0;

        //for (int i = 0; i < valores.Length; i++)
        //{
        //    valores[i] = int.Parse(Console.ReadLine());
        //}

        //foreach (int valor in valores)
        //{
        //    if (valor >= 10 && valor <= 20)
        //        valuesIn++;
        //    else
        //        valuesOut++;
        //}

        //Console.WriteLine($"{valuesIn} in");
        //Console.WriteLine($"{valuesOut} out");
        #endregion
    }
}