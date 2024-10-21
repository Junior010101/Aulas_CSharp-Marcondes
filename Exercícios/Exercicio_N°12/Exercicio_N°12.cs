//objetivo: Escreva um programa que caucula o desconto previdenciario de um funcionario. Dado o salario, o 
// programa deve retornar o valor do desconto proporcional ao mesmo. O Cauculo segue a regra: o desconto é
// de 11% do valor do salario, entretanto, o valor maximo de desconto é 334,29, o que seja menor.

//inicio do algoritimo
Console.Clear();

//variaveis
double taxa_desconto = 0.11f;
double desconto_maximo = 334.29f;
double salario;
double desconto;

//entrada 
Console.WriteLine($"{new string('=', 12)} Algoritimo que calcula o desconto previdenciario {new string('=', 12)}\n");

Console.Write("Informe o Salario: ");
salario = Convert.ToDouble(Console.ReadLine());

//saida
desconto = salario * taxa_desconto;

if (desconto > desconto_maximo) {
    desconto = desconto_maximo;
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nO Desconto Previdenciario Será de: R$ {desconto:F}");
Console.ResetColor();
