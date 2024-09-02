namespace Motos
{
    partial class Resultados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btnCerrarResultados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResultados);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(6, 15);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(571, 95);
            this.lbResultados.TabIndex = 1;
            // 
            // btnCerrarResultados
            // 
            this.btnCerrarResultados.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarResultados.Location = new System.Drawing.Point(251, 162);
            this.btnCerrarResultados.Name = "btnCerrarResultados";
            this.btnCerrarResultados.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarResultados.TabIndex = 2;
            this.btnCerrarResultados.Text = "Cerrar";
            this.btnCerrarResultados.UseVisualStyleBackColor = true;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 197);
            this.Controls.Add(this.btnCerrarResultados);
            this.Controls.Add(this.groupBox1);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lbResultados;
        public System.Windows.Forms.Button btnCerrarResultados;
    }
}