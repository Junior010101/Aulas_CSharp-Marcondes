//Objetivo: Criar um algoritimo que faça a conversão Cambial do Real para
//Dólar, Assumindo que o valor do Dolar é US$ = 5,50.

//inicio do algoritimo
Console.Clear();

//variaveis
double Dolar = 5.50f;
double Real;
double Cambio;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que Converte Real para Dólar {new string('=', 12)}\n");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("""
1- Digite o Valor em Real
2- Para Representar numeros quebrados utilize ',' (virgula)
""");
Console.ResetColor();

Console.Write("\nDigite o Valor: ");
Real = Convert.ToDouble(Console.ReadLine());

//saida
Cambio = Real / Dolar;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nR${Real} Convetidos em dólar é aproximadamente igual a US${Cambio:F}\n");
Console.ResetColor();
