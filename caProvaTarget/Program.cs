using caProvaTarget;

char? opcao = '0';

while (opcao != '6')
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     Desenvolvedor SP    ===");
    Console.WriteLine("=== 1 - Pergunta 1          ===");
    Console.WriteLine("=== 2 - Pergunta 2          ===");
    Console.WriteLine("=== 3 - Pergunta 3          ===");
    Console.WriteLine("=== 4 - Pergunta 4          ===");
    Console.WriteLine("=== 5 - Pergunta 5          ===");
    Console.WriteLine("=== 6 - Sair do Sistema     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n\n");

    Console.Write("Digite a opção desejada: ");
    opcao = Console.ReadLine()[0];

    Console.WriteLine();

    switch (opcao)
    {
        case '1':
            Pergunta1.P1();
            break;
        case '2':
            Pergunta2.P2();
            break;
        case '3':
            Pergunta3.P3();
            break;
        case '4':
            Pergunta4.P4();
            break;
        case '5':
            Pergunta5.P5();
            break;
        case '6':
            break;
        default:
            Console.WriteLine("Opcao não implementada.");
            break;
    }

}
