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
    public class UniversiaPostController : ApiController
    {
        /// <summary>
        /// Post Universia
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public IHttpActionResult PostUniversia(UniversiaModel datosFormulario)
        {
            ApiBusiness mapeoDatos = new ApiBusiness();

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Modelo de datos inválido");

                var response = mapeoDatos.UniversiaBusiness(datosFormulario);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("mensaje de error: " + e.Message);
            }
        }
    }
}
