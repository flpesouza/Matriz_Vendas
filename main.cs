using System;
class Exercicio1
  {
  static void Main(string[] args)
  {
    int[,] matriz = new int[4, 4];
    int [,] matriz1 = { { 0,1,2,3} , { 4,5,6,7} , { 8,9,10,11} , { 12,13,14,15} };
    int soma = 0;
    int somaAnual = 0;
    int cont = 1;
    int somaCol1 = 0;
    int somaCol2 = 0;
    int somaCol3 = 0;
    int somaCol4 = 0;
    
    for (int i = 0; i < matriz1.GetLength(0); i++)
    {
      somaCol1 += matriz1[i, 0];
      somaCol2 += matriz1[i, 1];
      somaCol3 += matriz1[i, 2];
      somaCol4 += matriz1[i, 3];
      Console.WriteLine("Mês " + cont + ":");
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
      somaAnual += matriz1[i, j];
      soma += matriz1[i,j];
    }
    Console.WriteLine("Total - R$"+soma);
    soma = 0;
    cont++;
    }
    Console.WriteLine("Total anual: R$" + somaAnual);
    
    if (somaCol1 > somaCol2 && somaCol1 > somaCol3 && somaCol1 > somaCol4)
    {
      Console.WriteLine("A melhor semana de compras é a 1º semana");
    }
    else if (somaCol2 > somaCol1 && somaCol2 > somaCol3 && somaCol2 > somaCol4)
    {
      Console.WriteLine("A melhor semana de compras é a 2º semana");
    }
    else if (somaCol3 > somaCol1 && somaCol3 > somaCol2 && somaCol3 > somaCol4)
    {
      Console.WriteLine("A melhor semana de compras é a 3º semana");
    }
    else if (somaCol4 > somaCol1 && somaCol4 > somaCol2 && somaCol4 > somaCol3)
    {
      Console.WriteLine("A melhor semana de compras é a 4º semana");
    }
  }
}
