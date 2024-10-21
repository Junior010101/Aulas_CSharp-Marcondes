//objetivo: Construir um algoritimo que determina se o individuo está com o peso favoravel

//inicio do algoritimo
Console.Clear();

//variaveis
double peso;
double altura;
double imc;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que caucula seu (Imc) indice de massa corporal {new string('=', 12)}\n");

Console.Write("Digite seu peso (Kg): ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite sua altura (M): ");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / (altura * altura);

//saida
Console.WriteLine($"\nSeu Imc é Aproximadamente: {imc:F}");

if (imc <= 19) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você está abaixo do peso\n");
}
if (imc >= 20 && imc <= 24) {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Você está Saudavel\n");
}
if (imc >= 25 && imc <= 29) {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Você está sobre peso\n");
}
if (imc >= 30 && imc <= 39) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você está obeso\n");
}
if (imc >= 40) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você está obeso mórbido\n");
}
Console.ResetColor();
