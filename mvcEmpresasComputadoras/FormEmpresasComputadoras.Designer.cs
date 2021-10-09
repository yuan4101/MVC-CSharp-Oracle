
namespace MVC_CSharp_Oracle
{
    partial class FormEmpresasComputadoras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresasComputadoras));
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dtgvConsultaComputadores = new System.Windows.Forms.DataGridView();
            this.labelCosultaEmpresa = new System.Windows.Forms.Label();
            this.txtCosultaEmpresa = new System.Windows.Forms.TextBox();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegistroEmpresa = new System.Windows.Forms.TabPage();
            this.lblEmpresaEstadoRegistro = new System.Windows.Forms.Label();
            this.panelRegistroEmpresa = new System.Windows.Forms.Panel();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarEmpresa = new System.Windows.Forms.Button();
            this.txtRegistroNombre = new System.Windows.Forms.TextBox();
            this.txtRegistroNIT = new System.Windows.Forms.TextBox();
            this.labelFechaCreacion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNIT = new System.Windows.Forms.Label();
            this.labelRegistrarEmpresa = new System.Windows.Forms.Label();
            this.tabRegistroComputadora = new System.Windows.Forms.TabPage();
            this.lblComputadorEstadoRegistro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxComputadoraMarca = new System.Windows.Forms.ComboBox();
            this.txtComputadoraNITEmpPertenece = new System.Windows.Forms.TextBox();
            this.labelComputadoraNitEmpPerenecie = new System.Windows.Forms.Label();
            this.txtComputadoraCapRAMGB = new System.Windows.Forms.TextBox();
            this.labelComputadoraCapRAMGB = new System.Windows.Forms.Label();
            this.txtComputadoraTipoDiscoDuro = new System.Windows.Forms.TextBox();
            this.labelComputadoraTipoDiscoDuro = new System.Windows.Forms.Label();
            this.txtComputadoraCapDiscoGB = new System.Windows.Forms.TextBox();
            this.txtComputadoraCapDiscoDuroGB = new System.Windows.Forms.TextBox();
            this.labelComputadoraCapDiscoDuroGB = new System.Windows.Forms.Label();
            this.labelCapDiscoDuroGB = new System.Windows.Forms.Label();
            this.dtpFechaEnsamble = new System.Windows.Forms.DateTimePicker();
            this.btnRegistarComputadora = new System.Windows.Forms.Button();
            this.txtComputadoraNroSerial = new System.Windows.Forms.TextBox();
            this.labelFechaEnsamble = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelNroSerial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultaComputadores)).BeginInit();
            this.tabRegistro.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegistroEmpresa.SuspendLayout();
            this.panelRegistroEmpresa.SuspendLayout();
            this.tabRegistroComputadora.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.dtgvConsultaComputadores);
            this.tabConsulta.Controls.Add(this.labelCosultaEmpresa);
            this.tabConsulta.Controls.Add(this.txtCosultaEmpresa);
            this.tabConsulta.Controls.Add(this.labelConsulta);
            this.tabConsulta.Controls.Add(this.btnConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(768, 400);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dtgvConsultaComputadores
            // 
            this.dtgvConsultaComputadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsultaComputadores.Location = new System.Drawing.Point(12, 60);
            this.dtgvConsultaComputadores.Name = "dtgvConsultaComputadores";
            this.dtgvConsultaComputadores.Size = new System.Drawing.Size(744, 282);
            this.dtgvConsultaComputadores.TabIndex = 4;
            // 
            // labelCosultaEmpresa
            // 
            this.labelCosultaEmpresa.AutoSize = true;
            this.labelCosultaEmpresa.Location = new System.Drawing.Point(297, 357);
            this.labelCosultaEmpresa.Name = "labelCosultaEmpresa";
            this.labelCosultaEmpresa.Size = new System.Drawing.Size(143, 13);
            this.labelCosultaEmpresa.TabIndex = 3;
            this.labelCosultaEmpresa.Text = "Ingrese empresa a consultar:";
            // 
            // txtCosultaEmpresa
            // 
            this.txtCosultaEmpresa.Location = new System.Drawing.Point(446, 354);
            this.txtCosultaEmpresa.Name = "txtCosultaEmpresa";
            this.txtCosultaEmpresa.Size = new System.Drawing.Size(143, 20);
            this.txtCosultaEmpresa.TabIndex = 2;
            this.txtCosultaEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCosultaEmpresa.WordWrap = false;
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulta.Location = new System.Drawing.Point(34, 27);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(492, 18);
            this.labelConsulta.TabIndex = 1;
            this.labelConsulta.Text = "Consultar todos los datos de computadores para una empresa específica";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(595, 348);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(145, 30);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Realizar consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.tabControl2);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(768, 400);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegistroEmpresa);
            this.tabControl2.Controls.Add(this.tabRegistroComputadora);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(756, 388);
            this.tabControl2.TabIndex = 0;
            // 
            // tabRegistroEmpresa
            // 
            this.tabRegistroEmpresa.Controls.Add(this.lblEmpresaEstadoRegistro);
            this.tabRegistroEmpresa.Controls.Add(this.panelRegistroEmpresa);
            this.tabRegistroEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroEmpresa.Name = "tabRegistroEmpresa";
            this.tabRegistroEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroEmpresa.Size = new System.Drawing.Size(748, 362);
            this.tabRegistroEmpresa.TabIndex = 0;
            this.tabRegistroEmpresa.Text = "Empresa";
            this.tabRegistroEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblEmpresaEstadoRegistro
            // 
            this.lblEmpresaEstadoRegistro.AutoSize = true;
            this.lblEmpresaEstadoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaEstadoRegistro.Location = new System.Drawing.Point(452, 152);
            this.lblEmpresaEstadoRegistro.Name = "lblEmpresaEstadoRegistro";
            this.lblEmpresaEstadoRegistro.Size = new System.Drawing.Size(210, 29);
            this.lblEmpresaEstadoRegistro.TabIndex = 1;
            this.lblEmpresaEstadoRegistro.Text = "Estado de registro";
            this.lblEmpresaEstadoRegistro.Visible = false;
            // 
            // panelRegistroEmpresa
            // 
            this.panelRegistroEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistroEmpresa.Controls.Add(this.dtpFechaCreacion);
            this.panelRegistroEmpresa.Controls.Add(this.btnRegistrarEmpresa);
            this.panelRegistroEmpresa.Controls.Add(this.txtRegistroNombre);
            this.panelRegistroEmpresa.Controls.Add(this.txtRegistroNIT);
            this.panelRegistroEmpresa.Controls.Add(this.labelFechaCreacion);
            this.panelRegistroEmpresa.Controls.Add(this.labelNombre);
            this.panelRegistroEmpresa.Controls.Add(this.labelNIT);
            this.panelRegistroEmpresa.Controls.Add(this.labelRegistrarEmpresa);
            this.panelRegistroEmpresa.Location = new System.Drawing.Point(6, 6);
            this.panelRegistroEmpresa.Name = "panelRegistroEmpresa";
            this.panelRegistroEmpresa.Size = new System.Drawing.Size(405, 356);
            this.panelRegistroEmpresa.TabIndex = 0;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Location = new System.Drawing.Point(165, 145);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCreacion.TabIndex = 8;
            // 
            // btnRegistrarEmpresa
            // 
            this.btnRegistrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpresa.Location = new System.Drawing.Point(114, 288);
            this.btnRegistrarEmpresa.Name = "btnRegistrarEmpresa";
            this.btnRegistrarEmpresa.Size = new System.Drawing.Size(140, 50);
            this.btnRegistrarEmpresa.TabIndex = 7;
            this.btnRegistrarEmpresa.Text = "Registrar";
            this.btnRegistrarEmpresa.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpresa.Click += new System.EventHandler(this.btnRegistrarEmpresa_Click);
            // 
            // txtRegistroNombre
            // 
            this.txtRegistroNombre.Location = new System.Drawing.Point(165, 106);
            this.txtRegistroNombre.Name = "txtRegistroNombre";
            this.txtRegistroNombre.Size = new System.Drawing.Size(200, 20);
            this.txtRegistroNombre.TabIndex = 5;
            // 
            // txtRegistroNIT
            // 
            this.txtRegistroNIT.Location = new System.Drawing.Point(165, 66);
            this.txtRegistroNIT.Name = "txtRegistroNIT";
            this.txtRegistroNIT.Size = new System.Drawing.Size(200, 20);
            this.txtRegistroNIT.TabIndex = 4;
            // 
            // labelFechaCreacion
            // 
            this.labelFechaCreacion.AutoSize = true;
            this.labelFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCreacion.Location = new System.Drawing.Point(35, 145);
            this.labelFechaCreacion.Name = "labelFechaCreacion";
            this.labelFechaCreacion.Size = new System.Drawing.Size(111, 15);
            this.labelFechaCreacion.TabIndex = 3;
            this.labelFechaCreacion.Text = "Fecha de creacion:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(35, 105);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(55, 15);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelNIT
            // 
            this.labelNIT.AutoSize = true;
            this.labelNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIT.Location = new System.Drawing.Point(35, 65);
            this.labelNIT.Name = "labelNIT";
            this.labelNIT.Size = new System.Drawing.Size(29, 15);
            this.labelNIT.TabIndex = 1;
            this.labelNIT.Text = "NIT:";
            // 
            // labelRegistrarEmpresa
            // 
            this.labelRegistrarEmpresa.AutoSize = true;
            this.labelRegistrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarEmpresa.Location = new System.Drawing.Point(80, 20);
            this.labelRegistrarEmpresa.Name = "labelRegistrarEmpresa";
            this.labelRegistrarEmpresa.Size = new System.Drawing.Size(237, 18);
            this.labelRegistrarEmpresa.TabIndex = 0;
            this.labelRegistrarEmpresa.Text = "Digite los datos de la empresa";
            this.labelRegistrarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRegistroComputadora
            // 
            this.tabRegistroComputadora.Controls.Add(this.lblComputadorEstadoRegistro);
            this.tabRegistroComputadora.Controls.Add(this.panel1);
            this.tabRegistroComputadora.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroComputadora.Name = "tabRegistroComputadora";
            this.tabRegistroComputadora.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroComputadora.Size = new System.Drawing.Size(748, 362);
            this.tabRegistroComputadora.TabIndex = 1;
            this.tabRegistroComputadora.Text = "Computadora";
            this.tabRegistroComputadora.UseVisualStyleBackColor = true;
            // 
            // lblComputadorEstadoRegistro
            // 
            this.lblComputadorEstadoRegistro.AutoSize = true;
            this.lblComputadorEstadoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputadorEstadoRegistro.Location = new System.Drawing.Point(446, 151);
            this.lblComputadorEstadoRegistro.Name = "lblComputadorEstadoRegistro";
            this.lblComputadorEstadoRegistro.Size = new System.Drawing.Size(210, 29);
            this.lblComputadorEstadoRegistro.TabIndex = 2;
            this.lblComputadorEstadoRegistro.Text = "Estado de registro";
            this.lblComputadorEstadoRegistro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxComputadoraMarca);
            this.panel1.Controls.Add(this.txtComputadoraNITEmpPertenece);
            this.panel1.Controls.Add(this.labelComputadoraNitEmpPerenecie);
            this.panel1.Controls.Add(this.txtComputadoraCapRAMGB);
            this.panel1.Controls.Add(this.labelComputadoraCapRAMGB);
            this.panel1.Controls.Add(this.txtComputadoraTipoDiscoDuro);
            this.panel1.Controls.Add(this.labelComputadoraTipoDiscoDuro);
            this.panel1.Controls.Add(this.txtComputadoraCapDiscoGB);
            this.panel1.Controls.Add(this.txtComputadoraCapDiscoDuroGB);
            this.panel1.Controls.Add(this.labelComputadoraCapDiscoDuroGB);
            this.panel1.Controls.Add(this.labelCapDiscoDuroGB);
            this.panel1.Controls.Add(this.dtpFechaEnsamble);
            this.panel1.Controls.Add(this.btnRegistarComputadora);
            this.panel1.Controls.Add(this.txtComputadoraNroSerial);
            this.panel1.Controls.Add(this.labelFechaEnsamble);
            this.panel1.Controls.Add(this.labelMarca);
            this.panel1.Controls.Add(this.labelNroSerial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 356);
            this.panel1.TabIndex = 1;
            // 
            // cbxComputadoraMarca
            // 
            this.cbxComputadoraMarca.FormattingEnabled = true;
            this.cbxComputadoraMarca.Items.AddRange(new object[] {
            "Lenovo",
            "Dell",
            "Asus"});
            this.cbxComputadoraMarca.Location = new System.Drawing.Point(214, 117);
            this.cbxComputadoraMarca.Name = "cbxComputadoraMarca";
            this.cbxComputadoraMarca.Size = new System.Drawing.Size(151, 21);
            this.cbxComputadoraMarca.TabIndex = 17;
            // 
            // txtComputadoraNITEmpPertenece
            // 
            this.txtComputadoraNITEmpPertenece.Location = new System.Drawing.Point(214, 91);
            this.txtComputadoraNITEmpPertenece.Name = "txtComputadoraNITEmpPertenece";
            this.txtComputadoraNITEmpPertenece.Size = new System.Drawing.Size(151, 20);
            this.txtComputadoraNITEmpPertenece.TabIndex = 16;
            // 
            // labelComputadoraNitEmpPerenecie
            // 
            this.labelComputadoraNitEmpPerenecie.AutoSize = true;
            this.labelComputadoraNitEmpPerenecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputadoraNitEmpPerenecie.Location = new System.Drawing.Point(35, 91);
            this.labelComputadoraNitEmpPerenecie.Name = "labelComputadoraNitEmpPerenecie";
            this.labelComputadoraNitEmpPerenecie.Size = new System.Drawing.Size(176, 15);
            this.labelComputadoraNitEmpPerenecie.TabIndex = 15;
            this.labelComputadoraNitEmpPerenecie.Text = "NIT de empresa perteneciente:";
            // 
            // txtComputadoraCapRAMGB
            // 
            this.txtComputadoraCapRAMGB.Location = new System.Drawing.Point(238, 195);
            this.txtComputadoraCapRAMGB.Name = "txtComputadoraCapRAMGB";
            this.txtComputadoraCapRAMGB.Size = new System.Drawing.Size(127, 20);
            this.txtComputadoraCapRAMGB.TabIndex = 14;
            // 
            // labelComputadoraCapRAMGB
            // 
            this.labelComputadoraCapRAMGB.AutoSize = true;
            this.labelComputadoraCapRAMGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputadoraCapRAMGB.Location = new System.Drawing.Point(35, 196);
            this.labelComputadoraCapRAMGB.Name = "labelComputadoraCapRAMGB";
            this.labelComputadoraCapRAMGB.Size = new System.Drawing.Size(197, 15);
            this.labelComputadoraCapRAMGB.TabIndex = 13;
            this.labelComputadoraCapRAMGB.Text = "Capacidad de memoria RAM (GB):";
            // 
            // txtComputadoraTipoDiscoDuro
            // 
            this.txtComputadoraTipoDiscoDuro.Location = new System.Drawing.Point(215, 169);
            this.txtComputadoraTipoDiscoDuro.Name = "txtComputadoraTipoDiscoDuro";
            this.txtComputadoraTipoDiscoDuro.Size = new System.Drawing.Size(150, 20);
            this.txtComputadoraTipoDiscoDuro.TabIndex = 12;
            // 
            // labelComputadoraTipoDiscoDuro
            // 
            this.labelComputadoraTipoDiscoDuro.AutoSize = true;
            this.labelComputadoraTipoDiscoDuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputadoraTipoDiscoDuro.Location = new System.Drawing.Point(35, 170);
            this.labelComputadoraTipoDiscoDuro.Name = "labelComputadoraTipoDiscoDuro";
            this.labelComputadoraTipoDiscoDuro.Size = new System.Drawing.Size(111, 15);
            this.labelComputadoraTipoDiscoDuro.TabIndex = 11;
            this.labelComputadoraTipoDiscoDuro.Text = "Tipo de disco duro:";
            // 
            // txtComputadoraCapDiscoGB
            // 
            this.txtComputadoraCapDiscoGB.Location = new System.Drawing.Point(215, 143);
            this.txtComputadoraCapDiscoGB.Name = "txtComputadoraCapDiscoGB";
            this.txtComputadoraCapDiscoGB.Size = new System.Drawing.Size(150, 20);
            this.txtComputadoraCapDiscoGB.TabIndex = 10;
            // 
            // txtComputadoraCapDiscoDuroGB
            // 
            this.txtComputadoraCapDiscoDuroGB.Location = new System.Drawing.Point(215, 143);
            this.txtComputadoraCapDiscoDuroGB.Name = "txtComputadoraCapDiscoDuroGB";
            this.txtComputadoraCapDiscoDuroGB.Size = new System.Drawing.Size(150, 20);
            this.txtComputadoraCapDiscoDuroGB.TabIndex = 10;
            // 
            // labelComputadoraCapDiscoDuroGB
            // 
            this.labelComputadoraCapDiscoDuroGB.AutoSize = true;
            this.labelComputadoraCapDiscoDuroGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputadoraCapDiscoDuroGB.Location = new System.Drawing.Point(35, 144);
            this.labelComputadoraCapDiscoDuroGB.Name = "labelComputadoraCapDiscoDuroGB";
            this.labelComputadoraCapDiscoDuroGB.Size = new System.Drawing.Size(174, 15);
            this.labelComputadoraCapDiscoDuroGB.TabIndex = 9;
            this.labelComputadoraCapDiscoDuroGB.Text = "Capacidad de disco duro (GB):";
            // 
            // labelCapDiscoDuroGB
            // 
            this.labelCapDiscoDuroGB.AutoSize = true;
            this.labelCapDiscoDuroGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapDiscoDuroGB.Location = new System.Drawing.Point(35, 140);
            this.labelCapDiscoDuroGB.Name = "labelCapDiscoDuroGB";
            this.labelCapDiscoDuroGB.Size = new System.Drawing.Size(174, 15);
            this.labelCapDiscoDuroGB.TabIndex = 9;
            this.labelCapDiscoDuroGB.Text = "Capacidad de disco duro (GB):";
            // 
            // dtpFechaEnsamble
            // 
            this.dtpFechaEnsamble.Checked = false;
            this.dtpFechaEnsamble.CustomFormat = "";
            this.dtpFechaEnsamble.Location = new System.Drawing.Point(165, 221);
            this.dtpFechaEnsamble.Name = "dtpFechaEnsamble";
            this.dtpFechaEnsamble.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEnsamble.TabIndex = 8;
            // 
            // btnRegistarComputadora
            // 
            this.btnRegistarComputadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarComputadora.Location = new System.Drawing.Point(114, 288);
            this.btnRegistarComputadora.Name = "btnRegistarComputadora";
            this.btnRegistarComputadora.Size = new System.Drawing.Size(140, 50);
            this.btnRegistarComputadora.TabIndex = 7;
            this.btnRegistarComputadora.Text = "Registrar";
            this.btnRegistarComputadora.UseVisualStyleBackColor = true;
            this.btnRegistarComputadora.Click += new System.EventHandler(this.btnRegistarComputadora_Click);
            // 
            // txtComputadoraNroSerial
            // 
            this.txtComputadoraNroSerial.Location = new System.Drawing.Point(165, 65);
            this.txtComputadoraNroSerial.Name = "txtComputadoraNroSerial";
            this.txtComputadoraNroSerial.Size = new System.Drawing.Size(200, 20);
            this.txtComputadoraNroSerial.TabIndex = 4;
            // 
            // labelFechaEnsamble
            // 
            this.labelFechaEnsamble.AutoSize = true;
            this.labelFechaEnsamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEnsamble.Location = new System.Drawing.Point(35, 225);
            this.labelFechaEnsamble.Name = "labelFechaEnsamble";
            this.labelFechaEnsamble.Size = new System.Drawing.Size(119, 15);
            this.labelFechaEnsamble.TabIndex = 3;
            this.labelFechaEnsamble.Text = "Fecha de ensamble:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(35, 118);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 15);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca:";
            // 
            // labelNroSerial
            // 
            this.labelNroSerial.AutoSize = true;
            this.labelNroSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroSerial.Location = new System.Drawing.Point(35, 65);
            this.labelNroSerial.Name = "labelNroSerial";
            this.labelNroSerial.Size = new System.Drawing.Size(105, 15);
            this.labelNroSerial.TabIndex = 1;
            this.labelNroSerial.Text = "Numero de serial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Digite los datos de la computadora";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // FormEmpresasComputadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpresasComputadoras";
            this.Text = "Empresas de computadoras";
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultaComputadores)).EndInit();
            this.tabRegistro.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegistroEmpresa.ResumeLayout(false);
            this.tabRegistroEmpresa.PerformLayout();
            this.panelRegistroEmpresa.ResumeLayout(false);
            this.panelRegistroEmpresa.PerformLayout();
            this.tabRegistroComputadora.ResumeLayout(false);
            this.tabRegistroComputadora.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.DataGridView dtgvConsultaComputadores;
        private System.Windows.Forms.Label labelCosultaEmpresa;
        private System.Windows.Forms.TextBox txtCosultaEmpresa;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegistroEmpresa;
        private System.Windows.Forms.Label lblEmpresaEstadoRegistro;
        private System.Windows.Forms.Panel panelRegistroEmpresa;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Button btnRegistrarEmpresa;
        private System.Windows.Forms.TextBox txtRegistroNombre;
        private System.Windows.Forms.TextBox txtRegistroNIT;
        private System.Windows.Forms.Label labelFechaCreacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNIT;
        private System.Windows.Forms.Label labelRegistrarEmpresa;
        private System.Windows.Forms.TabPage tabRegistroComputadora;
        private System.Windows.Forms.Label lblComputadorEstadoRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxComputadoraMarca;
        private System.Windows.Forms.TextBox txtComputadoraNITEmpPertenece;
        private System.Windows.Forms.Label labelComputadoraNitEmpPerenecie;
        private System.Windows.Forms.TextBox txtComputadoraCapRAMGB;
        private System.Windows.Forms.Label labelComputadoraCapRAMGB;
        private System.Windows.Forms.TextBox txtComputadoraTipoDiscoDuro;
        private System.Windows.Forms.Label labelComputadoraTipoDiscoDuro;
        private System.Windows.Forms.TextBox txtComputadoraCapDiscoGB;
        private System.Windows.Forms.TextBox txtComputadoraCapDiscoDuroGB;
        private System.Windows.Forms.Label labelComputadoraCapDiscoDuroGB;
        private System.Windows.Forms.Label labelCapDiscoDuroGB;
        private System.Windows.Forms.DateTimePicker dtpFechaEnsamble;
        private System.Windows.Forms.Button btnRegistarComputadora;
        private System.Windows.Forms.TextBox txtComputadoraNroSerial;
        private System.Windows.Forms.Label labelFechaEnsamble;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelNroSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

