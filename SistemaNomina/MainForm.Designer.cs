﻿namespace SistemaNomina
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTop = new Panel();
            btnExpand = new Button();
            panelLeft = new Panel();
            btnSalir = new Button();
            btnVerNóminas = new Button();
            panelTipoNomina = new Panel();
            btnSemanal = new Button();
            btnQuincenal = new Button();
            btnMensual = new Button();
            btnTipoNomina = new Button();
            tabPrincipal = new TabControl();
            tabPagePrincipal = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabMensual = new TabPage();
            panelMensual = new Panel();
            tabQuincenal = new TabPage();
            panelQuincenal = new Panel();
            tabSemanal = new TabPage();
            panelSemanal = new Panel();
            tabResumen = new TabPage();
            panelResumen = new Panel();
            panelPrincipal = new Panel();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panelTipoNomina.SuspendLayout();
            tabPrincipal.SuspendLayout();
            tabPagePrincipal.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabMensual.SuspendLayout();
            tabQuincenal.SuspendLayout();
            tabSemanal.SuspendLayout();
            tabResumen.SuspendLayout();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnExpand);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1718, 47);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // btnExpand
            // 
            btnExpand.Dock = DockStyle.Left;
            btnExpand.FlatAppearance.BorderSize = 0;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnExpand.Location = new Point(0, 0);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(68, 47);
            btnExpand.TabIndex = 0;
            btnExpand.Text = "≡";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(23, 24, 29);
            panelLeft.Controls.Add(btnSalir);
            panelLeft.Controls.Add(btnVerNóminas);
            panelLeft.Controls.Add(panelTipoNomina);
            panelLeft.Controls.Add(btnTipoNomina);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 47);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 772);
            panelLeft.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(17, 0, 0, 0);
            btnSalir.Size = new Size(250, 79);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerNóminas
            // 
            btnVerNóminas.Dock = DockStyle.Top;
            btnVerNóminas.FlatAppearance.BorderSize = 0;
            btnVerNóminas.FlatStyle = FlatStyle.Flat;
            btnVerNóminas.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnVerNóminas.ForeColor = Color.White;
            btnVerNóminas.Image = (Image)resources.GetObject("btnVerNóminas.Image");
            btnVerNóminas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerNóminas.Location = new Point(0, 328);
            btnVerNóminas.Name = "btnVerNóminas";
            btnVerNóminas.Padding = new Padding(15, 0, 0, 0);
            btnVerNóminas.Size = new Size(250, 79);
            btnVerNóminas.TabIndex = 3;
            btnVerNóminas.Text = "Resumen";
            btnVerNóminas.UseVisualStyleBackColor = true;
            btnVerNóminas.Click += btnVerNóminas_Click;
            // 
            // panelTipoNomina
            // 
            panelTipoNomina.BackColor = Color.FromArgb(32, 33, 36);
            panelTipoNomina.Controls.Add(btnSemanal);
            panelTipoNomina.Controls.Add(btnQuincenal);
            panelTipoNomina.Controls.Add(btnMensual);
            panelTipoNomina.Dock = DockStyle.Top;
            panelTipoNomina.Location = new Point(0, 79);
            panelTipoNomina.Name = "panelTipoNomina";
            panelTipoNomina.Size = new Size(250, 249);
            panelTipoNomina.TabIndex = 2;
            panelTipoNomina.Visible = false;
            // 
            // btnSemanal
            // 
            btnSemanal.Dock = DockStyle.Top;
            btnSemanal.FlatAppearance.BorderSize = 0;
            btnSemanal.FlatStyle = FlatStyle.Flat;
            btnSemanal.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnSemanal.ForeColor = Color.White;
            btnSemanal.Image = (Image)resources.GetObject("btnSemanal.Image");
            btnSemanal.ImageAlign = ContentAlignment.MiddleLeft;
            btnSemanal.Location = new Point(0, 158);
            btnSemanal.Name = "btnSemanal";
            btnSemanal.Padding = new Padding(20, 0, 0, 0);
            btnSemanal.Size = new Size(250, 79);
            btnSemanal.TabIndex = 3;
            btnSemanal.Text = "Semanal";
            btnSemanal.UseVisualStyleBackColor = true;
            btnSemanal.Click += btnSemanal_Click;
            // 
            // btnQuincenal
            // 
            btnQuincenal.Dock = DockStyle.Top;
            btnQuincenal.FlatAppearance.BorderSize = 0;
            btnQuincenal.FlatStyle = FlatStyle.Flat;
            btnQuincenal.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnQuincenal.ForeColor = Color.White;
            btnQuincenal.Image = (Image)resources.GetObject("btnQuincenal.Image");
            btnQuincenal.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuincenal.Location = new Point(0, 79);
            btnQuincenal.Name = "btnQuincenal";
            btnQuincenal.Padding = new Padding(20, 0, 0, 0);
            btnQuincenal.Size = new Size(250, 79);
            btnQuincenal.TabIndex = 2;
            btnQuincenal.Text = "Quincenal";
            btnQuincenal.UseVisualStyleBackColor = true;
            btnQuincenal.Click += btnQuincenal_Click;
            // 
            // btnMensual
            // 
            btnMensual.Dock = DockStyle.Top;
            btnMensual.FlatAppearance.BorderSize = 0;
            btnMensual.FlatStyle = FlatStyle.Flat;
            btnMensual.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnMensual.ForeColor = Color.White;
            btnMensual.Image = (Image)resources.GetObject("btnMensual.Image");
            btnMensual.ImageAlign = ContentAlignment.MiddleLeft;
            btnMensual.Location = new Point(0, 0);
            btnMensual.Name = "btnMensual";
            btnMensual.Padding = new Padding(20, 0, 0, 0);
            btnMensual.Size = new Size(250, 79);
            btnMensual.TabIndex = 1;
            btnMensual.Text = "Mensual";
            btnMensual.UseVisualStyleBackColor = true;
            btnMensual.Click += btnMensual_Click;
            // 
            // btnTipoNomina
            // 
            btnTipoNomina.Dock = DockStyle.Top;
            btnTipoNomina.FlatAppearance.BorderSize = 0;
            btnTipoNomina.FlatStyle = FlatStyle.Flat;
            btnTipoNomina.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTipoNomina.ForeColor = Color.White;
            btnTipoNomina.Image = (Image)resources.GetObject("btnTipoNomina.Image");
            btnTipoNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnTipoNomina.Location = new Point(0, 0);
            btnTipoNomina.Name = "btnTipoNomina";
            btnTipoNomina.Padding = new Padding(15, 0, 0, 0);
            btnTipoNomina.Size = new Size(250, 79);
            btnTipoNomina.TabIndex = 0;
            btnTipoNomina.Text = "  Tipo de Nómina";
            btnTipoNomina.UseVisualStyleBackColor = true;
            btnTipoNomina.Click += DesplegarTipoNomina;
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabPagePrincipal);
            tabPrincipal.Controls.Add(tabMensual);
            tabPrincipal.Controls.Add(tabQuincenal);
            tabPrincipal.Controls.Add(tabSemanal);
            tabPrincipal.Controls.Add(tabResumen);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1468, 772);
            tabPrincipal.TabIndex = 4;
            // 
            // tabPagePrincipal
            // 
            tabPagePrincipal.Controls.Add(toolStrip1);
            tabPagePrincipal.Controls.Add(label2);
            tabPagePrincipal.Controls.Add(label1);
            tabPagePrincipal.Controls.Add(pictureBox1);
            tabPagePrincipal.Location = new Point(4, 29);
            tabPagePrincipal.Name = "tabPagePrincipal";
            tabPagePrincipal.Padding = new Padding(3);
            tabPagePrincipal.Size = new Size(1460, 739);
            tabPagePrincipal.TabIndex = 0;
            tabPagePrincipal.Text = "Principal";
            tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(103, 536);
            toolStrip1.Margin = new Padding(10);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(193, 74);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(10);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 54);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Guardar Todo";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(10);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 54);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Cargar Datos";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Margin = new Padding(10);
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 54);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Limpiar Todo";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(103, 485);
            label2.Name = "label2";
            label2.Size = new Size(479, 51);
            label2.TabIndex = 2;
            label2.Text = "!Seleccione una de las opciones del panel izquierdo para comenzar¡";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 97);
            label1.Name = "label1";
            label1.Size = new Size(581, 388);
            label1.TabIndex = 1;
            label1.Text = "!BIENVENIDO AL SISTEMA DE CÁLULO DE NÓMINA¡";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(691, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(682, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabMensual
            // 
            tabMensual.Controls.Add(panelMensual);
            tabMensual.Location = new Point(4, 29);
            tabMensual.Name = "tabMensual";
            tabMensual.Padding = new Padding(3);
            tabMensual.Size = new Size(1460, 739);
            tabMensual.TabIndex = 1;
            tabMensual.Text = "Mensual";
            tabMensual.UseVisualStyleBackColor = true;
            // 
            // panelMensual
            // 
            panelMensual.Dock = DockStyle.Fill;
            panelMensual.Location = new Point(3, 3);
            panelMensual.Name = "panelMensual";
            panelMensual.Size = new Size(1454, 733);
            panelMensual.TabIndex = 0;
            // 
            // tabQuincenal
            // 
            tabQuincenal.Controls.Add(panelQuincenal);
            tabQuincenal.Location = new Point(4, 29);
            tabQuincenal.Name = "tabQuincenal";
            tabQuincenal.Size = new Size(1460, 739);
            tabQuincenal.TabIndex = 2;
            tabQuincenal.Text = "Quincenal";
            tabQuincenal.UseVisualStyleBackColor = true;
            // 
            // panelQuincenal
            // 
            panelQuincenal.Dock = DockStyle.Fill;
            panelQuincenal.Location = new Point(0, 0);
            panelQuincenal.Name = "panelQuincenal";
            panelQuincenal.Size = new Size(1460, 739);
            panelQuincenal.TabIndex = 0;
            // 
            // tabSemanal
            // 
            tabSemanal.Controls.Add(panelSemanal);
            tabSemanal.Location = new Point(4, 29);
            tabSemanal.Name = "tabSemanal";
            tabSemanal.Size = new Size(1460, 739);
            tabSemanal.TabIndex = 3;
            tabSemanal.Text = "Semanal";
            tabSemanal.UseVisualStyleBackColor = true;
            // 
            // panelSemanal
            // 
            panelSemanal.Dock = DockStyle.Fill;
            panelSemanal.Location = new Point(0, 0);
            panelSemanal.Name = "panelSemanal";
            panelSemanal.Size = new Size(1460, 739);
            panelSemanal.TabIndex = 0;
            // 
            // tabResumen
            // 
            tabResumen.Controls.Add(panelResumen);
            tabResumen.Location = new Point(4, 29);
            tabResumen.Name = "tabResumen";
            tabResumen.Padding = new Padding(3);
            tabResumen.Size = new Size(1460, 739);
            tabResumen.TabIndex = 4;
            tabResumen.Text = "Resumen:";
            tabResumen.UseVisualStyleBackColor = true;
            // 
            // panelResumen
            // 
            panelResumen.Dock = DockStyle.Fill;
            panelResumen.Location = new Point(3, 3);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(1454, 733);
            panelResumen.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(tabPrincipal);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(250, 47);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1468, 772);
            panelPrincipal.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 819);
            Controls.Add(panelPrincipal);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelTipoNomina.ResumeLayout(false);
            tabPrincipal.ResumeLayout(false);
            tabPagePrincipal.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabMensual.ResumeLayout(false);
            tabQuincenal.ResumeLayout(false);
            tabSemanal.ResumeLayout(false);
            tabResumen.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnExpand;
        private Panel panelLeft;
        private Button btnSalir;
        private Button btnVerNóminas;
        private Panel panelTipoNomina;
        private Button btnSemanal;
        private Button btnQuincenal;
        private Button btnMensual;
        private Button btnTipoNomina;
        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private TabPage tabMensual;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TabPage tabQuincenal;
        private TabPage tabSemanal;
        private Panel panelMensual;
        private Panel panelQuincenal;
        private Panel panelSemanal;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Panel panelPrincipal;
        private TabPage tabResumen;
        private Panel panelResumen;
    }
}
