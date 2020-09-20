using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
               
        }
        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
               
        }
                        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2020, TipoEscuela.Primaria, pais: "Colombia", ciudad: "Bogota");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach ( var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluaciones
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float) (5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre="Matemáticas"} ,
                    new Asignatura{Nombre="Educación Física"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
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


            foreach (var curso in Escuela.Cursos)
            {
                var cantidadRandom = new Random().Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}