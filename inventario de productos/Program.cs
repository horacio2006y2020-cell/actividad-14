using System;
using System.Collections.Generic;
using System.Threading.Channels;

List<Producto> productos = new List<Producto>();
Console.WriteLine("¿cúantos productos desea registrar?");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Producto p = new Producto();
    Console.WriteLine($"\nProducto {i + 1}:");
    Console.Write("Nombre: "); p.Nombre = Console.ReadLine();
    Console.Write("Precio: "); p.Precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Cantidad:"); p.Cantidad = int.Parse(Console.ReadLine());
    productos.Add(p);
}
double totalInventario = 0;
Producto masCostoso = productos[0];
Console.WriteLine("\nInventario de Productos:");
foreach (Producto p in productos)
{
    p.MostrarDatos();
    totalInventario += p.CalcularValorInventario();
    if (p.Precio > masCostoso.Precio) masCostoso = p;
}
class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;
    public double CalcularValorInventario() { return Precio * Cantidad; }
    public string EvaluarStock()
    {
        if (Cantidad == 0) return "agotado";
        else if (Cantidad <= 5) return " bajo";
        else return "normal";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Producto: {Nombre} | Precio: Q{Precio:F2} | Cantidad: {Cantidad} | Total: Q{CalcularValorInventario():F2} | Estado: {EvaluarStock()}");

    }
}