// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Escuela curso = new Escuela();
        int opcion = -1;

        while (opcion != 0)
        {
            MostrarMenu();

            Console.WriteLine("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlumno(curso);
                    break;

                case 2:
                    BuscarAlumno(curso);
                    break;

                case 3:
                    AgregarFalta(curso);
                    break;

                case 4:
                    curso.MostrarTodos();
                    break;

                case 5:
                    curso.MostrarLibres();
                    break;

                case 0:
                    Console.WriteLine("Saliendo");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n1- Agregar alumno");
        Console.WriteLine("2- Buscar alumno");
        Console.WriteLine("3- Agregar falta");
        Console.WriteLine("4- Mostrar todos");
        Console.WriteLine("5- Mostrar libres");
        Console.WriteLine("0- Salir");
    }

    static void AgregarAlumno(Escuela curso)
    {
        Console.WriteLine("DNI: ");
        int dni = int.Parse(Console.ReadLine());

        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();

        Alumno alumno = new Alumno(dni, nombre);
        curso.AgregarAlumno(alumno , dni);
    }

    static void BuscarAlumno(Escuela curso)
    {
        Console.WriteLine("DNI: ");
        int dni = int.Parse(Console.ReadLine());
        curso.MostrarAlumno(dni);
    }

    static void AgregarFalta(Escuela curso)
    {
        Console.WriteLine("DNI: ");
        int dni = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa cuanto falto");
        double falta= double.Parse(Console.ReadLine());
        curso.CargarFalta(dni , falta);
    }