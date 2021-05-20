using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO

{
    public class Region : Estacion
    {
        private int codigoPostal;
        private string nombre;

        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return codigoPostal + "|" + nombre + "|";
        }
    }
}
