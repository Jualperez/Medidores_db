using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Administrador : CentroComunicacion
    {
        private string rut;
        private string codigo;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string correo;

        public string Rut { get => rut; set => rut = value; }
        public string Codigo1 { get => codigo; set => codigo = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Correo { get => correo; set => correo = value; }

        public override string ToString()
        {
            return rut + "|" + codigo + "|" + nombre + "|" + apellidoMaterno + "|" + ApellidoPaterno + "|" + correo + "|";
        }
    }
}
