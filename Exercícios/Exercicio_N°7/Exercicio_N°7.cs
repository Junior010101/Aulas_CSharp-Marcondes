//objetivo: O custo ao consumidor de um carro novo, é a soma do custo de fabrica com o persentual do revendedor e com 
//os custos dos impostos (Aplicados ao Custo de Fabrica). Supondo que a percentagem do revendedor seja 25% e que os 
//impostos custam 45% do custo de fabrica, faça um algoritimo que leia o custo de fabrica e determine o preço final
//do automóvel (custo ao consumidor).

//inicio do algoritimo
Console.Clear();

//variaveis
double CustoFabrica = (double)(Console.ForegroundColor = ConsoleColor.White);
double ComicaoRevendedor;
double inpostos;
double PrecoFinal;

//entrada
Console.WriteLine($"{new string('=', 12)} Algoritimo que determina o preço final de um automovel {new string('=', 12)}\n");
Console.WriteLine("""
Para descobrir o valor final do revendedor levando em consideração 25% que é a
porcentagem do revendedor e que 45% são os inpostos aplicados ao custo de fabrica.
""");

Console.Write("\nDigite o custo de fabrica: ");
CustoFabrica = Convert.ToDouble(Console.ReadLine());

//saida
ComicaoRevendedor = CustoFabrica * 0.25f;
inpostos = CustoFabrica * 0.45f;
PrecoFinal = CustoFabrica + ComicaoRevendedor + inpostos;

Console.WriteLine("\n" + $"""
O custo de fabrica era de: {CustoFabrica}
O percentual de 25% do revendedor ficou por: {ComicaoRevendedor}
E os inpostos ficaram com o valor de: {inpostos:F}

Somando tudo, o preço final de seu carro ficou por: {PrecoFinal:F}
""");
