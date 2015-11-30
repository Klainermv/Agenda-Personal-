namespace AgendaPersonal2
{
    partial class RegistroPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonaIdtextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.ApellidostextBox = new System.Windows.Forms.TextBox();
            this.TelefonostextBox = new System.Windows.Forms.TextBox();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.EstadoCivilcomboBox = new System.Windows.Forms.ComboBox();
            this.DetallesdataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PersonaId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefonos";
            // 
            // PersonaIdtextBox
            // 
            this.PersonaIdtextBox.Location = new System.Drawing.Point(112, 9);
            this.PersonaIdtextBox.Name = "PersonaIdtextBox";
            this.PersonaIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.PersonaIdtextBox.TabIndex = 5;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(112, 38);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(100, 20);
            this.NombrestextBox.TabIndex = 6;
            // 
            // ApellidostextBox
            // 
            this.ApellidostextBox.Location = new System.Drawing.Point(112, 76);
            this.ApellidostextBox.Name = "ApellidostextBox";
            this.ApellidostextBox.Size = new System.Drawing.Size(100, 20);
            this.ApellidostextBox.TabIndex = 7;
            // 
            // TelefonostextBox
            // 
            this.TelefonostextBox.Location = new System.Drawing.Point(112, 156);
            this.TelefonostextBox.Name = "TelefonostextBox";
            this.TelefonostextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonostextBox.TabIndex = 9;
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(70, 350);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton.TabIndex = 10;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(269, 350);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(168, 350);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(267, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // EstadoCivilcomboBox
            // 
            this.EstadoCivilcomboBox.FormattingEnabled = true;
            this.EstadoCivilcomboBox.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Otro(a)"});
            this.EstadoCivilcomboBox.Location = new System.Drawing.Point(112, 114);
            this.EstadoCivilcomboBox.Name = "EstadoCivilcomboBox";
            this.EstadoCivilcomboBox.Size = new System.Drawing.Size(121, 21);
            this.EstadoCivilcomboBox.TabIndex = 14;
            // 
            // DetallesdataGridView
            // 
            this.DetallesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefono});
            this.DetallesdataGridView.Location = new System.Drawing.Point(30, 187);
            this.DetallesdataGridView.Name = "DetallesdataGridView";
            this.DetallesdataGridView.Size = new System.Drawing.Size(368, 157);
            this.DetallesdataGridView.TabIndex = 15;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(323, 158);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 16;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // RegistroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 380);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.DetallesdataGridView);
            this.Controls.Add(this.EstadoCivilcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.TelefonostextBox);
            this.Controls.Add(this.ApellidostextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.PersonaIdtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPersona";
            this.Text = "RegistroPersona";
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PersonaIdtextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox ApellidostextBox;
        private System.Windows.Forms.TextBox TelefonostextBox;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox EstadoCivilcomboBox;
        private System.Windows.Forms.DataGridView DetallesdataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}