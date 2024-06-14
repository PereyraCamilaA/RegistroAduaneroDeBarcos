using RegistroDeBarcos.Entidades;

namespace RegistroDeBarcos.Logica.Services
{
    public interface IBarcosService
    {
        void RegistrarBarco(Barco barco);
        List<Barco> ObtenerBarcos();
    }

    public class BarcosService : IBarcosService
    {
        private static List<Barco> _barcos = new List<Barco>();

        public void RegistrarBarco(Barco barco)
        {
            barco.Tasa = (int)((barco.Antiguedad * 0.10) + (barco.TripulacionMaxima / 2));
            barco.IdBarco = _barcos.Count == 0
                ? 1
                : _barcos.Max(b => b.IdBarco) + 1;
            _barcos.Add(barco);
        }

        public List<Barco> ObtenerBarcos()
        {
            return _barcos.OrderBy(b => b.IdBarco).ToList();
        }
    }
}

