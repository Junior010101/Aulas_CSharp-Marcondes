//objetivo: Uma empresa de celulares paga a seu vendedor um valor fixo de R$1.200,00 reais por
//mês, mais uma comissão de 15% pelo seu valor de vendas no mês. Faça um algoritimo que leia o
//valor de venda e determine o salario total do funcionario.

//inicio do algoritimo
Console.Clear();

//variaveis
double ValorDeVendas;

//entrada 
Console.WriteLine($"{new string('=', 12)} Algoritimo que determina a comissão de um vendedor {new string('=', 12)}\n");
Console.WriteLine("Para caucular a comissão e nessesario que você informe o valor total de vendas realizadas no mês");

Console.Write("Numero de Vendas: ");
ValorDeVendas = Convert.ToDouble(Console.ReadLine());

//saida
Console.WriteLine("\n" + $"""
Com uma Comissão de: {ValorDeVendas * 0.15f:F}
O salario total deste vendedor é igual a: {1200 + (ValorDeVendas * 0.15f):F}
""");
