using System.ComponentModel.DataAnnotations;

namespace caProvaTarget;

public class ClsDistribuidora
{
    [Key]
    [Required]
    public string? Estado { get; set; }
    public decimal Faturamento { get; set; }
    public static decimal TotalFaturamento { get; set; }

    public ClsDistribuidora(string? estado, decimal faturamento)
    {
        Estado = estado;
        Faturamento = faturamento;
        TotalFaturamento += faturamento;
    }

    public static decimal CalculaPercentualEstado(decimal faturamento)
    {
        return faturamento * 100 / TotalFaturamento;
    }
}