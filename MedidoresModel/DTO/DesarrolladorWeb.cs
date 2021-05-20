using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
   public class DesarrolladorWeb
    {
        private int codigo;
        private string rut;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string profesion;
        private string correo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Correo { get => correo; set => correo = value; }

        public override string ToString()
        {
            return codigo + "|" + rut + "|" + nombre + "|" + apellidoMaterno + "|" + ApellidoPaterno+ "|" + profesion + "|" + correo + "|";
        }
    }
}
