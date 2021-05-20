using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;

namespace MedidoresModel.DAL
{
    public class MedidorTraficoDALArchivos : IMedidorTraficoDAL
    {
        public MedidorTraficoDALArchivos()
        {

        }

        private static IMedidorTraficoDAL instancia;

        public static IMedidorTraficoDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new MedidorTraficoDALArchivos();
            return instancia;
        }
        private static List<int> medidorTrafico = new List<int>()
       {
              2341, 2890, 8932, 4221, 9999
       };
        public List<int> ObtenerTrafico()
        {
            return medidorTrafico;
        }


    }
}