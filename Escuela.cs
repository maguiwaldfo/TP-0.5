

using System;


public class Escuela
{
    Dictionary<int , Alumno> alumnos = new Dictionary <int , Alumno>(); 

    public Escuela ()
    {
        alumnos = new Dictionary <int , Alumno>();
    }

    public void AgregarAlumno(Alumno alumno , int dni)
    {
        bool esta = alumnos.ContainsKey(dni); 
        if (esta == false)
        {
        alumnos.Add(dni , alumno);
        }
        else {
            Console.WriteLine("Ya hay un alumno con ese dni");
        }

    }

    public void MostrarAlumno ( int dni)
    {
        Console.WriteLine(alumnos[dni].Mostrar());
    }


    public void MostrarTodos()
    {
        foreach (int clave in alumnos.Keys){
        Console.WriteLine(alumnos[clave].Mostrar()); 
        }
    }

    public void MostrarLibres()
    {
        foreach (int clave in alumnos.Keys)
        {
            if (alumnos[clave].getFaltas() > 15)
            {
                alumnos[clave].Mostrar();
            }
        }
    }

    public void CargarFalta ( int dni , double falta)
    {
        alumnos[dni].AgregarFalta(falta); 
    }
}


