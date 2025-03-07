using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wSistemaReservaVuelo
{
    public partial class Form1: Form
    {
        private List<Vuelo> vuelos = new List<Vuelo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoVuelo.Text;
                string origen = txtOrigen.Text;
                string destino = txtDestino.Text;
                DateTime fechaSalida = dtpFechaSalida.Value;
                int asientosDisponibles = int.Parse(txtAsientosDisponibles.Text);

                Vuelo nuevoVuelo = new Vuelo(codigo, origen, destino, fechaSalida, asientosDisponibles);
                vuelos.Add(nuevoVuelo);

                ActualizarListaVuelos();
                MessageBox.Show("Vuelo agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaVuelos()
        {
            listBoxVuelos.Items.Clear();
            foreach (var vuelo in vuelos)
            {
                listBoxVuelos.Items.Add(vuelo.ToString());
            }
        }

        private void btnReservarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoReserva = txtCodigoReserva.Text;
                int cantidadReservas = int.Parse(txtCantidadReservas.Text);

                Vuelo vuelo = vuelos.Find(v => v.Codigo == codigoReserva);

                if (vuelo != null)
                {
                    if (vuelo.AsientosDisponibles >= cantidadReservas)
                    {
                        vuelo.AsientosDisponibles -= cantidadReservas;
                        ActualizarListaVuelos();
                        MessageBox.Show("Reserva realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes asientos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vuelo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
