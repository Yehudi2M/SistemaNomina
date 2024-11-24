namespace SistemaNomina
{
    public partial class MainForm : Form
    {
        private FrmGenericNomina frmGenericNominaMensual;//acceder a metodos
        private FrmGenericNomina frmGenericNominaQuincenal;
        private FrmGenericNomina frmGenericNominaSemanal;
        private FrmResumen frmResumen;

        private bool _isPanelVisibleTipoNomina = false;
        private bool _isPanelExpand = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            //expandir o contraer el panel izquierdo
            if (_isPanelExpand)
            {
                panelLeft.Width = 250;//Tamaño expandido
                _isPanelExpand = false;
                //restaura el texto de los botones
                foreach (Button button in panelLeft.Controls.OfType<Button>())
                {
                    btnTipoNomina.Text = "Tipo de Nómina";
                    btnVerNóminas.Text = "Ver Nóminas";
                    btnSalir.Text = "Salir";
                    btnMensual.Text = "Mensual";
                    btnSemanal.Text = "Quincenal";
                    btnQuincenal.Text = "Semanal";
                }
            }
            else
            {
                panelLeft.Width = 75;//tamaño contraido
                _isPanelExpand = true;
                //eliminar el texto de los botones
                foreach (Button button in panelLeft.Controls.OfType<Button>())
                {
                    btnTipoNomina.Text = "";
                    btnVerNóminas.Text = "";
                    btnSalir.Text = "";
                    btnMensual.Text = "";
                    btnSemanal.Text = "";
                    btnQuincenal.Text = "";
                }
                //cierra el panel TipoNomina si el panelLeft esta cotraido
                if (_isPanelExpand)
                {
                    _isPanelVisibleTipoNomina = false;
                    panelTipoNomina.Visible = false;
                }
            }
        }

        private void DesplegarTipoNomina(object sender, EventArgs e)
        {
            //solo se despliega si el panelLeft esta expandido
            if (panelLeft.Width > 75)
            {
                _isPanelVisibleTipoNomina = !_isPanelVisibleTipoNomina;
                panelTipoNomina.Visible = _isPanelVisibleTipoNomina;
            }
            else
            {
                panelTipoNomina.Visible = false;
            }
        }
        private void MostrarFormularioEnPanel(Form formulario, Panel panel)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {
            if (frmGenericNominaMensual == null)
            {
                frmGenericNominaMensual = new FrmGenericNomina("SalarioMensual");
            }
            tabPrincipal.SelectedTab = tabMensual;// Cambia a la pestaña Mensual
            frmGenericNominaMensual.AjustarColumnas("SalarioMensual");
            MostrarFormularioEnPanel(frmGenericNominaMensual, panelMensual);

        }

        private void btnQuincenal_Click(object sender, EventArgs e)
        {
            
            if (frmGenericNominaQuincenal == null)
            {
                frmGenericNominaQuincenal = new FrmGenericNomina("SalarioQuincenal");
            }
            tabPrincipal.SelectedTab = tabQuincenal;
            frmGenericNominaQuincenal.AjustarColumnas("SalarioQuincenal");
            MostrarFormularioEnPanel(frmGenericNominaQuincenal, panelQuincenal);
        }

        private void btnSemanal_Click(object sender, EventArgs e)
        {
            
            if (frmGenericNominaSemanal == null)
            {
                frmGenericNominaSemanal = new FrmGenericNomina("SalarioSemanal");
            }
            tabPrincipal.SelectedTab = tabSemanal;
            frmGenericNominaSemanal.AjustarColumnas("SalarioSemanal");
            MostrarFormularioEnPanel(frmGenericNominaSemanal, panelSemanal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerNóminas_Click(object sender, EventArgs e)
        {
            if (frmResumen == null)
            {
                frmResumen = new FrmResumen();
            }
            tabPrincipal.SelectedTab = tabResumen;
            MostrarFormularioEnPanel(frmResumen, panelResumen);
        }
    }
}
