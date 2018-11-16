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
        public IHttpActionResult PostLineaContinuada(LineaContinuadaModel datosFormulario)
        {
            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Modelo de datos inválido");

                var response = mapeoDatos.LineaContinuadaBusiness(datosFormulario);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("mensaje de error: " + e.Message);
            }
        }
    }
}
