using System.Collections.Generic;


List<Curso> cursos = new List<Curso>();

Console.Write("¿Cuántos cursos desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Curso c = new Curso();

    Console.WriteLine($"\nCurso #{i + 1}");

    Console.Write("Nombre del curso: ");
    c.Nombre = Console.ReadLine();

    Console.Write("Créditos: ");
    c.Creditos = int.Parse(Console.ReadLine());

    Console.Write("Nota promedio del curso: ");
    c.NotaPromedio = double.Parse(Console.ReadLine());

    cursos.Add(c);
}

// Validación
if (cursos.Count > 0)
{
    Curso destacado = cursos[0];

    Console.WriteLine("\n--- CURSOS REGISTRADOS ---");

    foreach (Curso c in cursos)
    {
        c.MostrarDatos();

        if (c.NotaPromedio > destacado.NotaPromedio)
        {
            destacado = c;
        }
    }

    Console.WriteLine("\n🏆 Curso con mejor promedio:");
    destacado.MostrarDatos();
}
else
{
    Console.WriteLine("No se registraron cursos.");
}
class Curso
{
    public string Nombre;
    public int Creditos;
    public double NotaPromedio;

    public string EvaluarRendimiento()
    {
        if (NotaPromedio >= 80) return "Excelente";
        else if (NotaPromedio >= 61) return "Aceptable";
        else return "Bajo";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Curso: {Nombre} | Créditos: {Creditos} | Promedio: {NotaPromedio:F2} | Rendimiento: {EvaluarRendimiento()}");
    }
}

