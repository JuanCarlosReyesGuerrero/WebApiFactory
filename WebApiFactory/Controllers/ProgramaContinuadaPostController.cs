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
    public class ProgramaContinuadaPostController : ApiController
    {
        /// <summary>
        /// Post ProgramaContinuada
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostProgramaContinuada([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            ProgramaContinuadaModel request = null;
            request = new ProgramaContinuadaModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("NumeroTelefono")) request.NumeroTelefono = kv.Value;
                if (kv.Key.Contains("TipoIdentificacion")) request.TipoIdentificacion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("ComoPrefieresContactemos")) request.ComoPrefieresContactemos = kv.Value;
                if (kv.Key.Contains("HorarioPrefiereSerContactado")) request.HorarioPrefiereSerContactado = kv.Value;
                if (kv.Key.Contains("SeleccionaCiudad")) request.SeleccionaCiudad = kv.Value;
                if (kv.Key.Contains("CuandoQuieresIniciarClase")) request.CuandoQuieresIniciarClase = kv.Value;
                if (kv.Key.Contains("ComoNosConociste")) request.ComoNosConociste = kv.Value;
                if (kv.Key.Contains("ReferidoEANSINO")) request.ReferidoEANSINO = kv.Value;
                if (kv.Key.Contains("Comentarios")) request.Comentarios = kv.Value;
                if (kv.Key.Contains("AutorizoUsoDatosPersonales")) request.AutorizoUsoDatosPersonales = kv.Value;
                if (kv.Key.Contains("ProgramaAcademico")) request.ProgramaAcademico = kv.Value;
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
                var response = mapeoDatos.ProgramaContinuadaBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
