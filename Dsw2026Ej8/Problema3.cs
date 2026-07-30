namespace Dsw2026Ej8;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        int copiaValue = originalValue;
        copiaValue++;

        Product copiaReferencia = product;
        copiaReferencia.ActualizarDescripcion(copiaReferencia.Description + " Modificado");

        return $"{originalValue}-{copiaValue}-{product.Description}";
    }
}
