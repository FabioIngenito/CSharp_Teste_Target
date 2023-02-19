namespace caProvaTarget;

public class ClsDados
{
    public int dia { get; set; }
    public decimal valor { get; set; }

    public ClsDados(int dia, decimal valor)
    {
        this.dia = dia;
        this.valor = valor;
    }

    public static decimal CalculaPercentualDiario(decimal faturamento, decimal totalFaturamento)
    {
        return faturamento * 100 / totalFaturamento;
    }

    public static ClsDados MenorValorNoMes(List<ClsDados> listaDados)
    {
        int dia = listaDados[0].dia;
        decimal valor = listaDados[0].valor;

        foreach (ClsDados dado in listaDados)
        {
            if (dado.valor < valor && dado.valor > 0)
            {
                dia = dado.dia;
                valor = dado.valor;
            }
        }

        return new ClsDados(dia, valor);
    }

    public static ClsDados MaiorValorNoMes(List<ClsDados> listaDados)
    {
        int dia = 0;
        decimal valor = 0;

        foreach (ClsDados dado in listaDados)
        {
            if (dado.valor > valor)
            {
                dia = dado.dia;
                valor = dado.valor;
            }
        }

        return new ClsDados(dia, valor);
    }

    public static int CalculaMediaMensal(List<ClsDados> listaDados)
    {
        int numeroDias = 0;
        int numeroDiasTotal = 0;
        decimal media;
        decimal total = 0;

        listaDados.ForEach(dado =>
        {
            if (dado.valor > 0)
            {
                numeroDiasTotal++;
                total += dado.valor;
            }
        });

        media = Math.Round(total / numeroDiasTotal, 4);

        foreach (ClsDados dado in listaDados)
            if (dado.valor > media) numeroDias++;

        return numeroDias;
    }
}
