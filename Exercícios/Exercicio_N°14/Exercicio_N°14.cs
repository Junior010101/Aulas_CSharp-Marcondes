//objetivo: Uma financeira usa o seguinte critério: para conceder emprestimos  o valor total do emprestimo deve ser de até dez
//vezes o valor da renda mensal do solicitante e o valor da prestação deve ser no maximo 30% da renda mensal do solicitante.
//Escreva um algoritimo que leia a renda mensal de um solicitante, o valor total do emprestimo que é solicitado e o numero
//de prestações que o solicitante deseja pagar e informe se o emprestimo pode ou nao ser concedido

//inicio do algoritimo
Console.Clear();

//variaveis
double renda_mensal;
double valor_emprestimo;
int numero_prestacoes;
double valor_prestacao;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que informa se um emprestimo pode ser concedido {new string('=', 12)}\n");
Console.WriteLine("""
Para caucular seu imprestimo preciso que informe:

Sua renda mensal,
O valor total do emprestimo,
E o Numero de pacotes
""");

Console.Write("\nRenda Mensal: ");
renda_mensal = Convert.ToDouble(Console.ReadLine());

Console.Write("\nValor do emprestimo: ");
valor_emprestimo = Convert.ToDouble(Console.ReadLine());

Console.Write("\nN° de Pacotes: ");
numero_prestacoes = Convert.ToInt32(Console.ReadLine());

//saida
if (valor_emprestimo > 10 * renda_mensal){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nO valor do emprestimo excede o limite permitido.");
    Console.ResetColor();
}
else{
    valor_prestacao = valor_emprestimo / numero_prestacoes;

    if (valor_prestacao > 0.3f * renda_mensal){
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nO valor da prestação excede 30% da renda mensal.");
        Console.ResetColor();
    }
    else{
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nO emprestimo pode ser concedido.");
        Console.ResetColor();
    }
}
