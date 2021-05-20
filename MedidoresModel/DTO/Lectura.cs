using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
   
    public class Lectura
    {
        private string nroSerie;
        private String fechaConsulta;
        private String tipo;
        private int valor;
        private int estado;

        public string NroSerie { get => nroSerie; set => nroSerie = value; }
        public String FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public String Tipo { get => tipo; set => tipo = value; }
        public int Valor { get => valor; set => valor = value; }
        public int Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return nroSerie + "|" + fechaConsulta + "|" + tipo + "|" + valor + "|" + estado + "|";
        }
    }
}
