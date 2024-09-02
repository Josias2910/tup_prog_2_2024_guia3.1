using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    abstract internal class Evaluador
    {
        protected int anoACalcular;
        public int AnoACalcular { get { return anoACalcular; } }
        protected Moto Vehiculo;
        public Evaluador (int anoACalcular, Moto vehiculo) 
        {
            this.anoACalcular = anoACalcular;
            Vehiculo = vehiculo;
        }

        abstract public double CalcularDepreciacion();

        virtual public string VerDescripcion()
        {
            return $"{AnoACalcular}";
        }

    }
}
