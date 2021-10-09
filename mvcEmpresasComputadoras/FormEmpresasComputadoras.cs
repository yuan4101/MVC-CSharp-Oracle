using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mvcEmpresasComputadoras.Logica;

namespace MVC_CSharp_Oracle
{
    public partial class FormEmpresasComputadoras : Form
    {
        public FormEmpresasComputadoras()
        {
            InitializeComponent();
        }

        clsEmpresa atrEmpresa = new clsEmpresa();
        clsComputador atrComputador = new clsComputador();
        int atrEstadoConsulta = 0;

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {

            int varNIT = int.Parse(txtRegistroNIT.Text);
            string varNombre = txtRegistroNombre.Text;
            string varFechaCreacion = dtpFechaCreacion.Value.ToString();
            atrEstadoConsulta = atrEmpresa.ingresarEmpresa(varNIT, varNombre, varFechaCreacion);
            if (atrEstadoConsulta > 0) {
                lblEmpresaEstadoRegistro.Text = "Registro completo";
                lblEmpresaEstadoRegistro.Visible = true;
            }
            else {
                lblEmpresaEstadoRegistro.Text = "Registro no completado";
                lblEmpresaEstadoRegistro.Visible = true;
            }
        }

        private void btnRegistarComputadora_Click(object sender, EventArgs e)
        {
            int varSerial = int.Parse(txtComputadoraNroSerial.Text);
            int varEM_NIT = int.Parse(txtComputadoraNITEmpPertenece.Text);
            string varMarca = cbxComputadoraMarca.Items[cbxComputadoraMarca.SelectedIndex].ToString();
            int varCapDiscoDuro = int.Parse(txtComputadoraCapDiscoGB.Text); 
            string varTipoDisco = txtComputadoraTipoDiscoDuro.Text;
            int varCapMemoria = int.Parse(txtComputadoraCapRAMGB.Text);
            string varFechaEnsable = dtpFechaEnsamble.Value.ToString();
            atrEstadoConsulta = atrComputador.ingresarComputador(varSerial, varEM_NIT, varMarca, varCapDiscoDuro, varTipoDisco, varCapMemoria, varFechaEnsable);
            if (atrEstadoConsulta > 0)
            {
                lblComputadorEstadoRegistro.Text = "Registro completo";
                lblComputadorEstadoRegistro.Visible = true;
            }
            else
            {
                lblComputadorEstadoRegistro.Text = "Registro no completado";
                lblComputadorEstadoRegistro.Visible = true;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string varEmpresa = txtCosultaEmpresa.Text;
            DataSet varDataSetReult = new DataSet();
            varDataSetReult = atrComputador.consultaComputadorPorEmpresa(varEmpresa);
            dtgvConsultaComputadores.DataSource = varDataSetReult;
            dtgvConsultaComputadores.DataMember = "ResultadoDatos";
        }
    }
}
