using System;

public class Alumno
{
    public string Nombre;
    public double CantidadFaltas;

    public Alumno(string nombre , double CantidadFaltas)
    {
        Nombre = nombre;
        CantidadFaltas = 0;
    }

    public void AgregarFalta(double falta)
    {
        CantidadFaltas += falta;
    }

    public string Mostrar()
    {
        string x = ("DNI: " + DNI + " Nombre: " + Nombre + " Faltas: " + CantidadFaltas);
        return x;
    }

    public double getFaltas ()
    {
        return this.CantidadFaltas;
    }
}
    