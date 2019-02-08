namespace CapaPresentacion
{
    partial class PresentacionEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionEmpleados));
            this.LblListaEMpleados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEMp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblListaEMpleados
            // 
            this.LblListaEMpleados.AutoSize = true;
            this.LblListaEMpleados.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaEMpleados.Location = new System.Drawing.Point(404, 24);
            this.LblListaEMpleados.Name = "LblListaEMpleados";
            this.LblListaEMpleados.Size = new System.Drawing.Size(215, 25);
            this.LblListaEMpleados.TabIndex = 0;
            this.LblListaEMpleados.Text = "Listado de Empleados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.NomEMp,
            this.edadEmp,
            this.sexoEmp,
            this.sueldoEmp});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1022, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // codEmp
            // 
            this.codEmp.DataPropertyName = "codEmp";
            this.codEmp.HeaderText = "Código";
            this.codEmp.Name = "codEmp";
            // 
            // NomEMp
            // 
            this.NomEMp.DataPropertyName = "nomEMp";
            this.NomEMp.HeaderText = "Nombre";
            this.NomEMp.Name = "NomEMp";
            // 
            // edadEmp
            // 
            this.edadEmp.DataPropertyName = "edadEMp";
            this.edadEmp.HeaderText = "Edad";
            this.edadEmp.Name = "edadEmp";
            // 
            // sexoEmp
            // 
            this.sexoEmp.DataPropertyName = "sexoEmp";
            this.sexoEmp.HeaderText = "Sexo";
            this.sexoEmp.Name = "sexoEmp";
            // 
            // sueldoEmp
            // 
            this.sueldoEmp.DataPropertyName = "sueldoEmp";
            this.sueldoEmp.HeaderText = "Sueldo";
            this.sueldoEmp.Name = "sueldoEmp";
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(841, 507);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(173, 32);
            this.btnMantenimiento.TabIndex = 2;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // PresentacionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 551);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblListaEMpleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PresentacionEmpleados";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.PresentacionEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblListaEMpleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEMp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
        private System.Windows.Forms.Button btnMantenimiento;
    }
}

