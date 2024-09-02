using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class EvaluadorLineal:Evaluador
    {
        private int vidaUtil;
        public int VidaUtil { get { return vidaUtil; } set { vidaUtil = value; } }
        Moto m;
        public EvaluadorLineal(Moto vehiculo, int anoACalcular, int vidaUtil) : base(anoACalcular, vehiculo) 
        {
            VidaUtil = vidaUtil;
            m = vehiculo;
        }

        public override double CalcularDepreciacion()
        {
            double valorActualizado = 0;
            double anosDeUso = 0;
            anosDeUso = anoACalcular - m.Modelo;
            valorActualizado = m.ValorFabricacion - (m.ValorFabricacion * (anosDeUso / VidaUtil));
            return valorActualizado;
        }

        public override string VerDescripcion()
        {
            return $"Tipo de Evaluacion Lineal, Monto: {CalcularDepreciacion()}";
        }
    }
}
