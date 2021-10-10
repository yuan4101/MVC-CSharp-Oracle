using mvcEmpresasComputadoras.accesoDatos;

namespace mvcEmpresasComputadoras.Logica
{
    class clsEmpresa
    {
        clsConnectionDB atrDataBase = new clsConnectionDB();

        public int ingresarEmpresa(int prmNIT, string prmNombre, string prmDate) {
            int varResultado;
            string prmConsulta;
            prmConsulta = "INSERT INTO EMPRESA(EM_NIT, EM_NOMBRE, EM_FECHA_CREACION) " +
            "VALUES (" + prmNIT + ",'" + prmNombre + "', TO_DATE('" + prmDate + "', 'DD/MM/YY'))";
            varResultado = atrDataBase.executeDML(prmConsulta);
            return varResultado;
        }
    }
}
