using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; } //se asigna por dentro de la clase no por fuera
        public string Nombre { get; set; }

        public Asignatura()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}