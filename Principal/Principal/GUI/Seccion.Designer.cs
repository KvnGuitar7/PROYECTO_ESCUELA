namespace Principal.GUI
{
    partial class Seccion
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
            this.dataGridViewseccion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtseccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownalumnos = new System.Windows.Forms.NumericUpDown();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewseccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewseccion
            // 
            this.dataGridViewseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewseccion.Location = new System.Drawing.Point(12, 189);
            this.dataGridViewseccion.Name = "dataGridViewseccion";
            this.dataGridViewseccion.Size = new System.Drawing.Size(264, 150);
            this.dataGridViewseccion.TabIndex = 79;
            this.dataGridViewseccion.DoubleClick += new System.EventHandler(this.dataGridViewseccion_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Seccion";
            // 
            // txtseccion
            // 
            this.txtseccion.Location = new System.Drawing.Point(82, 44);
            this.txtseccion.Name = "txtseccion";
            this.txtseccion.Size = new System.Drawing.Size(100, 20);
            this.txtseccion.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 84;
            this.label2.Text = "Alumnos";
            // 
            // numericUpDownalumnos
            // 
            this.numericUpDownalumnos.Location = new System.Drawing.Point(110, 90);
            this.numericUpDownalumnos.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numericUpDownalumnos.Minimum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numericUpDownalumnos.Name = "numericUpDownalumnos";
            this.numericUpDownalumnos.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownalumnos.TabIndex = 85;
            this.numericUpDownalumnos.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Image = global::Principal.Properties.Resources.error;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(164, 129);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(36, 54);
            this.btnsalir.TabIndex = 82;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = global::Principal.Properties.Resources.edit;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.Location = new System.Drawing.Point(103, 129);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(48, 54);
            this.btnmodificar.TabIndex = 81;
            this.btnmodificar.Text = "Editar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.Image = global::Principal.Properties.Resources.save1;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardar.Location = new System.Drawing.Point(43, 129);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(54, 54);
            this.btnguardar.TabIndex = 80;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Seccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 377);
            this.Controls.Add(this.numericUpDownalumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridViewseccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtseccion);
            this.Name = "Seccion";
            this.Text = "Seccion";
            this.Load += new System.EventHandler(this.Seccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewseccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownalumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dataGridViewseccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownalumnos;
    }
}