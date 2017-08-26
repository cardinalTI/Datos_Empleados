using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Empleados
{
    class Vempleados
    {
        private string m_numero;
        private string m_nombres;
        private string m_apellido_paterno;
        private string m_apellido_pmaterno;
        private string m_clavepuesto;
        private string m_clavedepto;
        private string m_turno;
        private string m_clavefrecuenciapago;
        private string m_regpatronal;
        private string m_formapago;
        private string m_contrato;
        private string m_diashorasjsr;
        private string m_jornada;
        private string m_regimenfiscal;
        private string m_fechaingreso;
        private string m_estatus;
        private string m_tiposalario;
        private string m_pctjeintegracion;
        private string m_salariodiario;
        private string m_salarioporhora;
        private string m_salariointegrado;
        private string m_zonasalario;
        private string m_calle;
        private string m_nombrecalle;
        private string m_numexterior;
        private string m_numinterior;
        private string m_colonia;
        private string m_poblacion;
        private string m_referenciadireccion;
        private string m_claveciudad;
        private string m_codigopostal;
        private string m_telefono1;
        private string m_telefono2;
        private string m_email;
        private string m_sexo;
        private string m_estadocivil;
        private string m_fechanacimiento;
        private string m_unidadmedica;
        private string m_rfc;
        private string m_curp;
        private string m_registroimss;
        private string m_otroregistro;

        private string m_mensaje;

        public string numero
        {
            get { return this.m_numero; }
            set { this.m_numero = value; }
        }

        public string nombres
        {
            get { return this.m_nombres; }
            set { this.m_nombres = value; }
        }
        public string apellido_paterno
        {
            get { return this.m_apellido_paterno; }
            set { this.m_apellido_paterno = value; }
        }
        public string apellido_pmaterno
        {
            get { return this.m_apellido_pmaterno; }
            set { this.m_apellido_pmaterno = value; }
        }
        public string clavepuesto
        {
            get { return this.m_clavepuesto; }
            set { this.m_clavepuesto = value; }
        }
        public string clavedepto
        {
            get { return this.m_clavedepto; }
            set { this.m_clavedepto = value; }
        }
        public string clavefrecuenciapago
        {
            get { return this.m_clavefrecuenciapago; }
            set { this.m_clavefrecuenciapago = value; }
        }
        public string regpatronal
        {
            get { return this.m_regpatronal; }
            set { this.m_regpatronal = value; }
        }
        public string formapago
        {
            get { return this.m_formapago; }
            set { this.m_formapago = value; }
        }
        public string contrato
        {
            get { return this.m_contrato; }
            set { this.m_contrato = value; }
        }
        public string diashorasjsr
        {
            get { return this.m_diashorasjsr; }
            set { this.m_diashorasjsr = value; }
        }
        public string jornada
        {
            get { return this.m_jornada; }
            set { this.m_jornada = value; }
        }
        public string regimenfiscal
        {
            get { return this.m_regimenfiscal; }
            set { this.m_regimenfiscal = value; }
        }
        public string fechaingreso
        {
            get { return this.m_fechaingreso; }
            set { this.m_fechaingreso = value; }
        }
        public string estatus
        {
            get { return this.m_estatus; }
            set { this.m_estatus = value; }
        }
        public string tiposalario
        {
            get { return this.m_tiposalario; }
            set { this.m_tiposalario = value; }
        }
        public string pctjeintegracion
        {
            get { return this.m_pctjeintegracion; }
            set { this.m_pctjeintegracion = value; }
        }
        public string salariodiario
        {
            get { return this.m_salariodiario; }
            set { this.m_salariodiario = value; }
        }
        public string salarioporhora
        {
            get { return this.m_salarioporhora; }
            set { this.m_salarioporhora = value; }
        }
        public string salariointegrado
        {
            get { return this.m_salariointegrado; }
            set { this.m_salariointegrado = value; }
        }
        public string zonasalario
        {
            get { return this.m_zonasalario; }
            set { this.m_zonasalario = value; }
        }
        public string calle
        {
            get { return this.m_calle; }
            set { this.m_calle = value; }
        }
        public string nombrecalle
        {
            get { return this.m_nombrecalle; }
            set { this.m_nombrecalle = value; }
        }
        public string numexterior
        {
            get { return this.m_numexterior; }
            set { this.m_numexterior = value; }
        }
        public string numinterior
        {
            get { return this.m_numinterior; }
            set { this.m_numinterior = value; }
        }
        public string colonia
        {
            get { return this.m_colonia; }
            set { this.m_colonia = value; }
        }
        public string poblacion
        {
            get { return this.m_poblacion; }
            set { this.m_poblacion = value; }
        }
        public string referenciadireccion
        {
            get { return this.m_referenciadireccion; }
            set { this.m_referenciadireccion = value; }
        }
        public string claveciudad
        {
            get { return this.m_claveciudad; }
            set { this.m_claveciudad = value; }
        }
        public string codigopostal
        {
            get { return this.m_codigopostal; }
            set { this.m_codigopostal = value; }
        }
        public string telefono1
        {
            get { return this.m_telefono1; }
            set { this.m_telefono1 = value; }
        }
        public string telefono2
        {
            get { return this.m_telefono2; }
            set { this.m_telefono2 = value; }
        }
        public string email
        {
            get { return this.m_email; }
            set { this.m_email = value; }
        }
        public string sexo
        {
            get { return this.m_sexo; }
            set { this.m_sexo = value; }
        }
        public string estadocivil
        {
            get { return this.m_estadocivil; }
            set { this.m_estadocivil = value; }
        }
        public string fechanacimiento
        {
            get { return this.m_fechanacimiento; }
            set { this.m_fechanacimiento = value; }
        }
        public string unidadmedica
        {
            get { return this.m_unidadmedica; }
            set { this.m_unidadmedica = value; }
        }
        public string rfc
        {
            get { return this.m_rfc; }
            set { this.m_rfc = value; }
        }
        public string curp
        {
            get { return this.m_curp; }
            set { this.m_curp = value; }
        }
        public string registroimss
        {
            get { return this.m_registroimss; }
            set { this.m_registroimss = value; }
        }
        public string otroregistro
        {
            get { return this.m_otroregistro; }
            set { this.m_otroregistro = value; }
        }


        public string turno
        {
            get { return this.m_turno; }
            set { this.m_turno = value; }
        }


        private string m_direccion;

        private string m_cp;
        public string direccion
        {
            get { return this.m_direccion; }
            set { this.m_direccion = value; }
        }
        public string cp
        {
            get { return this.m_cp; }
            set { this.m_cp = value; }
        }

        private string m_cuenta;
        private string m_centro;

        private string m_frecuencia;

        public string cuenta
        {
            get { return this.m_cuenta; }
            set { this.m_cuenta = value; }
        }
        public string centro
        {
            get { return this.m_centro; }
            set { this.m_centro = value; }
        }
        public string frecuencia
        {
            get { return this.m_frecuencia; }
            set { this.m_frecuencia = value; }
        }



        private string m_contratosat;
        public string contratosat
        {
            get { return this.m_contratosat; }
            set { this.m_contratosat = value; }
        }




        public string mensaje
        {
            get { return this.m_mensaje; }
            set { this.m_mensaje = value; }
        }

    }
}
