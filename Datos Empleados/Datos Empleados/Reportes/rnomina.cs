using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Empleados
{
    class rnomina
    {
        private string m_centro;
        public string centro
        {
            get { return this.m_centro; }
            set { this.m_centro = value; }
        }
        private string m_departamento;
        public string departartamento
        {
            get { return this.m_departamento; }
            set { this.m_departamento = value; }
        }
        private string m_puesto;
        public string puesto
        {
            get { return this.m_puesto; }
            set { this.m_puesto = value; }
        }
        private string m_empleado;
        public string empleado
        {
            get { return this.m_empleado; }
            set { this.m_empleado = value; }
        }
        private string m_rfc;
        public string rfc
        {
            get { return this.m_rfc; }
            set { this.m_rfc = value; }
        }
        private string m_nss;
        public string nss
        {
            get { return this.m_nss; }
            set { this.m_nss = value; }
        }
        private string m_curp;
        public string curp
        {
            get { return this.m_curp; }
            set { this.m_curp = value; }
        }
        private string m_fecha_alta;
        public string fecha_alta
        {
            get { return this.m_fecha_alta; }
            set { this.m_fecha_alta = value; }
        }
        private string m_nombre;
        public string nombre
        {
            get { return this.m_nombre; }
            set { this.m_nombre = value; }
        }
        private double m_sueldodiario;
        public double sueldodiario
        {
            get { return this.m_sueldodiario; }
            set { this.m_sueldodiario = value; }
        }
        private double m_sdi;
        public double sdi
        {
            get { return this.m_sdi; }
            set { this.m_sdi = value; }
        }
        private double m_dias_laborados;
        public double dias_laborados
        {
            get { return this.m_dias_laborados; }
            set { this.m_dias_laborados = value; }
        }
        private double m_dias_laboradosreales;
        public double dias_laboradosreales
        {
            get { return this.m_dias_laboradosreales; }
            set { this.m_dias_laboradosreales = value; }
        }
        private int m_dias_faltas;
        public int dias_faltas
        {
            get { return this.m_dias_faltas; }
            set { this.m_dias_faltas = value; }
        }
        private double m_descuentop_aldia;
        public double descuentop_aldia
        {
            get { return this.m_descuentop_aldia; }
            set { this.m_descuentop_aldia = value; }
        }
        private double m_faltas;
        public double faltas
        {
            get { return this.m_faltas; }
            set { this.m_faltas = value; }
        }
        private int m_diasIncEnfGral;
        public int diasIncEnfGral
        {
            get { return this.m_diasIncEnfGral; }
            set { this.m_diasIncEnfGral = value; }
        }
        private int m_diasmaternidad;
        public int diasmaternidad
        {
            get { return this.m_diasmaternidad; }
            set { this.m_diasmaternidad = value; }
        }
        private int m_diasIncTrayecto;
        public int diasIncTrayecto
        {
            get { return this.m_diasIncTrayecto; }
            set { this.m_diasIncTrayecto = value; }
        }
        private double m_sueldo;
        public double sueldo
        {
            get { return this.m_sueldo; }
            set { this.m_sueldo = value; }
        }
        private double m_OtrosIngresosGravados;
        public double OtrosIngresosGravados
        {
            get { return this.m_OtrosIngresosGravados; }
            set { this.m_OtrosIngresosGravados = value; }
        }
        private double m_OtrosIngresosExento;
        public double OtrosIngresosExento
        {
            get { return this.m_OtrosIngresosExento; }
            set { this.m_OtrosIngresosExento = value; }
        }
        private double m_primaVacacional;
        public double primaVacacional
        {
            get { return this.m_primaVacacional; }
            set { this.m_primaVacacional = value; }
        }
        private double m_diaFestivo;
        public double diaFestivo
        {
            get { return this.m_diaFestivo; }
            set { this.m_diaFestivo = value; }
        }
        private double m_primaDominical;
        public double primaDominical
        {
            get { return this.m_primaDominical; }
            set { this.m_primaDominical = value; }
        }
        private double m_Bonos;
        public double Bonos
        {
            get { return this.m_Bonos; }
            set { this.m_Bonos = value; }
        }
        private double m_horasExtra;
        public double horasExtra
        {
            get { return this.m_horasExtra; }
            set { this.m_horasExtra = value; }
        }
        private double m_sudsidioapraelempleopagado;
        public double sudsidioapraelempleopagado
        {
            get { return this.m_sudsidioapraelempleopagado; }
            set { this.m_sudsidioapraelempleopagado = value; }
        }
        private double m_totalpercepciones;
        public double totalpercepciones
        {
            get { return this.m_totalpercepciones; }
            set { this.m_totalpercepciones = value; }
        }
        private double m_impuestoretenido;
        public double impuestoretenido
        {
            get { return this.m_impuestoretenido; }
            set { this.m_impuestoretenido = value; }
        }

        private double m_pension_alimenticia;
        public double pension_alimenticia
        {
            get { return this.m_pension_alimenticia; }
            set { this.m_pension_alimenticia = value; }
        }


        private double m_Descanso_laborado;
        public double Descanso_laborado
        {
            get { return this.m_Descanso_laborado; }
            set { this.m_Descanso_laborado = value; }
        }
        private double m_Descanso_laborado1;
        public double Descanso_laborado1
        {
            get { return this.m_Descanso_laborado1; }
            set { this.m_Descanso_laborado1 = value; }
        }


        private double m_ISR_ANUAL;
        public double ISR_ANUAL
        {
            get { return this.m_ISR_ANUAL; }
            set { this.m_ISR_ANUAL = value; }
        }

        private double m_Descuento_fonacot;
        public double Descuento_fonacot
        {
            get { return this.m_Descuento_fonacot; }
            set { this.m_Descuento_fonacot = value; }
        }




        private double m_imss;
        public double imss
        {
            get { return this.m_imss; }
            set { this.m_imss = value; }
        }
        private double m_DescCreditoInfonavit;
        public double DescCreditoInfonavit
        {
            get { return this.m_DescCreditoInfonavit; }
            set { this.m_DescCreditoInfonavit = value; }
        }
        private double m_AjusteDifInfonavit;
        public double AjusteDifInfonavit
        {
            get { return this.m_AjusteDifInfonavit; }
            set { this.m_AjusteDifInfonavit = value; }
        }
        private double m_otrosdescuentos;
        public double otrosdescuentos
        {
            get { return this.m_otrosdescuentos; }
            set { this.m_otrosdescuentos = value; }
        }

        private double m_descuentofaltas;
        public double descuentofaltas
        {
            get { return this.m_descuentofaltas; }
            set { this.m_descuentofaltas = value; }
        }
        private double m_totaldeducciones;
        public double totaldeducciones
        {
            get { return this.m_totaldeducciones; }
            set { this.m_totaldeducciones = value; }
        }
        private double m_netopagar;
        public double netopagar
        {
            get { return this.m_netopagar; }
            set { this.m_netopagar = value; }
        }
        private double m_isn;
        public double isn
        {
            get { return this.m_isn; }
            set { this.m_isn = value; }
        }
        private double m_sua;
        public double sua
        {
            get { return this.m_sua; }
            set { this.m_sua = value; }
        }
        private double m_cargasocial;
        public double cargasocial
        {
            get { return this.m_cargasocial; }
            set { this.m_cargasocial = value; }
        }

        private double m_sueldomensual;
        public double sueldomensual
        {
            get { return this.m_sueldomensual; }
            set { this.m_sueldomensual = value; }
        }

        private double m_vacaciones;
        public double vacaciones
        {
            get { return this.m_vacaciones; }
            set { this.m_vacaciones = value; }
        }
        private double m_primavacacional2;
        public double primavacacional2
        {
            get { return this.m_primavacacional2; }
            set { this.m_primavacacional2 = value; }
        }
        private double m_aguinaldo;
        public double aguinaldo
        {
            get { return this.m_aguinaldo; }
            set { this.m_aguinaldo = value; }
        }
        private double m_totalpasivolaboral;
        public double totalpasivolaboral
        {
            get { return this.m_totalpasivolaboral; }
            set { this.m_totalpasivolaboral = value; }
        }



        //'julio

        private string m_cuenta;
        public string cuenta
        {
            get { return this.m_cuenta; }
            set { this.m_cuenta = value; }
        }

        private string m_banco;
        public string banco
        {
            get { return this.m_banco; }
            set { this.m_banco = value; }
        }

        private double m_clabe;
        public double clabe
        {
            get { return this.m_clabe; }
            set { this.m_clabe = value; }
        }



        //'julio

        //'agosto

        private string m_bancoe;
        public string bancoe
        {
            get { return this.m_bancoe; }
            set { this.m_bancoe = value; }
        }


        private double m_cuentabancaria;
        public double cuentabancaria
        {
            get { return this.m_cuentabancaria; }
            set { this.m_cuentabancaria = value; }
        }

        private string m_frecuenciae;
        public string frecuenciae
        {
            get { return this.m_frecuenciae; }
            set { this.m_frecuenciae = value; }
        }

        private string m_clavedepto;
        public string clavedepto
        {
            get { return this.m_clavedepto; }
            set { this.m_clavedepto = value; }
        }

        private string m_nombredepto;
        public string nombredeptoe
        {
            get { return this.m_nombredepto; }
            set { this.m_nombredepto = value; }
        }

        private string m_clavepuesto;
        public string clavepuesto
        {
            get { return this.m_clavepuesto; }
            set { this.m_clavepuesto = value; }
        }

        private string m_nombrepuesto;
        public string nombrepuesto
        {
            get { return this.m_nombrepuesto; }
            set { this.m_nombrepuesto = value; }
        }

        private string  m_noempleado;
        public string noempleado
        {
            get { return this.m_noempleado; }
            set { this.m_noempleado = value; }
        }

        private string m_rfce;
        public string rfce
        {
            get { return this.m_rfce; }
            set { this.m_rfce = value; }
        }

        private string m_nsse;
        public string nsse
        {
            get { return this.m_nsse; }
            set { this.m_nsse = value; }
        }

        private string m_curpe;
        public string curpe
        {
            get { return this.m_curpe; }
            set { this.m_curpe = value; }
        }

        private string m_fechaalta;
        public string fechaalta
        {
            get { return this.m_fechaalta; }
            set { this.m_fechaalta = value; }
        }

        private string m_fechabaja;
        public string fechabaja
        {
            get { return this.m_fechabaja; }
            set { this.m_fechabaja = value; }
        }


        private string m_nomempleado;
        public string nomempleado
        {
            get { return this.m_nomempleado; }
            set { this.m_nomempleado = value; }
        }

        private string m_factorintegracion;
        public string factorintegracion
        {
            get { return this.m_factorintegracion; }
            set { this.m_factorintegracion = value; }
        }

        private string m_salariodiario;
        public string salariodiario
        {
            get { return this.m_salariodiario; }
            set { this.m_salariodiario = value; }
        }


        private Double m_salariodiarioI;

        public Double salariodiarioI
        {
            get { return m_salariodiarioI; }
            set { this.m_salariodiarioI = value; }
        }


        //'PEUGEOT



        private double m_PRIMAdP;
        public double PRIMAdP
        {
            get { return m_PRIMAdP; }
            set { this.m_PRIMAdP = value; }
        }



        private double m_PRIMAvP;
        public double PRIMAVP
        {
            get { return m_PRIMAvP; }
            set { this.m_PRIMAvP = value; }
        }

        private string m_NOMBREP;
        public string NOMBREP
        {
            get { return m_NOMBREP; }
            set { this.m_NOMBREP = value; }
        }


        private double m_CUOTADIARIAP;
        public double CUOTADIARIAP
        {
            get { return m_CUOTADIARIAP; }
            set { this.m_CUOTADIARIAP = value; }
        }


        private double m_diasp;
        public double diasP
        {
            get { return m_diasp; }
            set { this.m_diasp = value; }
        }

        private double m_sueldop;
        public double sueldoP
        {
            get { return m_sueldop; }
            set { this.m_sueldop = value; }
        }

        private double m_fondodeahorrop;
        public double fondodeahorroP
        {
            get { return m_fondodeahorrop; }
            set { this.m_fondodeahorrop = value; }
        }

        private double m_valesdedespensap;
        public double valesdedespensaP
        {
            get { return m_valesdedespensap; }
            set { this.m_valesdedespensap = value; }
        }

        private double m_subsidioalempleop;
        public double subsidioalempleoP
        {
            get { return m_subsidioalempleop; }
            set { this.m_subsidioalempleop = value; }
        }

        private double m_totalpercepcionesp;
        public double totalpercepcionesP
        {
            get { return m_totalpercepcionesp; }
            set { this.m_totalpercepcionesp = value; }
        }

        private double m_retencionimssp;
        public double retencionimssP
        {
            get { return m_retencionimssp; }
            set { this.m_retencionimssp = value; }
        }

        private double m_retencionisrp;
        public double retencionisrP
        {
            get { return m_retencionisrp; }
            set { this.m_retencionisrp = value; }
        }

        private double m_valesdedespensadp;
        public double valesdedespensadP
        {
            get { return m_valesdedespensadp; }
            set { this.m_valesdedespensadp = value; }
        }


        private double m_fondodeahorroemp;
        public double fondodeahorroemp
        {
            get { return m_fondodeahorroemp; }
            set { this.m_fondodeahorroemp = value; }
        }

        private double m_fondodeahorropap;
        public double fondodeahorropaP
        {
            get { return m_fondodeahorropap; }
            set { this.m_fondodeahorropap = value; }
        }

        private double m_amortizacionp;
        public double amortizacionP
        {
            get { return m_amortizacionp; }
            set { this.m_amortizacionp = value; }
        }

        private double m_totaldp;
        public double totaldP
        {
            get { return m_totaldp; }
            set { this.m_totaldp = value; }
        }

        private double m_ingresonetop;
        public double ingresonetoP
        {
            get { return m_ingresonetop; }
            set { this.m_ingresonetop = value; }
        }

        private double m_aguinaldo15p;
        public double aguinaldo15P
        {
            get { return m_aguinaldo15p; }
            set { this.m_aguinaldo15p = value; }
        }

        private double m_aguinaldo30p;
        public double aguinaldo30P
        {
            get { return m_aguinaldo30p; }
            set { this.m_aguinaldo30p = value; }
        }

        private double m_primav25p;
        public double primav25P
        {
            get { return m_primav25p; }
            set { this.m_primav25p = value; }
        }


        private double m_primav70p;
        public double primav70P
        {
            get { return m_primav70p; }
            set { this.m_primav70p = value; }
        }

        private double m_vales10p;
        public double vales10P
        {
            get { return m_vales10p; }
            set { this.m_vales10p = value; }
        }
        private double m_fondo13p;
        public double fondo13P
        {
            get { return m_fondo13p; }
            set { this.m_fondo13p = value; }
        }

        private double m_totalpresp;
        public double totalpresP
        {
            get { return m_totalpresp; }
            set { this.m_totalpresp = value; }
        }

        private double m_costosimssp;
        public double costosimssP
        {
            get { return m_costosimssp; }
            set { this.m_costosimssp = value; }
        }

        private double m_costosisnp;
        public double costosisnP
        {
            get { return m_costosisnp; }
            set { this.m_costosisnp = value; }
        }

        private double m_totalimpuesto;
        public double totalimpuesto
        {
            get { return m_totalimpuesto; }
            set { this.m_totalimpuesto = value; }
        }


        private double m_costopatronalp;
        public double costopatronalP
        {
            get { return m_costopatronalp; }
            set { this.m_costopatronalp = value; }
        }

        private double m_comisionp;
        public double comisionP
        {
            get { return m_comisionp; }
            set { this.m_comisionp = value; }
        }

        private double m_subtp;
        public double subtP
        {
            get { return m_subtp; }
            set { this.m_subtp = value; }
        }

        private double m_ivap;
        public double ivaP
        {
            get { return m_ivap; }
            set { this.m_ivap = value; }
        }


        private double m_totalp;
        public double totalP
        {
            get { return m_totalp; }
            set { this.m_totalp = value; }
        }
        private double m_bancop;
        public double bancoP
        {
            get { return m_bancop; }
            set { this.m_bancop = value; }
        }
        private double m_cuentap;
        public double cuentaP
        {
            get { return m_cuentap; }
            set { this.m_cuentap = value; }
        }

        private double m_otrosingp;
        public double otrosingP
        {
            get { return m_otrosingp; }
            set { this.m_otrosingp = value; }
        }


        private double m_diafp;
        public double diafP
        {
            get { return m_diafp; }
            set { this.m_diafp = value; }
        }

        private double m_descansolp;
        public double descansolP
        {
            get { return m_descansolp; }
            set { this.m_descansolp = value; }
        }

        private double m_bonosp;
        public double bonosP
        {
            get { return m_bonosp; }
            set { this.m_bonosp = value; }
        }

        private double m_horasextrasp;
        public double horasextrasP
        {
            get { return m_horasextrasp; }
            set { this.m_horasextrasp = value; }
        }

        private string m_clabep;
        public string clabeP
        {
            get { return m_clabep; }
            set { this.m_clabep = value; }
        }

        //'prestaciones






        //'PEUGEOT

    }
}
