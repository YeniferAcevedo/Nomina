namespace NominaEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.btbCalcularSalarioFinal = new System.Windows.Forms.Button();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblSalarioFinal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nómina por Antigüedad";
            // 
            // btbCalcularSalarioFinal
            // 
            this.btbCalcularSalarioFinal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btbCalcularSalarioFinal.Font = new System.Drawing.Font("Arial", 12F);
            this.btbCalcularSalarioFinal.Location = new System.Drawing.Point(20, 180);
            this.btbCalcularSalarioFinal.Name = "btbCalcularSalarioFinal";
            this.btbCalcularSalarioFinal.Size = new System.Drawing.Size(169, 30);
            this.btbCalcularSalarioFinal.TabIndex = 1;
            this.btbCalcularSalarioFinal.Text = "Calcular Salario Final";
            this.btbCalcularSalarioFinal.UseVisualStyleBackColor = false;
            this.btbCalcularSalarioFinal.Click += new System.EventHandler(this.btbCalcularSalarioFinal_Click);
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSalarioBase.Font = new System.Drawing.Font("Arial", 14F);
            this.txtSalarioBase.Location = new System.Drawing.Point(218, 77);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 29);
            this.txtSalarioBase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese sus años de antigüedad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese salario base:";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAntiguedad.Font = new System.Drawing.Font("Arial", 14F);
            this.txtAntiguedad.Location = new System.Drawing.Point(308, 126);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 29);
            this.txtAntiguedad.TabIndex = 5;
            // 
            // lblSalarioFinal
            // 
            this.lblSalarioFinal.AutoSize = true;
            this.lblSalarioFinal.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSalarioFinal.Location = new System.Drawing.Point(195, 187);
            this.lblSalarioFinal.Name = "lblSalarioFinal";
            this.lblSalarioFinal.Size = new System.Drawing.Size(21, 22);
            this.lblSalarioFinal.TabIndex = 6;
            this.lblSalarioFinal.Text = "0";
            this.lblSalarioFinal.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(423, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aumento según Antigüedad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Más de 10 años = 50%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "10 años = 45%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "7 años = 40%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "5 años = 30%";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(20, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 30);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 262);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSalarioFinal);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.btbCalcularSalarioFinal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nómina Empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbCalcularSalarioFinal;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Label lblSalarioFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

