//Na aula 03 vimos o uso do switch case
//Alem disso criamos um projeto de multipla escolha usando o switch case.

class CriancaEsperanca{
    static void Main(){
        //Variaveis
        char doacao;

        //Inicio Criança Esperança
        Console.WriteLine("""
        ========== Bem-Vindo ao Criança Esperança ==========

        Selecione a opção desejada para o valor que quiser doar

        tecle [1] para doar R$ 10,00.
        tecle [2] para doar R$ 20,00.
        tecle [3] para doar R$ 30,00.
        tecle [4] para doar R$ 40,00.
        tecle [5] para doar outro valor.
        tecle [6] para fechar
        """);

        //processamento de dados
        Console.Write("\nOpçaõ: ");
        doacao = char.Parse(Console.ReadLine());

        switch (doacao){
            //caso selecione n° 1
            case '1':
                Console.WriteLine("Você doou R$10,00");
            break;

            //caso selecione n° 2
            case '2':
                Console.WriteLine("Você doou R$20,00");
            break;

            //caso selecione n° 3
            case '3':
                Console.WriteLine("Você doou R$30,00");
            break;

            //caso selecione n° 4
            case '4':
                Console.WriteLine("Você doou R$40,00");
            break;

            //caso selecione n° 5
            case '5':
                Console.WriteLine("Digite o valor que deseja doar\n");
                Console.Write("Valor: ");

                //entrada
                float valor = float.Parse(Console.ReadLine());

                //saida
                Console.WriteLine($"Você doou R${valor:f}");
            break;

            //caso selecione n° 6
            case '6':
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você Cancelou está operação");
                Console.ResetColor();
            break;

            //caso nem um dos casos
            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Invalida");
                Console.ResetColor();
                Main();
            break;
        }
    }
}
