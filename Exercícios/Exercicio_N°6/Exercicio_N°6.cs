//objetivo: Criar um algoritimo que leia a idade de uma pessoa e informe
//a sua classe eleitoral.

//inicio so algoritimo
Console.Clear();

//variaveis
int idade;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que fala sua classe eleitoral {new string('=', 12)}\n");

Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

//saida
if (idade < 16){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nNão Eleitor");
}
if (idade >= 18 && idade < 65) {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nEleitor Obrigatorio");
}
if (idade >= 16 && idade < 18 || idade >= 65) {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nEleitor Facultativo");
}
Console.ResetColor();
