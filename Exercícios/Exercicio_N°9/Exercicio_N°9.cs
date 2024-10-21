//objetivo: Sabe-se que Paulo deseja entrar em um consorcio de R$280.000,00 Reais, entretanto sabendo que os juros são
//de 12% ao ano e serão 65 parcelas em meses fixos. Paulo deu de entrada R$2.500,00. Faça um algoritimo que
//caucule o valor final que Paulo vai pagar ao final dos 65 meses.

//inicio do algoritimo
Console.Clear();

//variaveis
int ValorTotal = 280000;
double ValorTotalPago;
double ValorFinal;
int Entrada = 2500;
double parcelas = 65;
int ValorFinanciado;
double TaxaAnual = 0.12f;
double TaxaMensal;
double parcela;

//saida
ValorFinanciado = ValorTotal - Entrada;
TaxaMensal = Math.Pow(1f + TaxaAnual, 1f / 12f) - 1;
parcela = ValorFinanciado * TaxaMensal / (1 - Math.Pow(1 + TaxaMensal, parcelas * -1));

ValorTotalPago = parcela * parcelas;
ValorFinal = ValorTotalPago + Entrada;

Console.WriteLine($"O valor final que Paulo irá pagar é de: R${ValorFinal:F}");
