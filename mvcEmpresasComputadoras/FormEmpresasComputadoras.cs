﻿using System;
using System.Data;
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
            string[] varFechaCreacion = dtpFechaCreacion.Value.ToString().Split();
            try
            {
                atrEstadoConsulta = atrEmpresa.ingresarEmpresa(varNIT, varNombre, varFechaCreacion[0]);
            }
            catch (Exception)
            {
                atrEstadoConsulta = -1;
            }
            if (atrEstadoConsulta > 0)
            {
                lblEmpresaEstadoRegistro.Text = "Registro completo";
                lblEmpresaEstadoRegistro.Visible = true;
            }
            else
            {
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
            string[] varFechaEnsable = dtpFechaEnsamble.Value.ToString().Split();
            try
            {
                atrEstadoConsulta = atrComputador.ingresarComputador(varSerial, varEM_NIT, varMarca, varCapDiscoDuro, varTipoDisco, varCapMemoria, varFechaEnsable[0]);
            }
            catch (Exception)
            {
                atrEstadoConsulta = -1;
            }
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
            DataSet varDataSetReult;
            try
            {
                varDataSetReult = atrComputador.consultaComputadorPorEmpresa(varEmpresa);
                dtgvConsultaComputadores.DataSource = varDataSetReult;
                dtgvConsultaComputadores.DataMember = "ResultadoDatos";
                lblConsultaEstado.Text = "Consulta realizada correctamente";
                lblConsultaEstado.Visible = true;
            }
            catch (Exception)
            {
                lblConsultaEstado.Text = "Consulta no realizada";
                lblConsultaEstado.Visible = true;
            }
        }
    }
}
