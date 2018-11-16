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
    public class UniversiaPostController : ApiController
    {
        /// <summary>
        /// Post Universia
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostUniversia([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            UniversiaModel request = null;
            request = new UniversiaModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
                if (kv.Key.Contains("CodigoPostal")) request.CodigoPostal = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("NumeroTelefono")) request.NumeroTelefono = kv.Value;
                if (kv.Key.Contains("NumeroOpcion")) request.NumeroOpcion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("AutorizoUsoDatosPersonales")) request.AutorizoUsoDatosPersonales = kv.Value;
                if (kv.Key.Contains("DepartamentoResidencia")) request.DepartamentoResidencia = kv.Value;
                if (kv.Key.Contains("CalendarioAcademico")) request.CalendarioAcademico = kv.Value;
                if (kv.Key.Contains("GradoColegio")) request.GradoColegio = kv.Value;
            }

            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                var response = mapeoDatos.UniversiaBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
