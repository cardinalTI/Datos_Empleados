using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleados
{
    class Mcuentas
    {

        string cadena;
        public virtual string conexiofinal(string conexion)
        {

            if (conexion == "NUBULA")
            {
                cadena = ConfigurationManager.ConnectionStrings["NUBULA"].ConnectionString;
            }
            if (conexion == "INFORMATION THECNOLOGY INDUSTRIES")
            {
                cadena = ConfigurationManager.ConnectionStrings["INFORMATION THECNOLOGY INDUSTRIES"].ConnectionString;
            }
            if (conexion == "FOLDUR")
            {
                cadena = ConfigurationManager.ConnectionStrings["FOLDUR"].ConnectionString;
            }
            if (conexion == "MORGET")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGET"].ConnectionString;
            }
            if (conexion == "GRUPO CONISAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["GRUPOCONISAL"].ConnectionString;
            }
            if (conexion == "WIPSI")
            {
                cadena = ConfigurationManager.ConnectionStrings["WIPSI"].ConnectionString;
            }
            if (conexion == "MORGET SEMANAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETSEMANAL"].ConnectionString;
            }
            if (conexion == "MORGET CATORCENAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETCATORCENAL"].ConnectionString;
            }
            if (conexion == "MORGET QUINCENAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETQUINCENAL"].ConnectionString;
            }
            if (conexion == "MORGET MENSUAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETMENSUAL"].ConnectionString;
            }
            if (conexion == "IT TELECOM")
            {
                cadena = ConfigurationManager.ConnectionStrings["ITTELECOM"].ConnectionString;
            }
            if (conexion == "MORGET INTERNA")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETINTERNA"].ConnectionString;
            }
            if (conexion == "AICEL")
            {
                cadena = ConfigurationManager.ConnectionStrings["AICEL"].ConnectionString;
            }
            if (conexion == "CONSORCIO ATERAP SA DE CV")
            {
                cadena = ConfigurationManager.ConnectionStrings["CONSORCIOATERAPSADECV"].ConnectionString;
            }
            if (conexion == "CROTEC SA DE CV")
            {
                cadena = ConfigurationManager.ConnectionStrings["CROTECSADECV"].ConnectionString;
            }
            if (conexion == "PEPSAT SA DE CV")
            {
                cadena = ConfigurationManager.ConnectionStrings["PEPSATSADECV"].ConnectionString;
            }
            if (conexion == "UPHETILOLI 2")
            {
                cadena = ConfigurationManager.ConnectionStrings["UPHETILOLI2"].ConnectionString;
            }

            return cadena;
        }

        public void cargarcuentas(string numero, string cuenta, string rc)
        {
            string cuentacompleta;
          cuentacompleta=  cuenta + "000000000000000000000000000000000000000000000000000000000000000000";

            try
            {
                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                OdbcCommand comando = new OdbcCommand("update empleados set NUM_CTABAN_PAGO_ELECT = '" + cuentacompleta  + "' where numero = '" + numero + "' ");
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }


        public void cargarbancos(string numero,string banco,string rc, string empresa)
        {
            if (empresa == "FOLDUR")
            {
                if (banco == "SANTANDER")
                {
                    banco = "13479";
                }

                if (banco == "BANCOMER")
                {
                    banco = "7516";
                }
            }
         
            if (empresa == "AICEL")
            {
                if (banco == "AZTECA")
                {
                    banco = "17416";
                }

                if (banco == "BANAMEX")
                {
                    banco = "17417";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "17418";
                }
                if (banco == "BANORTE")
                {
                    banco = "17419";
                }
                if (banco == "BBVA")
                {
                    banco = "17420";
                }
                if (banco == "HSBC")
                {
                    banco = "17421";
                }
                if (banco == "INBURSA")
                {
                    banco = "17422";
                }
                if (banco == "SANTANDER")
                {
                    banco = "17423";
                }
                if (banco == "IXE BANCO")
                {
                    banco = "17510";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "17511";
                }
                if (banco == "CHEQUE")
                {
                    banco = "19398";
                }
                if (banco == "BANCO DEL BAJIO")
                {
                    banco = "19399";
                }
                if (banco == "BANCOPPEL")
                {
                    banco = "19400";
                }
                if (banco == "AUTOFIN")
                {
                    banco = "19401";
                }
                if (banco == "AFIRME")
                {
                    banco = "19403";
                }
                if (banco == "BANREGIO")
                {
                    banco = "19609";
                }

            }


            if (empresa == "MORGET INTERNA")
            {
                if (banco == "BANAMEX")
                {
                    banco = "796";
                }
                if (banco == "HSBC")
                {
                    banco = "805";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "813";
                }
                if (banco == "BANORTE")
                {
                    banco = "821";
                }
                if (banco == "BBVA BANCOMER")
                {
                    banco = "829";
                }
                if (banco == "SANTANDER")
                {
                    banco = "839";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "847";
                }

            }
          
            if (empresa == "MORGET SEMANAL")
            {
                if (banco == "AFIRME")
                {
                    banco = "5944";
                }
                if (banco == "AUTOFIN")
                {
                    banco = "5945";
                }
                if (banco == "CITIBANAMEX")
                {
                    banco = "5946";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "5947";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "5949";
                }
                if (banco == "BANCOMER")
                {
                    banco = "5950";
                }
                if (banco == "BANCOPPEL")
                {
                    banco = "5951";
                }
                if (banco == "BANORTE")
                {
                    banco = "5952";
                }
                if (banco == "HSBC")
                {
                    banco = "5953";
                }
                if (banco == "IXE")
                {
                    banco = "5954";
                }
                if (banco == "SANTANDER")
                {
                    banco = "5955";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "5956";
                }
                if (banco == "BANREGIO")
                {
                    banco = "5957";
                }

            }

          

            if (empresa == "MORGET CATORCENAL")
            {
                if (banco == "AFIRME")
                {
                    banco = "2249";
                }
                if (banco == "AUTOFIN")
                {
                    banco = "2250";
                }
                if (banco == "CITIBANAMEX")
                {
                    banco = "2251";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "2252";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "2253";
                }
                if (banco == "BANCOMER")
                {
                    banco = "2255";
                }
                if (banco == "BANCOPPEL")
                {
                    banco = "2254";
                }
                if (banco == "BANORTE")
                {
                    banco = "2256";
                }
                if (banco == "HSBC")
                {
                    banco = "2257";
                }
                if (banco == "IXE")
                {
                    banco = "2258";
                }
                if (banco == "SANTANDER")
                {
                    banco = "2259";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "2260";
                }
                if (banco == "BANREGIO")
                {
                    banco = "2261";
                }

            }


            if (empresa == "MORGET QUINCENAL")
            {
                if (banco == "AFIRME")
                {
                    banco = "828";
                }
                if (banco == "AUTOFIN")
                {
                    banco = "3829";
                }
                if (banco == "CITIBANAMEX")
                {
                    banco = "3830";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "3831";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "3832";
                }
                if (banco == "BANCOMER")
                {
                    banco = "3833";
                }
                if (banco == "BANCOPPEL")
                {
                    banco = "3834";

                }
                if (banco == "BANORTE")
                {
                    banco = "3538";


                }
                if (banco == "HSBC")
                {
                    banco = "3836";

                }
                if (banco == "IXE")
                {
                    banco = "3837";

                }
                if (banco == "SANTANDER")
                {
                    banco = "3838";

                }
                if (banco == "SCOTIABANK")
                {
                    banco = "3839";

                }
                if (banco == "BANREGIO")
                {
                    banco = "3840";


                }
            }

        

            if (empresa == "MORGET MENSUAL")
            {
                if (banco == "AFIRME")
                {
                    banco = "2646";
                }
                if (banco == "AUTOFIN")
                {
                    banco = "2647";
                }
                if (banco == "CITIBANAMEX")
                {
                    banco = "2648";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "2649";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "2650";
                }
                if (banco == "BANCOMER")
                {
                    banco = "2651";
                }
                if (banco == "BANCOPPEL")
                {
                    banco = "2652";

                }
                if (banco == "BANORTE")
                {
                    banco = "2653";


                }
                if (banco == "HSBC")
                {
                    banco = "2654";

                }
                if (banco == "IXE")
                {
                    banco = "2655";

                }
                if (banco == "SANTANDER")
                {
                    banco = "2656";

                }
                if (banco == "SCOTIABANK")
                {
                    banco = "2657";

                }
                if (banco == "BANREGIO")
                {
                    banco = "2658";


                }
            }

            
            if (empresa == "MORGET")
            {
                if (banco == "BANCOMER")
                {
                    banco = "6942";
                }
                if (banco == "AFIRME")
                {
                    banco = "7012";
                }
                if (banco == "AUTOFIN")
                {
                    banco = "7021";
                }
                if (banco == "BANAMEX")
                {
                    banco = "7029";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "7030";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "7031";
                }
                if (banco == "BANCO DEL BAJIO")
                {
                    banco = "7032";
                }
                if (banco == "BANCOPPEL")
                {
                    banco = "7033";
                }
                if (banco == "BANORTE")
                {
                    banco = "7034";
                }
                if (banco == "CHEQUE")
                {
                    banco = "7035";
                }
                if (banco == "HSBC")
                {
                    banco = "7036";
                }
                if (banco == "IXE")
                {
                    banco = "7037";
                }
                if (banco == "SANTANDER")
                {
                    banco = "7038";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "7039";
                }
            }

            if (empresa == "GRUPO CONISAL")
            {
                if (banco == "BBVA")
                {
                    banco = "416";
                }
                if (banco == "BANAMEX")
                {
                    banco = "426";
                }
                if (banco == "INBURSA")
                {
                    banco = "435";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "444";
                }
                if (banco == "AZTECA")
                {
                    banco = "8568";
                }
                if (banco == "BANORTE")
                {
                    banco = "8569";
                }
                if (banco == "HSBC")
                {
                    banco = "8570";
                }
                if (banco == "SANTANDER")
                {
                    banco = "8571";
                }

            }

         

            if (empresa == "WIPSI")
            {

                if (banco == "BBVA")
                {
                    banco = "17420";
                }
                if (banco == "BANAMEX")
                {
                    banco = "17417";
                }
                if (banco == "INBURSA")
                {
                    banco = "17422";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "17418";
                }
                if (banco == "AZTECA")
                {
                    banco = "17416";
                }
                if (banco == "BANORTE")
                {
                    banco = "17419";
                }
                if (banco == "HSBC")
                {
                    banco = "17421";
                }
                if (banco == "SANTANDER")
                {
                    banco = "17423";
                }
                if (banco == "IXE BANCO")
                {
                    banco = "17510";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "17511";
                }

                if (banco == "CHEQUE")
                {
                    banco = "19398";
                }

                if (banco == "BANCO DEL BAJIO")
                {
                    banco = "19399";
                }

                if (banco == "BANCOPPEL")
                {
                    banco = "19400";
                }

                if (banco == "AUTOFIN")
                {
                    banco = "19401";
                }
                if (banco == "AFIRME")
                {
                    banco = "19403";
                }

            }

            

            if (empresa == "IT TELECOM")
            {
                if (banco == "BBVA")
                {
                    banco = "9175";
                }
                if (banco == "BANAMEX")
                {
                    banco = "9172";
                }
                if (banco == "INBURSA")
                {
                    banco = "9177";
                }
                if (banco == "BANBAJIO")
                {
                    banco = "9173";
                }
                if (banco == "IXE BANCO")
                {
                    banco = "9178";
                }
                if (banco == "BANORTE")
                {
                    banco = "9174";
                }
                if (banco == "HSBC")
                {
                    banco = "9176";
                }
                if (banco == "SANTANDER")
                {
                    banco = "9179";
                }
                if (banco == "SCOTIABANK")
                {
                    banco = "9180";
                }

            }


            if (empresa == "UPHETILOLI 2")
            {
                if (banco == "BANORTE")
                {
                    banco = "373";
                }

                if (banco == "AFIRME")
                {
                    banco = "382";
                }

                if (banco == "AUTOFIN")
                {
                    banco = "390";
                }

                if (banco == "BANBAJIO")
                {
                    banco = "398";
                }

                if (banco == "BANCO AZTECA")
                {
                    banco = "406";
                }

                if (banco == "BANCOMER")
                {
                    banco = "414";
                }

                if (banco == "BANCOPPEL")
                {
                    banco = "422";
                }

                if (banco == "BANREGIO")
                {
                    banco = "430";
                }

                if (banco == "CITIBANAMEX")
                {
                    banco = "438";
                }

                if (banco == "HSBC")
                {
                    banco = "446";
                }

                if (banco == "IXE")
                {
                    banco = "454";
                }

                if (banco == "SANTANDER")
                {
                    banco = "462";
                }

                if (banco == "SCOTIABANK")
                {
                    banco = "470";
                }

            }

          
            if (empresa == "NUBULA")
            {
                if (banco == "BANCOMER")
                {
                    banco = "502";
                }

                if (banco == "SANTANDER")
                {
                    banco = "505";
                }

                if (banco == "BANAMEX")
                {
                    banco = "508";
                }

                if (banco == "HSBC")
                {
                    banco = "520";
                }

            }


            if (empresa == "INFORMATION THECNOLOGY")
            {
                if (banco == "BANCOMER")
                {
                    banco = "500";
                }
                if (banco == "BANCO AZTECA")
                {
                    banco = "503";
                }
                if (banco == "HSBC")
                {
                    banco = "514";
                }
                if (banco == "SANTANDER")
                {
                    banco = "521";
                }

            }
            //fin de las cuentas

            try
            {
                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                OdbcCommand comando = new OdbcCommand("update empleados set GRUPO_PAGO_ELECT_ID = '" + banco + "' where numero = '" + numero + "' ");
                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }



        }

    }
}
