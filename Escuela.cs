using System.Collections.Generic;

namespace TP0_5
{
    public class Escuela
    {
        public List<Alumno> Alumnos = new List<Alumno>();
    }
    
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public Alumno BuscarporDNI(int dni)
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            if (alumnos[i].DNI == dni)
            {
                return alumnos[i];
            }
            i = i + 1;
        }

        return null;
    }

    public void mostrarTodos()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            alumnos[i].mostrar();
            i = i + 1;
        }
    }

    public void mostrarLibres()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            if (alumnos[i].CantidadFaltas > 15)
            {
                alumnos[i].mostrar();
            }
            i = i + 1;
        }
    }
}




