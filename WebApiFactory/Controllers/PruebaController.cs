using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http;
using WebApiFactory.Business;
using WebApiFactory.Model;

namespace WebApiFactory.Controllers
{
    public class PruebaController : ApiController
    {
        //public HttpResponseMessage Get()
        //{
        //try
        //{
        //    return Request.CreateResponse(HttpStatusCode.Found, Entities.Products.ToList());
        //}
        //catch (Exception)
        //{
        //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Data found");
        //}
        //}

        //public HttpResponseMessage Get(int id)
        //{
        //try
        //{
        //    return Request.CreateResponse(HttpStatusCode.Found, Entities.Products.SingleOrDefault(p => p.Id == id));
        //}
        //catch (Exception)
        //{
        //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Data found");
        //}
        //}


        [DataContract]
        class Blog
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Description { get; set; }
        }


        //public HttpResponseMessage Post([FromBody] Product product)
        //public HttpResponseMessage PostProgramaContinuada([FromBody] ForProgramasContinuadaFormalModel datosFormulario)
        //public IHttpActionResult PostProgramaContinuada(ProgramaContinuadaModel datosFormulario)
        // public IHttpActionResult PostProgramaContinuada(string datosFormulario)
        //public void Post([FromBody]string value)
        public HttpResponseMessage Post([FromBody] string product)
        {

            ProgramaContinuadaModel request = null;
            request = new ProgramaContinuadaModel();

            //string json = "{\"Description\":\" Compartir conocimiento \",\"Name 1\":\"estradawebgroup\"}";
            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                request.PrimerNombre = kv.Key;
                //var g = kv.Key.Replace(" ", "_");
                //Console.WriteLine(g);
            }




            //var definicion = new { Codigo = "", Cantidad = 0 };
            //var listaDefinicion = new[] { definicion };

            //var productos = "[{\"codigo1\":\"Servilleta\",\"cantidad\":2},{\"codigo\":\"Papelhig\",\"cantidad\":1}]";

            //var listProductos = JsonConvert.DeserializeAnonymousType(productos, listaDefinicion);

            //foreach (var prod in listProductos)
            //{
            //    Console.WriteLine("Código: " + prod.Codigo + " - Cantidad: " + prod.Cantidad);
            //}




            //string j = Newtonsoft.Json.JsonConvert.SerializeObject(product);

            //string json = "{\"Description\":\" Compartir conocimiento \",\"Name 1\":\"estradawebgroup\"}";
            ////dynamic pr = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            ////string p = ((Newtonsoft.Json.Linq.JProperty)(Newtonsoft.Json.Linq.JToken>(((Newtonsoft.Json.Linq.JObject)pr).ChildrenTokens).Items[0])).Name;
            //using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(product)))
            //{
            //    // Deserialization from JSON 
            //    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Blog));
            //    Blog bsObj2 = (Blog)deserializer.ReadObject(ms);
            //    //Response.Write("Name: " + bsObj2.Name); // Name: estradawebgroup
            //    //Response.Write("Description: " + bsObj2.Description); // Description: Compartir conocimiento 
            //}



            //*******************************************************
            ApiBusiness mapeoDatos = new ApiBusiness();
            try
            {
                //if (!ModelState.IsValid)
                // return BadRequest("Modelo de datos inválido");

                //var response = mapeoDatos.ProgramaContinuadaBusiness(datosFormulario);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Data not inserted");
                //return Ok("aaaaaaa");
            }
            catch (Exception e)
            {
                //return BadRequest("mensaje de error: " + e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Data not inserted");
            }

            //*******************************************************

            //try
            //{
            //    Entities.Products.Add(product);
            //    Entities.SaveChanges();
            //    var response = Request.CreateResponse(HttpStatusCode.Created, product);
            //    response.Headers.Location = Request.RequestUri;

            //    return response;
            //}
            //catch (Exception)
            //{
            //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Data not inserted");
            //}


        }

        //public HttpResponseMessage Delete(int id)
        //{
        //try
        //{
        //    var product = Entities.Products.SingleOrDefault(p => p.Id == id);
        //    if (product == null)
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Product not found to delete");
        //    Entities.Products.Remove(product);
        //    Entities.SaveChanges();

        //    return Request.CreateResponse(HttpStatusCode.OK, "Product Deleted Successfully");
        //}
        //catch (Exception)
        //{
        //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Product not deleted");
        //}
        //}

        //public HttpResponseMessage Put(int id, [FromBody] Product product)
        //{
        //try
        //{
        //    var entity = Entities.Products.SingleOrDefault(p => p.Id == id);
        //    if (entity == null)
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Product not found ");

        //    entity.Category = product.Category;
        //    entity.Name = product.Name;
        //    entity.Price = product.Price;
        //    Entities.SaveChanges();

        //    return Request.CreateResponse(HttpStatusCode.OK, "Product Updated Successfully");
        //}
        //catch (Exception ex)
        //{
        //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //}            
        //}

    }
}
