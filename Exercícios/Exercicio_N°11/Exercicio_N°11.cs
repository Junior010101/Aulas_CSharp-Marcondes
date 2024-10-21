//objetivo: Faça um algoritimo que transforme uma velocidade fornecida em m/s pelo 
//usuario para Km/h.

//inicio do algoritimo
Console.Clear();

//variaveis
double Velocidade_Ms;
double Velocidade_Kmh;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que converte m/s para km/h {new string('=', 12)}\n");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Digite em (m/s) Metros por segundo a velocidade que deseja ser convertida.");
Console.Write("C/>: ");
Console.ResetColor();
Velocidade_Ms = Convert.ToDouble(Console.ReadLine());

//saida
Velocidade_Kmh = Velocidade_Ms * 3.6f;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\n{Velocidade_Ms} m/s Convertidos para km/h é igual a: {Velocidade_Kmh:F} km/h");
Console.ResetColor();
