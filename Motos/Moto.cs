using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class Moto
    {
        private string marca;
        public int modelo;
        public double valorFabricacion;
        public string Marca { get { return marca; } }
        public int Modelo { get { return modelo; } }
        public double ValorFabricacion { get { return valorFabricacion; } }

        public Moto (string marca, int modelo, double valorFabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.valorFabricacion = valorFabricacion;
        }

        public string VerDescripcion()
        {
            return $"Vehiculo... Marca: {Marca} - Modelo: {Modelo} - Valor Fabricacion: {ValorFabricacion}";
        }
    }
}
