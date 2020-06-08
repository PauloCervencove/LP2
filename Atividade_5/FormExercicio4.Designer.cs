namespace Atividade5
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCaracterNum = new System.Windows.Forms.Button();
            this.btnPriBranco = new System.Windows.Forms.Button();
            this.btnCaracterAlfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(34, 22);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(100, 96);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnCaracterNum
            // 
            this.btnCaracterNum.Location = new System.Drawing.Point(164, 22);
            this.btnCaracterNum.Name = "btnCaracterNum";
            this.btnCaracterNum.Size = new System.Drawing.Size(111, 23);
            this.btnCaracterNum.TabIndex = 1;
            this.btnCaracterNum.Text = "Caracter Numero";
            this.btnCaracterNum.UseVisualStyleBackColor = true;
            this.btnCaracterNum.Click += new System.EventHandler(this.btnCaracterNum_Click);
            // 
            // btnPriBranco
            // 
            this.btnPriBranco.Location = new System.Drawing.Point(164, 66);
            this.btnPriBranco.Name = "btnPriBranco";
            this.btnPriBranco.Size = new System.Drawing.Size(111, 23);
            this.btnPriBranco.TabIndex = 2;
            this.btnPriBranco.Text = "Branco";
            this.btnPriBranco.UseVisualStyleBackColor = true;
            this.btnPriBranco.Click += new System.EventHandler(this.btnPriBranco_Click);
            // 
            // btnCaracterAlfa
            // 
            this.btnCaracterAlfa.Location = new System.Drawing.Point(164, 111);
            this.btnCaracterAlfa.Name = "btnCaracterAlfa";
            this.btnCaracterAlfa.Size = new System.Drawing.Size(111, 23);
            this.btnCaracterAlfa.TabIndex = 3;
            this.btnCaracterAlfa.Text = "Alfa";
            this.btnCaracterAlfa.UseVisualStyleBackColor = true;
            this.btnCaracterAlfa.Click += new System.EventHandler(this.btnCaracterAlfa_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaracterAlfa);
            this.Controls.Add(this.btnPriBranco);
            this.Controls.Add(this.btnCaracterNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "FormExercicio4";
            this.Load += new System.EventHandler(this.FormExercicio4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnCaracterNum;
        private System.Windows.Forms.Button btnPriBranco;
        private System.Windows.Forms.Button btnCaracterAlfa;
    }
}