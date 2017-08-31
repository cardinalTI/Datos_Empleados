namespace Datos_Empleados
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeSalarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasDeBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNIempleados = new System.Windows.Forms.Button();
            this.BTNGempleadostxt = new System.Windows.Forms.Button();
            this.DGVAempleados = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_alta_empleados = new System.Windows.Forms.Panel();
            this.panel_baja_empleados = new System.Windows.Forms.Panel();
            this.CBXbajas = new System.Windows.Forms.ComboBox();
            this.DGVbajas = new System.Windows.Forms.DataGridView();
            this.BTNBbajas = new System.Windows.Forms.Button();
            this.BTNIbajas = new System.Windows.Forms.Button();
            this.panel_salario = new System.Windows.Forms.Panel();
            this.BTNAsueldos = new System.Windows.Forms.Button();
            this.CBXAsueldos = new System.Windows.Forms.ComboBox();
            this.DGVAsueldo = new System.Windows.Forms.DataGridView();
            this.BTNIsueldos = new System.Windows.Forms.Button();
            this.panel_cuentas = new System.Windows.Forms.Panel();
            this.DGVcuentas = new System.Windows.Forms.DataGridView();
            this.CBXcuentas = new System.Windows.Forms.ComboBox();
            this.BTNAcuentas = new System.Windows.Forms.Button();
            this.BTNIcuentas = new System.Windows.Forms.Button();
            this.panel_departamento = new System.Windows.Forms.Panel();
            this.DGVIdepartamento = new System.Windows.Forms.DataGridView();
            this.CBXDepto = new System.Windows.Forms.ComboBox();
            this.BTNIdepartamentos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAempleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_alta_empleados.SuspendLayout();
            this.panel_baja_empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVbajas)).BeginInit();
            this.panel_salario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsueldo)).BeginInit();
            this.panel_cuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcuentas)).BeginInit();
            this.panel_departamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIdepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.salarioToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(93, 428);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.AutoSize = false;
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.bajaEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Image = global::Datos_Empleados.Properties.Resources.empleado__1_;
            this.empleadosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.empleadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(90, 90);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.empleadosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.datosToolStripMenuItem.Text = "Agregar Empleados";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // bajaEmpleadosToolStripMenuItem
            // 
            this.bajaEmpleadosToolStripMenuItem.Name = "bajaEmpleadosToolStripMenuItem";
            this.bajaEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.bajaEmpleadosToolStripMenuItem.Text = "Baja empleados";
            this.bajaEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.bajaEmpleadosToolStripMenuItem_Click);
            // 
            // salarioToolStripMenuItem
            // 
            this.salarioToolStripMenuItem.AutoSize = false;
            this.salarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeSalarioToolStripMenuItem,
            this.cuentasDeBancoToolStripMenuItem});
            this.salarioToolStripMenuItem.Image = global::Datos_Empleados.Properties.Resources.simbolo_de_dolar;
            this.salarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salarioToolStripMenuItem.Name = "salarioToolStripMenuItem";
            this.salarioToolStripMenuItem.Size = new System.Drawing.Size(90, 90);
            this.salarioToolStripMenuItem.Text = "Pagos";
            this.salarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cambioDeSalarioToolStripMenuItem
            // 
            this.cambioDeSalarioToolStripMenuItem.Name = "cambioDeSalarioToolStripMenuItem";
            this.cambioDeSalarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cambioDeSalarioToolStripMenuItem.Text = "Cambio de salario";
            this.cambioDeSalarioToolStripMenuItem.Click += new System.EventHandler(this.cambioDeSalarioToolStripMenuItem_Click);
            // 
            // cuentasDeBancoToolStripMenuItem
            // 
            this.cuentasDeBancoToolStripMenuItem.Name = "cuentasDeBancoToolStripMenuItem";
            this.cuentasDeBancoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cuentasDeBancoToolStripMenuItem.Text = "Cuentas de Banco";
            this.cuentasDeBancoToolStripMenuItem.Click += new System.EventHandler(this.cuentasDeBancoToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.AutoSize = false;
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDepartamentoToolStripMenuItem,
            this.agregarPuestoToolStripMenuItem});
            this.empresaToolStripMenuItem.Image = global::Datos_Empleados.Properties.Resources.carpeta;
            this.empresaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.empresaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(90, 90);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // agregarDepartamentoToolStripMenuItem
            // 
            this.agregarDepartamentoToolStripMenuItem.Name = "agregarDepartamentoToolStripMenuItem";
            this.agregarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.agregarDepartamentoToolStripMenuItem.Text = "Agregar Departamento";
            this.agregarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.agregarDepartamentoToolStripMenuItem_Click);
            // 
            // agregarPuestoToolStripMenuItem
            // 
            this.agregarPuestoToolStripMenuItem.Name = "agregarPuestoToolStripMenuItem";
            this.agregarPuestoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.agregarPuestoToolStripMenuItem.Text = "Agregar Puesto";
            // 
            // BTNIempleados
            // 
            this.BTNIempleados.Location = new System.Drawing.Point(13, 12);
            this.BTNIempleados.Name = "BTNIempleados";
            this.BTNIempleados.Size = new System.Drawing.Size(166, 23);
            this.BTNIempleados.TabIndex = 0;
            this.BTNIempleados.Text = "Importar Datos Excel";
            this.BTNIempleados.UseVisualStyleBackColor = true;
            this.BTNIempleados.Click += new System.EventHandler(this.BTNIempleados_Click);
            // 
            // BTNGempleadostxt
            // 
            this.BTNGempleadostxt.Location = new System.Drawing.Point(218, 12);
            this.BTNGempleadostxt.Name = "BTNGempleadostxt";
            this.BTNGempleadostxt.Size = new System.Drawing.Size(166, 23);
            this.BTNGempleadostxt.TabIndex = 1;
            this.BTNGempleadostxt.Text = "Generar el archivo TXT";
            this.BTNGempleadostxt.UseVisualStyleBackColor = true;
            this.BTNGempleadostxt.Click += new System.EventHandler(this.BTNGempleadostxt_Click);
            // 
            // DGVAempleados
            // 
            this.DGVAempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAempleados.Location = new System.Drawing.Point(13, 42);
            this.DGVAempleados.Name = "DGVAempleados";
            this.DGVAempleados.Size = new System.Drawing.Size(790, 365);
            this.DGVAempleados.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(920, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(15, 32);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "mensaje";
            this.Column1.Name = "Column1";
            // 
            // panel_alta_empleados
            // 
            this.panel_alta_empleados.Controls.Add(this.DGVAempleados);
            this.panel_alta_empleados.Controls.Add(this.BTNGempleadostxt);
            this.panel_alta_empleados.Controls.Add(this.BTNIempleados);
            this.panel_alta_empleados.Location = new System.Drawing.Point(106, 12);
            this.panel_alta_empleados.Name = "panel_alta_empleados";
            this.panel_alta_empleados.Size = new System.Drawing.Size(808, 413);
            this.panel_alta_empleados.TabIndex = 1;
            // 
            // panel_baja_empleados
            // 
            this.panel_baja_empleados.Controls.Add(this.CBXbajas);
            this.panel_baja_empleados.Controls.Add(this.DGVbajas);
            this.panel_baja_empleados.Controls.Add(this.BTNBbajas);
            this.panel_baja_empleados.Controls.Add(this.BTNIbajas);
            this.panel_baja_empleados.Location = new System.Drawing.Point(106, 0);
            this.panel_baja_empleados.Name = "panel_baja_empleados";
            this.panel_baja_empleados.Size = new System.Drawing.Size(808, 425);
            this.panel_baja_empleados.TabIndex = 3;
            // 
            // CBXbajas
            // 
            this.CBXbajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXbajas.FormattingEnabled = true;
            this.CBXbajas.Items.AddRange(new object[] {
            "FOLDUR",
            "MORGET",
            "GRUPO CONISAL",
            "WIPSI",
            "IT TELECOM",
            "MORGET SEMANAL",
            "MORGET CATORCENAL",
            "MORGET QUINCENAL",
            "MORGET MENSUAL",
            "MORGET INTERNA",
            "AICEL",
            "NUBULA",
            "CONSORCIO ATERAP SA DE CV",
            "CROTEC SA DE CV",
            "PEPSAT SA DE CV",
            "INFORMATION THECNOLOGY",
            "UPHETILOLI 2"});
            this.CBXbajas.Location = new System.Drawing.Point(163, 25);
            this.CBXbajas.Name = "CBXbajas";
            this.CBXbajas.Size = new System.Drawing.Size(200, 21);
            this.CBXbajas.TabIndex = 3;
            // 
            // DGVbajas
            // 
            this.DGVbajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVbajas.Location = new System.Drawing.Point(13, 53);
            this.DGVbajas.Name = "DGVbajas";
            this.DGVbajas.Size = new System.Drawing.Size(790, 366);
            this.DGVbajas.TabIndex = 2;
            // 
            // BTNBbajas
            // 
            this.BTNBbajas.Location = new System.Drawing.Point(369, 25);
            this.BTNBbajas.Name = "BTNBbajas";
            this.BTNBbajas.Size = new System.Drawing.Size(155, 23);
            this.BTNBbajas.TabIndex = 1;
            this.BTNBbajas.Text = "Dar Empleados de Baja";
            this.BTNBbajas.UseVisualStyleBackColor = true;
            this.BTNBbajas.Click += new System.EventHandler(this.BTNBbajas_Click);
            // 
            // BTNIbajas
            // 
            this.BTNIbajas.Location = new System.Drawing.Point(13, 24);
            this.BTNIbajas.Name = "BTNIbajas";
            this.BTNIbajas.Size = new System.Drawing.Size(143, 23);
            this.BTNIbajas.TabIndex = 0;
            this.BTNIbajas.Text = "Importar Bajas de Excel";
            this.BTNIbajas.UseVisualStyleBackColor = true;
            this.BTNIbajas.Click += new System.EventHandler(this.BTNIbajas_Click);
            // 
            // panel_salario
            // 
            this.panel_salario.Controls.Add(this.BTNAsueldos);
            this.panel_salario.Controls.Add(this.CBXAsueldos);
            this.panel_salario.Controls.Add(this.DGVAsueldo);
            this.panel_salario.Controls.Add(this.BTNIsueldos);
            this.panel_salario.Location = new System.Drawing.Point(106, 0);
            this.panel_salario.Name = "panel_salario";
            this.panel_salario.Size = new System.Drawing.Size(808, 425);
            this.panel_salario.TabIndex = 4;
            // 
            // BTNAsueldos
            // 
            this.BTNAsueldos.Location = new System.Drawing.Point(442, 23);
            this.BTNAsueldos.Name = "BTNAsueldos";
            this.BTNAsueldos.Size = new System.Drawing.Size(169, 23);
            this.BTNAsueldos.TabIndex = 3;
            this.BTNAsueldos.Text = "Actualizar los Salarios";
            this.BTNAsueldos.UseVisualStyleBackColor = true;
            this.BTNAsueldos.Click += new System.EventHandler(this.BTNAsueldos_Click);
            // 
            // CBXAsueldos
            // 
            this.CBXAsueldos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXAsueldos.FormattingEnabled = true;
            this.CBXAsueldos.Items.AddRange(new object[] {
            "FOLDUR",
            "MORGET",
            "GRUPO CONISAL",
            "WIPSI",
            "IT TELECOM",
            "MORGET SEMANAL",
            "MORGET CATORCENAL",
            "MORGET QUINCENAL",
            "MORGET MENSUAL",
            "MORGET INTERNA",
            "AICEL",
            "NUBULA",
            "CONSORCIO ATERAP SA DE CV",
            "CROTEC SA DE CV",
            "PEPSAT SA DE CV",
            "INFORMATION THECNOLOGY",
            "UPHETILOLI 2"});
            this.CBXAsueldos.Location = new System.Drawing.Point(193, 23);
            this.CBXAsueldos.Name = "CBXAsueldos";
            this.CBXAsueldos.Size = new System.Drawing.Size(233, 21);
            this.CBXAsueldos.TabIndex = 2;
            // 
            // DGVAsueldo
            // 
            this.DGVAsueldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAsueldo.Location = new System.Drawing.Point(13, 52);
            this.DGVAsueldo.Name = "DGVAsueldo";
            this.DGVAsueldo.Size = new System.Drawing.Size(780, 367);
            this.DGVAsueldo.TabIndex = 1;
            // 
            // BTNIsueldos
            // 
            this.BTNIsueldos.Location = new System.Drawing.Point(13, 23);
            this.BTNIsueldos.Name = "BTNIsueldos";
            this.BTNIsueldos.Size = new System.Drawing.Size(174, 23);
            this.BTNIsueldos.TabIndex = 0;
            this.BTNIsueldos.Text = "Importar Sueldos de Excel";
            this.BTNIsueldos.UseVisualStyleBackColor = true;
            this.BTNIsueldos.Click += new System.EventHandler(this.BTNIsueldos_Click);
            // 
            // panel_cuentas
            // 
            this.panel_cuentas.Controls.Add(this.DGVcuentas);
            this.panel_cuentas.Controls.Add(this.CBXcuentas);
            this.panel_cuentas.Controls.Add(this.BTNAcuentas);
            this.panel_cuentas.Controls.Add(this.BTNIcuentas);
            this.panel_cuentas.Location = new System.Drawing.Point(106, 0);
            this.panel_cuentas.Name = "panel_cuentas";
            this.panel_cuentas.Size = new System.Drawing.Size(808, 425);
            this.panel_cuentas.TabIndex = 5;
            // 
            // DGVcuentas
            // 
            this.DGVcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcuentas.Location = new System.Drawing.Point(13, 52);
            this.DGVcuentas.Name = "DGVcuentas";
            this.DGVcuentas.Size = new System.Drawing.Size(772, 365);
            this.DGVcuentas.TabIndex = 3;
            // 
            // CBXcuentas
            // 
            this.CBXcuentas.FormattingEnabled = true;
            this.CBXcuentas.Items.AddRange(new object[] {
            "FOLDUR",
            "MORGET",
            "GRUPO CONISAL",
            "WIPSI",
            "IT TELECOM",
            "MORGET SEMANAL",
            "MORGET CATORCENAL",
            "MORGET QUINCENAL",
            "MORGET MENSUAL",
            "MORGET INTERNA",
            "AICEL",
            "NUBULA",
            "CONSORCIO ATERAP SA DE CV",
            "CROTEC SA DE CV",
            "PEPSAT SA DE CV",
            "INFORMATION THECNOLOGY",
            "UPHETILOLI 2"});
            this.CBXcuentas.Location = new System.Drawing.Point(242, 21);
            this.CBXcuentas.Name = "CBXcuentas";
            this.CBXcuentas.Size = new System.Drawing.Size(234, 21);
            this.CBXcuentas.TabIndex = 2;
            // 
            // BTNAcuentas
            // 
            this.BTNAcuentas.Location = new System.Drawing.Point(495, 19);
            this.BTNAcuentas.Name = "BTNAcuentas";
            this.BTNAcuentas.Size = new System.Drawing.Size(191, 23);
            this.BTNAcuentas.TabIndex = 1;
            this.BTNAcuentas.Text = "Actualizar Cuentas Bancarias";
            this.BTNAcuentas.UseVisualStyleBackColor = true;
            this.BTNAcuentas.Click += new System.EventHandler(this.BTNAcuentas_Click);
            // 
            // BTNIcuentas
            // 
            this.BTNIcuentas.Location = new System.Drawing.Point(13, 21);
            this.BTNIcuentas.Name = "BTNIcuentas";
            this.BTNIcuentas.Size = new System.Drawing.Size(212, 23);
            this.BTNIcuentas.TabIndex = 0;
            this.BTNIcuentas.Text = "Importar Cuentas Bancarias de Excel";
            this.BTNIcuentas.UseVisualStyleBackColor = true;
            this.BTNIcuentas.Click += new System.EventHandler(this.BTNIcuentas_Click);
            // 
            // panel_departamento
            // 
            this.panel_departamento.Controls.Add(this.DGVIdepartamento);
            this.panel_departamento.Controls.Add(this.CBXDepto);
            this.panel_departamento.Controls.Add(this.BTNIdepartamentos);
            this.panel_departamento.Controls.Add(this.button1);
            this.panel_departamento.Location = new System.Drawing.Point(106, 0);
            this.panel_departamento.Name = "panel_departamento";
            this.panel_departamento.Size = new System.Drawing.Size(808, 428);
            this.panel_departamento.TabIndex = 6;
            // 
            // DGVIdepartamento
            // 
            this.DGVIdepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIdepartamento.Location = new System.Drawing.Point(13, 67);
            this.DGVIdepartamento.Name = "DGVIdepartamento";
            this.DGVIdepartamento.Size = new System.Drawing.Size(780, 349);
            this.DGVIdepartamento.TabIndex = 3;
            // 
            // CBXDepto
            // 
            this.CBXDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXDepto.FormattingEnabled = true;
            this.CBXDepto.Items.AddRange(new object[] {
            "FOLDUR",
            "MORGET",
            "GRUPO CONISAL",
            "WIPSI",
            "IT TELECOM",
            "MORGET SEMANAL",
            "MORGET CATORCENAL",
            "MORGET QUINCENAL",
            "MORGET MENSUAL",
            "MORGET INTERNA",
            "AICEL",
            "NUBULA",
            "CONSORCIO ATERAP SA DE CV",
            "CROTEC SA DE CV",
            "PEPSAT SA DE CV",
            "INFORMATION THECNOLOGY",
            "UPHETILOLI 2"});
            this.CBXDepto.Location = new System.Drawing.Point(218, 37);
            this.CBXDepto.Name = "CBXDepto";
            this.CBXDepto.Size = new System.Drawing.Size(221, 21);
            this.CBXDepto.TabIndex = 2;
            // 
            // BTNIdepartamentos
            // 
            this.BTNIdepartamentos.Location = new System.Drawing.Point(445, 37);
            this.BTNIdepartamentos.Name = "BTNIdepartamentos";
            this.BTNIdepartamentos.Size = new System.Drawing.Size(169, 23);
            this.BTNIdepartamentos.TabIndex = 1;
            this.BTNIdepartamentos.Text = "Agregar Departamentos";
            this.BTNIdepartamentos.UseVisualStyleBackColor = true;
            this.BTNIdepartamentos.Click += new System.EventHandler(this.BTNIdepartamentos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Importar Departamentos de Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 428);
            this.Controls.Add(this.panel_departamento);
            this.Controls.Add(this.panel_cuentas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_salario);
            this.Controls.Add(this.panel_baja_empleados);
            this.Controls.Add(this.panel_alta_empleados);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Datos de Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAempleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_alta_empleados.ResumeLayout(false);
            this.panel_baja_empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVbajas)).EndInit();
            this.panel_salario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsueldo)).EndInit();
            this.panel_cuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcuentas)).EndInit();
            this.panel_departamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVIdepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeSalarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasDeBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPuestoToolStripMenuItem;
        private System.Windows.Forms.Button BTNIempleados;
        private System.Windows.Forms.Button BTNGempleadostxt;
        private System.Windows.Forms.DataGridView DGVAempleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel_alta_empleados;
        private System.Windows.Forms.Panel panel_baja_empleados;
        private System.Windows.Forms.DataGridView DGVbajas;
        private System.Windows.Forms.Button BTNBbajas;
        private System.Windows.Forms.Button BTNIbajas;
        private System.Windows.Forms.ComboBox CBXbajas;
        private System.Windows.Forms.Panel panel_salario;
        private System.Windows.Forms.Button BTNIsueldos;
        private System.Windows.Forms.DataGridView DGVAsueldo;
        private System.Windows.Forms.Button BTNAsueldos;
        private System.Windows.Forms.ComboBox CBXAsueldos;
        private System.Windows.Forms.Panel panel_cuentas;
        private System.Windows.Forms.DataGridView DGVcuentas;
        private System.Windows.Forms.ComboBox CBXcuentas;
        private System.Windows.Forms.Button BTNAcuentas;
        private System.Windows.Forms.Button BTNIcuentas;
        private System.Windows.Forms.Panel panel_departamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGVIdepartamento;
        private System.Windows.Forms.ComboBox CBXDepto;
        private System.Windows.Forms.Button BTNIdepartamentos;
    }
}

