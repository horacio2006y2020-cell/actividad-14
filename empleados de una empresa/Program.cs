
using System.Collections.Generic;


        List<Empleado> listaEmpleados = new List<Empleado>();

        Console.Write("¿Cuántos empleados desea registrar?: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Empleado emp = new Empleado();

            Console.WriteLine($"\nEmpleado #{i + 1}");

            Console.Write("Nombre: ");
            emp.Nombre = Console.ReadLine();

            Console.Write("Puesto: ");
            emp.Puesto = Console.ReadLine();

            Console.Write("Salario mensual: ");
            emp.SalarioMensual = double.Parse(Console.ReadLine());

            listaEmpleados.Add(emp);
        }

        Console.WriteLine("\n--- LISTA DE EMPLEADOS ---");

        foreach (Empleado emp in listaEmpleados)
        {
            emp.MostrarDatos();
        }

        class Empleado
{
    public string Nombre;
    public string Puesto;
    public double SalarioMensual;

    public double CalcularSalarioAnual()
    {
        return SalarioMensual * 12;
    }

    public double CalcularBono()
    {
        if (SalarioMensual >= 5000) return SalarioMensual * 0.15;
        else return SalarioMensual * 0.08;
    }

    public string ClasificarSalario()
    {
        if (SalarioMensual >= 7000) return "Salario alto";
        else if (SalarioMensual >= 4000) return "Salario medio";
        else return "Salario básico";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Puesto: {Puesto} | Salario mensual: Q{SalarioMensual:F2} | Salario anual: Q{CalcularSalarioAnual():F2} | Bono: Q{CalcularBono():F2} | Nivel: {ClasificarSalario()}");
    }
}