
namespace SistemaWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDobrar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDobrar
            // 
            this.btDobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btDobrar.Location = new System.Drawing.Point(93, 219);
            this.btDobrar.Name = "btDobrar";
            this.btDobrar.Size = new System.Drawing.Size(135, 62);
            this.btDobrar.TabIndex = 0;
            this.btDobrar.Text = "Calcular o dobro";
            this.btDobrar.UseVisualStyleBackColor = false;
            this.btDobrar.Click += new System.EventHandler(this.btDobrar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(93, 158);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(135, 23);
            this.tbValor.TabIndex = 1;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.Location = new System.Drawing.Point(93, 326);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(25, 30);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btDobrar);
            this.Name = "Form1";
            this.Text = "Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDobrar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbResultado;
    }
}

