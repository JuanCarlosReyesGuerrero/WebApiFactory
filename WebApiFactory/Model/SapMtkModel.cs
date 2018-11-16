using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFactory.Model
{
    public class SapMtkModel
    {
        public string ID { get; set; }
        public string IdOrigen { get; set; }
        public string Timestamp { get; set; }
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string TitleDescription { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Direccion { get; set; }
        public string NumeroCasa { get; set; }
        public string Genero { get; set; }
        public string D { get; set; }
        public string NombreConsumidor { get; set; }
        public string Empresa { get; set; }
        public string NitEmpresa { get; set; }
        public string CargoEmpresa { get; set; }
        public string Email { get; set; }
        public string EmailOpcional { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroOpcion { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string NumeroTelefonoCelularOpcion { get; set; }
        public string NumeroTelefonoSMSCelularOpcion { get; set; }
        public string FechaCumpleanos { get; set; }
        public string TwitterID { get; set; }
        public string TwitterOpcion { get; set; }
        public string FacebookID { get; set; }
        public string FacebookOpcion { get; set; }
        public string GooglePlusID { get; set; }
        public string GooglePlusOpcion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string ComoPrefieresContactemos { get; set; }
        public string HorarioPrefiereSerContactado { get; set; }
        public string SeleccionaCiudad { get; set; }
        public string CuandoQuieresIniciarClase { get; set; }
        public string ComoNosConociste { get; set; }
        public string ReferidoEANSINO { get; set; }
        public string Comentarios { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string ProgramaAcademico { get; set; }
        public string Metodologia { get; set; }
        public string EstadoCivil { get; set; }
        public string TieneHijos { get; set; }
        public string Estrato { get; set; }
        public string TipoVivienda { get; set; }
        public string FechaActualizacion { get; set; }
        public string CualEsSuActividadProfesional { get; set; }
        public string SectorDesempeno { get; set; }
        public string TipoEmpresa { get; set; }
        public string TamanoEmpresa { get; set; }
        public string RangoSalarial { get; set; }
        public string DominioSegundoIdioma { get; set; }
        public string CualesSonLasExpectativas { get; set; }
        public string AnioAcademico { get; set; }
        public string PeriodoAcademico { get; set; }
        public string TipoIngresoDenom { get; set; }
        public string CategoriaAdmisionDenominacion { get; set; }
        public string DepartamentoResidencia { get; set; }
        public string EstadoDenom { get; set; }
        public string InicioProgramaDen { get; set; }
        public string DenVariantePeriodo { get; set; }
        public string JornadaDen { get; set; }
        public string NumeroHijos { get; set; }
        public string OrigenEtnicoDenominacion { get; set; }
        public string TieneDiscapacidad { get; set; }
        public string TipoDiscapacidad { get; set; }
        public string OrganizacionExternaResponsable { get; set; }
        public string TituloObtenido { get; set; }
        public string EstatusEstudio { get; set; }
        public string InglesLectura { get; set; }
        public string InglesEscritura { get; set; }
        public string InglesExpresionOral { get; set; }
        public string FrancesLectura { get; set; }
        public string FrancesEscritura { get; set; }
        public string FrancesExpresionOral { get; set; }
        public string TieneHermanos { get; set; }
        public string NumeroHermanos { get; set; }
        public string IngresosFamiliares { get; set; }
        public string PaisDondeLabora { get; set; }
        public string CiudadDondeLabora { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Descuento { get; set; }
        public string EmpresaConveniosEmpresariales { get; set; }
        public string AplazamientoCupo { get; set; }
        public string ReactivacionCupos { get; set; }
        public string PersonaViculadaEAN { get; set; }
        public string Campania { get; set; }
        public string Cuenta { get; set; }
        public string AreaInteres { get; set; }
        public string CanalChatbot { get; set; }
        public string ColegioInstitucion { get; set; }
        public string SeleccionaGrado { get; set; }
        public string SeleccionaEdad { get; set; }
        public string CompeteciaPersonal { get; set; }
        public string CompeteciaAcademica { get; set; }
        public string Fecharegistro { get; set; }
        public string NivelFormacion { get; set; }
        public string HorarioPrefieres { get; set; }
        public string CuandoTeGustariaIniciarClases { get; set; }
        public string CompetenciaPersonal { get; set; }
        public string MomentoVida { get; set; }
        public string Facultad { get; set; }
        public string TituloProgramaMovilidadInternacional { get; set; }
        public string FechaEnvio { get; set; }
        public string CalendarioAcademico { get; set; }
        public string GradoColegio { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }
    }

    public class ProgramaContinuadaModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string ComoPrefieresContactemos { get; set; }
        public string HorarioPrefiereSerContactado { get; set; }
        public string SeleccionaCiudad { get; set; }
        public string CuandoQuieresIniciarClase { get; set; }
        public string ComoNosConociste { get; set; }
        public string ReferidoEANSINO { get; set; }
        public string Comentarios { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string ProgramaAcademico { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }
    }

    public class EgresadosModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string CargoEmpresa { get; set; }
        public string Email { get; set; }
        public string EmailOpcional { get; set; }
        public string TwitterOpcion { get; set; }
        public string FacebookID { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string ProgramaAcademico { get; set; }
        public string Metodologia { get; set; }
        public string EstadoCivil { get; set; }
        public string TieneHijos { get; set; }
        public string Estrato { get; set; }
        public string TipoVivienda { get; set; }
        public string FechaActualizacion { get; set; }
        public string CualEsSuActividadProfesional { get; set; }
        public string SectorDesempeno { get; set; }
        public string TipoEmpresa { get; set; }
        public string TamanoEmpresa { get; set; }
        public string RangoSalarial { get; set; }
        public string DominioSegundoIdioma { get; set; }
        public string CualesSonLasExpectativas { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }

    }

    public class LineaFormalModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Genero { get; set; }
        public string Empresa { get; set; }
        public string CargoEmpresa { get; set; }
        public string Email { get; set; }
        public string EmailOpcional { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroOpcion { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string FechaCumpleanos { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string ComoNosConociste { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string ProgramaAcademico { get; set; }
        public string Metodologia { get; set; }
        public string EstadoCivil { get; set; }
        public string TieneHijos { get; set; }
        public string Estrato { get; set; }
        public string TipoVivienda { get; set; }
        public string CualEsSuActividadProfesional { get; set; }
        public string SectorDesempeno { get; set; }
        public string TipoEmpresa { get; set; }
        public string TamanoEmpresa { get; set; }
        public string RangoSalarial { get; set; }
        public string AnioAcademico { get; set; }
        public string PeriodoAcademico { get; set; }
        public string TipoIngresoDenom { get; set; }
        public string CategoriaAdmisionDenominacion { get; set; }
        public string DepartamentoResidencia { get; set; }
        public string EstadoDenom { get; set; }
        public string InicioProgramaDen { get; set; }
        public string DenVariantePeriodo { get; set; }
        public string JornadaDen { get; set; }
        public string NumeroHijos { get; set; }
        public string OrigenEtnicoDenominacion { get; set; }
        public string TieneDiscapacidad { get; set; }
        public string TipoDiscapacidad { get; set; }
        public string OrganizacionExternaResponsable { get; set; }
        public string TituloObtenido { get; set; }
        public string EstatusEstudio { get; set; }
        public string InglesLectura { get; set; }
        public string InglesEscritura { get; set; }
        public string InglesExpresionOral { get; set; }
        public string FrancesLectura { get; set; }
        public string FrancesEscritura { get; set; }
        public string FrancesExpresionOral { get; set; }
        public string TieneHermanos { get; set; }
        public string NumeroHermanos { get; set; }
        public string IngresosFamiliares { get; set; }
        public string PaisDondeLabora { get; set; }
        public string CiudadDondeLabora { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Descuento { get; set; }
        public string EmpresaConveniosEmpresariales { get; set; }
        public string AplazamientoCupo { get; set; }
        public string ReactivacionCupos { get; set; }
        public string PersonaViculadaEAN { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }

    }

    public class LineaContinuadaModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string Empresa { get; set; }
        public string CargoEmpresa { get; set; }
        public string Email { get; set; }
        public string EmailOpcional { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroOpcion { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string FechaCumpleanos { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string ComoNosConociste { get; set; }
        public string ProgramaAcademico { get; set; }
        public string DepartamentoResidencia { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }

    }

    public class B2BModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Comentarios { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string ProgramaAcademico { get; set; }
        public string Metodologia { get; set; }
        public string Campania { get; set; }
        public string Cuenta { get; set; }
        public string AreaInteres { get; set; }
    }

    public class ChatBotModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string CanalChatbot { get; set; }
    }

    public class OrientacionPregradoModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string SectorDesempeno { get; set; }
        public string ColegioInstitucion { get; set; }
        public string SeleccionaGrado { get; set; }
        public string SeleccionaEdad { get; set; }
        public string CompeteciaPersonal { get; set; }
        public string CompeteciaAcademica { get; set; }
        public string Fecharegistro { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }
    }

    public class OrientacionPostgradoModel
    {
        public string NumeroTelefono { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string SectorDesempeno { get; set; }
        public string Fecharegistro { get; set; }
        public string NivelFormacion { get; set; }
        public string HorarioPrefieres { get; set; }
        public string CuandoTeGustariaIniciarClases { get; set; }
        public string CompetenciaPersonal { get; set; }
        public string MomentoVida { get; set; }
        public string URLreferencia { get; set; }
        public string URLOrigen { get; set; }
        public string UTMSource { get; set; }
        public string UTMMedium { get; set; }
        public string UTMCampaing { get; set; }
        public string UTMTerm { get; set; }
        public string UTMContent { get; set; }
    }

    public class InternacionalizacionMovilModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroTelefonoCelular { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Metodologia { get; set; }
        public string Facultad { get; set; }
        public string TituloProgramaMovilidadInternacional { get; set; }
        public string FechaEnvio { get; set; }
    }

    public class UniversiaModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroOpcion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
        public string DepartamentoResidencia { get; set; }
        public string CalendarioAcademico { get; set; }
        public string GradoColegio { get; set; }
    }

    public class GuiaAcademicaModel
    {
        public string PrimerNombre { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string AutorizoUsoDatosPersonales { get; set; }
    }

    public class FacebookModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string HorarioPrefiereSerContactado { get; set; }
        public string CuandoQuieresIniciarClase { get; set; }

        public string FormId { get; set; }
        public string CreatedTime { get; set; }
        public string Id { get; set; }
        public string Comentarios { get; set; }
    }

    public class LinkedinModel
    {
        public string PrimerNombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string HorarioPrefiereSerContactado { get; set; }
        public string CuandoQuieresIniciarClase { get; set; }
    }
}