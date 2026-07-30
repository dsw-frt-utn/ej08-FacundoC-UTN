namespace Dsw2026Ej8;

public partial class ProductHelper
{
    public string ObtenerEtiquetaProducto(long code, string description, decimal price)
    {
        return FormatearEtiqueta(code, description, price);
    }
}