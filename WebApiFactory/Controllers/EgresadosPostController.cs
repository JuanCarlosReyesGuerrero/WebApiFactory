using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFactory.Business;
using WebApiFactory.Model;

namespace WebApiFactory.Controllers
{
    public class EgresadosPostController : ApiController
    {
        /// <summary>
        /// Post Egresados
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostEgresados([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            EgresadosModel request = null;
            request = new EgresadosModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
                if (kv.Key.Contains("Direccion")) request.Direccion = kv.Value;
                if (kv.Key.Contains("Genero")) request.Genero = kv.Value;
                if (kv.Key.Contains("CargoEmpresa")) request.CargoEmpresa = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("EmailOpcional")) request.EmailOpcional = kv.Value;
                if (kv.Key.Contains("TwitterOpcion")) request.TwitterOpcion = kv.Value;
                if (kv.Key.Contains("FacebookID")) request.FacebookID = kv.Value;
                if (kv.Key.Contains("TipoIdentificacion")) request.TipoIdentificacion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("ProgramaAcademico")) request.ProgramaAcademico = kv.Value;
                if (kv.Key.Contains("Metodologia")) request.Metodologia = kv.Value;
                if (kv.Key.Contains("EstadoCivil")) request.EstadoCivil = kv.Value;
                if (kv.Key.Contains("TieneHijos")) request.TieneHijos = kv.Value;
                if (kv.Key.Contains("Estrato")) request.Estrato = kv.Value;
                if (kv.Key.Contains("TipoVivienda")) request.TipoVivienda = kv.Value;
                if (kv.Key.Contains("FechaActualizacion")) request.FechaActualizacion = kv.Value;
                if (kv.Key.Contains("CualEsSuActividadProfesional")) request.CualEsSuActividadProfesional = kv.Value;
                if (kv.Key.Contains("SectorDesempeno")) request.SectorDesempeno = kv.Value;
                if (kv.Key.Contains("TipoEmpresa")) request.TipoEmpresa = kv.Value;
                if (kv.Key.Contains("TamanoEmpresa")) request.TamanoEmpresa = kv.Value;
                if (kv.Key.Contains("RangoSalarial")) request.RangoSalarial = kv.Value;
                if (kv.Key.Contains("DominioSegundoIdioma")) request.DominioSegundoIdioma = kv.Value;
                if (kv.Key.Contains("CualesSonLasExpectativas")) request.CualesSonLasExpectativas = kv.Value;
                if (kv.Key.Contains("URLreferencia")) request.URLreferencia = kv.Value;
                if (kv.Key.Contains("URLOrigen")) request.URLOrigen = kv.Value;
                if (kv.Key.Contains("UTMSource")) request.UTMSource = kv.Value;
                if (kv.Key.Contains("UTMMedium")) request.UTMMedium = kv.Value;
                if (kv.Key.Contains("UTMCampaing")) request.UTMCampaing = kv.Value;
                if (kv.Key.Contains("UTMTerm")) request.UTMTerm = kv.Value;
                if (kv.Key.Contains("UTMContent")) request.UTMContent = kv.Value;
            }

            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                var response = mapeoDatos.EgresadosBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
