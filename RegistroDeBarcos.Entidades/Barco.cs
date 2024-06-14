using System.ComponentModel.DataAnnotations;

namespace RegistroDeBarcos.Entidades
{
    public class Barco
    {
        public int IdBarco { get; set; }
    
        public String Nombre { get; set; }
     
        public int Antiguedad { get; set; }
     
        public int TripulacionMaxima { get; set; }

        public int Tasa { get; set; }
    }
}
