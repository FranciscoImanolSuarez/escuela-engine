using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2020, TipoEscuela.Primaria, pais: "Colombia", ciudad: "Bogota");
          
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
        }
    }
}