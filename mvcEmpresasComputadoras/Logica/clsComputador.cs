using System.Data;
using mvcEmpresasComputadoras.accesoDatos;

namespace mvcEmpresasComputadoras.Logica
{
    class clsComputador
    {
        clsConnectionDB atrDataBase = new clsConnectionDB();

        public int ingresarComputador(int prmSerial, int prmEM_NIT, string prmMarca, int prmCapDiscoDuro, string prmTipoDisco, int prmCapMemoria, string prmFechaEnsable)
        {
            int varResultado;
            string prmConsulta;
            prmConsulta = "INSERT INTO COMPUTADOR(COM_NRO_SERIAL, EM_NIT, COM_MARCA, COM_CAP_DISCO_DURO_GB, COM_TIPO_DISCO_DURO, COM_CAP_MEMORIA_RAM_GB, COM_FECHA_ENSAMBLE) " +
            "VALUES (" + prmSerial + "," + prmEM_NIT + ",'" + prmMarca + "'," + prmCapDiscoDuro + ",'" + prmTipoDisco + "'," + prmCapMemoria + ", TO_DATE('" + prmFechaEnsable + "', 'DD/MM/YY'))";
            varResultado = atrDataBase.executeDML(prmConsulta);
            return varResultado;
        }

        public DataSet consultaComputador() {
            DataSet varDB;
            string varConsulta;
            varConsulta = "SELECT * FROM COMPUTADOR";
            varDB = atrDataBase.executeSELECT(varConsulta);
            return varDB;
        }
        public DataSet consultaComputadorPorEmpresa(string prmEmpresa)
        {
            DataSet varDB;
            string varConsulta;
            varConsulta = "SELECT COM_NRO_SERIAL SERIAL, EM_NIT NIT, COM_MARCA MARCA, COM_CAP_DISCO_DURO_GB \"CAPACIDAD DISCO\", COM_TIPO_DISCO_DURO \"TIPO DISCO\", COM_CAP_MEMORIA_RAM_GB RAM, COM_FECHA_ENSAMBLE \"FECHA ENSAMBLE\" FROM COMPUTADOR WHERE EM_NIT = (SELECT EM_NIT FROM EMPRESA WHERE EM_NOMBRE = '" + prmEmpresa + "')";
            varDB = atrDataBase.executeSELECT(varConsulta);
            return varDB;
        }
    }
}
