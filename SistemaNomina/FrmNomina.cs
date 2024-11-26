using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNomina
{
    public partial class FrmNomina : Form
    {

        public FrmNomina(string tipoNomina)//parametro para ajustar las columnas
        {
            InitializeComponent();
            if (dvgNomina != null)//verifica que dvgNomina este inicializado antes de ajustar las columnas
            {
                AjustarColumnas(tipoNomina);
            }
            else
            {
                MessageBox.Show("El DataGridView no está inicializado.");
            }
        }
        public void AjustarColumnas(string tipoNomina)
        {
            //Cambia la visibilidad de las columnas segun el tipo de Nomina
            foreach (DataGridViewColumn columna in dvgNomina.Columns)
            {
                columna.Visible = true;
            }
            if (tipoNomina == "Mensual")
            {
                dvgNomina.Columns["clmSalarioQuincenal"].Visible = false;
                dvgNomina.Columns["clmSalarioSemanal"].Visible = false;
            }
            else if (tipoNomina == "Quincenal")
            {
                dvgNomina.Columns["clmSalarioMensual"].Visible = false;
                dvgNomina.Columns["clmSalarioSemanal"].Visible = false;
            }
            else if (tipoNomina == "Semanal")
            {
                dvgNomina.Columns["clmSalarioMensual"].Visible = false;
                dvgNomina.Columns["clmSalarioQuincenal"].Visible = false;
            }
        }

        private void FrmNominaMensual_Load(object sender, EventArgs e)
        {
        }
        private void ValidarCampos()
        {
            //verifica que todos los campos hallan sido llenados
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !mtbNoINNS.MaskCompleted ||
                cmbDepartamento.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                !mtbHorasExtra.MaskCompleted ||
                !mtbAntigüedad.MaskCompleted)
            {
                MessageBox.Show("Complete todos los campos para poder calcular", "Campo incompleto.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ubica la informacion de los campos en su respectiva columna
            int NuevaFila = dvgNomina.Rows.Add();
            dvgNomina.Rows[NuevaFila].Cells["clmNombre"].Value = txtNombre.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmNoINNS"].Value = mtbNoINNS.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmDepartamento"].Value = cmbDepartamento.SelectedItem.ToString();
            dvgNomina.Rows[NuevaFila].Cells["clmSalarioMensual"].Value = txtSalario.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmSalarioQuincenal"].Value = txtSalario.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmSalarioSemanal"].Value = txtSalario.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmHorasExtras"].Value = mtbHorasExtra.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmAntigüedad"].Value = mtbAntigüedad.Text;

            txtNombre.Clear();
            mtbNoINNS.Clear();
            cmbDepartamento.SelectedIndex = -1;
            txtSalario.Clear();
            mtbHorasExtra.Clear();
            mtbAntigüedad.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgNomina.SelectedRows.Count > 0)
            {
                bool filaNuevaSeleccionada = false;
                foreach (DataGridViewRow fila in dvgNomina.SelectedRows)//verifica que la fila seleccionada es la por defecto
                {
                    if (fila.IsNewRow)
                    {
                        filaNuevaSeleccionada = true;//indica que la fila por defecto se selecciono
                    }
                    else
                    {
                        //si no es la fila por defeccto se procede con la eliminacion
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?",
                            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            dvgNomina.Rows.Remove(fila);
                        }
                    }
                }
                if (filaNuevaSeleccionada)
                {
                    return;//si la fila por defecto fue seleccionada, no sucede nada
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
