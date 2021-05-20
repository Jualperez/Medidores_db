using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
     public class Estacion 
    {
        private int codigo;
        private string direccion;
        private int capacidadMaximaBomba;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int CapacidadMaximaBomba { get => capacidadMaximaBomba; set => capacidadMaximaBomba = value; }

        public override string ToString()
        {
            return codigo + "|" + direccion + "|" + capacidadMaximaBomba + "|" ;
        }
    }
}
