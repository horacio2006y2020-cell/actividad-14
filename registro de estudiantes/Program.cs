using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

List<Estudiante> estudiantes = new List<Estudiante>();
Console.WriteLine("¿Cúantos estudiantes desea registrar?");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"\nEstudiante {i + 1}:");
    Console.Write("Nombre: "); e.Nombre = Console.ReadLine();
    Console.WriteLine("Nota 1");e.Nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 2");e.Nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 3");e.Nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}
double sumaPromedios = 0;
Estudiante mejor = estudiantes[0];
Console.WriteLine("\n Listado de estudiantes");
foreach (Estudiante e in estudiantes)
{
    e.MostrarDatos();
    sumaPromedios += e.calcularPromedio();
    if (e.calcularPromedio() > mejor.calcularPromedio()) mejor = e;
}
Console.WriteLine($"\n Promedio general del grupo: {sumaPromedios / estudiantes.Count: F2}");
Console.WriteLine("Mejor estudiante:");
mejor.MostrarDatos();


class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;
    public double calcularPromedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }
    public string determinarEstado()
    {
        double promedio = calcularPromedio();
        if (promedio >= 60) return "Aprobado";
        else return "Reprobado";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}, Nota1: {Nota1}, Nota2: {Nota2}, Nota3: {Nota3}, Promedio: {calcularPromedio()}, Estado: {determinarEstado()}");
    }

}



