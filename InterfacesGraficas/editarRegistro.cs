using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesGraficas
{
    public partial class editarRegistro: Form
    {
        public editarRegistro(DataGridViewRow fila, String tareaSeleccionada, String descripcionSeleccionada, String estadoSeleccionado)
        {
            InitializeComponent();
            cbox2EstadoTarea.SelectedIndex = 0;
        }

        private void ObtenerDatosRegistro()
        {

        }
    }
}
