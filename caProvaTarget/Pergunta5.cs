namespace caProvaTarget;

public class Pergunta5
{
    public static void P5()
    {
        string StrInvertida = "";

        Console.WriteLine("----- Pergunta 5 -----");
        Console.WriteLine();
        Console.Write("Por favor, digite uma frase para inverter: ");
        string? STR = Console.ReadLine();
        
        if (string.IsNullOrEmpty(STR)) return;

        foreach (char c in STR)
            StrInvertida = c.ToString() + StrInvertida;

        Console.WriteLine($"String normal: {STR}");
        Console.WriteLine();
        Console.WriteLine("----- Resposta 5 -----");
        Console.WriteLine($"String invertida: {StrInvertida}");
        Console.WriteLine("----------------------");
        Console.ReadKey();
    }
}
