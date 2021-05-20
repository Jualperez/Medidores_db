using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class CentroComunicacion : Estacion
    {
        private int codigo;
        private string nombre;
        private string direccion;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public override string ToString()
        {
            return codigo + "|" + nombre + "|" + direccion + "|";
        }
    }
}
