using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DAL;

namespace MedidoresModel.DAL
{
    public class MedidorTraficoDALFactory
    {
         public static IMedidorTraficoDAL CreateDAL()
        {
            return MedidorTraficoDALArchivos.GetInstancia();
        }
    }
}
