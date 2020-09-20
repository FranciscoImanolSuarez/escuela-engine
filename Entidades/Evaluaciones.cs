using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; } //se asigna por dentro de la clase no por fuera
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
        public Evaluaciones()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}