namespace numerosAleatorios
{
    partial class Aleatorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_seguro = new System.Windows.Forms.CheckBox();
            this.tb_sueldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_mujer = new System.Windows.Forms.RadioButton();
            this.rb_hombre = new System.Windows.Forms.RadioButton();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(140, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_seguro);
            this.groupBox1.Controls.Add(this.tb_sueldo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_grupo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_mujer);
            this.groupBox1.Controls.Add(this.rb_hombre);
            this.groupBox1.Controls.Add(this.dtp_Fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Nombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.tb_Num);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 533);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generar datos aleatorios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_seguro
            // 
            this.cb_seguro.AutoSize = true;
            this.cb_seguro.Location = new System.Drawing.Point(94, 422);
            this.cb_seguro.Name = "cb_seguro";
            this.cb_seguro.Size = new System.Drawing.Size(133, 23);
            this.cb_seguro.TabIndex = 13;
            this.cb_seguro.Text = "Seguro médico";
            this.cb_seguro.UseVisualStyleBackColor = true;
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.Location = new System.Drawing.Point(94, 338);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.Size = new System.Drawing.Size(153, 27);
            this.tb_sueldo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sueldo";
            // 
            // cb_grupo
            // 
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cb_grupo.Location = new System.Drawing.Point(94, 304);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(121, 27);
            this.cb_grupo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grupo";
            // 
            // rb_mujer
            // 
            this.rb_mujer.AutoSize = true;
            this.rb_mujer.Location = new System.Drawing.Point(132, 247);
            this.rb_mujer.Name = "rb_mujer";
            this.rb_mujer.Size = new System.Drawing.Size(98, 23);
            this.rb_mujer.TabIndex = 8;
            this.rb_mujer.TabStop = true;
            this.rb_mujer.Text = "Femenino";
            this.rb_mujer.UseVisualStyleBackColor = true;
            // 
            // rb_hombre
            // 
            this.rb_hombre.AutoSize = true;
            this.rb_hombre.Location = new System.Drawing.Point(132, 201);
            this.rb_hombre.Name = "rb_hombre";
            this.rb_hombre.Size = new System.Drawing.Size(99, 23);
            this.rb_hombre.TabIndex = 7;
            this.rb_hombre.TabStop = true;
            this.rb_hombre.Text = "Masculino";
            this.rb_hombre.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(186, 155);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(304, 27);
            this.dtp_Fecha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(94, 95);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(195, 27);
            this.tb_Nombre.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(23, 95);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(63, 19);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // tb_Num
            // 
            this.tb_Num.Location = new System.Drawing.Point(94, 38);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(121, 27);
            this.tb_Num.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero";
            // 
            // Aleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Aleatorio";
            this.Text = "Empleado con datos aleatorios";
            this.Load += new System.EventHandler(this.Aleatorio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_mujer;
        private System.Windows.Forms.RadioButton rb_hombre;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_seguro;
        private System.Windows.Forms.TextBox tb_sueldo;
        private System.Windows.Forms.Button button1;
    }
}

