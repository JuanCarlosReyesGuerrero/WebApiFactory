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
    public class LineaContinuadaPostController : ApiController
    {
        /// <summary>
        /// Post LineaContinuada
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostLineaContinuada([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            LineaContinuadaModel request = null;
            request = new LineaContinuadaModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Pais")) request.Pais = kv.Value;
                if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
                if (kv.Key.Contains("Direccion")) request.Direccion = kv.Value;
                if (kv.Key.Contains("Genero")) request.Genero = kv.Value;
                if (kv.Key.Contains("Empresa")) request.Empresa = kv.Value;
                if (kv.Key.Contains("CargoEmpresa")) request.CargoEmpresa = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("EmailOpcional")) request.EmailOpcional = kv.Value;
                if (kv.Key.Contains("NumeroTelefono")) request.NumeroTelefono = kv.Value;
                if (kv.Key.Contains("NumeroOpcion")) request.NumeroOpcion = kv.Value;
                if (kv.Key.Contains("NumeroTelefonoCelular")) request.NumeroTelefonoCelular = kv.Value;
                if (kv.Key.Contains("FechaCumpleanos")) request.FechaCumpleanos = kv.Value;
                if (kv.Key.Contains("TipoIdentificacion")) request.TipoIdentificacion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("ComoNosConociste")) request.ComoNosConociste = kv.Value;
                if (kv.Key.Contains("ProgramaAcademico")) request.ProgramaAcademico = kv.Value;
                if (kv.Key.Contains("DepartamentoResidencia")) request.DepartamentoResidencia = kv.Value;
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
                var response = mapeoDatos.LineaContinuadaBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
