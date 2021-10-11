using System.Data;
using Oracle.DataAccess.Client;

namespace mvcEmpresasComputadoras.accesoDatos
{
    public class clsConnectionDB
    {
        //MODIFIQUE LOS DATOS ACORDE A LOS DATOS DE SU BASE DE DATOS

        private static string atrUserDB = "EmpresasComputadoras";
        private static string atrPasswordDB = "bddarwin";
        //private static string atrPasswordDB = "AnteDatabase";
        private static string atrConnectionDB = "Data Source = localhost; User ID = " + atrUserDB + "; Password=" + atrPasswordDB + ";";

        public int executeDML(string prmConsulta) {
            int varFilasAfectadas;
            OracleConnection varConnection = new OracleConnection(atrConnectionDB);
            OracleCommand varConsulta = new OracleCommand(prmConsulta, varConnection);
            varConnection.Open();
            varFilasAfectadas = varConsulta.ExecuteNonQuery();
            varConnection.Close();
            return varFilasAfectadas;
        }

        public DataSet executeSELECT(string prmConsulta) {
            DataSet varDataSet = new DataSet();
            OracleDataAdapter varAdaptador = new OracleDataAdapter(prmConsulta, atrConnectionDB);
            varAdaptador.Fill(varDataSet, "ResultadoDatos");
            return varDataSet;
        }

        
    }
}
