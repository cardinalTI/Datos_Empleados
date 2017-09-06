namespace Datos_Empleados
{
    partial class Menu_Principal
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
            this.BTNreportes = new System.Windows.Forms.Button();
            this.BTNDempleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNreportes
            // 
            this.BTNreportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNreportes.Image = global::Datos_Empleados.Properties.Resources.analitica;
            this.BTNreportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNreportes.Location = new System.Drawing.Point(107, 2);
            this.BTNreportes.Name = "BTNreportes";
            this.BTNreportes.Size = new System.Drawing.Size(98, 83);
            this.BTNreportes.TabIndex = 1;
            this.BTNreportes.Text = "Reportes";
            this.BTNreportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNreportes.UseVisualStyleBackColor = true;
            this.BTNreportes.Click += new System.EventHandler(this.BTNreportes_Click);
            // 
            // BTNDempleados
            // 
            this.BTNDempleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNDempleados.Image = global::Datos_Empleados.Properties.Resources.carpeta1;
            this.BTNDempleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNDempleados.Location = new System.Drawing.Point(3, 2);
            this.BTNDempleados.Name = "BTNDempleados";
            this.BTNDempleados.Size = new System.Drawing.Size(98, 83);
            this.BTNDempleados.TabIndex = 0;
            this.BTNDempleados.Text = "Datos Empleados";
            this.BTNDempleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNDempleados.UseVisualStyleBackColor = true;
            this.BTNDempleados.Click += new System.EventHandler(this.BTNDempleados_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 91);
            this.Controls.Add(this.BTNreportes);
            this.Controls.Add(this.BTNDempleados);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNDempleados;
        private System.Windows.Forms.Button BTNreportes;
    }
}