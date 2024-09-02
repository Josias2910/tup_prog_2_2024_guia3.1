namespace Motos
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
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.tbTasaDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.nudAnoCalcular = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoCalcular)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(135, 48);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 0;
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(135, 113);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabricacion.TabIndex = 1;
            // 
            // tbTasaDepreciacion
            // 
            this.tbTasaDepreciacion.Location = new System.Drawing.Point(135, 114);
            this.tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            this.tbTasaDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.tbTasaDepreciacion.TabIndex = 2;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(135, 139);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Fabricacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ano a Calcular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tasa de Depreciacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vida Util";
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(135, 83);
            this.nudModelo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(56, 20);
            this.nudModelo.TabIndex = 10;
            // 
            // nudAnoCalcular
            // 
            this.nudAnoCalcular.Location = new System.Drawing.Point(135, 88);
            this.nudAnoCalcular.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAnoCalcular.Name = "nudAnoCalcular";
            this.nudAnoCalcular.Size = new System.Drawing.Size(56, 20);
            this.nudAnoCalcular.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLineal);
            this.groupBox1.Controls.Add(this.rbAnual);
            this.groupBox1.Controls.Add(this.btnCalcularCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTasaDepreciacion);
            this.groupBox1.Controls.Add(this.tbVidaUtil);
            this.groupBox1.Controls.Add(this.nudAnoCalcular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 206);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo Depreciacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMarca);
            this.groupBox2.Controls.Add(this.tbValorFabricacion);
            this.groupBox2.Controls.Add(this.nudModelo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 171);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Vehiculo";
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(271, 86);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(75, 44);
            this.btnCalcularCosto.TabIndex = 11;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(160, 405);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 44);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(91, 40);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 12;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.rbAnual_CheckedChanged);
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(182, 40);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(53, 17);
            this.rbLineal.TabIndex = 13;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 455);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoCalcular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbValorFabricacion;
        private System.Windows.Forms.TextBox tbTasaDepreciacion;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.NumericUpDown nudAnoCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.RadioButton rbLineal;
        public System.Windows.Forms.RadioButton rbAnual;
    }
}

