namespace Dsw2026Ej8;

public partial class ProductHelper
{
    private static string FormatearEtiqueta(long code, string description, decimal price)
    {
        return $"[{code}] {description} - {price:C}";
    }
}