using System; 
using System.Collections.Generic;
using System.Threading.Channels;

class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;
    public double CalcularValorInventario() { return Precio * Cantidad; }
    public string EvaluarStock()
    {
        if (Cantidad == 0) return "Sin existencia";
        else if (Cantidad <= 5) return "Stock bajo";
        else return "Stock suficiente";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Producto: {Nombre} | Precio: Q{Precio:F2} | Cantidad: {Cantidad} | Total: Q{CalcularValorInventario():F2} | Estado: 
    { EvaluarStock()}
        ");
    }
}