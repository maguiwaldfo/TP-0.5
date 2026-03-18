namespace TP0_5
{
    public class Alumno
    {
        public int Dni ; 
        public string Nombre ;
        public int CantidadDeFaltas;

        public Alumno(int dni, string nombre, int cantidadDeFaltas)
        {
            Dni = dni;
            Nombre = nombre;
            CantidadDeFaltas = cantidadDeFaltas;
        }
        
    }
}