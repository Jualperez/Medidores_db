using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
   public class Bomba : Estacion
    {
        private int codigo;
        private string tipo;
        private int capacidadMaximaVehiculos;
        private DateTime vidaUtil;
        private string estadoBomba;

        public int Codigo1 { get => codigo; set => codigo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int CapacidadMaximaVehiculos { get => capacidadMaximaVehiculos; set => capacidadMaximaVehiculos = value; }
        public DateTime VidaUtil { get => vidaUtil; set => vidaUtil = value; }
        public string EstadoBomba { get => estadoBomba; set => estadoBomba = value; }

        public override string ToString()
        {
            return codigo + "|" + tipo + "|" + capacidadMaximaVehiculos + "|" + vidaUtil + "|" + estadoBomba + "|";
        }
    }
}
