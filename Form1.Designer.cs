namespace Atividade2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.rdbtnFem = new System.Windows.Forms.RadioButton();
            this.rdbtnMasc = new System.Windows.Forms.RadioButton();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.grpbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.txtAltura);
            this.grpbxSexo.Controls.Add(this.txtPeso);
            this.grpbxSexo.Controls.Add(this.lblAltura);
            this.grpbxSexo.Controls.Add(this.lblPeso);
            this.grpbxSexo.Controls.Add(this.rdbtnMasc);
            this.grpbxSexo.Controls.Add(this.rdbtnFem);
            this.grpbxSexo.Location = new System.Drawing.Point(35, 23);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Size = new System.Drawing.Size(200, 159);
            this.grpbxSexo.TabIndex = 0;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "groupBox1";
            // 
            // rdbtnFem
            // 
            this.rdbtnFem.AutoSize = true;
            this.rdbtnFem.Location = new System.Drawing.Point(7, 20);
            this.rdbtnFem.Name = "rdbtnFem";
            this.rdbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdbtnFem.TabIndex = 0;
            this.rdbtnFem.TabStop = true;
            this.rdbtnFem.Text = "Feminino";
            this.rdbtnFem.UseVisualStyleBackColor = true;
            // 
            // rdbtnMasc
            // 
            this.rdbtnMasc.AutoSize = true;
            this.rdbtnMasc.Location = new System.Drawing.Point(7, 44);
            this.rdbtnMasc.Name = "rdbtnMasc";
            this.rdbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbtnMasc.TabIndex = 1;
            this.rdbtnMasc.TabStop = true;
            this.rdbtnMasc.Text = "Masculino";
            this.rdbtnMasc.UseVisualStyleBackColor = true;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(7, 68);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(4, 102);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(78, 68);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(78, 102);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(113, 221);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 1;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.grpbxSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.RadioButton rdbtnMasc;
        private System.Windows.Forms.RadioButton rdbtnFem;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnResultado;
    }
}

