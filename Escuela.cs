

using System;
using System.Collections.Generic;

public class Escuela
{
    public List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public Alumno BuscarPorDNI(int dni)
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

    public void MostrarTodos()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            alumnos[i].Mostrar();
            i++;
        }
    }

    public void MostrarLibres()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            if (alumnos[i].CantidadFaltas > 15)
            {
                alumnos[i].Mostrar();
            }
            i++;
        }
    }
}


