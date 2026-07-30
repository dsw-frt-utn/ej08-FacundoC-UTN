namespace Dsw2026Ej8;

public abstract class Sale
{
    public decimal MontoBase { get; set; }

    public virtual decimal CalculateTotal() => MontoBase;
}

public class RetailSale : Sale
{
    public override decimal CalculateTotal() => MontoBase;
}

public class WholesaleSale : Sale
{
    public override decimal CalculateTotal() => MontoBase * 0.90m;
}

public class Problema5
{
    public decimal ObtenerImporteFinal(Sale sale) => sale.CalculateTotal();
}