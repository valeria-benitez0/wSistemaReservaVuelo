using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSistemaReservaVuelo
{
    class Vuelo
    {
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public int AsientosDisponibles { get; set; }

        public Vuelo(string codigo, string origen, string destino, DateTime fechaSalida, int asientosDisponibles)
        {
            Codigo = codigo;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            AsientosDisponibles = asientosDisponibles;
        }

        public override string ToString()
        {
            return $"{Codigo} | {Origen} -> {Destino} | {FechaSalida.ToShortDateString()} | Asientos: {AsientosDisponibles}";
        }
    }
}
