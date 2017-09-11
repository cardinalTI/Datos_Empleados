using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Empleados
{
    class suanomina
    {
        //'Instrucciones
        private double m_TISN;
        private double m_PdGdRdC;

        private string m_ZoAGdT;
        public string ZoAGdT
        {
            get { return this.m_ZoAGdT; }
            set { this.m_ZoAGdT = value; }
        }

        public double PdGdRdC
        {
            get { return this.m_PdGdRdC; }
            set { this.m_PdGdRdC = value; }
        }

        public double TISN
        {
            get { return this.m_TISN; }
            set { this.m_TISN = value; }
        }

        //' Fin de Instrucciones

        //'calculo Imss

        private double m_SMG;
        private double m_retencionImss;
        private double m_retencionISRSueldos;
        private double m_subsidioalempleo;
        private double m_ingresonetosueldos;
        private double m_sueldomensualdeseado;
        private double m_asimiladosmensuales;
        private double m_honorariosmensuales;
        private double m_pagosporfuera;
        private double m_totaldeingresos;
        private double m_ingresosexentosIMSSxsalarios;
        private double m_ingresosexentosimpuestossobrenominas;
        private double m_salariobasedecotizacion;
        private double m_salariominimoDF;
        private double m_excedente35mgdf;
        //'patron
        private double m_riesgodetrabajop;
        private double m_coutafijap;
        private double m_exedentep;
        private double m_prestacionesendinerop;
        private double m_gastosmedicospensionadosp;
        private double m_invalidezyvidap;
        private double m_guaderiasp;
        private double m_retirop;
        private double m_cesantiayvejezp;

        private double m_totalpatron;
        //'trabajador
        private double m_riesgodetrabajot;
        private double m_coutafijat;
        private double m_exedentet;
        private double m_prestacionesendinerot;
        private double m_gastosmedicospensionadost;
        private double m_invalidezyvidat;
        private double m_guaderiast;
        private double m_retirot;
        private double m_cesantiayvejezt;

        private double m_totaltrabador;
        //'patron mas trabajador

        private double m_riesgodetrabajopyt;
        private double m_coutafijapyt;
        private double m_exedentepyt;
        private double m_prestacionesendineropyt;
        private double m_gastosmedicospensionadospyt;
        private double m_invalidezyvidapyt;
        private double m_guaderiaspyt;
        private double m_retiropyt;
        private double m_cesantiayvejezpyt;

        private double m_totalpatronyt;
        //'costos sociales

        private double m_mensual;
        private double m_bimestral;
        private double m_total;
        private double m_infonavit;
        private double m_impuestosobrenominac;
        private double m_totalcostosocial;

        private double m_SUA;
        public double SUA
        {
            get { return this.m_SUA; }
            set { this.m_SUA = value; }
        }

        public double totalcostosocial
        {
            get { return this.m_totalcostosocial; }
            set { this.m_totalcostosocial = value; }
        }

        public double impuestosobrenominac
        {
            get { return this.m_impuestosobrenominac; }
            set { this.m_impuestosobrenominac = value; }
        }

        public double infonavit
        {
            get { return this.m_infonavit; }
            set { this.m_infonavit = value; }
        }

        public double total
        {
            get { return this.m_total; }
            set { this.m_total = value; }
        }

        public double bimestral
        {
            get { return this.m_bimestral; }
            set { this.m_bimestral = value; }
        }

        public double mensual
        {
            get { return this.m_mensual; }
            set { this.m_mensual = value; }
        }

        //'patron y trabajador

        public double totalpatronyt
        {
            get { return this.m_totalpatronyt; }
            set { this.m_totalpatronyt = value; }
        }

        public double cesantiayvejezpyt
        {
            get { return this.m_cesantiayvejezpyt; }
            set { this.m_cesantiayvejezpyt = value; }
        }

        public double retiropyt
        {
            get { return this.m_retiropyt; }
            set { this.m_retiropyt = value; }
        }



        public double guaderiaspyt
        {
            get { return this.m_guaderiaspyt; }
            set { this.m_guaderiaspyt = value; }
        }

        public double invalidezyvidapyt
        {
            get { return this.m_invalidezyvidapyt; }
            set { this.m_invalidezyvidapyt = value; }
        }

        public double gastosmedicospensionadospyt
        {
            get { return this.m_gastosmedicospensionadospyt; }
            set { this.m_gastosmedicospensionadospyt = value; }
        }

        public double prestacionesendineropyt
        {
            get { return this.m_prestacionesendineropyt; }
            set { this.m_prestacionesendineropyt = value; }
        }


        public double exedentepyt
        {
            get { return this.m_exedentepyt; }
            set { this.m_exedentepyt = value; }
        }

        public double coutafijapyt
        {
            get { return this.m_coutafijapyt; }
            set { this.m_coutafijapyt = value; }
        }

        public double riesgodetrabajopyt
        {
            get { return this.m_riesgodetrabajopyt; }
            set { this.m_riesgodetrabajopyt = value; }
        }

        //'Fin patron y trabajador


        //'trabajador

        public double totaltrabador
        {
            get { return this.m_totaltrabador; }
            set { this.m_totaltrabador = value; }
        }

        public double cesantiayvejezt
        {
            get { return this.m_cesantiayvejezt; }
            set { this.m_cesantiayvejezt = value; }
        }

        public double retirot
        {
            get { return this.m_retirot; }
            set { this.m_retirot = value; }
        }



        public double guaderiast
        {
            get { return this.m_guaderiast; }
            set { this.m_guaderiast = value; }
        }

        public double invalidezyvidat
        {
            get { return this.m_invalidezyvidat; }
            set { this.m_invalidezyvidat = value; }
        }

        public double gastosmedicospensionadost
        {
            get { return this.m_gastosmedicospensionadost; }
            set { this.m_gastosmedicospensionadost = value; }
        }

        public double prestacionesendinerot
        {
            get { return this.m_prestacionesendinerot; }
            set { this.m_prestacionesendinerot = value; }
        }


        public double exedentet
        {
            get { return this.m_exedentet; }
            set { this.m_exedentet = value; }
        }

        public double coutafijat
        {
            get { return this.m_coutafijat; }
            set { this.m_coutafijat = value; }
        }

        public double riesgodetrabajot
        {
            get { return this.m_riesgodetrabajot; }
            set { this.m_riesgodetrabajot = value; }
        }

        //'Fin trabajador



        //'patron
        public double totalpatron
        {
            get { return this.m_totalpatron; }
            set { this.m_totalpatron = value; }
        }

        public double cesantiayvejezp
        {
            get { return this.m_cesantiayvejezp; }
            set { this.m_cesantiayvejezp = value; }
        }

        public double retirop
        {
            get { return this.m_retirop; }
            set { this.m_retirop = value; }
        }



        public double guaderiasp
        {
            get { return this.m_guaderiasp; }
            set { this.m_guaderiasp = value; }
        }

        public double invalidezyvidap
        {
            get { return this.m_invalidezyvidap; }
            set { this.m_invalidezyvidap = value; }
        }

        public double gastosmedicospensionadosp
        {
            get { return this.m_gastosmedicospensionadosp; }
            set { this.m_gastosmedicospensionadosp = value; }
        }

        public double prestacionesendinerop
        {
            get { return this.m_prestacionesendinerop; }
            set { this.m_prestacionesendinerop = value; }
        }


        public double exedentep
        {
            get { return this.m_exedentep; }
            set { this.m_exedentep = value; }
        }

        public double coutafijap
        {
            get { return this.m_coutafijap; }
            set { this.m_coutafijap = value; }
        }

        public double riesgodetrabajop
        {
            get { return this.m_riesgodetrabajop; }
            set { this.m_riesgodetrabajop = value; }
        }

        //'fin patron 

        public double excedente35mgdf
        {
            get { return this.m_excedente35mgdf; }
            set { this.m_excedente35mgdf = value; }
        }

        public double salariominimoDF
        {
            get { return this.m_salariominimoDF; }
            set { this.m_salariominimoDF = value; }
        }

        public double salariobasedecotizacion
        {
            get { return this.m_salariobasedecotizacion; }
            set { this.m_salariobasedecotizacion = value; }
        }

        public double ingresosexentosimpuestossobrenominas
        {
            get { return this.m_ingresosexentosimpuestossobrenominas; }
            set { this.m_ingresosexentosimpuestossobrenominas = value; }
        }

        public double ingresosexentosIMSSxsalarios
        {
            get { return this.m_ingresosexentosIMSSxsalarios; }
            set { this.m_ingresosexentosIMSSxsalarios = value; }
        }

        public double totaldeingresos
        {
            get { return this.m_totaldeingresos; }
            set { this.m_totaldeingresos = value; }
        }

        public double pagosporfuera
        {
            get { return this.m_pagosporfuera; }
            set { this.m_pagosporfuera = value; }
        }

        public double honorariosmensuales
        {
            get { return this.m_honorariosmensuales; }
            set { this.m_honorariosmensuales = value; }
        }

        public double asimiladosmensuales
        {
            get { return this.m_asimiladosmensuales; }
            set { this.m_asimiladosmensuales = value; }
        }

        public double sueldomensualdeseado
        {
            get { return this.m_sueldomensualdeseado; }
            set { this.m_sueldomensualdeseado = value; }
        }

        public double ingresonetosueldos
        {
            get { return this.m_ingresonetosueldos; }
            set { this.m_ingresonetosueldos = value; }
        }

        public double subsidioalempleo
        {
            get { return this.m_subsidioalempleo; }
            set { this.m_subsidioalempleo = value; }
        }

        public double retencionISRSueldos
        {
            get { return this.m_retencionISRSueldos; }
            set { this.m_retencionISRSueldos = value; }
        }

        public double retencionImss
        {
            get { return this.m_retencionImss; }
            set { this.m_retencionImss = value; }
        }

        public double SMG
        {
            get { return this.m_SMG; }
            set { this.m_SMG = value; }
        }



        //'Fin calculo Imss

        //'tablas
        private string m_riedgodetrabajoBASE;
        private double m_riedgodetrabajoPATRON;
        private double m_riedgodetrabajotrabajador;
        private double m_riedgodetrabajototal;
        private string m_prestacionesespecieunoBASE;
        private double m_prestacionesespecieunoPATRON;
        private double m_prestacionesespecieunotrabajador;
        private double m_prestacionesespecieunototal;
        private string m_prestacionesespeciedosBASE;
        private double m_prestacionesespeciedosPATRON;
        private double m_prestacionesespeciedostrabajador;
        private double m_prestacionesespeciedostotal;
        private string m_prestacionesdineroBASE;
        private double m_prestacionesdineroPATRON;
        private double m_prestacionesdinerotrabajador;
        private double m_prestacionesdinerototal;
        private string m_gastosmedicospensionadosBASE;
        private double m_gastosmedicospensionadosPATRON;
        private double m_gastosmedicospensionadostrabajador;
        private double m_gastosmedicospensionadostotal;
        private string m_invalidezyvidaBASE;
        private double m_invalidezyvidaPATRON;
        private double m_invalidezyvidatrabajador;
        private double m_invalidezyvidatotal;
        private string m_guarderiasyprestacionessocialesBASE;
        private double m_guarderiasyprestacionessocialesPATRON;
        private double m_guarderiasyprestacionessocialestrabajador;
        private double m_guarderiasyprestacionessocialestotal;
        private string m_retiroBASE;
        private double m_retiroPATRON;
        private double m_retirotrabajador;
        private double m_retirototal;
        private string m_cesantiayvejezBASE;
        private double m_cesantiayvejezPATRON;
        private double m_cesantiayvejeztrabajador;
        private double m_cesantiayvejeztotal;
        private string m_sumasBASE;
        private double m_sumasPATRON;
        private double m_sumastrabajador;

        private double m_sumastotal;
        public double sumastotal
        {
            get { return this.m_sumastotal; }
            set { this.m_sumastotal = value; }
        }

        public double sumastrabajador
        {
            get { return this.m_sumastrabajador; }
            set { this.m_sumastrabajador = value; }
        }

        public double sumasPATRON
        {
            get { return this.m_sumasPATRON; }
            set { this.m_sumasPATRON = value; }
        }

        public string sumasBASE
        {
            get { return this.m_sumasBASE; }
            set { this.m_sumasBASE = value; }
        }
        //'
        public double cesantiayvejeztotal
        {
            get { return this.m_cesantiayvejeztotal; }
            set { this.m_cesantiayvejeztotal = value; }
        }

        public double cesantiayvejeztrabajador
        {
            get { return this.m_cesantiayvejeztrabajador; }
            set { this.m_cesantiayvejeztrabajador = value; }
        }

        public double cesantiayvejezPATRON
        {
            get { return this.m_cesantiayvejezPATRON; }
            set { this.m_cesantiayvejezPATRON = value; }
        }

        public string cesantiayvejezBASE
        {
            get { return this.m_cesantiayvejezBASE; }
            set { this.m_cesantiayvejezBASE = value; }
        }
        //'
        public double retirototal
        {
            get { return this.m_retirototal; }
            set { this.m_retirototal = value; }
        }

        public double retirotrabajador
        {
            get { return this.m_retirotrabajador; }
            set { this.m_retirotrabajador = value; }
        }

        public double retiroPATRON
        {
            get { return this.m_retiroPATRON; }
            set { this.m_retiroPATRON = value; }
        }

        public string retiroBASE
        {
            get { return this.m_retiroBASE; }
            set { this.m_retiroBASE = value; }
        }
        //'
        public double guarderiasyprestacionessocialestotal
        {
            get { return this.m_guarderiasyprestacionessocialestotal; }
            set { this.m_guarderiasyprestacionessocialestotal = value; }
        }

        public double guarderiasyprestacionessocialestrabajador
        {
            get { return this.m_guarderiasyprestacionessocialestrabajador; }
            set { this.m_guarderiasyprestacionessocialestrabajador = value; }
        }

        public double guarderiasyprestacionessocialesPATRON
        {
            get { return this.m_guarderiasyprestacionessocialesPATRON; }
            set { this.m_guarderiasyprestacionessocialesPATRON = value; }
        }

        public string guarderiasyprestacionessocialesBASE
        {
            get { return this.m_guarderiasyprestacionessocialesBASE; }
            set { this.m_guarderiasyprestacionessocialesBASE = value; }
        }
        //'
        public double invalidezyvidatotal
        {
            get { return this.m_invalidezyvidatotal; }
            set { this.m_invalidezyvidatotal = value; }
        }

        public double invalidezyvidatrabajador
        {
            get { return this.m_invalidezyvidatrabajador; }
            set { this.m_invalidezyvidatrabajador = value; }
        }

        public double invalidezyvidaPATRON
        {
            get { return this.m_invalidezyvidaPATRON; }
            set { this.m_invalidezyvidaPATRON = value; }
        }

        public string invalidezyvidaBASE
        {
            get { return this.m_invalidezyvidaBASE; }
            set { this.m_invalidezyvidaBASE = value; }
        }
        //'

        public double gastosmedicospensionadostotal
        {
            get { return this.m_gastosmedicospensionadostotal; }
            set { this.m_gastosmedicospensionadostotal = value; }
        }

        public double gastosmedicospensionadostrabajador
        {
            get { return this.m_gastosmedicospensionadostrabajador; }
            set { this.m_gastosmedicospensionadostrabajador = value; }
        }

        public double gastosmedicospensionadosPATRON
        {
            get { return this.m_gastosmedicospensionadosPATRON; }
            set { this.m_gastosmedicospensionadosPATRON = value; }
        }

        public string gastosmedicospensionadosBASE
        {
            get { return this.m_gastosmedicospensionadosBASE; }
            set { this.m_gastosmedicospensionadosBASE = value; }
        }
        //'
        public double prestacionesdinerototal
        {
            get { return this.m_prestacionesdinerototal; }
            set { this.m_prestacionesdinerototal = value; }
        }

        public double prestacionesdinerotrabajador
        {
            get { return this.m_prestacionesdinerotrabajador; }
            set { this.m_prestacionesdinerotrabajador = value; }
        }

        public double prestacionesdineroPATRON
        {
            get { return this.m_prestacionesdineroPATRON; }
            set { this.m_prestacionesdineroPATRON = value; }
        }

        public string prestacionesdineroBASE
        {
            get { return this.m_prestacionesdineroBASE; }
            set { this.m_prestacionesdineroBASE = value; }
        }
        //'
        public double prestacionesespeciedostotal
        {
            get { return this.m_prestacionesespeciedostotal; }
            set { this.m_prestacionesespeciedostotal = value; }
        }

        public double prestacionesespeciedostrabajador
        {
            get { return this.m_prestacionesespeciedostrabajador; }
            set { this.m_prestacionesespeciedostrabajador = value; }
        }

        public double prestacionesespeciedosPATRON
        {
            get { return this.m_prestacionesespeciedosPATRON; }
            set { this.m_prestacionesespeciedosPATRON = value; }
        }

        public string prestacionesespeciedosBASE
        {
            get { return this.m_prestacionesespeciedosBASE; }
            set { this.m_prestacionesespeciedosBASE = value; }
        }
        //'
        public double prestacionesespecieunototal
        {
            get { return this.m_prestacionesespecieunototal; }
            set { this.m_prestacionesespecieunototal = value; }
        }

        public double prestacionesespecieunotrabajador
        {
            get { return this.m_prestacionesespecieunotrabajador; }
            set { this.m_prestacionesespecieunotrabajador = value; }
        }

        public double prestacionesespecieunoPATRON
        {
            get { return this.m_prestacionesespecieunoPATRON; }
            set { this.m_prestacionesespecieunoPATRON = value; }
        }

        public string prestacionesespecieunoBASE
        {
            get { return this.m_prestacionesespecieunoBASE; }
            set { this.m_prestacionesespecieunoBASE = value; }
        }
        //'

        public double riedgodetrabajototal
        {
            get { return this.m_riedgodetrabajototal; }
            set { this.m_riedgodetrabajototal = value; }
        }

        public double riedgodetrabajotrabajador
        {
            get { return this.m_riedgodetrabajotrabajador; }
            set { this.m_riedgodetrabajotrabajador = value; }
        }

        public double riedgodetrabajoPATRON
        {
            get { return this.m_riedgodetrabajoPATRON; }
            set { this.m_riedgodetrabajoPATRON = value; }
        }

        public string riedgodetrabajoBASE
        {
            get { return this.m_riedgodetrabajoBASE; }
            set { this.m_riedgodetrabajoBASE = value; }
        }
    }
}
