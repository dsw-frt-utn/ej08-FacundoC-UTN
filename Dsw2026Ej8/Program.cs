namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PROBLEMA 1 =====");
            ProductHelper helper = new ProductHelper();
            // Debería imprimir algo como: [123] Mouse - $ 1.500,00
            Console.WriteLine(helper.ObtenerEtiquetaProducto(123, "Mouse", 1500));

            Console.WriteLine("\n===== PROBLEMA 2 =====");
            Problema2 p2 = new Problema2();
            // Debería imprimir: 1001 - Teclado - 3000
            Console.WriteLine(p2.CrearResumenVenta(1001, "Teclado", 2, 1500));

            Console.WriteLine("\n===== PROBLEMA 3 =====");
            Problema3 p3 = new Problema3();
            Product prod = new Product { Description = "Original" };
            // Debería imprimir: 5-6-Original Modificado
            Console.WriteLine(p3.CompararCopias(5, prod));

            Console.WriteLine("\n===== PROBLEMA 4 =====");
            Problema4 p4 = new Problema4();
            // Ignora el null. Suma 8 + 10 = 18. Divide entre 2. Debería imprimir: 9
            Console.WriteLine(p4.CalcularPromedio(8, null, 10));

            Console.WriteLine("\n===== PROBLEMA 5 =====");
            Problema5 p5 = new Problema5();
            Sale venta1 = new RetailSale { MontoBase = 1000 };
            Sale venta2 = new WholesaleSale { MontoBase = 1000 };
            // Minorista sin descuento: 1000
            Console.WriteLine(p5.ObtenerImporteFinal(venta1));
            // Mayorista con 10% descuento: 900
            Console.WriteLine(p5.ObtenerImporteFinal(venta2));

            Console.WriteLine("\n===== PROBLEMA 6 =====");
            Problema6 p6 = new Problema6();
            // Debería imprimir: AB-123-X
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
            // Debería imprimir: SIN-CODIGO
            Console.WriteLine(p6.NormalizarCodigoProducto(null));

            // Pausa la consola para que puedas leer los resultados
            Console.ReadLine();
        }
    }
}