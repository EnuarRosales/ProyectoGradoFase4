namespace PMA
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxDestino = new System.Windows.Forms.GroupBox();
            this.gboxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sistema Militar para la Administracion PMA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tienda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(30, 54);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(81, 23);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Habitaciones";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnCola
            // 
            this.btnCola.Location = new System.Drawing.Point(169, 54);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(75, 23);
            this.btnCola.TabIndex = 0;
            this.btnCola.Text = "Alimentacion";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enuar Emilio Rosales Salazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre Administrador";
            // 
            // gboxDestino
            // 
            this.gboxDestino.Controls.Add(this.button1);
            this.gboxDestino.Controls.Add(this.btnLista);
            this.gboxDestino.Controls.Add(this.btnCola);
            this.gboxDestino.Location = new System.Drawing.Point(32, 44);
            this.gboxDestino.Name = "gboxDestino";
            this.gboxDestino.Size = new System.Drawing.Size(415, 121);
            this.gboxDestino.TabIndex = 25;
            this.gboxDestino.TabStop = false;
            this.gboxDestino.Text = "Modulos del Programa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gboxDestino);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxDestino.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnLista;
        public System.Windows.Forms.Button btnCola;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gboxDestino;
    }
}

