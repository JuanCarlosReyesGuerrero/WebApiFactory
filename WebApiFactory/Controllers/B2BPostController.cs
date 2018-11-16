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
    public class B2BPostController : ApiController
    {
        /// <summary>
        /// Post B2B
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public HttpResponseMessage PostB2B([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            B2BModel request = null;
            request = new B2BModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("NumeroTelefonoCelular")) request.NumeroTelefonoCelular = kv.Value;
                if (kv.Key.Contains("TipoIdentificacion")) request.TipoIdentificacion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("Comentarios")) request.Comentarios = kv.Value;
                if (kv.Key.Contains("AutorizoUsoDatosPersonales")) request.AutorizoUsoDatosPersonales = kv.Value;
                if (kv.Key.Contains("ProgramaAcademico")) request.ProgramaAcademico = kv.Value;
                if (kv.Key.Contains("Metodologia")) request.Metodologia = kv.Value;
                if (kv.Key.Contains("Campania")) request.Campania = kv.Value;
                if (kv.Key.Contains("Cuenta")) request.Cuenta = kv.Value;
                if (kv.Key.Contains("AreaInteres")) request.AreaInteres = kv.Value;
            }

            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                var response = mapeoDatos.B2BBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }

        /// <summary>
        /// Post B2B
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        //public IHttpActionResult PostB2B(B2BModel datosFormulario)
        //{
        //    ApiBusiness mapeoDatos = new ApiBusiness();

        //    try
        //    {
        //        if (!ModelState.IsValid)
        //            return BadRequest("Modelo de datos inválido");

        //        var response = mapeoDatos.B2BBusiness(datosFormulario);

        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest("mensaje de error: " + e.Message);
        //    }
        //}

    }
}
