using System.Collections;

namespace caProvaTarget;

public class Pergunta4
{
    public static void P4()
    {
        Console.WriteLine("----- Pergunta 4 -----");
        Console.WriteLine();
        Console.WriteLine("4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:\r\n\r\nSP – R$67.836,43\r\nRJ – R$36.678,66\r\nMG – R$29.229,88\r\nES – R$27.165,48\r\nOutros – R$19.849,53\r\n\r\nEscreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.");

        List<ClsDistribuidora> Distribuidoras = new();
        decimal percentagemEstado;

        Distribuidoras.Add(new ClsDistribuidora("SP", 67836.43m));
        Distribuidoras.Add(new ClsDistribuidora("RJ", 36678.66m));
        Distribuidoras.Add(new ClsDistribuidora("MG", 29229.88m));
        Distribuidoras.Add(new ClsDistribuidora("ES", 27165.48m));
        Distribuidoras.Add(new ClsDistribuidora("Outros", 19849.53m));
        Console.WriteLine();
        Console.WriteLine("----- Resposta 4 -----");

        foreach (ClsDistribuidora distribuidora in Distribuidoras)
        {
            percentagemEstado = decimal.Round(ClsDistribuidora.CalculaPercentualEstado(distribuidora.Faturamento), 2);

            Console.WriteLine($"O percentual do estado: {distribuidora.Estado} é de: {percentagemEstado} %.");
        }

        Console.WriteLine("----------------------");
        Console.ReadKey();
    }
}
