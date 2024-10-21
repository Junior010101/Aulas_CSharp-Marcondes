//objetivo: Faça um algoritimo que leia a data de nascimento de uma pessoa e escreva a idade
//desta pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.

//inicio do algoritimo
Console.Clear();

//variaveis
DateTime DataDeNascimento;
int[] idade = new int[3];
string Data;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que exibe sua idade em dias {new string('=', 12)}\n");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Digite sua data de nascimento com dia, mês e ano separados por '/' deste jeito: 00/00/0000");

Console.Write("\nData de Nascimento: ");
Console.ResetColor();
Data = string.Join("", new string(Console.ReadLine()).Split('/'));

//saida
idade[0] = Convert.ToInt32(Data[..2]);
idade[1] = Convert.ToInt32(Data.Substring(2, 2));
idade[2] = Convert.ToInt32(Data[4..]);

DataDeNascimento = new DateTime(idade[2], idade[1], idade[0]);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nSua idade expressa em dias é aproximadamente: {DateTime.Today.Subtract(DataDeNascimento).TotalDays} dias");
Console.ResetColor();
