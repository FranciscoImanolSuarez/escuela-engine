using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace c_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2020, TipoEscuela.Primaria,pais: "Colombia", ciudad:"Bogota");
            
            var listaCursos = new List<Curso>() 
            {
                new Curso() { Nombre = "101", Jornada = TiposJornadas.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornadas.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornadas.Mañana },
                new Curso() { Nombre = "102", Jornada = TiposJornadas.Tarde },
                new Curso() { Nombre = "202", Jornada = TiposJornadas.Tarde },
                new Curso() { Nombre = "401", Jornada = TiposJornadas.Mañana },
                new Curso() { Nombre = "402", Jornada = TiposJornadas.Tarde },
                new Curso() { Nombre = "501", Jornada = TiposJornadas.Mañana },
                new Curso() { Nombre = "502", Jornada = TiposJornadas.Tarde },
            };

            escuela.Cursos.Add(new Curso { Nombre = "301", Jornada = TiposJornadas.Tarde });            
            
            escuela.Cursos.RemoveAll(delegate(Curso cur) {
             return cur.Nombre == "301";  
            });
            
            Console.WriteLine(escuela);
            
            System.Console.WriteLine("==============================");
            
            ImpimirCursosEscuela(escuela);
            
            
        }
        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}