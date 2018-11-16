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
    public class OrientacionPregradoPostController : ApiController
    {
        /// <summary>
        /// Post OrientacionPregrado
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostOrientacionPregrado([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            OrientacionPregradoModel request = null;
            request = new OrientacionPregradoModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("NumeroTelefonoCelular")) request.NumeroTelefonoCelular = kv.Value;
                if (kv.Key.Contains("TipoIdentificacion")) request.TipoIdentificacion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("AutorizoUsoDatosPersonales")) request.AutorizoUsoDatosPersonales = kv.Value;
                if (kv.Key.Contains("SectorDesempeno")) request.SectorDesempeno = kv.Value;
                if (kv.Key.Contains("ColegioInstitucion")) request.ColegioInstitucion = kv.Value;
                if (kv.Key.Contains("SeleccionaGrado")) request.SeleccionaGrado = kv.Value;
                if (kv.Key.Contains("SeleccionaEdad")) request.SeleccionaEdad = kv.Value;
                if (kv.Key.Contains("CompeteciaPersonal")) request.CompeteciaPersonal = kv.Value;
                if (kv.Key.Contains("CompeteciaAcademica")) request.CompeteciaAcademica = kv.Value;
                if (kv.Key.Contains("Fecharegistro")) request.Fecharegistro = kv.Value;
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
                var response = mapeoDatos.OrientacionPregradoBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
