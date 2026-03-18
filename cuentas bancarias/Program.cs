using System;
using System.Collections.Generic;


Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

Console.Write("¿Cuántos productos desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nProducto #{i + 1}");

    Console.Write("Código: ");
    int codigo = int.Parse(Console.ReadLine());

    Producto p = new Producto();

    Console.Write("Nombre: ");
    p.Nombre = Console.ReadLine();

    Console.Write("Precio: ");
    p.Precio = double.Parse(Console.ReadLine());

    Console.Write("Stock: ");
    p.Stock = int.Parse(Console.ReadLine());

    productos[codigo] = p;
}

Console.WriteLine("\n--- LISTADO DE PRODUCTOS ---");

foreach (KeyValuePair<int, Producto> item in productos)
{
    Console.Write($"Código: {item.Key} | ");
    item.Value.MostrarDatos();
}

// Búsqueda
Console.Write("\nIngrese un código para buscar: ");
int buscar = int.Parse(Console.ReadLine());

if (productos.ContainsKey(buscar))
{
    Console.WriteLine("Producto encontrado:");
    productos[buscar].MostrarDatos();
}
else
{
    Console.WriteLine("No existe un producto con ese código.");
}
class Producto
{
    public string Nombre;
    public double Precio;
    public int Stock;

    public string EvaluarStock()
    {
        if (Stock == 0) return "Agotado";
        else if (Stock <= 5) return "Stock bajo";
        else return "Stock normal";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Precio: Q{Precio:F2} | Stock: {Stock} | Estado: {EvaluarStock()}");
    }
}