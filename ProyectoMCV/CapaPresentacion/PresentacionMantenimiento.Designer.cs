namespace CapaPresentacion
{
    partial class PresentacionMantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionMantenimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigp = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.DataGrivViewDatos = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEMp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mantenimiento de Datos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigp
            // 
            this.txtCodigp.Location = new System.Drawing.Point(133, 66);
            this.txtCodigp.Name = "txtCodigp";
            this.txtCodigp.Size = new System.Drawing.Size(100, 20);
            this.txtCodigp.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(133, 171);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(133, 221);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(133, 280);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 4;
            // 
            // DataGrivViewDatos
            // 
            this.DataGrivViewDatos.AllowUserToAddRows = false;
            this.DataGrivViewDatos.AllowUserToDeleteRows = false;
            this.DataGrivViewDatos.AllowUserToResizeColumns = false;
            this.DataGrivViewDatos.AllowUserToResizeRows = false;
            this.DataGrivViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrivViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrivViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.nomEMp,
            this.edadEmp,
            this.sexoEmp,
            this.sueldoEmp,
            this.Eliminar,
            this.Editar});
            this.DataGrivViewDatos.Location = new System.Drawing.Point(273, 66);
            this.DataGrivViewDatos.Name = "DataGrivViewDatos";
            this.DataGrivViewDatos.Size = new System.Drawing.Size(941, 435);
            this.DataGrivViewDatos.TabIndex = 11;
            this.DataGrivViewDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrivViewDatos_CellContentClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(37, 376);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(163, 39);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(37, 462);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // codEmp
            // 
            this.codEmp.DataPropertyName = "codEmp";
            this.codEmp.HeaderText = "Codigo";
            this.codEmp.Name = "codEmp";
            this.codEmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nomEMp
            // 
            this.nomEMp.DataPropertyName = "nomEMp";
            this.nomEMp.HeaderText = "Nombre";
            this.nomEMp.Name = "nomEMp";
            // 
            // edadEmp
            // 
            this.edadEmp.DataPropertyName = "edadEmp";
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle31.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle31.NullValue")));
            dataGridViewCellStyle31.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.Line_ui_icons_Svg_03_icon_icons_com_72170;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle32.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle32.NullValue")));
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.descarga;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle29.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle29.NullValue")));
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle29;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaPresentacion.Properties.Resources.Line_ui_icons_Svg_03_icon_icons_com_72170;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 50;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle30.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle30.NullValue")));
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Editar.DefaultCellStyle = dataGridViewCellStyle30;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.descarga;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 50;
            // 
            // PresentacionMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1238, 533);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.DataGrivViewDatos);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCodigp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PresentacionMantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.PresentacionMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigp;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DataGridView DataGrivViewDatos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEMp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}