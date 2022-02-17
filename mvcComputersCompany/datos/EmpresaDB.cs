﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    class EmpresaDB
    {
        static ConnectionDB atrConnecionDB = new ConnectionDB();

        public string InsertarEmpresa(int prmNit, string prmNombre, DateTime prmFechaCreacion) {
            try
            {
                OracleCommand myCommand = new OracleCommand("ComputersCompany.prcRegistrarEmpresa", atrConnecionDB.getMyConnection());
                myCommand.Parameters.Add("P_NIT", OracleDbType.Int64, prmNit, ParameterDirection.Input);
                myCommand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2, prmNombre, ParameterDirection.Input);
                myCommand.Parameters.Add("P_FECHA_CREACION", OracleDbType.Date, prmFechaCreacion, ParameterDirection.Input);
                myCommand.CommandType = CommandType.StoredProcedure;
                return "Se ha registrado la empresa";
            }
            catch (Exception)
            {
                return "No se ha registrado la empresa";
            }
            finally 
            {
                atrConnecionDB.ComprobarConnection();
            }
        }
    }
}