﻿using System;
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
        public IHttpActionResult PostEgresados(EgresadosModel datosFormulario)
        {
            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Modelo de datos inválido");

                var response = mapeoDatos.EgresadosBusiness(datosFormulario);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("mensaje de error: " + e.Message);
            }
        }
    }
}
