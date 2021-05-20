using MedidoresModel.DAL;
using MedidoresModel.DTO;
using SocketUtils;
using System;

namespace MedidoresApp.Hilos
{
    class HiloCliente
    {
        private ClienteSocket clienteSocket;
        private ILecturaDAL dal = LecturaDALFactory.CreateDAL();
        static IMedidorConsumoDAL dalConsumo = MedidorConsumoDALFactory.CreateDAL();
        static IMedidorTraficoDAL dalTrafico = MedidorTraficoDALFactory.CreateDAL();





        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }

        public void Ejecutar()
        {
            bool verificado = false;
            int medidorT;
            string intento = clienteSocket.Leer();
            Console.WriteLine(intento);
            string fechaString = (intento.Split('|'))[0];

            try
            {
                medidorT = Int32.Parse((intento.Split('|'))[1]);
            }
            catch (Exception ex)
            {
                medidorT = 0;
            }
            string tipoMed;
            try
            {
                tipoMed = (intento.Split('|'))[2];
            }
            catch (Exception)
            {

                tipoMed = "cadena";
            }


            DateTime fecha;
            try
            {
                fecha = DateTime.ParseExact(fechaString, "yyyy-MM-dd-HH-mm-ss",
                System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {

                fecha = new DateTime(2021, 01, 01, 00, 00, 00);
            }

            string fecha1string;
            TimeSpan intervalo = DateTime.Now - fecha;

            if (tipoMed == "consumo")
            {
                foreach (var medidor in dalConsumo.obtenerMedidor())
                {
                    if (medidorT == medidor)
                    {
                        verificado = true;
                    }
                }
            }
            else if (tipoMed == "trafico")
            {
                foreach (var medidor in dalTrafico.obtenerMedidor())
                {
                    if (medidorT == medidor)
                    {
                        verificado = true;
                    }
                }
            }


        }

    }
}
