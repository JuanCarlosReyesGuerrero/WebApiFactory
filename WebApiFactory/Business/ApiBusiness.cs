using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFactory.Model;

namespace WebApiFactory.Business
{
    public class ApiBusiness
    {
        public SapMtkModel ProgramaContinuadaBusiness(ProgramaContinuadaModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.ComoPrefieresContactemos = request.ComoPrefieresContactemos;
                    response.HorarioPrefiereSerContactado = request.HorarioPrefiereSerContactado;
                    response.SeleccionaCiudad = request.SeleccionaCiudad;
                    response.CuandoQuieresIniciarClase = request.CuandoQuieresIniciarClase;
                    response.ComoNosConociste = request.ComoNosConociste;
                    response.ReferidoEANSINO = request.ReferidoEANSINO;
                    response.Comentarios = request.Comentarios;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;
                    response.ProgramaAcademico = request.ProgramaAcademico;
                    response.URLreferencia = request.URLreferencia;
                    response.URLOrigen = request.URLOrigen;
                    response.UTMSource = request.UTMSource;
                    response.UTMMedium = request.UTMMedium;
                    response.UTMCampaing = request.UTMCampaing;
                    response.UTMTerm = request.UTMTerm;
                    response.UTMContent = request.UTMContent;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel EgresadosBusiness(EgresadosModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Ciudad = request.Ciudad;
                    response.Direccion = request.Direccion;
                    response.Genero = request.Genero;
                    response.CargoEmpresa = request.CargoEmpresa;
                    response.Email = request.Email;
                    response.EmailOpcional = request.EmailOpcional;
                    response.TwitterOpcion = request.TwitterOpcion;
                    response.FacebookID = request.FacebookID;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.ProgramaAcademico = request.ProgramaAcademico;
                    response.Metodologia = request.Metodologia;
                    response.EstadoCivil = request.EstadoCivil;
                    response.TieneHijos = request.TieneHijos;
                    response.Estrato = request.Estrato;
                    response.TipoVivienda = request.TipoVivienda;
                    response.FechaActualizacion = request.FechaActualizacion;
                    response.CualEsSuActividadProfesional = request.CualEsSuActividadProfesional;
                    response.SectorDesempeno = request.SectorDesempeno;
                    response.TipoEmpresa = request.TipoEmpresa;
                    response.TamanoEmpresa = request.TamanoEmpresa;
                    response.RangoSalarial = request.RangoSalarial;
                    response.DominioSegundoIdioma = request.DominioSegundoIdioma;
                    response.CualesSonLasExpectativas = request.CualesSonLasExpectativas;
                    response.URLreferencia = request.URLreferencia;
                    response.URLOrigen = request.URLOrigen;
                    response.UTMSource = request.UTMSource;
                    response.UTMMedium = request.UTMMedium;
                    response.UTMCampaing = request.UTMCampaing;
                    response.UTMTerm = request.UTMTerm;
                    response.UTMContent = request.UTMContent;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel LineaFormalBusiness(LineaFormalModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Pais = request.Pais;
                    response.Ciudad = request.Ciudad;
                    response.Genero = request.Genero;
                    response.Empresa = request.Empresa;
                    response.CargoEmpresa = request.CargoEmpresa;
                    response.Email = request.Email;
                    response.EmailOpcional = request.EmailOpcional;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.NumeroOpcion = request.NumeroOpcion;
                    response.NumeroTelefonoCelular = request.NumeroTelefonoCelular;
                    response.FechaCumpleanos = request.FechaCumpleanos;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.ComoNosConociste = request.ComoNosConociste;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;
                    response.ProgramaAcademico = request.ProgramaAcademico;
                    response.Metodologia = request.Metodologia;
                    response.EstadoCivil = request.EstadoCivil;
                    response.TieneHijos = request.TieneHijos;
                    response.Estrato = request.Estrato;
                    response.TipoVivienda = request.TipoVivienda;
                    response.CualEsSuActividadProfesional = request.CualEsSuActividadProfesional;
                    response.SectorDesempeno = request.SectorDesempeno;
                    response.TipoEmpresa = request.TipoEmpresa;
                    response.TamanoEmpresa = request.TamanoEmpresa;
                    response.RangoSalarial = request.RangoSalarial;
                    response.AnioAcademico = request.AnioAcademico;
                    response.PeriodoAcademico = request.PeriodoAcademico;
                    response.TipoIngresoDenom = request.TipoIngresoDenom;
                    response.CategoriaAdmisionDenominacion = request.CategoriaAdmisionDenominacion;
                    response.DepartamentoResidencia = request.DepartamentoResidencia;
                    response.EstadoDenom = request.EstadoDenom;
                    response.InicioProgramaDen = request.InicioProgramaDen;
                    response.DenVariantePeriodo = request.DenVariantePeriodo;
                    response.JornadaDen = request.JornadaDen;
                    response.NumeroHijos = request.NumeroHijos;
                    response.OrigenEtnicoDenominacion = request.OrigenEtnicoDenominacion;
                    response.TieneDiscapacidad = request.TieneDiscapacidad;
                    response.TipoDiscapacidad = request.TipoDiscapacidad;
                    response.OrganizacionExternaResponsable = request.OrganizacionExternaResponsable;
                    response.TituloObtenido = request.TituloObtenido;
                    response.EstatusEstudio = request.EstatusEstudio;
                    response.InglesLectura = request.InglesLectura;
                    response.InglesEscritura = request.InglesEscritura;
                    response.InglesExpresionOral = request.InglesExpresionOral;
                    response.FrancesLectura = request.FrancesLectura;
                    response.FrancesEscritura = request.FrancesEscritura;
                    response.FrancesExpresionOral = request.FrancesExpresionOral;
                    response.TieneHermanos = request.TieneHermanos;
                    response.NumeroHermanos = request.NumeroHermanos;
                    response.IngresosFamiliares = request.IngresosFamiliares;
                    response.PaisDondeLabora = request.PaisDondeLabora;
                    response.CiudadDondeLabora = request.CiudadDondeLabora;
                    response.DireccionEmpresa = request.DireccionEmpresa;
                    response.Descuento = request.Descuento;
                    response.EmpresaConveniosEmpresariales = request.EmpresaConveniosEmpresariales;
                    response.AplazamientoCupo = request.AplazamientoCupo;
                    response.ReactivacionCupos = request.ReactivacionCupos;
                    response.PersonaViculadaEAN = request.PersonaViculadaEAN;
                    response.URLreferencia = request.URLreferencia;
                    response.URLOrigen = request.URLOrigen;
                    response.UTMSource = request.UTMSource;
                    response.UTMMedium = request.UTMMedium;
                    response.UTMCampaing = request.UTMCampaing;
                    response.UTMTerm = request.UTMTerm;
                    response.UTMContent = request.UTMContent;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel LineaContinuadaBusiness(LineaContinuadaModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Pais = request.Pais;
                    response.Ciudad = request.Ciudad;
                    response.Direccion = request.Direccion;
                    response.Genero = request.Genero;
                    response.Empresa = request.Empresa;
                    response.CargoEmpresa = request.CargoEmpresa;
                    response.Email = request.Email;
                    response.EmailOpcional = request.EmailOpcional;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.NumeroOpcion = request.NumeroOpcion;
                    response.NumeroTelefonoCelular = request.NumeroTelefonoCelular;
                    response.FechaCumpleanos = request.FechaCumpleanos;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.ComoNosConociste = request.ComoNosConociste;
                    response.ProgramaAcademico = request.ProgramaAcademico;
                    response.DepartamentoResidencia = request.DepartamentoResidencia;
                    response.URLreferencia = request.URLreferencia;
                    response.URLOrigen = request.URLOrigen;
                    response.UTMSource = request.UTMSource;
                    response.UTMMedium = request.UTMMedium;
                    response.UTMCampaing = request.UTMCampaing;
                    response.UTMTerm = request.UTMTerm;
                    response.UTMContent = request.UTMContent;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel B2BBusiness(B2BModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Email = request.Email;
                    response.NumeroTelefonoCelular = request.NumeroTelefonoCelular;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.Comentarios = request.Comentarios;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;
                    response.ProgramaAcademico = request.ProgramaAcademico;
                    response.Metodologia = request.Metodologia;
                    response.Campania = request.Campania;
                    response.Cuenta = request.Cuenta;
                    response.AreaInteres = request.AreaInteres;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel ChatBotBusiness(ChatBotModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.CanalChatbot = request.CanalChatbot;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel OrientacionPregradoBusiness(OrientacionPregradoModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Ciudad = request.Ciudad;
                    response.Email = request.Email;
                    response.NumeroTelefonoCelular = request.NumeroTelefonoCelular;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;
                    response.SectorDesempeno = request.SectorDesempeno;
                    response.ColegioInstitucion = request.ColegioInstitucion;
                    response.SeleccionaGrado = request.SeleccionaGrado;
                    response.SeleccionaEdad = request.SeleccionaEdad;
                    response.CompeteciaPersonal = request.CompeteciaPersonal;
                    response.CompeteciaAcademica = request.CompeteciaAcademica;
                    response.Fecharegistro = request.Fecharegistro;
                    response.URLreferencia = request.URLreferencia;
                    response.URLOrigen = request.URLOrigen;
                    response.UTMSource = request.UTMSource;
                    response.UTMMedium = request.UTMMedium;
                    response.UTMCampaing = request.UTMCampaing;
                    response.UTMTerm = request.UTMTerm;
                    response.UTMContent = request.UTMContent;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel OrientacionPostgradoBusiness(OrientacionPostgradoModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.NumeroTelefono = request.NumeroTelefono;
                    response.NumeroTelefonoCelular = request.NumeroTelefonoCelular;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;
                    response.SectorDesempeno = request.SectorDesempeno;
                    response.Fecharegistro = request.Fecharegistro;
                    response.NivelFormacion = request.NivelFormacion;
                    response.HorarioPrefieres = request.HorarioPrefieres;
                    response.CuandoTeGustariaIniciarClases = request.CuandoTeGustariaIniciarClases;
                    response.CompetenciaPersonal = request.CompetenciaPersonal;
                    response.MomentoVida = request.MomentoVida;
                    response.URLreferencia = request.URLreferencia;
                    response.URLOrigen = request.URLOrigen;
                    response.UTMSource = request.UTMSource;
                    response.UTMMedium = request.UTMMedium;
                    response.UTMCampaing = request.UTMCampaing;
                    response.UTMTerm = request.UTMTerm;
                    response.UTMContent = request.UTMContent;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel InternacionalizacionMovilBusiness(InternacionalizacionMovilModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Pais = request.Pais;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.NumeroTelefonoCelular = request.NumeroTelefonoCelular;
                    response.TipoIdentificacion = request.TipoIdentificacion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.Metodologia = request.Metodologia;
                    response.Facultad = request.Facultad;
                    response.TituloProgramaMovilidadInternacional = request.TituloProgramaMovilidadInternacional;
                    response.FechaEnvio = request.FechaEnvio;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel UniversiaBusiness(UniversiaModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Ciudad = request.Ciudad;
                    response.CodigoPostal = request.CodigoPostal;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.NumeroOpcion = request.NumeroOpcion;
                    response.NumeroIdentificacion = request.NumeroIdentificacion;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;
                    response.DepartamentoResidencia = request.DepartamentoResidencia;
                    response.CalendarioAcademico = request.CalendarioAcademico;
                    response.GradoColegio = request.GradoColegio;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel GuiaAcademicaBusiness(GuiaAcademicaModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Ciudad = request.Ciudad;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.AutorizoUsoDatosPersonales = request.AutorizoUsoDatosPersonales;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel FacebookBusiness(FacebookModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Ciudad = request.Ciudad;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.HorarioPrefiereSerContactado = request.HorarioPrefiereSerContactado;
                    response.CuandoQuieresIniciarClase = request.CuandoQuieresIniciarClase;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }

        public SapMtkModel LinkedinBusiness(LinkedinModel request)
        {
            SapMtkModel response = null;

            if (request != null)
            {
                try
                {
                    response = new SapMtkModel();

                    response.PrimerNombre = request.PrimerNombre;
                    response.Apellidos = request.Apellidos;
                    response.Ciudad = request.Ciudad;
                    response.Email = request.Email;
                    response.NumeroTelefono = request.NumeroTelefono;
                    response.HorarioPrefiereSerContactado = request.HorarioPrefiereSerContactado;
                    response.CuandoQuieresIniciarClase = request.CuandoQuieresIniciarClase;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("El modelo esta vacio");
            }

            return response;
        }
    }
}