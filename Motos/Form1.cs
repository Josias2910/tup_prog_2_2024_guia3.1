using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAnual.Checked)
            {
                tbTasaDepreciacion.Enabled = true;
            }
        }

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLineal.Checked)
            {
                tbTasaDepreciacion.Enabled = false;
            }
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            Resultados res = new Resultados();
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nudModelo.Text);
            int valorFabricacion = Convert.ToInt32(tbValorFabricacion.Text);
            int ano = Convert.ToInt32(nudAnoCalcular.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            Moto vehiculo = new Moto(marca,modelo,valorFabricacion);           
            EvaluadorLineal lineal = new EvaluadorLineal(vehiculo, ano, vidaUtil);
            if (rbAnual.Checked)
            {
                double tasaDepreciacion = Convert.ToDouble(tbTasaDepreciacion.Text);
                EvaluadorAnual anual = new EvaluadorAnual(vehiculo, ano, tasaDepreciacion);
                anual.CalcularDepreciacion();
                res.lbResultados.Items.Add($"{vehiculo.VerDescripcion()} {anual.VerDescripcion()}");
            }
            else if (rbLineal.Checked)
            {
                lineal.CalcularDepreciacion();
                res.lbResultados.Items.Add($"{vehiculo.VerDescripcion()} {lineal.VerDescripcion()}");
            }
            res.ShowDialog();
            res.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
