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
    public partial class PantallaPrincipal: Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            cboxEstadoTarea.SelectedIndex = 0;
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreTarea.Text) && string.IsNullOrEmpty(txtNombreTarea.Text) && string.IsNullOrEmpty(txtNombreTarea.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else
            {
                dgvTablaTareas.Rows.Add(txtNombreTarea.Text, txtDescripcionTarea.Text, cboxEstadoTarea.SelectedItem);
                txtNombreTarea.Text = "";
                txtDescripcionTarea.Text = "";
                cboxEstadoTarea.SelectedIndex = 0;
            }
        }
        private void dgvTablaTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTablaTareas.Columns[e.ColumnIndex].Name == "dgvBorrar")
            {
                DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
                if (result == DialogResult.Yes)
                {
                    dgvTablaTareas.Rows.RemoveAt(e.RowIndex);
                }
                    
            }
        }
    }
}
