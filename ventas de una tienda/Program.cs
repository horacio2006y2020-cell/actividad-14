using System;
using System.Collections.Generic;



List<Venta> ventas = new List<Venta>();

Console.Write("¿Cuántas ventas desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Venta v = new Venta();

    Console.WriteLine($"\nVenta #{i + 1}");

    Console.Write("Producto: ");
    v.Producto = Console.ReadLine();

    Console.Write("Precio: ");
    v.Precio = double.Parse(Console.ReadLine());

    Console.Write("Cantidad: ");
    v.Cantidad = int.Parse(Console.ReadLine());

    ventas.Add(v);
}

double totalGeneral = 0;

Console.WriteLine("\n--- LISTADO DE VENTAS ---");

foreach (Venta v in ventas)
{
    v.MostrarDatos();
    totalGeneral += v.CalcularTotalFinal();
}

Console.WriteLine($"\n💰 Total general vendido: Q{totalGeneral:F2}");
class Venta
{
    public string Producto;
    public double Precio;
    public int Cantidad;

    public double CalcularSubtotal()
    {
        return Precio * Cantidad;
    }

    public double CalcularDescuento()
    {
        if (CalcularSubtotal() >= 500) return CalcularSubtotal() * 0.10;
        else if (CalcularSubtotal() >= 200) return CalcularSubtotal() * 0.05;
        else return 0;
    }

    public double CalcularTotalFinal()
    {
        return CalcularSubtotal() - CalcularDescuento();
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Producto: {Producto} | Cantidad: {Cantidad} | Subtotal: Q{CalcularSubtotal():F2} | Descuento: Q{CalcularDescuento():F2} | Total final: Q{CalcularTotalFinal():F2}");
    }
}
