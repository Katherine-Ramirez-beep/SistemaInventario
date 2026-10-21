namespace SistemaInventario.Presentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnNavReportes = new System.Windows.Forms.Button();
            this.btnNavPapelera = new System.Windows.Forms.Button();
            this.btnNavProductos = new System.Windows.Forms.Button();
            this.btnNavSuplidores = new System.Windows.Forms.Button();
            this.btnNavCategorias = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.lblSubtituloBrand = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.pnlFormCategoria = new System.Windows.Forms.Panel();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnLimpiarCat = new System.Windows.Forms.Button();
            this.btnGuardarCat = new System.Windows.Forms.Button();
            this.txtDescCat = new System.Windows.Forms.TextBox();
            this.lblDescCat = new System.Windows.Forms.Label();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.lblTitCat = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashInfo = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelBrand.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.pnlFormCategoria.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.Controls.Add(this.btnNavReportes);
            this.panelSidebar.Controls.Add(this.btnNavPapelera);
            this.panelSidebar.Controls.Add(this.btnNavProductos);
            this.panelSidebar.Controls.Add(this.btnNavSuplidores);
            this.panelSidebar.Controls.Add(this.btnNavCategorias);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.panelBrand);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(230, 680);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnNavReportes
            // 
            this.btnNavReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavReportes.FlatAppearance.BorderSize = 0;
            this.btnNavReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavReportes.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavReportes.Location = new System.Drawing.Point(0, 310);
            this.btnNavReportes.Name = "btnNavReportes";
            this.btnNavReportes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavReportes.Size = new System.Drawing.Size(230, 45);
            this.btnNavReportes.TabIndex = 6;
            this.btnNavReportes.Text = "Consultas / LINQ";
            this.btnNavReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReportes.UseVisualStyleBackColor = true;
            this.btnNavReportes.Click += new System.EventHandler(this.btnNavReportes_Click);
            // 
            // btnNavPapelera
            // 
            this.btnNavPapelera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPapelera.FlatAppearance.BorderSize = 0;
            this.btnNavPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPapelera.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavPapelera.ForeColor = System.Drawing.Color.FromArgb(248, 113, 113);
            this.btnNavPapelera.Location = new System.Drawing.Point(0, 265);
            this.btnNavPapelera.Name = "btnNavPapelera";
            this.btnNavPapelera.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavPapelera.Size = new System.Drawing.Size(230, 45);
            this.btnNavPapelera.TabIndex = 5;
            this.btnNavPapelera.Text = "Papelera";
            this.btnNavPapelera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPapelera.UseVisualStyleBackColor = true;
            this.btnNavPapelera.Click += new System.EventHandler(this.btnNavPapelera_Click);
            // 
            // btnNavProductos
            // 
            this.btnNavProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProductos.FlatAppearance.BorderSize = 0;
            this.btnNavProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProductos.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavProductos.Location = new System.Drawing.Point(0, 220);
            this.btnNavProductos.Name = "btnNavProductos";
            this.btnNavProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavProductos.Size = new System.Drawing.Size(230, 45);
            this.btnNavProductos.TabIndex = 4;
            this.btnNavProductos.Text = "Productos";
            this.btnNavProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProductos.UseVisualStyleBackColor = true;
            this.btnNavProductos.Click += new System.EventHandler(this.btnNavProductos_Click);
            // 
            // btnNavSuplidores
            // 
            this.btnNavSuplidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSuplidores.FlatAppearance.BorderSize = 0;
            this.btnNavSuplidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSuplidores.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavSuplidores.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavSuplidores.Location = new System.Drawing.Point(0, 175);
            this.btnNavSuplidores.Name = "btnNavSuplidores";
            this.btnNavSuplidores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavSuplidores.Size = new System.Drawing.Size(230, 45);
            this.btnNavSuplidores.TabIndex = 3;
            this.btnNavSuplidores.Text = "Suplidores";
            this.btnNavSuplidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSuplidores.UseVisualStyleBackColor = true;
            this.btnNavSuplidores.Click += new System.EventHandler(this.btnNavSuplidores_Click);
            // 
            // btnNavCategorias
            // 
            this.btnNavCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCategorias.FlatAppearance.BorderSize = 0;
            this.btnNavCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavCategorias.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavCategorias.Location = new System.Drawing.Point(0, 130);
            this.btnNavCategorias.Name = "btnNavCategorias";
            this.btnNavCategorias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavCategorias.Size = new System.Drawing.Size(230, 45);
            this.btnNavCategorias.TabIndex = 2;
            this.btnNavCategorias.Text = "Categorías";
            this.btnNavCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCategorias.UseVisualStyleBackColor = true;
            this.btnNavCategorias.Click += new System.EventHandler(this.btnNavCategorias_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 85);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(230, 45);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // panelBrand
            // 
            this.panelBrand.Controls.Add(this.lblSubtituloBrand);
            this.panelBrand.Controls.Add(this.lblBrand);
            this.panelBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrand.Location = new System.Drawing.Point(0, 0);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(230, 85);
            this.panelBrand.TabIndex = 0;
            // 
            // lblSubtituloBrand
            // 
            this.lblSubtituloBrand.AutoSize = true;
            this.lblSubtituloBrand.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtituloBrand.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtituloBrand.Location = new System.Drawing.Point(20, 50);
            this.lblSubtituloBrand.Name = "lblSubtituloBrand";
            this.lblSubtituloBrand.Size = new System.Drawing.Size(129, 19);
            this.lblSubtituloBrand.TabIndex = 1;
            this.lblSubtituloBrand.Text = "Gestión de Stock v1.0";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.lblBrand.Location = new System.Drawing.Point(18, 20);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(202, 30);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "INVENTARIO 360°";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTituloModulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(230, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(890, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI Bold", 13F);
            this.lblTituloModulo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTituloModulo.Location = new System.Drawing.Point(25, 15);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(182, 30);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "Panel de Control";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContenedor.Controls.Add(this.pnlCategorias);
            this.panelContenedor.Controls.Add(this.pnlDashboard);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(230, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(890, 620);
            this.panelContenedor.TabIndex = 2;
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.dgvCategorias);
            this.pnlCategorias.Controls.Add(this.pnlFormCategoria);
            this.pnlCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategorias.Location = new System.Drawing.Point(0, 0);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(890, 620);
            this.pnlCategorias.TabIndex = 1;
            this.pnlCategorias.Visible = false;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.Location = new System.Drawing.Point(340, 0);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 30;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(550, 620);
            this.dgvCategorias.TabIndex = 1;
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            // 
            // pnlFormCategoria
            // 
            this.pnlFormCategoria.BackColor = System.Drawing.Color.White;
            this.pnlFormCategoria.Controls.Add(this.btnEliminarCat);
            this.pnlFormCategoria.Controls.Add(this.btnLimpiarCat);
            this.pnlFormCategoria.Controls.Add(this.btnGuardarCat);
            this.pnlFormCategoria.Controls.Add(this.txtDescCat);
            this.pnlFormCategoria.Controls.Add(this.lblDescCat);
            this.pnlFormCategoria.Controls.Add(this.txtNombreCat);
            this.pnlFormCategoria.Controls.Add(this.lblNombreCat);
            this.pnlFormCategoria.Controls.Add(this.lblTitCat);
            this.pnlFormCategoria.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFormCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlFormCategoria.Name = "pnlFormCategoria";
            this.pnlFormCategoria.Size = new System.Drawing.Size(340, 620);
            this.pnlFormCategoria.TabIndex = 0;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            this.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCat.Font = new System.Drawing.Font("Segoe UI Bold", 9.5F);
            this.btnEliminarCat.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCat.Location = new System.Drawing.Point(170, 360);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(140, 38);
            this.btnEliminarCat.TabIndex = 7;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnLimpiarCat
            // 
            this.btnLimpiarCat.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLimpiarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCat.Font = new System.Drawing.Font("Segoe UI Bold", 9.5F);
            this.btnLimpiarCat.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCat.Location = new System.Drawing.Point(20, 360);
            this.btnLimpiarCat.Name = "btnLimpiarCat";
            this.btnLimpiarCat.Size = new System.Drawing.Size(140, 38);
            this.btnLimpiarCat.TabIndex = 6;
            this.btnLimpiarCat.Text = "Limpiar";
            this.btnLimpiarCat.UseVisualStyleBackColor = false;
            this.btnLimpiarCat.Click += new System.EventHandler(this.btnLimpiarCat_Click);
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGuardarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCat.Font = new System.Drawing.Font("Segoe UI Bold", 10F);
            this.btnGuardarCat.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCat.Location = new System.Drawing.Point(20, 310);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(290, 40);
            this.btnGuardarCat.TabIndex = 5;
            this.btnGuardarCat.Text = "Guardar Categoría";
            this.btnGuardarCat.UseVisualStyleBackColor = false;
            this.btnGuardarCat.Click += new System.EventHandler(this.btnGuardarCat_Click);
            // 
            // txtDescCat
            // 
            this.txtDescCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescCat.Location = new System.Drawing.Point(20, 190);
            this.txtDescCat.Multiline = true;
            this.txtDescCat.Name = "txtDescCat";
            this.txtDescCat.Size = new System.Drawing.Size(290, 90);
            this.txtDescCat.TabIndex = 4;
            // 
            // lblDescCat
            // 
            this.lblDescCat.AutoSize = true;
            this.lblDescCat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescCat.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblDescCat.Location = new System.Drawing.Point(16, 160);
            this.lblDescCat.Name = "lblDescCat";
            this.lblDescCat.Size = new System.Drawing.Size(100, 21);
            this.lblDescCat.TabIndex = 3;
            this.lblDescCat.Text = "Descripción:";
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCat.Location = new System.Drawing.Point(20, 110);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(290, 30);
            this.txtNombreCat.TabIndex = 2;
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreCat.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblNombreCat.Location = new System.Drawing.Point(16, 80);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(75, 21);
            this.lblNombreCat.TabIndex = 1;
            this.lblNombreCat.Text = "Nombre:";
            // 
            // lblTitCat
            // 
            this.lblTitCat.AutoSize = true;
            this.lblTitCat.Font = new System.Drawing.Font("Segoe UI Bold", 13F);
            this.lblTitCat.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitCat.Location = new System.Drawing.Point(16, 25);
            this.lblTitCat.Name = "lblTitCat";
            this.lblTitCat.Size = new System.Drawing.Size(225, 30);
            this.lblTitCat.TabIndex = 0;
            this.lblTitCat.Text = "Gestionar Categoría";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashInfo);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(890, 620);
            this.pnlDashboard.TabIndex = 0;
            // 
            // lblDashInfo
            // 
            this.lblDashInfo.AutoSize = true;
            this.lblDashInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDashInfo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDashInfo.Location = new System.Drawing.Point(30, 30);
            this.lblDashInfo.Name = "lblDashInfo";
            this.lblDashInfo.Size = new System.Drawing.Size(425, 28);
            this.lblDashInfo.TabIndex = 0;
            this.lblDashInfo.Text = "Bienvenido al Sistema de Gestión de Inventario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 680);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.pnlCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.pnlFormCategoria.ResumeLayout(false);
            this.pnlFormCategoria.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSubtituloBrand;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavCategorias;
        private System.Windows.Forms.Button btnNavSuplidores;
        private System.Windows.Forms.Button btnNavProductos;
        private System.Windows.Forms.Button btnNavPapelera;
        private System.Windows.Forms.Button btnNavReportes;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashInfo;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.Panel pnlFormCategoria;
        private System.Windows.Forms.Label lblTitCat;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Label lblDescCat;
        private System.Windows.Forms.TextBox txtDescCat;
        private System.Windows.Forms.Button btnGuardarCat;
        private System.Windows.Forms.Button btnLimpiarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}