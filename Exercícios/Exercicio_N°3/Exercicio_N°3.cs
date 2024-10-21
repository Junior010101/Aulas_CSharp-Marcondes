//objetivo: algoritimo que solicita seu salario e o valor da prestação
//se a prestação for maior que 20% do salario o emprestimo não poderá ser concedido

//inicio do algoritimo
Console.Clear();

//variaveis
double salario;
double prestacao;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo de Emprestimos Bancarios {new string('=', 12)}\n");

Console.Write("Valor salarial: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.Write("\nValor da Prestação: ");
prestacao = Convert.ToDouble(Console.ReadLine());

//saida
if ((salario * 20 / 100) < prestacao){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nEsté emprestimo não pode ser concedido.");
    Console.ResetColor();
}
else {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nEmprestimo pode ser Concedido");
    Console.ResetColor();
}
