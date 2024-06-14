using System.ComponentModel.DataAnnotations;
using RegistroAduaneroDeBarcos.Web.Controllers;
using RegistroDeBarcos.Entidades;

namespace RegistroAduaneroDeBarcos.Web.Models
{
    public class BarcoModel
    {
        public int IdBarco { get; set; }
        [StringLength(20), Required]
        public String Nombre { get; set; }
        [Range(1, 199), Required]
        public int Antiguedad { get; set; }
        [Range(1, 499), Required]
        public int TripulacionMaxima { get; set; }

        public int Tasa { get; set; }

        public BarcoModel()
        {
        }

        public BarcoModel(Barco entidad)
        {
            IdBarco = entidad.IdBarco;
            Nombre = entidad.Nombre;
            Antiguedad = entidad.Antiguedad;
            TripulacionMaxima = entidad.TripulacionMaxima;
            Tasa = entidad.Tasa;
        }

        public static List<BarcoModel> MapearAListaModel(List<Barco> barcos)
        {
            return barcos.Select(b => new BarcoModel(b)).ToList();
        }

        public Barco MapearAEntidad()
        {
            return new Barco
            {
                IdBarco = IdBarco,
                Nombre = Nombre,
                Antiguedad = Antiguedad,
                TripulacionMaxima = TripulacionMaxima,
                Tasa = Tasa

            };
        }
    }
}
