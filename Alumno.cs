namespace TP0_5
{
    public class Alumno
    {
        public int Dni ; 
        public string Nombre ;
        public double CantidadDeFaltas;

    public Alumno(int dni, string nombre)
    {
        DNI = dni;
        Nombre = nombre;
        CantidadFaltas = 0;
    }

    public void AgregarFalta(double falta)
    {
        CantidadFaltas = CantidadFaltas + falta;
    }

    public void Mostrar()
    {
        Console.WriteLine("DNI: " + DNI + " Nombre: " + Nombre + " Faltas: " + CantidadFaltas);
    }
}

        
    