using System;
using System.Collections.Generic;

List<Libro> libros = new List<Libro>();

Console.Write("¿Cuántos libros desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Libro l = new Libro();

    Console.WriteLine($"\nLibro #{i + 1}");

    Console.Write("Título: ");
    l.Titulo = Console.ReadLine();

    Console.Write("Autor: ");
    l.Autor = Console.ReadLine();

    Console.Write("Categoría: ");
    l.Categoria = Console.ReadLine();

    Console.Write("Cantidad de páginas: ");
    l.Paginas = int.Parse(Console.ReadLine());

    libros.Add(l);
}

if (libros.Count > 0)
{
    Libro mayor = libros[0];

    Console.WriteLine("\n--- LISTADO DE LIBROS ---");

    foreach (Libro l in libros)
    {
        l.MostrarDatos();

        if (l.Paginas > mayor.Paginas)
        {
            mayor = l;
        }
    }

    Console.WriteLine("\n Libro con más páginas:");
    mayor.MostrarDatos();
}
else
{
    Console.WriteLine("No se registraron libros.");
}
class Libro
{
    public string Titulo;
    public string Autor;
    public string Categoria;
    public int Paginas;

    public string ClasificarLongitud()
    {
        if (Paginas >= 500) return "Muy extenso";
        else if (Paginas >= 200) return "Mediano";
        else return "Corto";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Categoría: {Categoria} | Páginas: {Paginas} | Tipo: {ClasificarLongitud()}");
    }
}

