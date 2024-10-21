//objetivo: Escrever um algoritimo que lé um numero e informe se ele e
//divisivel por 10, por 5 ou por 2. Ou se é divisivel por todos ou por nenhun desses.

//inicio do algoritimo
Console.Clear();

//variaveis
double num;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que informa se um numero é divisivel por 10, 5 ou 2 {new string('=', 12)}\n");

Console.Write("Digite um Numero: ");
num = Convert.ToDouble(Console.ReadLine());

//saida
Console.ForegroundColor = ConsoleColor.DarkGreen;
if (num % 10 == 0 && num % 5 == 0 && num % 2 == 0) {
    Console.WriteLine("O numero pode ser dividido por 10, 5 e 2");
    Console.ResetColor();
}
else if (num % 10 == 0) {
    Console.WriteLine("O numero pode ser dividido por 10");
    Console.ResetColor();
}
else if (num % 5 == 0) {
    Console.WriteLine("O numero pode ser dividido por 5");
    Console.ResetColor();
}
else if (num % 2 == 0) {
    Console.WriteLine("O numero pode ser dividido por 2");
    Console.ResetColor();
}
else {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("O numero não pode ser dividido nem por 10, nem 5, nem 2");
    Console.ResetColor();
}

