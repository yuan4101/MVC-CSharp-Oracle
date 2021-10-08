
namespace MVC_CSharp_Oracle
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegistroEmpresa = new System.Windows.Forms.TabPage();
            this.tabRegistroComputadora = new System.Windows.Forms.TabPage();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.panelRegistroEmpresa = new System.Windows.Forms.Panel();
            this.labelRegistrarEmpresa = new System.Windows.Forms.Label();
            this.labelNIT = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaCreacion = new System.Windows.Forms.Label();
            this.txtRegistroNIT = new System.Windows.Forms.TextBox();
            this.txtRegistroNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrarEmpresa = new System.Windows.Forms.Button();
            this.labelEmpresaEstadoRegistro = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechaEnsamble = new System.Windows.Forms.DateTimePicker();
            this.btnRegistarComputadora = new System.Windows.Forms.Button();
            this.txtComputadoraMarca = new System.Windows.Forms.TextBox();
            this.txtComputadoraNroSerial = new System.Windows.Forms.TextBox();
            this.labelFechaEnsamble = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelNroSerial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComputadoraCapDiscoDuroGB = new System.Windows.Forms.TextBox();
            this.labelCapDiscoDuroGB = new System.Windows.Forms.Label();
            this.txtComputadoraTipoDiscoDuro = new System.Windows.Forms.TextBox();
            this.labelComputadoraTipoDiscoDuro = new System.Windows.Forms.Label();
            this.txtComputadoraCapRAMGB = new System.Windows.Forms.TextBox();
            this.labelComputadoraCapRAMGB = new System.Windows.Forms.Label();
            this.txtComputadoraNITEmpPertenece = new System.Windows.Forms.TextBox();
            this.labelComputadoraNitEmpPerenecie = new System.Windows.Forms.Label();
            this.labelComputadoraCapDiscoDuroGB = new System.Windows.Forms.Label();
            this.txtComputadoraCapDiscoGB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegistroEmpresa.SuspendLayout();
            this.tabRegistroComputadora.SuspendLayout();
            this.panelRegistroEmpresa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Controls.Add(this.tabBusqueda);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
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
            // tabConsulta
            // 
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
            this.tabRegistroEmpresa.Controls.Add(this.labelEmpresaEstadoRegistro);
            this.tabRegistroEmpresa.Controls.Add(this.panelRegistroEmpresa);
            this.tabRegistroEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroEmpresa.Name = "tabRegistroEmpresa";
            this.tabRegistroEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroEmpresa.Size = new System.Drawing.Size(748, 362);
            this.tabRegistroEmpresa.TabIndex = 0;
            this.tabRegistroEmpresa.Text = "Empresa";
            this.tabRegistroEmpresa.UseVisualStyleBackColor = true;
            // 
            // tabRegistroComputadora
            // 
            this.tabRegistroComputadora.Controls.Add(this.label1);
            this.tabRegistroComputadora.Controls.Add(this.panel1);
            this.tabRegistroComputadora.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroComputadora.Name = "tabRegistroComputadora";
            this.tabRegistroComputadora.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroComputadora.Size = new System.Drawing.Size(748, 362);
            this.tabRegistroComputadora.TabIndex = 1;
            this.tabRegistroComputadora.Text = "Computadora";
            this.tabRegistroComputadora.UseVisualStyleBackColor = true;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(768, 400);
            this.tabBusqueda.TabIndex = 2;
            this.tabBusqueda.Text = "Búsqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // panelRegistroEmpresa
            // 
            this.panelRegistroEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistroEmpresa.Controls.Add(this.dateTimePicker1);
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
            // txtRegistroNIT
            // 
            this.txtRegistroNIT.Location = new System.Drawing.Point(165, 66);
            this.txtRegistroNIT.Name = "txtRegistroNIT";
            this.txtRegistroNIT.Size = new System.Drawing.Size(200, 20);
            this.txtRegistroNIT.TabIndex = 4;
            // 
            // txtRegistroNombre
            // 
            this.txtRegistroNombre.Location = new System.Drawing.Point(165, 106);
            this.txtRegistroNombre.Name = "txtRegistroNombre";
            this.txtRegistroNombre.Size = new System.Drawing.Size(200, 20);
            this.txtRegistroNombre.TabIndex = 5;
            // 
            // btnRegistrarEmpresa
            // 
            this.btnRegistrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpresa.Location = new System.Drawing.Point(115, 256);
            this.btnRegistrarEmpresa.Name = "btnRegistrarEmpresa";
            this.btnRegistrarEmpresa.Size = new System.Drawing.Size(140, 50);
            this.btnRegistrarEmpresa.TabIndex = 7;
            this.btnRegistrarEmpresa.Text = "Registrar";
            this.btnRegistrarEmpresa.UseVisualStyleBackColor = true;
            // 
            // labelEmpresaEstadoRegistro
            // 
            this.labelEmpresaEstadoRegistro.AutoSize = true;
            this.labelEmpresaEstadoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresaEstadoRegistro.Location = new System.Drawing.Point(467, 152);
            this.labelEmpresaEstadoRegistro.Name = "labelEmpresaEstadoRegistro";
            this.labelEmpresaEstadoRegistro.Size = new System.Drawing.Size(234, 31);
            this.labelEmpresaEstadoRegistro.TabIndex = 1;
            this.labelEmpresaEstadoRegistro.Text = "Estado de registro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Controls.Add(this.FechaEnsamble);
            this.panel1.Controls.Add(this.btnRegistarComputadora);
            this.panel1.Controls.Add(this.txtComputadoraMarca);
            this.panel1.Controls.Add(this.txtComputadoraNroSerial);
            this.panel1.Controls.Add(this.labelFechaEnsamble);
            this.panel1.Controls.Add(this.labelMarca);
            this.panel1.Controls.Add(this.labelNroSerial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 356);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FechaEnsamble
            // 
            this.FechaEnsamble.Location = new System.Drawing.Point(165, 221);
            this.FechaEnsamble.Name = "FechaEnsamble";
            this.FechaEnsamble.Size = new System.Drawing.Size(200, 20);
            this.FechaEnsamble.TabIndex = 8;
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
            // 
            // txtComputadoraMarca
            // 
            this.txtComputadoraMarca.Location = new System.Drawing.Point(165, 117);
            this.txtComputadoraMarca.Name = "txtComputadoraMarca";
            this.txtComputadoraMarca.Size = new System.Drawing.Size(200, 20);
            this.txtComputadoraMarca.TabIndex = 5;
            this.txtComputadoraMarca.TextChanged += new System.EventHandler(this.txtComputadoraMarca_TextChanged);
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
            this.labelMarca.Location = new System.Drawing.Point(35, 117);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 15);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca:";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
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
            // txtComputadoraCapDiscoDuroGB
            // 
            this.txtComputadoraCapDiscoDuroGB.Location = new System.Drawing.Point(215, 143);
            this.txtComputadoraCapDiscoDuroGB.Name = "txtComputadoraCapDiscoDuroGB";
            this.txtComputadoraCapDiscoDuroGB.Size = new System.Drawing.Size(150, 20);
            this.txtComputadoraCapDiscoDuroGB.TabIndex = 10;
            this.txtComputadoraCapDiscoDuroGB.TextChanged += new System.EventHandler(this.txtComputadoraCapDiscoDuroGB_TextChanged);
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
            this.labelCapDiscoDuroGB.Click += new System.EventHandler(this.labelCapDiscoDuroGB_Click);
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
            // labelComputadoraCapDiscoDuroGB
            // 
            this.labelComputadoraCapDiscoDuroGB.AutoSize = true;
            this.labelComputadoraCapDiscoDuroGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputadoraCapDiscoDuroGB.Location = new System.Drawing.Point(35, 144);
            this.labelComputadoraCapDiscoDuroGB.Name = "labelComputadoraCapDiscoDuroGB";
            this.labelComputadoraCapDiscoDuroGB.Size = new System.Drawing.Size(174, 15);
            this.labelComputadoraCapDiscoDuroGB.TabIndex = 9;
            this.labelComputadoraCapDiscoDuroGB.Text = "Capacidad de disco duro (GB):";
            this.labelComputadoraCapDiscoDuroGB.Click += new System.EventHandler(this.labelCapDiscoDuroGB_Click);
            // 
            // txtComputadoraCapDiscoGB
            // 
            this.txtComputadoraCapDiscoGB.Location = new System.Drawing.Point(215, 143);
            this.txtComputadoraCapDiscoGB.Name = "txtComputadoraCapDiscoGB";
            this.txtComputadoraCapDiscoGB.Size = new System.Drawing.Size(150, 20);
            this.txtComputadoraCapDiscoGB.TabIndex = 10;
            this.txtComputadoraCapDiscoGB.TextChanged += new System.EventHandler(this.txtComputadoraCapDiscoDuroGB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado de registro";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(595, 348);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(145, 30);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Realizar consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulta.Location = new System.Drawing.Point(34, 27);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(480, 18);
            this.labelConsulta.TabIndex = 1;
            this.labelConsulta.Text = "Consultar todos los datos de los portátiles para una empresa específica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabRegistroEmpresa.ResumeLayout(false);
            this.tabRegistroEmpresa.PerformLayout();
            this.tabRegistroComputadora.ResumeLayout(false);
            this.tabRegistroComputadora.PerformLayout();
            this.panelRegistroEmpresa.ResumeLayout(false);
            this.panelRegistroEmpresa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegistroEmpresa;
        private System.Windows.Forms.TabPage tabRegistroComputadora;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.Panel panelRegistroEmpresa;
        private System.Windows.Forms.Button btnRegistrarEmpresa;
        private System.Windows.Forms.TextBox txtRegistroNombre;
        private System.Windows.Forms.TextBox txtRegistroNIT;
        private System.Windows.Forms.Label labelFechaCreacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNIT;
        private System.Windows.Forms.Label labelRegistrarEmpresa;
        private System.Windows.Forms.Label labelEmpresaEstadoRegistro;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtComputadoraCapRAMGB;
        private System.Windows.Forms.Label labelComputadoraCapRAMGB;
        private System.Windows.Forms.TextBox txtComputadoraTipoDiscoDuro;
        private System.Windows.Forms.Label labelComputadoraTipoDiscoDuro;
        private System.Windows.Forms.TextBox txtComputadoraCapDiscoDuroGB;
        private System.Windows.Forms.Label labelCapDiscoDuroGB;
        private System.Windows.Forms.DateTimePicker FechaEnsamble;
        private System.Windows.Forms.Button btnRegistarComputadora;
        private System.Windows.Forms.TextBox txtComputadoraMarca;
        private System.Windows.Forms.TextBox txtComputadoraNroSerial;
        private System.Windows.Forms.Label labelFechaEnsamble;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelNroSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComputadoraNITEmpPertenece;
        private System.Windows.Forms.Label labelComputadoraNitEmpPerenecie;
        private System.Windows.Forms.TextBox txtComputadoraCapDiscoGB;
        private System.Windows.Forms.Label labelComputadoraCapDiscoDuroGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.Button btnConsulta;
    }
}

