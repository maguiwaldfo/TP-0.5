using System;

public class Alumno
{
    public string Nombre;
    public double CantidadFaltas;

    public Alumno(string nombre , double CantidadFaltas)
    {
        this.Nombre = nombre;
        this.CantidadFaltas = 0;
    }

    public void AgregarFalta(double falta)
    {
        CantidadFaltas += falta;
    }

    public string Mostrar()
    {
        string x = (" Nombre: " + this.Nombre + " Faltas: " + this.CantidadFaltas);
        return x;
    }

    public double getFaltas ()
    {
        return this.CantidadFaltas;
    }
}
    