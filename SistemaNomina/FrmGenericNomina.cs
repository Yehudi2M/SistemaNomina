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
    public partial class FrmGenericNomina : Form
    {
        public FrmGenericNomina(string tipoNomina)
        {
            InitializeComponent();
            if (dvgNomina != null)
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
            foreach (DataGridViewColumn columna in dvgNomina.Columns)
            {
                columna.Visible = true;
            }
            if (tipoNomina == "SalarioMensual")
            {
                dvgNomina.Columns["SalarioQuincenal"].Visible = false;
                dvgNomina.Columns["SalarioSemanal"].Visible = false;
            }
            else if (tipoNomina == "SalarioQuincenal")
            {
                dvgNomina.Columns["SalarioMensual"].Visible = false;
                dvgNomina.Columns["SalarioSemanal"].Visible = false;
            }
            else if (tipoNomina == "SalarioSemanal")
            {
                dvgNomina.Columns["SalarioMensual"].Visible = false;
                dvgNomina.Columns["SalarioQuincenal"].Visible = false;
            }
        }
        private void FrmNominaMensual_Load(object sender, EventArgs e)
        {
        }
    }
}
