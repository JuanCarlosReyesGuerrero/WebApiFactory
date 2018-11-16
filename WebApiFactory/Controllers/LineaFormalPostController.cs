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
    public class LineaFormalPostController : ApiController
    {
        /// <summary>
        /// Post LineaFormal
        /// </summary>
        /// <param name="datosFormulario"></param>
        /// <returns></returns>
        public HttpResponseMessage PostLineaFormal([FromBody] string product)
        {
            if (string.IsNullOrEmpty(product))
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Modelo de datos inválido");

            LineaFormalModel request = null;
            request = new LineaFormalModel();

            Dictionary<string, string> j = JsonConvert.DeserializeObject<Dictionary<string, string>>(product);
            dynamic pr = JsonConvert.DeserializeObject(product);
            foreach (var kv in j)
            {
                if (kv.Key.Contains("PrimerNombre")) request.PrimerNombre = kv.Value;
                if (kv.Key.Contains("Apellidos")) request.Apellidos = kv.Value;
                if (kv.Key.Contains("Pais")) request.Pais = kv.Value;
                if (kv.Key.Contains("Ciudad")) request.Ciudad = kv.Value;
                if (kv.Key.Contains("Genero")) request.Genero = kv.Value;
                if (kv.Key.Contains("Empresa")) request.Empresa = kv.Value;
                if (kv.Key.Contains("CargoEmpresa")) request.CargoEmpresa = kv.Value;
                if (kv.Key.Contains("Email")) request.Email = kv.Value;
                if (kv.Key.Contains("EmailOpcional")) request.EmailOpcional = kv.Value;
                if (kv.Key.Contains("NumeroTelefono")) request.NumeroTelefono = kv.Value;
                if (kv.Key.Contains("NumeroOpcion")) request.NumeroOpcion = kv.Value;
                if (kv.Key.Contains("NumeroTelefonoCelular")) request.NumeroTelefonoCelular = kv.Value;
                if (kv.Key.Contains("FechaCumpleanos")) request.FechaCumpleanos = kv.Value;
                if (kv.Key.Contains("TipoIdentificacion")) request.TipoIdentificacion = kv.Value;
                if (kv.Key.Contains("NumeroIdentificacion")) request.NumeroIdentificacion = kv.Value;
                if (kv.Key.Contains("ComoNosConociste")) request.ComoNosConociste = kv.Value;
                if (kv.Key.Contains("AutorizoUsoDatosPersonales")) request.AutorizoUsoDatosPersonales = kv.Value;
                if (kv.Key.Contains("ProgramaAcademico")) request.ProgramaAcademico = kv.Value;
                if (kv.Key.Contains("Metodologia")) request.Metodologia = kv.Value;
                if (kv.Key.Contains("EstadoCivil")) request.EstadoCivil = kv.Value;
                if (kv.Key.Contains("TieneHijos")) request.TieneHijos = kv.Value;
                if (kv.Key.Contains("Estrato")) request.Estrato = kv.Value;
                if (kv.Key.Contains("TipoVivienda")) request.TipoVivienda = kv.Value;
                if (kv.Key.Contains("CualEsSuActividadProfesional")) request.CualEsSuActividadProfesional = kv.Value;
                if (kv.Key.Contains("SectorDesempeno")) request.SectorDesempeno = kv.Value;
                if (kv.Key.Contains("TipoEmpresa")) request.TipoEmpresa = kv.Value;
                if (kv.Key.Contains("TamanoEmpresa")) request.TamanoEmpresa = kv.Value;
                if (kv.Key.Contains("RangoSalarial")) request.RangoSalarial = kv.Value;
                if (kv.Key.Contains("AnioAcademico")) request.AnioAcademico = kv.Value;
                if (kv.Key.Contains("PeriodoAcademico")) request.PeriodoAcademico = kv.Value;
                if (kv.Key.Contains("TipoIngresoDenom")) request.TipoIngresoDenom = kv.Value;
                if (kv.Key.Contains("CategoriaAdmisionDenominacion")) request.CategoriaAdmisionDenominacion = kv.Value;
                if (kv.Key.Contains("DepartamentoResidencia")) request.DepartamentoResidencia = kv.Value;
                if (kv.Key.Contains("EstadoDenom")) request.EstadoDenom = kv.Value;
                if (kv.Key.Contains("InicioProgramaDen")) request.InicioProgramaDen = kv.Value;
                if (kv.Key.Contains("DenVariantePeriodo")) request.DenVariantePeriodo = kv.Value;
                if (kv.Key.Contains("JornadaDen")) request.JornadaDen = kv.Value;
                if (kv.Key.Contains("NumeroHijos")) request.NumeroHijos = kv.Value;
                if (kv.Key.Contains("OrigenEtnicoDenominacion")) request.OrigenEtnicoDenominacion = kv.Value;
                if (kv.Key.Contains("TieneDiscapacidad")) request.TieneDiscapacidad = kv.Value;
                if (kv.Key.Contains("TipoDiscapacidad")) request.TipoDiscapacidad = kv.Value;
                if (kv.Key.Contains("OrganizacionExternaResponsable")) request.OrganizacionExternaResponsable = kv.Value;
                if (kv.Key.Contains("TituloObtenido")) request.TituloObtenido = kv.Value;
                if (kv.Key.Contains("EstatusEstudio")) request.EstatusEstudio = kv.Value;
                if (kv.Key.Contains("InglesLectura")) request.InglesLectura = kv.Value;
                if (kv.Key.Contains("InglesEscritura")) request.InglesEscritura = kv.Value;
                if (kv.Key.Contains("InglesExpresionOral")) request.InglesExpresionOral = kv.Value;
                if (kv.Key.Contains("FrancesLectura")) request.FrancesLectura = kv.Value;
                if (kv.Key.Contains("FrancesEscritura")) request.FrancesEscritura = kv.Value;
                if (kv.Key.Contains("FrancesExpresionOral")) request.FrancesExpresionOral = kv.Value;
                if (kv.Key.Contains("TieneHermanos")) request.TieneHermanos = kv.Value;
                if (kv.Key.Contains("NumeroHermanos")) request.NumeroHermanos = kv.Value;
                if (kv.Key.Contains("IngresosFamiliares")) request.IngresosFamiliares = kv.Value;
                if (kv.Key.Contains("PaisDondeLabora")) request.PaisDondeLabora = kv.Value;
                if (kv.Key.Contains("CiudadDondeLabora")) request.CiudadDondeLabora = kv.Value;
                if (kv.Key.Contains("DireccionEmpresa")) request.DireccionEmpresa = kv.Value;
                if (kv.Key.Contains("Descuento")) request.Descuento = kv.Value;
                if (kv.Key.Contains("EmpresaConveniosEmpresariales")) request.EmpresaConveniosEmpresariales = kv.Value;
                if (kv.Key.Contains("AplazamientoCupo")) request.AplazamientoCupo = kv.Value;
                if (kv.Key.Contains("ReactivacionCupos")) request.ReactivacionCupos = kv.Value;
                if (kv.Key.Contains("PersonaViculadaEAN")) request.PersonaViculadaEAN = kv.Value;
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
                var response = mapeoDatos.LineaFormalBusiness(request);

                return Request.CreateResponse(HttpStatusCode.Accepted, "Modelo enviado");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "mensaje de error: " + e.Message);
            }
        }
    }
}
