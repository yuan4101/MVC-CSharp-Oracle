using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            prmConsulta = "INSERT INTO COMPUTADORES(COM_NRO_SERIAL, EM_NIT, COM_MARCA, COM_CAP_DISCO_DURO_GB, COM_TIPO_DISCO_DURO, COM_CAP_MEMORIA_RAM_GB, COM_FECHA_ENSAMBLE) " +
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
            varConsulta = "SELECT * FROM COMPUTADOR WHERE EM_NIT = (SELECT EM_NIT FROM EMPRESA WHERE EM_NOMBRE = '"+ prmEmpresa +"')";
            varDB = atrDataBase.executeSELECT(varConsulta);
            return varDB;

        }
    }
}
