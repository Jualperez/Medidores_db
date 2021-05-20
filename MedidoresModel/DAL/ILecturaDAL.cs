using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturaDAL
    {
        void registrarLecturaConsumo(Lectura l);
        void registrarLecturaTrafico(Lectura l);

        List<Lectura> ObtenerLecturasConsumo();

        List<Lectura> ObtenerLecturasTrafico();

    }
}
