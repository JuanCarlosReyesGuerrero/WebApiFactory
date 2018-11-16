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
    public class LinkedinPostController : ApiController
    {
        /// <summary>
        /// Post Linkedin
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostLinkedin([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            LinkedinModel request = null;
            request = new LinkedinModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("NumeroTelefono")) request.NumeroTelefono = kv.Value;
                if (kv.Key.Contains("HorarioPrefiereSerContactado")) request.HorarioPrefiereSerContactado = kv.Value;
                if (kv.Key.Contains("CuandoQuieresIniciarClase")) request.CuandoQuieresIniciarClase = kv.Value;
            }

            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                var response = mapeoDatos.LinkedinBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
