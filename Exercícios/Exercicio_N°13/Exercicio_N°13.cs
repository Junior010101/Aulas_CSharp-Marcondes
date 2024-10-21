//objetivo: Escreva um algoritimo que leia um caracteré e diga
//se ele é uma vogal, um numero, uma consoante ou um símbolo.

//inicio do algoritimo
Console.Clear();

//variaveis
string Caractere;
double num;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que exibe se um digito é uma vogal, consoante, numero ou simbolo {new string('=', 12)}\n");

Console.Write("Tecle um Digito: ");
Caractere = new string(Console.ReadLine());

if (Caractere.ToString().Length <= 1){
    bool PassN = double.TryParse(Caractere, out num);
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    if (PassN == true){
        Console.WriteLine($"\nO Caracteré: {num} é um Numero.");
        Console.ResetColor();
    }
    else if ("aeiou".IndexOf(Caractere.ToLower()) >= 0){
        Console.WriteLine($"\nO Caracteré: {Caractere} é uma Vogal.");
        Console.ResetColor();
    }
    else if (char.IsLetter(char.Parse(Caractere))){
        Console.WriteLine($"\nO Caracteré: {Caractere} é uma Consoante.");
        Console.ResetColor();
    }
    else{
        Console.WriteLine($"\nO Caracteré: {Caractere} é um Símbolo.");
        Console.ResetColor();
    }
}
else{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nInsira Apenas um Digito !");
    Console.ResetColor();
}
