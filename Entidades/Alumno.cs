using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; } //se asigna por dentro de la clase no por fuera
        public string Nombre { get; set; }
        public object Evaluaciones { get; internal set; }

        public Alumno()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}