namespace ejercicioTelegrama
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
            this.txtTelegrama = new System.Windows.Forms.RichTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rbOrdinario = new System.Windows.Forms.RadioButton();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(54, 33);
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(379, 103);
            this.txtTelegrama.TabIndex = 0;
            this.txtTelegrama.Text = "";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(94, 189);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(67, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(43, 193);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Coste:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbOrdinario
            // 
            this.rbOrdinario.AutoSize = true;
            this.rbOrdinario.Checked = true;
            this.rbOrdinario.Location = new System.Drawing.Point(6, 8);
            this.rbOrdinario.Name = "rbOrdinario";
            this.rbOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rbOrdinario.TabIndex = 6;
            this.rbOrdinario.TabStop = true;
            this.rbOrdinario.Text = "Ordinario";
            this.rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(79, 8);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbUrgente.TabIndex = 7;
            this.rbUrgente.TabStop = true;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrdinario);
            this.groupBox1.Controls.Add(this.rbUrgente);
            this.groupBox1.Location = new System.Drawing.Point(54, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 30);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTelegrama;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RadioButton rbOrdinario;
        private System.Windows.Forms.RadioButton rbUrgente;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

