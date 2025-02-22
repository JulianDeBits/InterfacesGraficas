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
        private DataGridViewRow fila;
        private String tareaSeleccionada;
        private String descripcionSeleccionada;
        private String estadoSeleccionado;
        public editarRegistro(DataGridViewRow fila, String tareaSeleccionada, String descripcionSeleccionada, String estadoSeleccionado)
        {
            InitializeComponent();
            this.fila = fila;
            this.tareaSeleccionada = tareaSeleccionada;
            this.descripcionSeleccionada = descripcionSeleccionada;
            this.estadoSeleccionado = estadoSeleccionado;
            ObtenerDatosRegistro();
        }

        private void ObtenerDatosRegistro()
        {
            txt2NombreTarea.Text = tareaSeleccionada;
            txt2DescripcionTarea.Text = descripcionSeleccionada;
            cbox2EstadoTarea.SelectedItem = estadoSeleccionado;
        }

        private void btnCancelarModificacio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt2NombreTarea.Text) && string.IsNullOrEmpty(txt2DescripcionTarea.Text) && string.IsNullOrEmpty(cbox2EstadoTarea.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else
            {

                DialogResult result = MessageBox.Show(
                      "¿Estás seguro de que deseas editar este registro?",
                      "Confirmar eliminación",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    try
                    {
                        fila.Cells[0].Value = txt2NombreTarea.Text;
                        fila.Cells[1].Value = txt2DescripcionTarea.Text;
                        fila.Cells[2].Value = cbox2EstadoTarea.SelectedItem;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar el registro: " + ex.Message);
                    }
                }
            }
        }
    }
}
