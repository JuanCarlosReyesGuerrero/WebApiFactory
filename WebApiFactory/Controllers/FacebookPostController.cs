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
    public class FacebookPostController : ApiController
    {
        /// <summary>
        /// Post Facebook
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public IHttpActionResult PostFacebook(FacebookModel datosFormulario)
        {
            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Modelo de datos inválido");

                var response = mapeoDatos.FacebookBusiness(datosFormulario);

                return Ok("Modelo enviado");
            }
            catch (Exception e)
            {
                return BadRequest("mensaje de error: " + e.Message);
            }
        }


        /// <summary>
        /// Post Facebook
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        //public HttpResponseMessage PostFacebook([FromBody] string product)
        //{
        //    if (string.IsNullOrEmpty(product))
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

        //    FacebookModel request = null;
        //    request = new FacebookModel();

        //    Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
        //    dynamic pr = JsonConvert.DeserializeObject(product);
        //    foreach (var kv in j)
        //    {
        //        if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
        //        if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
        //        if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
        //        if (kv.Key.Contains("Email")) request.Email = kv.Value;
        //        if (kv.Key.Contains("NumeroTelefono")) request.NumeroTelefono = kv.Value;
        //        if (kv.Key.Contains("HorarioPrefiereSerContactado")) request.HorarioPrefiereSerContactado = kv.Value;
        //        if (kv.Key.Contains("CuandoQuieresIniciarClase")) request.CuandoQuieresIniciarClase = kv.Value;

        //        if (kv.Key.Contains("FormId")) request.FormId = kv.Value;
        //        if (kv.Key.Contains("CreatedTime")) request.CreatedTime = kv.Value;
        //        if (kv.Key.Contains("Id")) request.Id = kv.Value;
        //        if (kv.Key.Contains("Comentarios")) request.Comentarios = kv.Value;
        //    }

        //    ApiBusiness mapeoDatos = new ApiBusiness();

        //    try
        //    {
        //        var response = mapeoDatos.FacebookBusiness(request);

        //        return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
        //    }
        //    catch (Exception e)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
        //    }
        //}
    }
}
