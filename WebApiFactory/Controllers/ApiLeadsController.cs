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
    public class ApiLeadsController : ApiController
    {
        // GET: api/ApiLeads
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };

            //ApiFactory factory = new ConcreteApiFactory();

            //ISapMtk margarita = factory.GetApis(Nombre, string Modelo);
            ////Console.WriteLine($"La margarita cuesta {margarita.getPrice()} euros");

            //// return ();
            //return new string[] { $"La {Nombre} cuesta {margarita.getPrice()} euros" };

            ////ISapMtk barbacoa = factory.GetApis("Barbacoa");
            ////Console.WriteLine($"La barbacoa cuesta {barbacoa.getPrice()} euros");

        }

        // GET: api/ApiLeads/5
        public string Get(int id)
        {
            return "value";
        }

        ////// POST: api/ApiLeads
        //public void Post([FromBody]string value)
        //{
        ////    //ApiFactory factory = new ConcreteApiFactory();

        ////    //ISapMtk margarita = factory.GetApis(Nombre, string Modelo);
        ////    //return new string[] { $"La {Nombre} cuesta {margarita.getPrice()} euros" };



        //}

        /// <summary>
        /// Post Formulario Programas Continuada - Formal
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public IHttpActionResult PostProgramaContinuada(ProgramaContinuadaModel datosFormulario)
        {
            ApiBusiness mapeoDatos = new ApiBusiness();
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Modelo de datos inválido");

                var response = mapeoDatos.ProgramaContinuadaBusiness(datosFormulario);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("mensaje de error: " + e.Message);
            }
        }

        //Get action methods of the previous section
        //public IHttpActionResult Post(string nombreFormulario, string modeloDatos)
        //{
        //    //if (string.IsNullOrEmpty(modeloDatos))
        //    //    return BadRequest("El modelo esta vacio");

        //    //ApiFactory factory = new ConcreteApiFactory();

        //    //ISapMtk margarita = factory.GetApis(nombreFormulario, modeloDatos);
        //    //return Ok();

        //    return BadRequest("Not a valid model");
        //}



        // PUT: api/ApiLeads/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiLeads/5
        public void Delete(int id)
        {
        }
    }
}
