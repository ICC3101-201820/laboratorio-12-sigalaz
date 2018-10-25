namespace Lab12_SebastianGalaz
{
    partial class Form1
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
            this.nombre_label1 = new System.Windows.Forms.Label();
            this.Proteinas_label = new System.Windows.Forms.Label();
            this.Grasas_label = new System.Windows.Forms.Label();
            this.Carbohidratos_label = new System.Windows.Forms.Label();
            this.Nombre_textBox1 = new System.Windows.Forms.TextBox();
            this.Proteinas_textBox1 = new System.Windows.Forms.TextBox();
            this.Grasas_textBox2 = new System.Windows.Forms.TextBox();
            this.Carbohidratos_textBox3 = new System.Windows.Forms.TextBox();
            this.Agregar_button1 = new System.Windows.Forms.Button();
            this.Listado_Comidas = new System.Windows.Forms.ListBox();
            this.EliminarSel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre_label1
            // 
            this.nombre_label1.AutoSize = true;
            this.nombre_label1.Location = new System.Drawing.Point(58, 36);
            this.nombre_label1.Name = "nombre_label1";
            this.nombre_label1.Size = new System.Drawing.Size(44, 13);
            this.nombre_label1.TabIndex = 0;
            this.nombre_label1.Text = "Nombre";
            // 
            // Proteinas_label
            // 
            this.Proteinas_label.AutoSize = true;
            this.Proteinas_label.Location = new System.Drawing.Point(58, 74);
            this.Proteinas_label.Name = "Proteinas_label";
            this.Proteinas_label.Size = new System.Drawing.Size(51, 13);
            this.Proteinas_label.TabIndex = 1;
            this.Proteinas_label.Text = "Proteinas";
            // 
            // Grasas_label
            // 
            this.Grasas_label.AutoSize = true;
            this.Grasas_label.Location = new System.Drawing.Point(58, 109);
            this.Grasas_label.Name = "Grasas_label";
            this.Grasas_label.Size = new System.Drawing.Size(40, 13);
            this.Grasas_label.TabIndex = 2;
            this.Grasas_label.Text = "Grasas";
            // 
            // Carbohidratos_label
            // 
            this.Carbohidratos_label.AutoSize = true;
            this.Carbohidratos_label.Location = new System.Drawing.Point(58, 141);
            this.Carbohidratos_label.Name = "Carbohidratos_label";
            this.Carbohidratos_label.Size = new System.Drawing.Size(72, 13);
            this.Carbohidratos_label.TabIndex = 3;
            this.Carbohidratos_label.Text = "Carbohidratos";
            this.Carbohidratos_label.Click += new System.EventHandler(this.Carbohidratos_label_Click);
            // 
            // Nombre_textBox1
            // 
            this.Nombre_textBox1.Location = new System.Drawing.Point(145, 33);
            this.Nombre_textBox1.Name = "Nombre_textBox1";
            this.Nombre_textBox1.Size = new System.Drawing.Size(100, 20);
            this.Nombre_textBox1.TabIndex = 4;
            // 
            // Proteinas_textBox1
            // 
            this.Proteinas_textBox1.Location = new System.Drawing.Point(145, 67);
            this.Proteinas_textBox1.Name = "Proteinas_textBox1";
            this.Proteinas_textBox1.Size = new System.Drawing.Size(100, 20);
            this.Proteinas_textBox1.TabIndex = 5;
            // 
            // Grasas_textBox2
            // 
            this.Grasas_textBox2.Location = new System.Drawing.Point(145, 102);
            this.Grasas_textBox2.Name = "Grasas_textBox2";
            this.Grasas_textBox2.Size = new System.Drawing.Size(100, 20);
            this.Grasas_textBox2.TabIndex = 6;
            // 
            // Carbohidratos_textBox3
            // 
            this.Carbohidratos_textBox3.Location = new System.Drawing.Point(145, 138);
            this.Carbohidratos_textBox3.Name = "Carbohidratos_textBox3";
            this.Carbohidratos_textBox3.Size = new System.Drawing.Size(100, 20);
            this.Carbohidratos_textBox3.TabIndex = 7;
            // 
            // Agregar_button1
            // 
            this.Agregar_button1.Location = new System.Drawing.Point(102, 185);
            this.Agregar_button1.Name = "Agregar_button1";
            this.Agregar_button1.Size = new System.Drawing.Size(75, 23);
            this.Agregar_button1.TabIndex = 8;
            this.Agregar_button1.Text = "Agregar";
            this.Agregar_button1.UseVisualStyleBackColor = true;
            this.Agregar_button1.Click += new System.EventHandler(this.Agregar_button1_Click);
            // 
            // Listado_Comidas
            // 
            this.Listado_Comidas.FormattingEnabled = true;
            this.Listado_Comidas.Location = new System.Drawing.Point(341, 33);
            this.Listado_Comidas.Name = "Listado_Comidas";
            this.Listado_Comidas.Size = new System.Drawing.Size(120, 95);
            this.Listado_Comidas.TabIndex = 9;
            // 
            // EliminarSel_button
            // 
            this.EliminarSel_button.Location = new System.Drawing.Point(341, 185);
            this.EliminarSel_button.Name = "EliminarSel_button";
            this.EliminarSel_button.Size = new System.Drawing.Size(161, 23);
            this.EliminarSel_button.TabIndex = 10;
            this.EliminarSel_button.Text = "Eliminar Seleccion";
            this.EliminarSel_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 586);
            this.Controls.Add(this.EliminarSel_button);
            this.Controls.Add(this.Listado_Comidas);
            this.Controls.Add(this.Agregar_button1);
            this.Controls.Add(this.Carbohidratos_textBox3);
            this.Controls.Add(this.Grasas_textBox2);
            this.Controls.Add(this.Proteinas_textBox1);
            this.Controls.Add(this.Nombre_textBox1);
            this.Controls.Add(this.Carbohidratos_label);
            this.Controls.Add(this.Grasas_label);
            this.Controls.Add(this.Proteinas_label);
            this.Controls.Add(this.nombre_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre_label1;
        private System.Windows.Forms.Label Proteinas_label;
        private System.Windows.Forms.Label Grasas_label;
        private System.Windows.Forms.Label Carbohidratos_label;
        private System.Windows.Forms.TextBox Nombre_textBox1;
        private System.Windows.Forms.TextBox Proteinas_textBox1;
        private System.Windows.Forms.TextBox Grasas_textBox2;
        private System.Windows.Forms.TextBox Carbohidratos_textBox3;
        private System.Windows.Forms.Button Agregar_button1;
        private System.Windows.Forms.ListBox Listado_Comidas;
        private System.Windows.Forms.Button EliminarSel_button;
    }
}

