using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;

namespace MedidoresModel.DAL
{
    public class MedidorConsumoDALArchivos : IMedidorConsumoDAL
    {
       public MedidorConsumoDALArchivos()
        {

        }

        private static IMedidorConsumoDAL instancia;

        public static IMedidorConsumoDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new MedidorConsumoDALArchivos();
            return instancia;
        }

        private static List<int> medidorConsumo = new List<int>()
       {
            1882,4324,5456,1234
       };
        public List<int> ObtenerMedidores()
        {
            return medidorConsumo;
        }


    }
}
