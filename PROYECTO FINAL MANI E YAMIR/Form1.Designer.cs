namespace Proyecto_Taller_Mecanico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvRegistroVenta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegistroDeVenta = new System.Windows.Forms.Button();
            this.lbDesplegarMenu = new System.Windows.Forms.Label();
            this.btnRealizarPago = new System.Windows.Forms.Button();
            this.btnPalancaDeInicio = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.lbTotalProd = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.cbServiciosOfrecidos = new System.Windows.Forms.ComboBox();
            this.txtNombreDelcCliente = new System.Windows.Forms.TextBox();
            this.lbServicioD = new System.Windows.Forms.Label();
            this.lbNameClient = new System.Windows.Forms.Label();
            this.lbNameWorker = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.lbplacas = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.cbMarcasAutos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gb_Precios = new System.Windows.Forms.GroupBox();
            this.s1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.s5 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Label();
            this.s3 = new System.Windows.Forms.Label();
            this.p6 = new System.Windows.Forms.Label();
            this.s7 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.s6 = new System.Windows.Forms.Label();
            this.s9 = new System.Windows.Forms.Label();
            this.s8 = new System.Windows.Forms.Label();
            this.s10 = new System.Windows.Forms.Label();
            this.p7 = new System.Windows.Forms.Label();
            this.p10 = new System.Windows.Forms.Label();
            this.p9 = new System.Windows.Forms.Label();
            this.p8 = new System.Windows.Forms.Label();
            this.s4 = new System.Windows.Forms.Label();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.Gb_Precios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRegistroVenta
            // 
            this.lvRegistroVenta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lvRegistroVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRegistroVenta.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRegistroVenta.ForeColor = System.Drawing.Color.White;
            this.lvRegistroVenta.GridLines = true;
            this.lvRegistroVenta.HideSelection = false;
            this.lvRegistroVenta.Location = new System.Drawing.Point(24, 377);
            this.lvRegistroVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvRegistroVenta.Name = "lvRegistroVenta";
            this.lvRegistroVenta.Size = new System.Drawing.Size(892, 126);
            this.lvRegistroVenta.TabIndex = 9;
            this.lvRegistroVenta.UseCompatibleStateImageBehavior = false;
            this.lvRegistroVenta.View = System.Windows.Forms.View.Details;
            this.lvRegistroVenta.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre Empleado:";
            this.columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre Cliente:";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Servicio(s) seleccionados:";
            this.columnHeader3.Width = 311;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Costo del Servicio:";
            this.columnHeader4.Width = 180;
            // 
            // btnRegistroDeVenta
            // 
            this.btnRegistroDeVenta.BackColor = System.Drawing.Color.White;
            this.btnRegistroDeVenta.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeVenta.ForeColor = System.Drawing.Color.Green;
            this.btnRegistroDeVenta.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRegistroDeVenta.Location = new System.Drawing.Point(112, 299);
            this.btnRegistroDeVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRegistroDeVenta.Name = "btnRegistroDeVenta";
            this.btnRegistroDeVenta.Size = new System.Drawing.Size(154, 69);
            this.btnRegistroDeVenta.TabIndex = 11;
            this.btnRegistroDeVenta.Text = "Seleccionar Servicio";
            this.btnRegistroDeVenta.UseVisualStyleBackColor = false;
            this.btnRegistroDeVenta.Visible = false;
            this.btnRegistroDeVenta.Click += new System.EventHandler(this.btnRegistroDeVenta_Click);
            // 
            // lbDesplegarMenu
            // 
            this.lbDesplegarMenu.AutoSize = true;
            this.lbDesplegarMenu.BackColor = System.Drawing.Color.Transparent;
            this.lbDesplegarMenu.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesplegarMenu.ForeColor = System.Drawing.Color.Black;
            this.lbDesplegarMenu.Location = new System.Drawing.Point(871, 12);
            this.lbDesplegarMenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDesplegarMenu.Name = "lbDesplegarMenu";
            this.lbDesplegarMenu.Size = new System.Drawing.Size(244, 17);
            this.lbDesplegarMenu.TabIndex = 12;
            this.lbDesplegarMenu.Text = "Click aqui para desplegar Menu --->";
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.BackColor = System.Drawing.Color.White;
            this.btnRealizarPago.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRealizarPago.Location = new System.Drawing.Point(548, 324);
            this.btnRealizarPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(174, 32);
            this.btnRealizarPago.TabIndex = 13;
            this.btnRealizarPago.Text = "Realizar Pago";
            this.btnRealizarPago.UseVisualStyleBackColor = false;
            this.btnRealizarPago.Visible = false;
            this.btnRealizarPago.Click += new System.EventHandler(this.btnRealizarPago_Click);
            // 
            // btnPalancaDeInicio
            // 
            this.btnPalancaDeInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPalancaDeInicio.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalancaDeInicio.ForeColor = System.Drawing.Color.White;
            this.btnPalancaDeInicio.Location = new System.Drawing.Point(1125, 1);
            this.btnPalancaDeInicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPalancaDeInicio.Name = "btnPalancaDeInicio";
            this.btnPalancaDeInicio.Size = new System.Drawing.Size(52, 39);
            this.btnPalancaDeInicio.TabIndex = 0;
            this.btnPalancaDeInicio.Text = "Menu";
            this.btnPalancaDeInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPalancaDeInicio.UseVisualStyleBackColor = false;
            this.btnPalancaDeInicio.Click += new System.EventHandler(this.btnPalancaDeInicio_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTicket.Enabled = false;
            this.btnTicket.Font = new System.Drawing.Font("Yu Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Location = new System.Drawing.Point(431, 510);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(186, 35);
            this.btnTicket.TabIndex = 18;
            this.btnTicket.Text = "Generar Ticket\'s";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Visible = false;
            this.btnTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(6, 32);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(50, 19);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "Total:";
            // 
            // gbTotal
            // 
            this.gbTotal.BackColor = System.Drawing.Color.Transparent;
            this.gbTotal.Controls.Add(this.lbTotalProd);
            this.gbTotal.Controls.Add(this.lbTotal);
            this.gbTotal.Location = new System.Drawing.Point(284, 299);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(189, 71);
            this.gbTotal.TabIndex = 22;
            this.gbTotal.TabStop = false;
            // 
            // lbTotalProd
            // 
            this.lbTotalProd.AutoSize = true;
            this.lbTotalProd.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProd.ForeColor = System.Drawing.Color.Lime;
            this.lbTotalProd.Location = new System.Drawing.Point(79, 28);
            this.lbTotalProd.Name = "lbTotalProd";
            this.lbTotalProd.Size = new System.Drawing.Size(36, 25);
            this.lbTotalProd.TabIndex = 25;
            this.lbTotalProd.Text = "---";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1185, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 39);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-11, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 21);
            this.panel2.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(-11, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1268, 28);
            this.panel5.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(419, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 61);
            this.label2.TabIndex = 26;
            this.label2.Text = "\"MANYAM\"";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Taller_Mecanico.Properties.Resources.kisspng_car_automobile_repair_shop_auto_mechanic_motor_veh_the_man_holding_the_tool_5aa29dfb2df7f9_5553329415206067151883;
            this.pictureBox2.Location = new System.Drawing.Point(701, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "TALLER MECANICO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbDesplegarMenu);
            this.groupBox2.Controls.Add(this.btnPalancaDeInicio);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1229, 129);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1216, -11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 556);
            this.panel3.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(1241, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 578);
            this.panel6.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(15, 571);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1252, 14);
            this.panel7.TabIndex = 28;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(180, 27);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(301, 33);
            this.txtNombreEmpleado.TabIndex = 8;
            this.txtNombreEmpleado.Visible = false;
            // 
            // cbServiciosOfrecidos
            // 
            this.cbServiciosOfrecidos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiciosOfrecidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbServiciosOfrecidos.FormattingEnabled = true;
            this.cbServiciosOfrecidos.Items.AddRange(new object[] {
            "Cambio de Aceite y Filtro",
            "Limpieza de Aire, Gasolina y Bujias",
            "Revicion de Luces",
            "Ajuste del Tiempo de Encendido",
            "Revicion de Clutch",
            "Borner",
            "Nivelar la Bateria",
            "Revision de Frenos",
            "Aire Acondicionado y Calefaccion",
            "Cambio de Bujias"});
            this.cbServiciosOfrecidos.Location = new System.Drawing.Point(513, 117);
            this.cbServiciosOfrecidos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbServiciosOfrecidos.Name = "cbServiciosOfrecidos";
            this.cbServiciosOfrecidos.Size = new System.Drawing.Size(320, 29);
            this.cbServiciosOfrecidos.TabIndex = 3;
            this.cbServiciosOfrecidos.Visible = false;
            this.cbServiciosOfrecidos.SelectedIndexChanged += new System.EventHandler(this.cbServiciosOfrecidos_SelectedIndexChanged);
            // 
            // txtNombreDelcCliente
            // 
            this.txtNombreDelcCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombreDelcCliente.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDelcCliente.ForeColor = System.Drawing.Color.White;
            this.txtNombreDelcCliente.Location = new System.Drawing.Point(194, 75);
            this.txtNombreDelcCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombreDelcCliente.Name = "txtNombreDelcCliente";
            this.txtNombreDelcCliente.Size = new System.Drawing.Size(288, 33);
            this.txtNombreDelcCliente.TabIndex = 6;
            this.txtNombreDelcCliente.Visible = false;
            // 
            // lbServicioD
            // 
            this.lbServicioD.AutoSize = true;
            this.lbServicioD.BackColor = System.Drawing.Color.White;
            this.lbServicioD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicioD.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbServicioD.Location = new System.Drawing.Point(426, 121);
            this.lbServicioD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbServicioD.Name = "lbServicioD";
            this.lbServicioD.Size = new System.Drawing.Size(77, 19);
            this.lbServicioD.TabIndex = 4;
            this.lbServicioD.Text = "Servicio:";
            this.lbServicioD.Visible = false;
            // 
            // lbNameClient
            // 
            this.lbNameClient.AutoSize = true;
            this.lbNameClient.BackColor = System.Drawing.Color.Transparent;
            this.lbNameClient.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameClient.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNameClient.Location = new System.Drawing.Point(18, 78);
            this.lbNameClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNameClient.Name = "lbNameClient";
            this.lbNameClient.Size = new System.Drawing.Size(166, 21);
            this.lbNameClient.TabIndex = 5;
            this.lbNameClient.Text = "Nombre del Cliente:";
            this.lbNameClient.Visible = false;
            // 
            // lbNameWorker
            // 
            this.lbNameWorker.AutoSize = true;
            this.lbNameWorker.BackColor = System.Drawing.Color.Transparent;
            this.lbNameWorker.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameWorker.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNameWorker.Location = new System.Drawing.Point(90, 30);
            this.lbNameWorker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNameWorker.Name = "lbNameWorker";
            this.lbNameWorker.Size = new System.Drawing.Size(80, 21);
            this.lbNameWorker.TabIndex = 7;
            this.lbNameWorker.Text = " Atiende:";
            this.lbNameWorker.Visible = false;
            // 
            // txtPlacas
            // 
            this.txtPlacas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPlacas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.ForeColor = System.Drawing.Color.White;
            this.txtPlacas.Location = new System.Drawing.Point(905, 67);
            this.txtPlacas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(163, 33);
            this.txtPlacas.TabIndex = 10;
            this.txtPlacas.Visible = false;
            // 
            // lbplacas
            // 
            this.lbplacas.AutoSize = true;
            this.lbplacas.BackColor = System.Drawing.Color.Transparent;
            this.lbplacas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplacas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbplacas.Location = new System.Drawing.Point(804, 75);
            this.lbplacas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbplacas.Name = "lbplacas";
            this.lbplacas.Size = new System.Drawing.Size(101, 21);
            this.lbplacas.TabIndex = 9;
            this.lbplacas.Text = "N° Placas:";
            this.lbplacas.Visible = false;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.BackColor = System.Drawing.Color.Transparent;
            this.lbModelo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbModelo.Location = new System.Drawing.Point(739, 34);
            this.lbModelo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(166, 21);
            this.lbModelo.TabIndex = 11;
            this.lbModelo.Text = "Marca de Automovil";
            this.lbModelo.Visible = false;
            // 
            // cbMarcasAutos
            // 
            this.cbMarcasAutos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcasAutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbMarcasAutos.FormattingEnabled = true;
            this.cbMarcasAutos.Items.AddRange(new object[] {
            "ALFA ROMEO ",
            "ACURA",
            "AUDI",
            "BENTLEY",
            "BMW",
            "CADILLAK",
            "CHEVROLET",
            "DODGE",
            "JEEP",
            "HONDA",
            "HYUNDAI",
            "FERRARI",
            "FORD",
            "FIAT",
            "SUSUKI",
            "GMC",
            "NISSAN",
            "MAZDA",
            "MERCEDES",
            "RENAULT",
            "KIA"});
            this.cbMarcasAutos.Location = new System.Drawing.Point(903, 30);
            this.cbMarcasAutos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMarcasAutos.Name = "cbMarcasAutos";
            this.cbMarcasAutos.Size = new System.Drawing.Size(231, 29);
            this.cbMarcasAutos.TabIndex = 19;
            this.cbMarcasAutos.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(382, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.White;
            this.gbDatos.Controls.Add(this.groupBox1);
            this.gbDatos.Controls.Add(this.cbMarcasAutos);
            this.gbDatos.Controls.Add(this.lbModelo);
            this.gbDatos.Controls.Add(this.lbplacas);
            this.gbDatos.Controls.Add(this.txtPlacas);
            this.gbDatos.Controls.Add(this.lbNameWorker);
            this.gbDatos.Controls.Add(this.lbNameClient);
            this.gbDatos.Controls.Add(this.lbServicioD);
            this.gbDatos.Controls.Add(this.txtNombreDelcCliente);
            this.gbDatos.Controls.Add(this.cbServiciosOfrecidos);
            this.gbDatos.Controls.Add(this.txtNombreEmpleado);
            this.gbDatos.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(18, 136);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(1223, 157);
            this.gbDatos.TabIndex = 14;
            this.gbDatos.TabStop = false;
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 538);
            this.panel1.TabIndex = 0;
            // 
            // Gb_Precios
            // 
            this.Gb_Precios.BackColor = System.Drawing.Color.White;
            this.Gb_Precios.Controls.Add(this.s4);
            this.Gb_Precios.Controls.Add(this.p10);
            this.Gb_Precios.Controls.Add(this.p9);
            this.Gb_Precios.Controls.Add(this.p8);
            this.Gb_Precios.Controls.Add(this.p7);
            this.Gb_Precios.Controls.Add(this.s10);
            this.Gb_Precios.Controls.Add(this.s9);
            this.Gb_Precios.Controls.Add(this.s8);
            this.Gb_Precios.Controls.Add(this.p6);
            this.Gb_Precios.Controls.Add(this.s7);
            this.Gb_Precios.Controls.Add(this.p3);
            this.Gb_Precios.Controls.Add(this.s6);
            this.Gb_Precios.Controls.Add(this.p4);
            this.Gb_Precios.Controls.Add(this.s5);
            this.Gb_Precios.Controls.Add(this.p5);
            this.Gb_Precios.Controls.Add(this.s3);
            this.Gb_Precios.Controls.Add(this.p2);
            this.Gb_Precios.Controls.Add(this.s2);
            this.Gb_Precios.Controls.Add(this.p1);
            this.Gb_Precios.Controls.Add(this.s1);
            this.Gb_Precios.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Precios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Gb_Precios.Location = new System.Drawing.Point(935, 291);
            this.Gb_Precios.Name = "Gb_Precios";
            this.Gb_Precios.Size = new System.Drawing.Size(300, 254);
            this.Gb_Precios.TabIndex = 32;
            this.Gb_Precios.TabStop = false;
            this.Gb_Precios.Text = "Precios Servicios";
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1.ForeColor = System.Drawing.Color.Black;
            this.s1.Location = new System.Drawing.Point(22, 28);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(141, 14);
            this.s1.TabIndex = 0;
            this.s1.Text = "Cambio de aceite y  Filtro";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.Black;
            this.p1.Location = new System.Drawing.Point(175, 27);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(86, 14);
            this.p1.TabIndex = 1;
            this.p1.Text = "................ $ 250";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.Location = new System.Drawing.Point(214, 50);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(47, 14);
            this.p2.TabIndex = 3;
            this.p2.Text = "... $ 700";
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.Location = new System.Drawing.Point(22, 50);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(191, 14);
            this.s2.TabIndex = 2;
            this.s2.Text = "Limpieza de Aire, Gasolina y Bujias";
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4.Location = new System.Drawing.Point(204, 95);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(59, 14);
            this.p4.TabIndex = 7;
            this.p4.Text = "....... $ 400";
            // 
            // s5
            // 
            this.s5.AutoSize = true;
            this.s5.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s5.ForeColor = System.Drawing.Color.Black;
            this.s5.Location = new System.Drawing.Point(22, 116);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(107, 14);
            this.s5.TabIndex = 6;
            this.s5.Text = "Revicion de Clutch";
            // 
            // p5
            // 
            this.p5.AutoSize = true;
            this.p5.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5.ForeColor = System.Drawing.Color.Black;
            this.p5.Location = new System.Drawing.Point(123, 116);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(146, 14);
            this.p5.TabIndex = 5;
            this.p5.Text = ".................................. $ 1400";
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s3.ForeColor = System.Drawing.Color.Black;
            this.s3.Location = new System.Drawing.Point(22, 72);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(104, 14);
            this.s3.TabIndex = 4;
            this.s3.Text = "Revision de Luces";
            // 
            // p6
            // 
            this.p6.AutoSize = true;
            this.p6.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p6.Location = new System.Drawing.Point(71, 138);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(200, 14);
            this.p6.TabIndex = 11;
            this.p6.Text = ".................................................... $ 2500";
            // 
            // s7
            // 
            this.s7.AutoSize = true;
            this.s7.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s7.ForeColor = System.Drawing.Color.Black;
            this.s7.Location = new System.Drawing.Point(22, 165);
            this.s7.Name = "s7";
            this.s7.Size = new System.Drawing.Size(84, 14);
            this.s7.TabIndex = 10;
            this.s7.Text = "Nivelar Bateria";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.ForeColor = System.Drawing.Color.Black;
            this.p3.Location = new System.Drawing.Point(148, 72);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(113, 14);
            this.p3.TabIndex = 9;
            this.p3.Text = "......................... $ 500";
            // 
            // s6
            // 
            this.s6.AutoSize = true;
            this.s6.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s6.Location = new System.Drawing.Point(22, 138);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(43, 14);
            this.s6.TabIndex = 8;
            this.s6.Text = "Borner";
            // 
            // s9
            // 
            this.s9.AutoSize = true;
            this.s9.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s9.ForeColor = System.Drawing.Color.Black;
            this.s9.Location = new System.Drawing.Point(22, 211);
            this.s9.Name = "s9";
            this.s9.Size = new System.Drawing.Size(180, 14);
            this.s9.TabIndex = 14;
            this.s9.Text = "Aire Acondicionado/Calefaccion";
            // 
            // s8
            // 
            this.s8.AutoSize = true;
            this.s8.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s8.Location = new System.Drawing.Point(22, 188);
            this.s8.Name = "s8";
            this.s8.Size = new System.Drawing.Size(108, 14);
            this.s8.TabIndex = 12;
            this.s8.Text = "Revision de Frenos";
            // 
            // s10
            // 
            this.s10.AutoSize = true;
            this.s10.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s10.Location = new System.Drawing.Point(22, 231);
            this.s10.Name = "s10";
            this.s10.Size = new System.Drawing.Size(100, 14);
            this.s10.TabIndex = 16;
            this.s10.Text = "Cambio de Bujias";
            // 
            // p7
            // 
            this.p7.AutoSize = true;
            this.p7.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p7.ForeColor = System.Drawing.Color.Black;
            this.p7.Location = new System.Drawing.Point(117, 165);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(152, 14);
            this.p7.TabIndex = 19;
            this.p7.Text = "...................................... $ 800";
            // 
            // p10
            // 
            this.p10.AutoSize = true;
            this.p10.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10.Location = new System.Drawing.Point(128, 231);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(134, 14);
            this.p10.TabIndex = 22;
            this.p10.Text = "................................ $ 750";
            // 
            // p9
            // 
            this.p9.AutoSize = true;
            this.p9.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p9.ForeColor = System.Drawing.Color.Black;
            this.p9.Location = new System.Drawing.Point(208, 211);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(68, 14);
            this.p9.TabIndex = 21;
            this.p9.Text = "..... $ 10 000";
            // 
            // p8
            // 
            this.p8.AutoSize = true;
            this.p8.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p8.Location = new System.Drawing.Point(144, 188);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(122, 14);
            this.p8.TabIndex = 20;
            this.p8.Text = ".......................... $ 1500";
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s4.Location = new System.Drawing.Point(23, 95);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(179, 14);
            this.s4.TabIndex = 23;
            this.s4.Text = "Ajuste del Tiempo de Encendido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1258, 569);
            this.Controls.Add(this.Gb_Precios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnRealizarPago);
            this.Controls.Add(this.btnRegistroDeVenta);
            this.Controls.Add(this.lvRegistroVenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.Gb_Precios.ResumeLayout(false);
            this.Gb_Precios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPalancaDeInicio;
        private System.Windows.Forms.ListView lvRegistroVenta;
        private System.Windows.Forms.Button btnRegistroDeVenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbDesplegarMenu;
        private System.Windows.Forms.Button btnRealizarPago;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbTotalProd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.ComboBox cbServiciosOfrecidos;
        private System.Windows.Forms.TextBox txtNombreDelcCliente;
        private System.Windows.Forms.Label lbServicioD;
        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.Label lbNameWorker;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label lbplacas;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.ComboBox cbMarcasAutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox Gb_Precios;
        private System.Windows.Forms.Label p10;
        private System.Windows.Forms.Label p9;
        private System.Windows.Forms.Label p8;
        private System.Windows.Forms.Label p7;
        private System.Windows.Forms.Label s10;
        private System.Windows.Forms.Label s9;
        private System.Windows.Forms.Label s8;
        private System.Windows.Forms.Label p6;
        private System.Windows.Forms.Label s7;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label s6;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label s5;
        private System.Windows.Forms.Label p5;
        private System.Windows.Forms.Label s3;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Label s4;
    }
}

