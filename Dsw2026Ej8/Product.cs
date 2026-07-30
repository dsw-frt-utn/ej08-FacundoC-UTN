namespace Dsw2026Ej8;

public class Product
{
    public string Description { get; set; } = string.Empty;

    public void ActualizarDescripcion(string nuevaDescripcion)
    {
        Description = nuevaDescripcion;
    }
}
