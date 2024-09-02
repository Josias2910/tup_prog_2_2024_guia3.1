using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class EvaluadorAnual:Evaluador
    {
        private double tasaDepreciacion;
        public double TasaDepreciacion { get { return tasaDepreciacion; } set { tasaDepreciacion = value; } }
        Moto m;

        public EvaluadorAnual(Moto vehiculo, int anoACalcular, double tasaDepreciacion) : base(anoACalcular,vehiculo)
        {
            TasaDepreciacion = tasaDepreciacion;
            m = vehiculo;
        }

        public override double CalcularDepreciacion()
        {
            double valorActualizado = 0;
            double anosDeUso = 0;
            anosDeUso = anoACalcular - m.Modelo;
            valorActualizado = m.ValorFabricacion * Math.Pow(1 - TasaDepreciacion, anosDeUso);
            return valorActualizado;
        }

        public override string VerDescripcion()
        {
            return $"Tipo de Evaluacion Anual, Monto: {CalcularDepreciacion()}";
        }
    }
}
