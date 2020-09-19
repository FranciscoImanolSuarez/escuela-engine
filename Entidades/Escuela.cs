using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
             get { return nombre; }
             set {  nombre = value.ToUpper(); } 
        
        }

        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }    
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        // Constructor
        public Escuela (string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre,año);
        
        public Escuela (string nombre, int año,TipoEscuela tipo, string pais = "", string ciudad = "")
        {
            Nombre = nombre;
            AñoDeCreacion = año;
            Pais = pais;
            Ciudad = ciudad;
            
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre},Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}