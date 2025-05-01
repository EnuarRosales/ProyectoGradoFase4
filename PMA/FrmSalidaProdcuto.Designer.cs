namespace PMA
{
    partial class FrmSalidaProdcuto
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.numeroIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxTerapia = new System.Windows.Forms.GroupBox();
            this.rbClaseB = new System.Windows.Forms.RadioButton();
            this.rbClaseC = new System.Windows.Forms.RadioButton();
            this.rbClaseA = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboxDestino = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoConsutlta = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gboxTerapia.SuspendLayout();
            this.gboxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(782, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 26);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(662, 296);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(96, 20);
            this.txtEliminar.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvData
            // 
            this.dtgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroIdentificacion,
            this.nombreCompleto,
            this.Edad,
            this.tipoConsulta,
            this.fecha,
            this.tiempoEspera});
            this.dtgvData.Location = new System.Drawing.Point(30, 336);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.Size = new System.Drawing.Size(848, 263);
            this.dtgvData.TabIndex = 52;
            // 
            // numeroIdentificacion
            // 
            this.numeroIdentificacion.HeaderText = "Cedula";
            this.numeroIdentificacion.Name = "numeroIdentificacion";
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.Name = "nombreCompleto";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // tipoConsulta
            // 
            this.tipoConsulta.HeaderText = "Tipo Consulta";
            this.tipoConsulta.Name = "tipoConsulta";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // tiempoEspera
            // 
            this.tiempoEspera.HeaderText = "Tiempo Espera";
            this.tiempoEspera.Name = "tiempoEspera";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gboxTerapia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(463, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 213);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos salida tienda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "12000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Costo total";
            // 
            // gboxTerapia
            // 
            this.gboxTerapia.Controls.Add(this.rbClaseB);
            this.gboxTerapia.Controls.Add(this.rbClaseC);
            this.gboxTerapia.Controls.Add(this.rbClaseA);
            this.gboxTerapia.Location = new System.Drawing.Point(190, 19);
            this.gboxTerapia.Name = "gboxTerapia";
            this.gboxTerapia.Size = new System.Drawing.Size(219, 51);
            this.gboxTerapia.TabIndex = 31;
            this.gboxTerapia.TabStop = false;
            // 
            // rbClaseB
            // 
            this.rbClaseB.AutoSize = true;
            this.rbClaseB.Location = new System.Drawing.Point(59, 19);
            this.rbClaseB.Name = "rbClaseB";
            this.rbClaseB.Size = new System.Drawing.Size(39, 17);
            this.rbClaseB.TabIndex = 2;
            this.rbClaseB.Text = "No";
            this.rbClaseB.UseVisualStyleBackColor = true;
            // 
            // rbClaseC
            // 
            this.rbClaseC.AutoSize = true;
            this.rbClaseC.Location = new System.Drawing.Point(6, 65);
            this.rbClaseC.Name = "rbClaseC";
            this.rbClaseC.Size = new System.Drawing.Size(57, 17);
            this.rbClaseC.TabIndex = 1;
            this.rbClaseC.Text = "claseC";
            this.rbClaseC.UseVisualStyleBackColor = true;
            // 
            // rbClaseA
            // 
            this.rbClaseA.AutoSize = true;
            this.rbClaseA.Checked = true;
            this.rbClaseA.Location = new System.Drawing.Point(6, 19);
            this.rbClaseA.Name = "rbClaseA";
            this.rbClaseA.Size = new System.Drawing.Size(34, 17);
            this.rbClaseA.TabIndex = 0;
            this.rbClaseA.TabStop = true;
            this.rbClaseA.Text = "Si";
            this.rbClaseA.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Credito";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(190, 84);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(219, 20);
            this.dtpDay.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Venta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(552, 296);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // gboxDestino
            // 
            this.gboxDestino.Controls.Add(this.comboBox1);
            this.gboxDestino.Controls.Add(this.label3);
            this.gboxDestino.Controls.Add(this.cbxTipoConsutlta);
            this.gboxDestino.Controls.Add(this.textBox4);
            this.gboxDestino.Controls.Add(this.label6);
            this.gboxDestino.Controls.Add(this.txtCedula);
            this.gboxDestino.Controls.Add(this.label2);
            this.gboxDestino.Controls.Add(this.label4);
            this.gboxDestino.Location = new System.Drawing.Point(30, 60);
            this.gboxDestino.Name = "gboxDestino";
            this.gboxDestino.Size = new System.Drawing.Size(415, 213);
            this.gboxDestino.TabIndex = 50;
            this.gboxDestino.TabStop = false;
            this.gboxDestino.Text = "Datos salida tienda";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buchans",
            "Helado",
            "Galleta"});
            this.comboBox1.Location = new System.Drawing.Point(178, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Producto";
            // 
            // cbxTipoConsutlta
            // 
            this.cbxTipoConsutlta.FormattingEnabled = true;
            this.cbxTipoConsutlta.Items.AddRange(new object[] {
            "1-CP.Rosales Salazar Enuar"});
            this.cbxTipoConsutlta.Location = new System.Drawing.Point(178, 76);
            this.cbxTipoConsutlta.Name = "cbxTipoConsutlta";
            this.cbxTipoConsutlta.Size = new System.Drawing.Size(219, 21);
            this.cbxTipoConsutlta.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(178, 30);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(219, 20);
            this.txtCedula.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario";
            // 
            // FrmSalidaProdcuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 646);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxDestino);
            this.Name = "FrmSalidaProdcuto";
            this.Text = "FrmSalidaProdcuto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxTerapia.ResumeLayout(false);
            this.gboxTerapia.PerformLayout();
            this.gboxDestino.ResumeLayout(false);
            this.gboxDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEspera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxDestino;
        private System.Windows.Forms.ComboBox cbxTipoConsutlta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxTerapia;
        private System.Windows.Forms.RadioButton rbClaseB;
        private System.Windows.Forms.RadioButton rbClaseC;
        private System.Windows.Forms.RadioButton rbClaseA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}