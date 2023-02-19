namespace caProvaTarget;

public class Pergunta1
{
    public static void P1()
    {
        Console.WriteLine("----- Pergunta 1 -----");
        Console.WriteLine();
        Console.WriteLine("1) Observe o trecho de código abaixo:");
        Console.WriteLine();
        Console.WriteLine("int INDICE = 13, SOMA = 0, K = 0;");
        Console.WriteLine();
        Console.WriteLine("enquanto K < INDICE faça");
        Console.WriteLine("{");
        Console.WriteLine("K = K + 1;");
        Console.WriteLine("SOMA = SOMA + K;");
        Console.WriteLine("}");
        Console.WriteLine();
        Console.WriteLine("imprimir(SOMA);");
        Console.WriteLine();

        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K++;
            SOMA += K;
        }

        Console.WriteLine("Ao final do processamento, qual será o valor da variável SOMA?");
        Console.WriteLine();
        Console.WriteLine("----- Resposta 1 -----");
        Console.WriteLine($"O valor da variável soma é: {SOMA} ");
        Console.WriteLine("----------------------");
        Console.ReadKey();
    }
}
