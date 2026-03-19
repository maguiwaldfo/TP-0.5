using System.Collections.Generic;

namespace TP0_5
{
    public class Escuela
    {
        public List<Alumno> Alumnos = new List<Alumno>();
    }
    
    public void agregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public Alumno buscarporDNI(int dni)
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            if (alumnos[i].DNI == dni)
            {
                return alumnos[i];
            }
            i++;
        }

        return null;
    }

    public void mostrarTodos()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            alumnos[i].mostrar();
            i++;
        }
    }

    public void mostrarLibres()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            if (alumnos[i].cantidadFaltas > 15)
            {
                alumnos[i].mostrar();
            }
            i++;
        }
    }
}




