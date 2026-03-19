namespace TP0_5
{
    public class Alumno
    {
        public int Dni ; 
        public string Nombre ;
        public double cantidadDeFaltas;

    public alumno(int dni, string nombre)
    {
        DNI = dni;
        Nombre = nombre;
        cantidadFaltas = 0;
    }

    public void agregarFalta(double falta)
    {
        CantidadFaltas = CantidadFaltas + falta;
    }

    public void mostrar()
    {
        Console.WriteLine("DNI: " + DNI + " Nombre: " + Nombre + " Faltas: " + cantidadFaltas);
    }
}

        
    