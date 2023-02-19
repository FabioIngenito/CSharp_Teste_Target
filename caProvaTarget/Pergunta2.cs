namespace caProvaTarget;

public class Pergunta2
{
    public static void P2()
    {
        try
        {
            Console.WriteLine("----- Pergunta 2 -----");
            Console.WriteLine();
            Console.WriteLine("2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.");
            Console.WriteLine();

            Console.Write("Digite um número para verificar se pertência a sequência Fibonacci:");
            int NUMERO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("----- Resposta 2 -----");

            if (ClsFibonacci.Fibonacci(NUMERO))
                Console.WriteLine($"O número {NUMERO} PERTENCE a sequência Fibonacci ");
            else
                Console.WriteLine($"O número {NUMERO} NÃO pertence a sequência Fibonacci ");

            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
        catch (OverflowException ex)
        {
            Console.WriteLine();
            Console.WriteLine("ERRO!!!");
            Console.WriteLine($"Mensagem: {ex.Message}");
            Console.ReadKey();
        }

    }
}
