namespace SistemaNomina
{
    partial class FrmNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNomina));
            groupBox1 = new GroupBox();
            mtbAntigüedad = new MaskedTextBox();
            mtbHorasExtra = new MaskedTextBox();
            txtSalario = new TextBox();
            mtbNoINNS = new MaskedTextBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbDepartamento = new ComboBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dvgNomina = new DataGridView();
            clmNoINNS = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmDepartamento = new DataGridViewTextBoxColumn();
            clmSalarioMensual = new DataGridViewTextBoxColumn();
            clmSalarioQuincenal = new DataGridViewTextBoxColumn();
            clmSalarioSemanal = new DataGridViewTextBoxColumn();
            clmHorasExtras = new DataGridViewTextBoxColumn();
            clmIngresoPorHora = new DataGridViewTextBoxColumn();
            clmAntigüedad = new DataGridViewTextBoxColumn();
            clmTotalIngresos = new DataGridViewTextBoxColumn();
            clmINNSLaboral = new DataGridViewTextBoxColumn();
            clmIR = new DataGridViewTextBoxColumn();
            clmTotalDeducciones = new DataGridViewTextBoxColumn();
            clmSalarioNeto = new DataGridViewTextBoxColumn();
            clmINATEC = new DataGridViewTextBoxColumn();
            clmINNSPatronal = new DataGridViewTextBoxColumn();
            clmVacaciones = new DataGridViewTextBoxColumn();
            clmTreceavoMes = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            btnEliminar = new Button();
            btnCargar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgNomina).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(mtbAntigüedad);
            groupBox1.Controls.Add(mtbHorasExtra);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(mtbNoINNS);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbDepartamento);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1426, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // mtbAntigüedad
            // 
            mtbAntigüedad.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbAntigüedad.Location = new Point(1059, 157);
            mtbAntigüedad.Mask = "99";
            mtbAntigüedad.Name = "mtbAntigüedad";
            mtbAntigüedad.Size = new Size(225, 34);
            mtbAntigüedad.TabIndex = 26;
            mtbAntigüedad.ValidatingType = typeof(int);
            // 
            // mtbHorasExtra
            // 
            mtbHorasExtra.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbHorasExtra.Location = new Point(1059, 104);
            mtbHorasExtra.Mask = "99";
            mtbHorasExtra.Name = "mtbHorasExtra";
            mtbHorasExtra.Size = new Size(225, 34);
            mtbHorasExtra.TabIndex = 25;
            mtbHorasExtra.ValidatingType = typeof(int);
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(1059, 52);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(225, 34);
            txtSalario.TabIndex = 22;
            // 
            // mtbNoINNS
            // 
            mtbNoINNS.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbNoINNS.Location = new Point(402, 104);
            mtbNoINNS.Mask = "999999999";
            mtbNoINNS.Name = "mtbNoINNS";
            mtbNoINNS.Size = new Size(225, 34);
            mtbNoINNS.TabIndex = 18;
            mtbNoINNS.ValidatingType = typeof(int);
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(78, 157);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 29);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(78, 104);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 29);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(761, 157);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(761, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 29);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(761, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(797, 153);
            label6.Name = "label6";
            label6.Size = new Size(173, 33);
            label6.TabIndex = 8;
            label6.Text = "Antigüedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(797, 103);
            label5.Name = "label5";
            label5.Size = new Size(188, 33);
            label5.TabIndex = 7;
            label5.Text = "Horas Extras:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(797, 53);
            label4.Name = "label4";
            label4.Size = new Size(114, 33);
            label4.TabIndex = 6;
            label4.Text = "Salario:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Direccion", "Recursos Humanos", "Produccion", "Marketing", "Compras", "Logística" });
            cmbDepartamento.Location = new Point(402, 151);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(225, 35);
            cmbDepartamento.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(402, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 34);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 153);
            label3.Name = "label3";
            label3.Size = new Size(211, 33);
            label3.TabIndex = 2;
            label3.Text = "Departamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 103);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 1;
            label2.Text = "No. INNS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 53);
            label1.Name = "label1";
            label1.Size = new Size(128, 33);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // dvgNomina
            // 
            dvgNomina.Anchor = AnchorStyles.None;
            dvgNomina.BackgroundColor = SystemColors.ControlLight;
            dvgNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNomina.Columns.AddRange(new DataGridViewColumn[] { clmNoINNS, clmNombre, clmDepartamento, clmSalarioMensual, clmSalarioQuincenal, clmSalarioSemanal, clmHorasExtras, clmIngresoPorHora, clmAntigüedad, clmTotalIngresos, clmINNSLaboral, clmIR, clmTotalDeducciones, clmSalarioNeto, clmINATEC, clmINNSPatronal, clmVacaciones, clmTreceavoMes });
            dvgNomina.Location = new Point(12, 259);
            dvgNomina.Name = "dvgNomina";
            dvgNomina.ReadOnly = true;
            dvgNomina.RowHeadersWidth = 51;
            dvgNomina.Size = new Size(1426, 324);
            dvgNomina.TabIndex = 1;
            // 
            // clmNoINNS
            // 
            clmNoINNS.HeaderText = "No. INNS";
            clmNoINNS.MinimumWidth = 6;
            clmNoINNS.Name = "clmNoINNS";
            clmNoINNS.ReadOnly = true;
            clmNoINNS.Width = 125;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmDepartamento
            // 
            clmDepartamento.HeaderText = "Departamento";
            clmDepartamento.MinimumWidth = 6;
            clmDepartamento.Name = "clmDepartamento";
            clmDepartamento.ReadOnly = true;
            clmDepartamento.Width = 125;
            // 
            // clmSalarioMensual
            // 
            clmSalarioMensual.HeaderText = "Salario Mensual";
            clmSalarioMensual.MinimumWidth = 6;
            clmSalarioMensual.Name = "clmSalarioMensual";
            clmSalarioMensual.ReadOnly = true;
            clmSalarioMensual.Width = 125;
            // 
            // clmSalarioQuincenal
            // 
            clmSalarioQuincenal.HeaderText = "Salario Quincenal";
            clmSalarioQuincenal.MinimumWidth = 6;
            clmSalarioQuincenal.Name = "clmSalarioQuincenal";
            clmSalarioQuincenal.ReadOnly = true;
            clmSalarioQuincenal.Width = 125;
            // 
            // clmSalarioSemanal
            // 
            clmSalarioSemanal.HeaderText = "Salario Semanal";
            clmSalarioSemanal.MinimumWidth = 6;
            clmSalarioSemanal.Name = "clmSalarioSemanal";
            clmSalarioSemanal.ReadOnly = true;
            clmSalarioSemanal.Width = 125;
            // 
            // clmHorasExtras
            // 
            clmHorasExtras.HeaderText = "Horas Extras";
            clmHorasExtras.MinimumWidth = 6;
            clmHorasExtras.Name = "clmHorasExtras";
            clmHorasExtras.ReadOnly = true;
            clmHorasExtras.Width = 125;
            // 
            // clmIngresoPorHora
            // 
            clmIngresoPorHora.HeaderText = "Ingreso por hora";
            clmIngresoPorHora.MinimumWidth = 6;
            clmIngresoPorHora.Name = "clmIngresoPorHora";
            clmIngresoPorHora.ReadOnly = true;
            clmIngresoPorHora.Width = 125;
            // 
            // clmAntigüedad
            // 
            clmAntigüedad.HeaderText = "Antigüedad";
            clmAntigüedad.MinimumWidth = 6;
            clmAntigüedad.Name = "clmAntigüedad";
            clmAntigüedad.ReadOnly = true;
            clmAntigüedad.Width = 125;
            // 
            // clmTotalIngresos
            // 
            clmTotalIngresos.HeaderText = "Total de Ingresos";
            clmTotalIngresos.MinimumWidth = 6;
            clmTotalIngresos.Name = "clmTotalIngresos";
            clmTotalIngresos.ReadOnly = true;
            clmTotalIngresos.Width = 125;
            // 
            // clmINNSLaboral
            // 
            clmINNSLaboral.HeaderText = "INNS Laboral";
            clmINNSLaboral.MinimumWidth = 6;
            clmINNSLaboral.Name = "clmINNSLaboral";
            clmINNSLaboral.ReadOnly = true;
            clmINNSLaboral.Width = 125;
            // 
            // clmIR
            // 
            clmIR.HeaderText = "IR";
            clmIR.MinimumWidth = 6;
            clmIR.Name = "clmIR";
            clmIR.ReadOnly = true;
            clmIR.Width = 125;
            // 
            // clmTotalDeducciones
            // 
            clmTotalDeducciones.HeaderText = "Total Deducciones";
            clmTotalDeducciones.MinimumWidth = 6;
            clmTotalDeducciones.Name = "clmTotalDeducciones";
            clmTotalDeducciones.ReadOnly = true;
            clmTotalDeducciones.Width = 125;
            // 
            // clmSalarioNeto
            // 
            clmSalarioNeto.HeaderText = "Salario Neto";
            clmSalarioNeto.MinimumWidth = 6;
            clmSalarioNeto.Name = "clmSalarioNeto";
            clmSalarioNeto.ReadOnly = true;
            clmSalarioNeto.Width = 125;
            // 
            // clmINATEC
            // 
            clmINATEC.HeaderText = "INATEC";
            clmINATEC.MinimumWidth = 6;
            clmINATEC.Name = "clmINATEC";
            clmINATEC.ReadOnly = true;
            clmINATEC.Width = 125;
            // 
            // clmINNSPatronal
            // 
            clmINNSPatronal.HeaderText = "INNS Patronal";
            clmINNSPatronal.MinimumWidth = 6;
            clmINNSPatronal.Name = "clmINNSPatronal";
            clmINNSPatronal.ReadOnly = true;
            clmINNSPatronal.Width = 125;
            // 
            // clmVacaciones
            // 
            clmVacaciones.HeaderText = "Vacaciones";
            clmVacaciones.MinimumWidth = 6;
            clmVacaciones.Name = "clmVacaciones";
            clmVacaciones.ReadOnly = true;
            clmVacaciones.Width = 125;
            // 
            // clmTreceavoMes
            // 
            clmTreceavoMes.HeaderText = "Treceavo mes";
            clmTreceavoMes.MinimumWidth = 6;
            clmTreceavoMes.Name = "clmTreceavoMes";
            clmTreceavoMes.ReadOnly = true;
            clmTreceavoMes.Width = 125;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.BackColor = SystemColors.ControlLight;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnCalcular.Location = new Point(79, 608);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(225, 90);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = SystemColors.ControlLight;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(438, 608);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 90);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.BackColor = SystemColors.ControlLight;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnCargar.Location = new Point(1138, 608);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(225, 90);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = SystemColors.ControlLight;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(795, 608);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(225, 90);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 725);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCalcular);
            Controls.Add(dvgNomina);
            Controls.Add(groupBox1);
            Name = "FrmNomina";
            Text = "FrmNominaMensual";
            Load += FrmNominaMensual_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbDepartamento;
        private TextBox txtNombre;
        private Label label3;
        private DataGridView dvgNomina;
        private Button btnCalcular;
        private Button btnEliminar;
        private Button btnCargar;
        private Button btnGuardar;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbAntiguedad;
        private MaskedTextBox mtbHorasExtras;
        private MaskedTextBox mtbNoINNS;
        private TextBox txtSalario;
        private MaskedTextBox mtbAntigüedad;
        private MaskedTextBox mtbHorasExtra;
        private DataGridViewTextBoxColumn clmNoINNS;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmDepartamento;
        private DataGridViewTextBoxColumn clmSalarioMensual;
        private DataGridViewTextBoxColumn clmSalarioQuincenal;
        private DataGridViewTextBoxColumn clmSalarioSemanal;
        private DataGridViewTextBoxColumn clmHorasExtras;
        private DataGridViewTextBoxColumn clmIngresoPorHora;
        private DataGridViewTextBoxColumn clmAntigüedad;
        private DataGridViewTextBoxColumn clmTotalIngresos;
        private DataGridViewTextBoxColumn clmINNSLaboral;
        private DataGridViewTextBoxColumn clmIR;
        private DataGridViewTextBoxColumn clmTotalDeducciones;
        private DataGridViewTextBoxColumn clmSalarioNeto;
        private DataGridViewTextBoxColumn clmINATEC;
        private DataGridViewTextBoxColumn clmINNSPatronal;
        private DataGridViewTextBoxColumn clmVacaciones;
        private DataGridViewTextBoxColumn clmTreceavoMes;
    }
}