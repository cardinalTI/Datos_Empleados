using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleados
{
    class MRnomina
    {
        private ArrayList arreCalculos = new ArrayList();
        private ArrayList arreDatos = new ArrayList();
        private OdbcConnection m_ConnODBC;
        OdbcTransaction trODBC;
        string cadena;
        public virtual string conexiofinal(string conexion)
        {
            cadena = ConfigurationManager.ConnectionStrings[conexion].ConnectionString;

            return cadena;
        }

        public string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }


        public virtual ArrayList ObtenerCalculoNomina(DateTime fecha, string rc)
        {
            string year, mes, dia, nombre, fechainicial;
            year = fecha.Year.ToString();
            mes = fecha.Month.ToString();
            dia = fecha.Day.ToString();

            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }

            nombre = MonthName(Int32.Parse(mes));

            fechainicial = mes + "/" + dia + "/" + year;

            try
            {

                OdbcDataReader OdbcDr;
                //System.Text.StringBuilder strQuery = new System.Text.StringBuilder();
                string strQuery = "";
                this.m_ConnODBC = new OdbcConnection(rc);
                this.m_ConnODBC.Open();
                trODBC = this.m_ConnODBC.BeginTransaction(IsolationLevel.RepeatableRead);
                OdbcCommand commODBC = new OdbcCommand("", this.m_ConnODBC, trODBC);


                strQuery.Remove(0, 0);
                strQuery = @"with Conceptos as(select d.cuota,p.pago_nomina_id,e.empleado_id,d.concepto_no_id,d.importe,p.total_percep_exen,p.total_percep_no_acum from pagos_nomina p 
                inner join pagos_nomina_det d
                on p.pago_nomina_id = d.pago_nomina_id
                inner join empleados e 
                on p.empleado_id = e.empleado_id) 
                select distinct  (dn.nombre) as departamento,pn.nombre as puesto,emp.numero as empleado,emp.grupo_pago_elect_id as banco ,emp.num_ctaban_pago_elect as cuenta, 
               emp.rfc as RFC,emp.reg_imss as NSS,emp.curp as CURP, 
               emp.fecha_ingreso as FECHA_ALTA,emp.nombre_completo as NOMBRE_EMPLEADO, 
               emp.salario_diario as SALARIO_DIARIO_ACTUAL,emp.salario_integ as SDI, 
               pgn.dias_cot as DIAS_LABORADOS,pgn.dias_trab as trabajados_reales ,PGN.faltas as FALTAS,pgn.dias_incap as DIAS_INCAPACIDADGENERAL,inc1.dias as RIESGOTRABAJO,inc2.dias as MATERNIDAD,pgn.total_reten as impuestoretenido, 
               c1.cuota as PRIMA_VACACIONAL, 
               c2.cuota as  OTRO_INGRESO_EXENTO, 
               c3.importe as dia_festivo, 
               c4.importe as prima_dominical, 
               c5.importe as bonos, 
               c6.cuota as horas_extra, 
               c7.importe as SUBSIDIO_PARA_EL_EMPLEO, 
               c8.importe as IMSS, 
               c9.cuota as descuento_infonavit, 
               c10.cuota as AJUSTE_DIFERENCIACREDINFONAVIT, 
               c11.cuota as otros_descuentos,pgn.faltas_dec as DESCUENTO_FALTAS,pgn.base_impto_estatal as ISN, 
               c12.importe as ISR, 
               c13.importe as Pension_Alimenticia, 
               c14.importe as Descanso_laborado, 
               c15.importe as Descanso_laborado1, 
               c16.importe as ISR_ANUAL, 
               c17.importe as Descuento_fonacot, 
               fpago.nombre AS NOMBRE 
               from empleados emp 
               inner join deptos_no dn 
               on emp.depto_no_id = dn.depto_no_id 
               inner join puestos_no pn 
               on emp.puesto_no_id = pn.puesto_no_id 
               inner join pagos_nomina pgn 
               on emp.empleado_id =pgn.empleado_id 
               inner join pagos_nomina_det pnd 
               on pgn.pago_nomina_id = pnd.pago_nomina_id 
               left join Conceptos c1
                on pgn.pago_nomina_id = c1.pago_nomina_id and emp.empleado_id = c1.empleado_id 
               and c1.concepto_no_id = 9761 
               left join Conceptos c2 
               on pgn.pago_nomina_id = c2.pago_nomina_id and emp.empleado_id = c2.empleado_id 
               and c2.concepto_no_id = 8986 
               left join Conceptos c3 
                on pgn.pago_nomina_id = c3.pago_nomina_id and emp.empleado_id = c3.empleado_id 
               and c3.concepto_no_id = 2176  
               left join Conceptos c4 
               on pgn.pago_nomina_id = c4.pago_nomina_id and emp.empleado_id = c4.empleado_id 
               and c4.concepto_no_id = 2106 
               left join Conceptos c5 
               on pgn.pago_nomina_id = c5.pago_nomina_id and emp.empleado_id = c5.empleado_id 
               and c5.concepto_no_id = 2175 
               left join Conceptos c6 
               on pgn.pago_nomina_id = c6.pago_nomina_id and emp.empleado_id = c6.empleado_id 
               and c6.concepto_no_id = 107 
               left join Conceptos c7 
               on pgn.pago_nomina_id = c7.pago_nomina_id and emp.empleado_id = c7.empleado_id 
               and c7.concepto_no_id = 156 
               left join Conceptos c8 
               on pgn.pago_nomina_id = c8.pago_nomina_id and emp.empleado_id = c8.empleado_id 
               and c8.concepto_no_id = 116 
               left join Conceptos c9 
               on pgn.pago_nomina_id = c9.pago_nomina_id and emp.empleado_id = c9.empleado_id 
               and c9.concepto_no_id = 10316 
               left join Conceptos c10 
               on pgn.pago_nomina_id = c10.pago_nomina_id and emp.empleado_id = c10.empleado_id 
               and c10.concepto_no_id = 10317 
               left join Conceptos c11 
               on pgn.pago_nomina_id = c11.pago_nomina_id and emp.empleado_id = c11.empleado_id 
               and c11.concepto_no_id = 8987 
               left join Conceptos c12 
               on pgn.pago_nomina_id = c12.pago_nomina_id and emp.empleado_id = c12.empleado_id 
               and c12.concepto_no_id = 115 
               left join Conceptos c13 
               on pgn.pago_nomina_id = c13.pago_nomina_id and emp.empleado_id = c13.empleado_id 
               and c13.concepto_no_id = 163 
               left join Conceptos c14 
               on pgn.pago_nomina_id = c14.pago_nomina_id and emp.empleado_id = c14.empleado_id 
               and c14.concepto_no_id = 11239 
               left join Conceptos c15 
               on pgn.pago_nomina_id = c15.pago_nomina_id and emp.empleado_id = c15.empleado_id 
               and c15.concepto_no_id = 11240 
               left join Conceptos c16 
               on pgn.pago_nomina_id = c16.pago_nomina_id and emp.empleado_id = c16.empleado_id 
               and c16.concepto_no_id = 12860 
               left join Conceptos c17 
               on pgn.pago_nomina_id = c17.pago_nomina_id and emp.empleado_id = c17.empleado_id 
               and c17.concepto_no_id = 11160 
               left join incapacidades inc1 
               on emp.empleado_id  = inc1.empleado_id and inc1.ramo = 'R' 
               left join incapacidades inc2 
               on emp.empleado_id = inc2.empleado_id and inc2.ramo = 'M' 
               inner join nominas nom 
               on nom.nomina_id = pgn.nomina_id 
               left join FRECUENCIAS_PAGO fpago 
               on fpago.frepag_id = nom.frepag_id 
               where  pgn.fecha = " + "'" + fechainicial + "'";
                commODBC.CommandText = strQuery.Replace("\r\n", "");
                //commODBC.CommandText = strQuery.ToString();
                OdbcDr = commODBC.ExecuteReader();
                trODBC.Commit();
                while (OdbcDr.Read())
                {
                    rnomina c = new rnomina();
                    suanomina s = new suanomina();
                    c.cuenta = ((OdbcDr["cuenta"] == DBNull.Value) ? "0" : OdbcDr["cuenta"].ToString());
                    c.centro = ((OdbcDr["NOMBRE"] == DBNull.Value) ? "N/A" : OdbcDr["NOMBRE"].ToString());
                    c.departartamento = ((OdbcDr["departamento"] == DBNull.Value) ? "N/A" : OdbcDr["departamento"].ToString());
                    c.puesto = ((OdbcDr["puesto"] == DBNull.Value) ? "N/A" : OdbcDr["puesto"].ToString());
                    c.empleado = ((OdbcDr["empleado"] == DBNull.Value) ? "0" : OdbcDr["empleado"].ToString());
                    c.rfc = ((OdbcDr["rfc"] == DBNull.Value) ? "N/A" : OdbcDr["rfc"].ToString());
                    c.nss = ((OdbcDr["nss"] == DBNull.Value) ? "N/A" : OdbcDr["nss"].ToString());
                    c.curp = ((OdbcDr["curp"] == DBNull.Value) ? "N/A" : OdbcDr["curp"].ToString());
                    c.fecha_alta = ((OdbcDr["FECHA_ALTA"] == DBNull.Value) ? "0" : OdbcDr["FECHA_ALTA"].ToString());
                    c.nombre = ((OdbcDr["NOMBRE_EMPLEADO"] == DBNull.Value) ? "0" : OdbcDr["NOMBRE_EMPLEADO"].ToString());
                    c.sueldodiario = ((OdbcDr["SALARIO_DIARIO_ACTUAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SALARIO_DIARIO_ACTUAL"].ToString()));
                    c.sdi = ((OdbcDr["SDI"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SDI"].ToString()));
                    c.dias_laborados = ((OdbcDr["FALTAS"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["FALTAS"].ToString()));
                    c.faltas = ((OdbcDr["SALARIO_DIARIO_ACTUAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SALARIO_DIARIO_ACTUAL"].ToString()));
                    c.dias_laboradosreales = ((OdbcDr["trabajados_reales"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["trabajados_reales"].ToString()));
                    c.sueldodiario = ((OdbcDr["SALARIO_DIARIO_ACTUAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SALARIO_DIARIO_ACTUAL"].ToString()));
                    c.sueldodiario = ((OdbcDr["SALARIO_DIARIO_ACTUAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SALARIO_DIARIO_ACTUAL"].ToString()));
                    c.descuentop_aldia = (2 - (((12 - c.sueldodiario) * 2) / 12)) * c.dias_faltas;
                    c.faltas = c.sueldodiario * c.dias_faltas;
                    c.diasIncEnfGral = ((OdbcDr["DIAS_INCAPACIDADGENERAL"] == DBNull.Value) ? 0 : Int32.Parse(OdbcDr["DIAS_INCAPACIDADGENERAL"].ToString()));
                    c.diasmaternidad = ((OdbcDr["MATERNIDAD"] == DBNull.Value) ? 0 : Int32.Parse(OdbcDr["MATERNIDAD"].ToString()));
                    c.diasIncTrayecto = ((OdbcDr["RIESGOTRABAJO"] == DBNull.Value) ? 0 : Int32.Parse(OdbcDr["RIESGOTRABAJO"].ToString()));
                    c.sueldo = c.dias_laborados * c.sueldodiario;
                    c.OtrosIngresosGravados = 0;
                    c.OtrosIngresosExento = ((OdbcDr["OTRO_INGRESO_EXENTO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["OTRO_INGRESO_EXENTO"].ToString()));
                    c.sdi = ((OdbcDr["PRIMA_VACACIONAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["PRIMA_VACACIONAL"].ToString()));
                    c.primaVacacional = ((OdbcDr["SDI"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SDI"].ToString()));
                    c.diaFestivo = ((OdbcDr["DIA_FESTIVO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["DIA_FESTIVO"].ToString()));
                    c.primaDominical = ((OdbcDr["PRIMA_DOMINICAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["PRIMA_DOMINICAL"].ToString()));
                    c.Bonos = ((OdbcDr["BONOS"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["BONOS"].ToString()));
                    c.horasExtra = ((OdbcDr["HORAS_EXTRA"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["HORAS_EXTRA"].ToString()));
                    c.sudsidioapraelempleopagado = ((OdbcDr["SUBSIDIO_PARA_EL_EMPLEO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SUBSIDIO_PARA_EL_EMPLEO"].ToString()));
                    c.totalpercepciones = c.sueldo + c.OtrosIngresosGravados + c.OtrosIngresosExento + c.primaVacacional + c.diaFestivo + c.primaDominical + c.Bonos + c.horasExtra + c.sudsidioapraelempleopagado;
                    c.impuestoretenido = ((OdbcDr["ISR"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["ISR"].ToString()));
                    c.ISR_ANUAL = ((OdbcDr["ISR_ANUAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["ISR_ANUAL"].ToString()));
                    c.Descuento_fonacot = ((OdbcDr["Descuento_fonacot"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["Descuento_fonacot"].ToString()));
                    c.pension_alimenticia = ((OdbcDr["Pension_Alimenticia"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["Pension_Alimenticia"].ToString()));
                    c.Descanso_laborado = ((OdbcDr["Descanso_laborado"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["Descanso_laborado"].ToString()));
                    c.Descanso_laborado1 = ((OdbcDr["Descanso_laborado1"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["Descanso_laborado1"].ToString()));
                    c.imss = ((OdbcDr["IMSS"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["IMSS"].ToString()));
                    c.DescCreditoInfonavit = ((OdbcDr["DESCUENTO_INFONAVIT"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["DESCUENTO_INFONAVIT"].ToString()));
                    c.AjusteDifInfonavit = ((OdbcDr["AJUSTE_DIFERENCIACREDINFONAVIT"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["AJUSTE_DIFERENCIACREDINFONAVIT"].ToString()));
                    c.otrosdescuentos = ((OdbcDr["OTROS_DESCUENTOS"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["OTROS_DESCUENTOS"].ToString()));
                    c.descuentofaltas = ((OdbcDr["DESCUENTO_FALTAS"] == DBNull.Value) ? 0 : c.descuentofaltas = c.descuentop_aldia + c.faltas);
                    c.totaldeducciones = c.Descuento_fonacot + c.pension_alimenticia + c.impuestoretenido + c.imss + c.DescCreditoInfonavit + c.AjusteDifInfonavit + c.otrosdescuentos + c.descuentofaltas;
                    c.netopagar = c.totalpercepciones - c.totaldeducciones;
                    c.isn = ((OdbcDr["ISN"] == DBNull.Value) ? (c.isn = (c.sueldo + c.OtrosIngresosExento + c.primaVacacional + c.diaFestivo + c.Descanso_laborado + c.primaDominical + c.Bonos + c.horasExtra) * 0.03) : c.isn = (c.sueldo + c.OtrosIngresosExento + c.primaVacacional + c.diaFestivo + c.Descanso_laborado + c.primaDominical + c.Bonos + c.horasExtra) * 0.03);
                    c.sua = 0;
                    c.cargasocial = c.isn + c.sua;
                    c.sueldomensual = c.sueldodiario * 30.42;
                    DateTime fecha_1 = Convert.ToDateTime(c.fecha_alta);
                    DateTime fecha_2 = DateTime.Now;
                    double fecha_3 = (fecha_2 - fecha_1).TotalDays;
                    c.vacaciones = (fecha_3 <= 365 ? (c.sueldomensual / 30.4 * 0) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad) : 0);
                    c.vacaciones = (fecha_3 >= 366 ? (c.sueldomensual / 30.4 * 6) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad) : c.vacaciones);
                    c.vacaciones = (fecha_3 >= 731 ? (c.sueldomensual / 30.4 * 8) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad) : c.vacaciones);
                    c.vacaciones = (fecha_3 >= 1096 ? (c.sueldomensual / 30.4 * 10) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad) : c.vacaciones);
                    c.vacaciones = (fecha_3 >= 1461 ? (c.sueldomensual / 30.4 * 12) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasIncTrayecto + c.diasmaternidad) : c.vacaciones);
                    c.primavacacional2 = (c.sueldomensual / 30.4 * 8) / 12 * (0.25) / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasmaternidad + c.diasIncTrayecto);
                    c.aguinaldo = (c.sueldomensual / 30.4 * 15) / 12 / (30.4) * (c.dias_laboradosreales + c.dias_faltas + c.diasIncEnfGral + c.diasmaternidad + c.diasIncTrayecto);
                    c.totalpasivolaboral = c.vacaciones + c.primavacacional2 + c.aguinaldo;
                    //sua

                    double factorIntegracion, salariominimodf, sueldomensual2;
                    string izquierda = "Costo de Administración";
                    Int16 tiponomina, baseimpuestonomina;
                    double numerovariable;

                    var options = new[] { "100206", "100207", "100969", "100970", "101160", "101189", "101470", "101475", "101479", "101484", "101848", "101849", "101850", "101862", "101863", "101947", "101948", "101950", "101953", "102056", "102058", "102059", "102062", "102064", "102065", "102067", "102068", "102171", "102172", "102173", "102174", "102175", "102176", "102177", "102178", "102179", "102292", "102293", "102294", "102295", "102296", "102297", "102299", "102300", "102302", "102303", "102304", "102305", "102306", "102307", "102309", "102456" };
                    numerovariable = (options.Contains(c.empleado) ? numerovariable = 0.5 : numerovariable = 0.52891);
                   
                    factorIntegracion = c.sdi / c.sueldodiario;
                    salariominimodf = 75.49;
                    sueldomensual2 = c.dias_laborados * c.sueldodiario;
                    s.SMG = c.sueldodiario / salariominimodf;
                    s.ingresosexentosIMSSxsalarios = 0;
                    s.salariobasedecotizacion = (((sueldomensual2 - s.ingresosexentosIMSSxsalarios) / c.dias_laborados) * factorIntegracion > salariominimodf * 25 ? (salariominimodf * 25) * c.dias_laborados : (sueldomensual2 - s.ingresosexentosIMSSxsalarios) * factorIntegracion);
                    s.salariominimoDF = (s.salariobasedecotizacion > 0 ? (salariominimodf * c.dias_laborados) : 0);
                    s.excedente35mgdf = (s.salariobasedecotizacion - (s.salariominimoDF * 3) > 0 ? s.salariobasedecotizacion - (s.salariominimoDF * 3) : 0);
                    s.riesgodetrabajop = (s.salariobasedecotizacion * numerovariable) / 100;
                    izquierda = "Costo de Administración";
                    s.coutafijap = (izquierda == "PRECAUCIÓN" ? s.salariominimoDF * 20.4 * 2.7 : s.coutafijap = s.salariominimoDF * 20.4 / 100);
                    s.exedentep = s.excedente35mgdf * 1.1 / 100;
                    s.prestacionesendinerop = s.salariobasedecotizacion * 0.7 / 100;
                    s.gastosmedicospensionadosp = s.salariobasedecotizacion * 1.05 / 100;
                    s.invalidezyvidap = s.salariobasedecotizacion * 1.75 / 100;
                    s.guaderiasp = s.salariobasedecotizacion * 1 / 100;
                    s.retirop = (s.salariobasedecotizacion * 2 / 100);
                    s.cesantiayvejezp = s.salariobasedecotizacion * 3.15 / 100;
                    s.totalpatron = s.riesgodetrabajop + s.coutafijap + s.exedentep + s.prestacionesendinerop + s.gastosmedicospensionadosp + s.invalidezyvidap + s.guaderiasp + s.retirop + s.cesantiayvejezp;

                    //trabajador

                    s.exedentet = s.excedente35mgdf * 0.4 / 100;
                    s.prestacionesendinerot = s.salariobasedecotizacion * 0.25 / 100;
                    s.gastosmedicospensionadost = s.salariobasedecotizacion * 0.375 / 100;
                    s.invalidezyvidat = s.salariobasedecotizacion * 0.625 / 100;
                    s.cesantiayvejezt = (izquierda == "PRECAUCIÓN" ? s.cesantiayvejezt = (s.salariobasedecotizacion * 1.125 / 100) * 2.7 : s.cesantiayvejezt = s.salariobasedecotizacion * 1.125 / 100);
                    s.totaltrabador = s.exedentet + s.prestacionesendinerot + s.gastosmedicospensionadost + s.invalidezyvidat + s.cesantiayvejezt;
                    s.riesgodetrabajopyt = s.riesgodetrabajop;
                    s.coutafijapyt = s.coutafijap;
                    s.exedentepyt = s.exedentep + s.exedentet;
                    s.prestacionesendineropyt = s.prestacionesendinerop + s.prestacionesendinerot;
                    s.gastosmedicospensionadospyt = s.gastosmedicospensionadosp + s.gastosmedicospensionadost;
                    s.invalidezyvidapyt = s.invalidezyvidap + s.invalidezyvidat;
                    s.guaderiaspyt = s.guaderiasp;
                    s.retiropyt = s.retirop;
                    s.cesantiayvejezpyt = s.cesantiayvejezp + s.cesantiayvejezt;
                    s.totalpatronyt = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt + s.retiropyt + s.cesantiayvejezpyt;
                    s.mensual = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt;
                    s.bimestral = s.retiropyt + s.cesantiayvejezpyt;
                    tiponomina = 1;
                    s.total = (tiponomina == 1 ? s.mensual + s.bimestral : 0);
                    s.infonavit = (tiponomina == 1 ? s.salariobasedecotizacion * 5 / 100 : 0);
                    baseimpuestonomina = 1;
                    s.ingresosexentosimpuestossobrenominas = 0;
                    s.asimiladosmensuales = 0;
                    s.impuestosobrenominac = (baseimpuestonomina == 1 ? ((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) * 3 / 100 : s.impuestosobrenominac = (((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) + s.asimiladosmensuales) * 3 / 100);
                    s.totalcostosocial = s.total + s.infonavit + s.impuestosobrenominac;
                    s.SUA = s.totalcostosocial - s.impuestosobrenominac;
                    c.sua = s.SUA;
                    c.banco = "prueba";


                    arreDatos.Add(c);

                    //if (OdbcDr["cuenta"] == DBNull.Value) { c.cuenta = "0"; }
                    //else { c.cuenta = OdbcDr["cuenta"].ToString(); }
                }
                this.m_ConnODBC.Close();
                return arreDatos;

            }
            catch (Exception e)
            {
                MessageBox.Show("El error es " + e);
                throw;
            }


        }

        public virtual ArrayList ObtenerCalculoNominaP(DateTime fecha, string rc)
        {
            string year, mes, dia, nombre, fechainicial;
            year = fecha.Year.ToString();
            mes = fecha.Month.ToString();
            dia = fecha.Day.ToString();

            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }

            nombre = MonthName(Int32.Parse(mes));

            fechainicial = mes + "/" + dia + "/" + year;
            try
            {
                OdbcDataReader OdbcDr;
                
                string strQuery = "";
                this.m_ConnODBC = new OdbcConnection(rc);
                this.m_ConnODBC.Open();
                trODBC = this.m_ConnODBC.BeginTransaction(IsolationLevel.RepeatableRead);
                OdbcCommand commODBC = new OdbcCommand("", this.m_ConnODBC, trODBC);


                strQuery.Remove(0, 0);
                strQuery = @"with Conceptos as(select d.cuota,p.pago_nomina_id,e.empleado_id,d.concepto_no_id,d.importe,p.total_percep_exen,p.total_percep_no_acum from pagos_nomina p 
                inner join pagos_nomina_det d 
                on p.pago_nomina_id = d.pago_nomina_id 
                inner join empleados e 
                on p.empleado_id = e.empleado_id) 
                select distinct  (dn.nombre) as departamento,pn.nombre as puesto,emp.numero as empleado,emp.grupo_pago_elect_id as banco ,emp.num_ctaban_pago_elect as cuenta, 
                emp.rfc as RFC,emp.reg_imss as NSS,emp.curp as CURP, 
                emp.fecha_ingreso as FECHA_ALTA,emp.nombre_completo as NOMBRE_EMPLEADO, 
                emp.salario_diario as SALARIO_DIARIO_ACTUAL,emp.salario_integ as SDI, 
                pgn.dias_cot as DIAS_LABORADOS,pgn.dias_trab as trabajados_reales,PGN.faltas as FALTAS,pgn.dias_incap as DIAS_INCAPACIDADGENERAL,inc1.dias as RIESGOTRABAJO,inc2.dias as MATERNIDAD,pgn.total_reten as impuestoretenido, 
                c1.importe as FONDODEAHORRO, 
                c2.importe as valesdedespensa, 
                c3.cuota as subsidioalempleo, 
                c4.importe as imss, 
                c5.importe as isr, 
                C6.cuota as PRIMAVACACIONAL, 
                c7.cuota as diafestivo, 
                c8.importe as primadominical, 
                c9.importe as bonos,
                c10.importe as horasextras, 
                c11.cuota as aguinaldo15P, 
                c12.cuota as aguinaldo30P, 
                c13.importe as primav25P, 
                c14.importe as primav70P, 
                c15.cuota as vales10P, 
                c16.cuota as fondo13P, 
                c17.importe as otrosingresos, 
                fpago.nombre AS NOMBRE 
                from empleados emp 
                inner join deptos_no dn 
                on emp.depto_no_id = dn.depto_no_id 
                inner join puestos_no pn 
                on emp.puesto_no_id = pn.puesto_no_id 
                inner join pagos_nomina pgn 
                on emp.empleado_id =pgn.empleado_id 
                inner join pagos_nomina_det pnd 
                on pgn.pago_nomina_id = pnd.pago_nomina_id 
                left join Conceptos c1 
                on pgn.pago_nomina_id = c1.pago_nomina_id and emp.empleado_id = c1.empleado_id 
                and c1.concepto_no_id = 644 
                left join Conceptos c2 
                on pgn.pago_nomina_id = c2.pago_nomina_id and emp.empleado_id = c2.empleado_id 
                and c2.concepto_no_id = 643 
                left join Conceptos c3 
                on pgn.pago_nomina_id = c3.pago_nomina_id and emp.empleado_id = c3.empleado_id 
                and c3.concepto_no_id = 156 
                left join Conceptos c4 
                on pgn.pago_nomina_id = c4.pago_nomina_id and emp.empleado_id = c4.empleado_id 
                and c4.concepto_no_id = 116 
                left join Conceptos c5 
                on pgn.pago_nomina_id = c5.pago_nomina_id and emp.empleado_id = c5.empleado_id 
                and c5.concepto_no_id = 115 
                left join Conceptos c6 
                on pgn.pago_nomina_id = c6.pago_nomina_id and emp.empleado_id = c6.empleado_id 
                and c6.concepto_no_id = 111 
                left join Conceptos c7 
                on pgn.pago_nomina_id = c7.pago_nomina_id and emp.empleado_id = c7.empleado_id 
                and c7.concepto_no_id = 647 
                left join Conceptos c8 
                on pgn.pago_nomina_id = c8.pago_nomina_id and emp.empleado_id = c8.empleado_id 
                and c8.concepto_no_id = 646 
                left join Conceptos c9 
                on pgn.pago_nomina_id = c9.pago_nomina_id and emp.empleado_id = c9.empleado_id 
                and c9.concepto_no_id = 648 
                left join Conceptos c10 
                on pgn.pago_nomina_id = c10.pago_nomina_id and emp.empleado_id = c10.empleado_id 
                and c10.concepto_no_id = 107 
                left join Conceptos c11 
                on pgn.pago_nomina_id = c11.pago_nomina_id and emp.empleado_id = c11.empleado_id 
                and c11.concepto_no_id = 746 
                left join Conceptos c12 
                on pgn.pago_nomina_id = c12.pago_nomina_id and emp.empleado_id = c12.empleado_id 
                and c12.concepto_no_id = 110 
                left join Conceptos c13 
                on pgn.pago_nomina_id = c13.pago_nomina_id and emp.empleado_id = c13.empleado_id 
                and c13.concepto_no_id = 745 
                left join Conceptos c14 
                on pgn.pago_nomina_id = c14.pago_nomina_id and emp.empleado_id = c14.empleado_id 
                and c14.concepto_no_id = 737 
                left join Conceptos c15 
                on pgn.pago_nomina_id = c15.pago_nomina_id and emp.empleado_id = c15.empleado_id 
                and c15.concepto_no_id = 643 
                left join Conceptos c16 
                on pgn.pago_nomina_id = c16.pago_nomina_id and emp.empleado_id = c16.empleado_id 
                and c16.concepto_no_id = 644 
                left join Conceptos c17 
                on pgn.pago_nomina_id = c17.pago_nomina_id and emp.empleado_id = c17.empleado_id 
                and c17.concepto_no_id = 747 
                left join incapacidades inc1 
                on emp.empleado_id  = inc1.empleado_id and inc1.ramo = 'R' 
                left join incapacidades inc2 
                on emp.empleado_id = inc2.empleado_id and inc2.ramo = 'M' 
                inner join nominas nom 
                on nom.nomina_id = pgn.nomina_id 
                left join FRECUENCIAS_PAGO fpago 
                on fpago.frepag_id = nom.frepag_id 
                 where  pgn.fecha = " + "'" + fechainicial + "'";
                commODBC.CommandText = strQuery.Replace("\r\n", "");
                OdbcDr = commODBC.ExecuteReader();
                trODBC.Commit();
                while (OdbcDr.Read())
                {
                    rnomina c = new rnomina();
                    suanomina s = new suanomina();

                    c.cuenta=((OdbcDr["cuenta"] == DBNull.Value) ? "0" : OdbcDr["cuenta"].ToString());
                    c.noempleado = ((OdbcDr["empleado"] == DBNull.Value) ? "0" : OdbcDr["empleado"].ToString());
                    c.salariodiarioI = ((OdbcDr["SDI"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SDI"].ToString()));
                    c.NOMBREP = ((OdbcDr["NOMBRE_EMPLEADO"] == DBNull.Value) ? "0" : OdbcDr["NOMBRE_EMPLEADO"].ToString());
                    c.otrosingP = ((OdbcDr["otrosingresos"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["otrosingresos"].ToString()));
                    c.CUOTADIARIAP = ((OdbcDr["SALARIO_DIARIO_ACTUAL"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["SALARIO_DIARIO_ACTUAL"].ToString()));
                    c.dias_laborados = ((OdbcDr["DIAS_LABORADOS"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["DIAS_LABORADOS"].ToString()));
                    c.diasP = ((OdbcDr["trabajados_reales"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["trabajados_reales"].ToString()));
                    c.sueldoP = c.diasP * c.CUOTADIARIAP;
                    c.fondodeahorroP = ((OdbcDr["FONDODEAHORRO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["FONDODEAHORRO"].ToString()));
                    c.valesdedespensaP = ((OdbcDr["valesdedespensa"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["valesdedespensa"].ToString()));
                    c.subsidioalempleoP = ((OdbcDr["subsidioalempleo"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["subsidioalempleo"].ToString()));
                    c.totalpercepcionesP = c.sueldoP + c.fondodeahorroP + c.valesdedespensaP + c.subsidioalempleoP;
                    c.retencionimssP = ((OdbcDr["imss"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["imss"].ToString()));
                    c.retencionisrP = ((OdbcDr["isr"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["isr"].ToString()));
                    c.valesdedespensadP = ((OdbcDr["valesdedespensa"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["valesdedespensa"].ToString()));
                    c.fondodeahorroemp = ((OdbcDr["FONDODEAHORRO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["FONDODEAHORRO"].ToString()));
                    c.fondodeahorropaP = ((OdbcDr["FONDODEAHORRO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["FONDODEAHORRO"].ToString()));
                    c.amortizacionP = 0;
                    c.totaldP = c.retencionimssP + c.retencionisrP + c.fondodeahorroemp + c.fondodeahorropaP + c.amortizacionP;
                    
                    
                    var options = new[] { "610616", "610618", "610616", "610604", "610626", "610627", "610628", "610629", "610630", "610631", "610632" };

                    if (options.Contains(c.noempleado))
                    {
                        c.aguinaldo15P = ((c.CUOTADIARIAP * 15) / 12);
                        c.aguinaldo30P = 0;
                    }
                    else
                    {
                        c.aguinaldo30P = ((c.CUOTADIARIAP * 30) / 12);
                        c.aguinaldo15P = 0;
                    }

                    //prima vacacional 25%

                    var options1 = new[] { "610618", "610615", "610604", "610626", "610627", "610628", "610630", "610631", "610632" };
                    if (options1.Contains(c.noempleado))
                    {
                        c.primav25P = (((c.CUOTADIARIAP * 6) * 0.25) / 12);
                        c.primav70P = 0;
                    }

                    var options2 = new[] {"610616","610629" };

                    if (options2.Contains(c.noempleado))
                    {
                        c.primav25P = (((c.CUOTADIARIAP * 10) * 0.25) / 12);
                        c.primav70P = 0;
                    }

                    //prima vacacional 70%

                    var options3 = new[] { "610610", "610625", "610607", "610619", "610608" };
                    if (options3.Contains(c.noempleado))
                    {
                        c.primav70P = (((c.CUOTADIARIAP * 13) * 0.7) / 12);
                    c.primav25P = 0;
                    }
                    var options4 = new[] { "610609", "610606", "610620", "610621", "610601", "610602" };
                    if (options4.Contains(c.noempleado))
                    {
                        c.primav70P = (((c.CUOTADIARIAP * 11) * 0.7) / 12);
                    c.primav25P = 0;
                    }
                    var options5 = new[] { "610624","610612","610617","610614","610622","610603","610611","610605" };
                    if (options5.Contains(c.noempleado))
                    {
                        c.primav70P = (((c.CUOTADIARIAP * 10) * 0.7) / 12);
                    c.primav25P = 0;
                    }
                    var options6 = new[] {"610613" };
                    if (options6.Contains(c.noempleado))
                    {
                        c.primav70P = (((c.CUOTADIARIAP * 6) * 0.25) / 12);

                    c.primav25P = 0;
                    }

                    c.vales10P = ((OdbcDr["valesdedespensa"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["valesdedespensa"].ToString()));
                    c.fondo13P = ((OdbcDr["FONDODEAHORRO"] == DBNull.Value) ? 0 : Convert.ToDouble(OdbcDr["FONDODEAHORRO"].ToString()));

                    c.totalpresP = c.aguinaldo15P + c.aguinaldo30P + c.primav25P + c.primav70P + c.vales10P + c.fondo13P;

                    //sua
                    double factorIntegracion, salariominimodf, sueldomensual2;
                    string izquierda = "Costo de Administración";
                    Int16 tiponomina, baseimpuestonomina;
                   
                    
                    factorIntegracion = c.sdi / c.sueldodiario;
                    salariominimodf = 75.49;
                    sueldomensual2 = c.dias_laborados * c.sueldodiario;
                    s.SMG = c.sueldodiario / salariominimodf;
                    s.ingresosexentosIMSSxsalarios = 0;
                    s.salariobasedecotizacion = (((sueldomensual2 - s.ingresosexentosIMSSxsalarios) / c.dias_laborados) * factorIntegracion > salariominimodf * 25 ? (salariominimodf * 25) * c.dias_laborados : (sueldomensual2 - s.ingresosexentosIMSSxsalarios) * factorIntegracion);
                    s.salariominimoDF = (s.salariobasedecotizacion > 0 ? (salariominimodf * c.dias_laborados) : 0);
                    s.excedente35mgdf = (s.salariobasedecotizacion - (s.salariominimoDF * 3) > 0 ? s.salariobasedecotizacion - (s.salariominimoDF * 3) : 0);
                    s.riesgodetrabajop = (s.salariobasedecotizacion * 0.54355) / 100;
                    izquierda = "Costo de Administración";
                    s.coutafijap = (izquierda == "PRECAUCIÓN" ? s.salariominimoDF * 20.4 * 2.7 : s.coutafijap = s.salariominimoDF * 20.4 / 100);
                    s.exedentep = s.excedente35mgdf * 1.1 / 100;
                    s.prestacionesendinerop = s.salariobasedecotizacion * 0.7 / 100;
                    s.gastosmedicospensionadosp = s.salariobasedecotizacion * 1.05 / 100;
                    s.invalidezyvidap = s.salariobasedecotizacion * 1.75 / 100;
                    s.guaderiasp = s.salariobasedecotizacion * 1 / 100;
                    s.retirop = (s.salariobasedecotizacion * 2 / 100);
                    s.cesantiayvejezp = s.salariobasedecotizacion * 3.15 / 100;
                    s.totalpatron = s.riesgodetrabajop + s.coutafijap + s.exedentep + s.prestacionesendinerop + s.gastosmedicospensionadosp + s.invalidezyvidap + s.guaderiasp + s.retirop + s.cesantiayvejezp;

                    //trabajador

                    s.exedentet = s.excedente35mgdf * 0.4 / 100;
                    s.prestacionesendinerot = s.salariobasedecotizacion * 0.25 / 100;
                    s.gastosmedicospensionadost = s.salariobasedecotizacion * 0.375 / 100;
                    s.invalidezyvidat = s.salariobasedecotizacion * 0.625 / 100;
                    s.cesantiayvejezt = (izquierda == "PRECAUCIÓN" ? s.cesantiayvejezt = (s.salariobasedecotizacion * 1.125 / 100) * 2.7 : s.cesantiayvejezt = s.salariobasedecotizacion * 1.125 / 100);
                    s.totaltrabador = s.exedentet + s.prestacionesendinerot + s.gastosmedicospensionadost + s.invalidezyvidat + s.cesantiayvejezt;
                    s.riesgodetrabajopyt = s.riesgodetrabajop;
                    s.coutafijapyt = s.coutafijap;
                    s.exedentepyt = s.exedentep + s.exedentet;
                    s.prestacionesendineropyt = s.prestacionesendinerop + s.prestacionesendinerot;
                    s.gastosmedicospensionadospyt = s.gastosmedicospensionadosp + s.gastosmedicospensionadost;
                    s.invalidezyvidapyt = s.invalidezyvidap + s.invalidezyvidat;
                    s.guaderiaspyt = s.guaderiasp;
                    s.retiropyt = s.retirop;
                    s.cesantiayvejezpyt = s.cesantiayvejezp + s.cesantiayvejezt;
                    s.totalpatronyt = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt + s.retiropyt + s.cesantiayvejezpyt;
                    s.mensual = s.riesgodetrabajopyt + s.coutafijapyt + s.exedentepyt + s.prestacionesendineropyt + s.gastosmedicospensionadospyt + s.invalidezyvidapyt + s.guaderiaspyt;
                    s.bimestral = s.retiropyt + s.cesantiayvejezpyt;
                    tiponomina = 1;
                    s.total = (tiponomina == 1 ? s.mensual + s.bimestral : 0);
                    s.infonavit = (tiponomina == 1 ? s.salariobasedecotizacion * 5 / 100 : 0);
                    baseimpuestonomina = 1;
                    s.ingresosexentosimpuestossobrenominas = 0;
                    s.asimiladosmensuales = 0;
                    s.impuestosobrenominac = (baseimpuestonomina == 1 ? ((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) * 3 / 100 : s.impuestosobrenominac = (((sueldomensual2 * 1) - s.ingresosexentosimpuestossobrenominas) + s.asimiladosmensuales) * 3 / 100);
                    c.costosimssP = s.total + s.infonavit + s.impuestosobrenominac;
                    //sua

                    //isn
                    c.costosisnP = ((c.sueldoP + c.otrosingP + c.vales10P + c.fondo13P) * 3 / 100);
                    c.totalimpuesto = c.costosimssP - c.costosisnP;
                    c.costopatronalP = (c.sueldoP + c.totalpresP + c.totalimpuesto + c.costosisnP);
                    c.comisionP = (c.costopatronalP * 0.14);
                    c.subtP = (c.costopatronalP + c.comisionP);
                    c.ivaP = (c.subtP * 0.16);
                    c.totalP = (c.subtP + c.ivaP);
                    arreDatos.Add(c);
                }
                this.m_ConnODBC.Close();
                return arreDatos;

            }
            catch (Exception e)
            {
                MessageBox.Show("El error es " + e);
                throw;
            }

        }
    }
}
