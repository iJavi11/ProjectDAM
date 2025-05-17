using albartohnosDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace albartohnosDesktop.ListFRM
{
    public partial class CentrosParadaFRM : Form
    {
        private Usuario currentUser;
        private List<TipoCentro> tiposCentro;
        private List<CentroParada> centrosParada;

        public CentrosParadaFRM(Usuario usuario, List<TipoCentro> tiposCentro)
        {
            InitializeComponent();

            currentUser = usuario;
            this.tiposCentro = tiposCentro;

            // Inicializar la lista de almacenes
            ReloadStopCenterList();

            this.FormClosed += CentrosParadaFRM_FormClosed;
        }

        private async void ReloadStopCenterList()
        {
            centrosParada = await Negocio.ObtenerCentrosParada();

            // Limpiamos el ListView antes de añadir nada
            lvStCenters.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var centroParada in centrosParada)
            {
                if (centroParada.TipoCentro != 1)
                {
                    ListViewItem item = new ListViewItem(centroParada.Nombre);
                    item.SubItems.Add(tiposCentro.FirstOrDefault(tc => tc.Id == centroParada.TipoCentro)?.Nombre ?? "-");
                    item.SubItems.Add(centroParada.Tlf);
                    item.SubItems.Add(centroParada.Email);
                    item.SubItems.Add(centroParada.Ccaa);
                    item.SubItems.Add(centroParada.Localidad);
                    item.SubItems.Add(centroParada.Direccion);

                    item.Tag = centroParada;

                    lvStCenters.Items.Add(item);
                }
            }
        }
        private void btnUpdateStCenters_Click(object sender, EventArgs e)
        {
            ReloadStopCenterList();
        }
        private void CentrosParadaFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
