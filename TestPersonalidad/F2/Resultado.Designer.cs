namespace F2
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
            this.txtr1 = new System.Windows.Forms.TextBox();
            this.txtr2 = new System.Windows.Forms.TextBox();
            this.txtr3 = new System.Windows.Forms.TextBox();
            this.txtr4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "SU PERSONALIDAD ES:";
            // 
            // txtr1
            // 
            this.txtr1.Location = new System.Drawing.Point(165, 132);
            this.txtr1.Name = "txtr1";
            this.txtr1.Size = new System.Drawing.Size(50, 20);
            this.txtr1.TabIndex = 1;
            // 
            // txtr2
            // 
            this.txtr2.Location = new System.Drawing.Point(221, 132);
            this.txtr2.Name = "txtr2";
            this.txtr2.Size = new System.Drawing.Size(50, 20);
            this.txtr2.TabIndex = 2;
            // 
            // txtr3
            // 
            this.txtr3.Location = new System.Drawing.Point(277, 132);
            this.txtr3.Name = "txtr3";
            this.txtr3.Size = new System.Drawing.Size(50, 20);
            this.txtr3.TabIndex = 3;
            // 
            // txtr4
            // 
            this.txtr4.Location = new System.Drawing.Point(333, 132);
            this.txtr4.Name = "txtr4";
            this.txtr4.Size = new System.Drawing.Size(50, 20);
            this.txtr4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.txtr4);
            this.Controls.Add(this.txtr3);
            this.Controls.Add(this.txtr2);
            this.Controls.Add(this.txtr1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtr1;
        private System.Windows.Forms.TextBox txtr2;
        private System.Windows.Forms.TextBox txtr3;
        private System.Windows.Forms.TextBox txtr4;
    }
}

