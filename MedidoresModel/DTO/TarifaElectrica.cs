using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class TarifaElectrica : Region
    {
        private int codigo;
        private decimal factor;

        public int Codigo { get => codigo; set => codigo = value; }
        public decimal Factor { get => factor; set => factor = value; }

        public override string ToString()
        {
            return codigo + "|" + factor + "|";
        }
    }
}
