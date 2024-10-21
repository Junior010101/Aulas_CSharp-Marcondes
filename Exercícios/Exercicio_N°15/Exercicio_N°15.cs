//objetivo: Dado um pais A, com 5.000.000 de habitates e uma taxa de natalidade de 3% ao ano, e
//um pais B com 7.000.000 de abitantes e taxa de natalidade 2% ao ano, escreva um algoritimo, 
//que imprima o tempo necessário para que a população do pais A passe a
//população do pais B.

//inicio do algoritimo
Console.Clear();

//variaveis
double Populacao_A = 5000000;
double Populacao_B = 7000000;
double TaxaDeNatalidadeA = 0.03;
double TaxaDeNatalidadeB = 0.02;
int anos = 0;

//saida
while (Populacao_A <= Populacao_B){
    Populacao_A += Populacao_A * TaxaDeNatalidadeA;
    Populacao_B += Populacao_B * TaxaDeNatalidadeB;
    anos++;
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Serâo necessarios {anos} anos para que a População do Pais A ultrapasse a População do Pais B");
Console.ResetColor();
