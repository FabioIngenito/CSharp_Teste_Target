using System.Text.Json;

namespace caProvaTarget;

public class Pergunta3
{
    public static void P3()
    {
        Console.WriteLine("----- Pergunta 3 -----");
        Console.WriteLine();
        Console.WriteLine("3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:\r\n• O menor valor de faturamento ocorrido em um dia do mês;\r\n• O maior valor de faturamento ocorrido em um dia do mês;\r\n• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.\r\n\r\nIMPORTANTE:\r\na) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;\r\nb) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;");

        using (StreamReader SR = new("dados.json"))
        {
            string? strJSON = SR.ReadToEnd();

            if (strJSON == null) return;

            List<ClsDados>? Lista = JsonSerializer.Deserialize<List<ClsDados>>(strJSON);

            if (Lista == null) return;

            Console.WriteLine();
            Console.WriteLine("----- Resposta 3 -----");

            ClsDados MenorDiaFaturamento = ClsDados.MenorValorNoMes(Lista);

            Console.WriteLine($"O menor valor de faturamento ocorrido foi dia {MenorDiaFaturamento.dia}, com o valor: {MenorDiaFaturamento.valor}.");
            Console.WriteLine();

            ClsDados MaiorDiaFaturamento = ClsDados.MaiorValorNoMes(Lista);

            Console.WriteLine($"O menor valor de faturamento ocorrido foi dia {MaiorDiaFaturamento.dia}, com o valor: {MaiorDiaFaturamento.valor}.");
            Console.WriteLine();

            int NumeroDiasMaiorFaturamento = ClsDados.CalculaMediaMensal(Lista);

            Console.WriteLine($"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal foi de {NumeroDiasMaiorFaturamento} dias.");
            Console.WriteLine("----------------------");
        }

        Console.ReadKey();
    }
}
