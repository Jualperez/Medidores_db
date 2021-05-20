using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;
using Newtonsoft.Json;


namespace MedidoresModel.DAL
{

    public class LecturaDALArchivos : ILecturaDAL
    {

        private LecturaDALArchivos()
        {

        }
        private static ILecturaDAL instancia;

        public static ILecturaDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new LecturaDALArchivos();
            return instancia;
        }
        private string textoTrafico = Directory.GetCurrentDirectory()
         + Path.DirectorySeparatorChar + "trafico.txt";

        private string textoConsumo = Directory.GetCurrentDirectory()
         + Path.DirectorySeparatorChar + "consumo.txt";


        public void registrarLecturaConsumo(Lectura l)
        {
            try
            {
                List<Lectura> lecturaConsumo = JsonConvert.DeserializeObject<List<Lectura>>(File.ReadAllText(textoConsumo));

                string json = JsonConvert.SerializeObject(lecturaConsumo, Formatting.Indented);

                File.WriteAllText(textoConsumo, json);

            }
            catch (NullReferenceException ex)
            {
                string json = JsonConvert.SerializeObject(l, Formatting.Indented);

                string jsjon = "[" + json + "]";

                File.WriteAllText(textoConsumo, jsjon);

            }
        }

        public void registrarLecturaTrafico(Lectura l)
        {
            try
            {
                List<Lectura> lecturaTrafico = JsonConvert.DeserializeObject<List<Lectura>>(File.ReadAllText(textoTrafico));

                string json = JsonConvert.SerializeObject(lecturaTrafico, Formatting.Indented);

                File.WriteAllText(textoTrafico, json);

            } catch (NullReferenceException ex)
            {
                string json = JsonConvert.SerializeObject(l, Formatting.Indented);

                string jsson = "[" + json + "]";

                File.WriteAllText(textoTrafico, json);

            }
        }

        public List<Lectura> ObtenerLecturaConsumo()
        {
            List<Lectura> consumo = JsonConvert.DeserializeObject<List<Lectura>>(File.ReadAllText(textoConsumo));

            return consumo;
        }

        public List<Lectura> ObtenerLecturasTrafico()
        {
            List<Lectura> trafico = JsonConvert.DeserializeObject<List<Lectura>>(File.ReadAllText(textoTrafico));

            return trafico;
        }

        public List<Lectura> ObtenerLecturasConsumo()
        {
            throw new NotImplementedException();
        }
    }
}
