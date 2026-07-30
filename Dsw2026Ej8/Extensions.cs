namespace Dsw2026Ej8;

public static class Extensions
{
    public static string ToProductCode(this string? code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return "SIN-CODIGO";
        }

        string normalizado = code.Trim().ToUpperInvariant();
        string[] partes = normalizado.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join("-", partes);
    }
}
