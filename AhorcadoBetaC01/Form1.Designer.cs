namespace AhorcadoBetaC01
{
    
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdJugar = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.CmdPausar = new System.Windows.Forms.Button();
            this.CmdSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAhorcado1 = new System.Windows.Forms.PictureBox();
            this.picAhorcado2 = new System.Windows.Forms.PictureBox();
            this.picAhorcado3 = new System.Windows.Forms.PictureBox();
            this.picAhorcado4 = new System.Windows.Forms.PictureBox();
            this.picAhorcado6 = new System.Windows.Forms.PictureBox();
            this.picAhorcado5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnJugarA = new System.Windows.Forms.RadioButton();
            this.BtnJugarS = new System.Windows.Forms.RadioButton();
            this.CmdNuevo = new System.Windows.Forms.Button();
            this.CmdCancela = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtContador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPuntaje1 = new System.Windows.Forms.TextBox();
            this.TxtPuntaje2 = new System.Windows.Forms.TextBox();
            this.lblteam1 = new System.Windows.Forms.Label();
            this.lblteam2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPregunta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnMaster = new System.Windows.Forms.RadioButton();
            this.BtnUniversidad = new System.Windows.Forms.RadioButton();
            this.BtnSecundaria = new System.Windows.Forms.RadioButton();
            this.BtnNiños = new System.Windows.Forms.RadioButton();
            this.TimerContador = new System.Windows.Forms.Timer(this.components);
            this.panelLetras = new System.Windows.Forms.Panel();
            this.txtLetraEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lbljuegoP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdJugar
            // 
            this.CmdJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdJugar.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdJugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CmdJugar.Location = new System.Drawing.Point(16, 568);
            this.CmdJugar.Name = "CmdJugar";
            this.CmdJugar.Size = new System.Drawing.Size(160, 39);
            this.CmdJugar.TabIndex = 2;
            this.CmdJugar.Text = "Jugar_";
            this.CmdJugar.UseVisualStyleBackColor = true;
            this.CmdJugar.Click += new System.EventHandler(this.CmdJugar_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnInstrucciones.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInstrucciones.Location = new System.Drawing.Point(373, 568);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(160, 39);
            this.btnInstrucciones.TabIndex = 3;
            this.btnInstrucciones.Text = "Como Jugar";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click_1);
            // 
            // CmdPausar
            // 
            this.CmdPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdPausar.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPausar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CmdPausar.Location = new System.Drawing.Point(194, 568);
            this.CmdPausar.Name = "CmdPausar";
            this.CmdPausar.Size = new System.Drawing.Size(160, 39);
            this.CmdPausar.TabIndex = 4;
            this.CmdPausar.Text = "Pausar_";
            this.CmdPausar.UseVisualStyleBackColor = true;
            this.CmdPausar.Click += new System.EventHandler(this.CmdPausar_Click);
            // 
            // CmdSalir
            // 
            this.CmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdSalir.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CmdSalir.Location = new System.Drawing.Point(552, 567);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(160, 39);
            this.CmdSalir.TabIndex = 5;
            this.CmdSalir.Text = "Salir_";
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AhorcadoBetaC01.Properties.Resources.ahorcado2;
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // picAhorcado1
            // 
            this.picAhorcado1.Image = ((System.Drawing.Image)(resources.GetObject("picAhorcado1.Image")));
            this.picAhorcado1.Location = new System.Drawing.Point(131, 58);
            this.picAhorcado1.Name = "picAhorcado1";
            this.picAhorcado1.Size = new System.Drawing.Size(67, 100);
            this.picAhorcado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado1.TabIndex = 7;
            this.picAhorcado1.TabStop = false;
            this.picAhorcado1.Visible = false;
            // 
            // picAhorcado2
            // 
            this.picAhorcado2.Image = ((System.Drawing.Image)(resources.GetObject("picAhorcado2.Image")));
            this.picAhorcado2.Location = new System.Drawing.Point(151, 157);
            this.picAhorcado2.Name = "picAhorcado2";
            this.picAhorcado2.Size = new System.Drawing.Size(25, 65);
            this.picAhorcado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado2.TabIndex = 8;
            this.picAhorcado2.TabStop = false;
            this.picAhorcado2.Visible = false;
            // 
            // picAhorcado3
            // 
            this.picAhorcado3.Image = ((System.Drawing.Image)(resources.GetObject("picAhorcado3.Image")));
            this.picAhorcado3.Location = new System.Drawing.Point(108, 159);
            this.picAhorcado3.Name = "picAhorcado3";
            this.picAhorcado3.Size = new System.Drawing.Size(43, 64);
            this.picAhorcado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado3.TabIndex = 9;
            this.picAhorcado3.TabStop = false;
            this.picAhorcado3.Visible = false;
            // 
            // picAhorcado4
            // 
            this.picAhorcado4.Image = ((System.Drawing.Image)(resources.GetObject("picAhorcado4.Image")));
            this.picAhorcado4.Location = new System.Drawing.Point(176, 158);
            this.picAhorcado4.Name = "picAhorcado4";
            this.picAhorcado4.Size = new System.Drawing.Size(41, 65);
            this.picAhorcado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado4.TabIndex = 10;
            this.picAhorcado4.TabStop = false;
            this.picAhorcado4.Visible = false;
            // 
            // picAhorcado6
            // 
            this.picAhorcado6.Image = ((System.Drawing.Image)(resources.GetObject("picAhorcado6.Image")));
            this.picAhorcado6.Location = new System.Drawing.Point(170, 222);
            this.picAhorcado6.Name = "picAhorcado6";
            this.picAhorcado6.Size = new System.Drawing.Size(43, 68);
            this.picAhorcado6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado6.TabIndex = 11;
            this.picAhorcado6.TabStop = false;
            this.picAhorcado6.Visible = false;
            // 
            // picAhorcado5
            // 
            this.picAhorcado5.Image = ((System.Drawing.Image)(resources.GetObject("picAhorcado5.Image")));
            this.picAhorcado5.Location = new System.Drawing.Point(110, 222);
            this.picAhorcado5.Name = "picAhorcado5";
            this.picAhorcado5.Size = new System.Drawing.Size(45, 68);
            this.picAhorcado5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado5.TabIndex = 12;
            this.picAhorcado5.TabStop = false;
            this.picAhorcado5.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnJugarA);
            this.groupBox2.Controls.Add(this.BtnJugarS);
            this.groupBox2.Controls.Add(this.CmdNuevo);
            this.groupBox2.Controls.Add(this.CmdCancela);
            this.groupBox2.Controls.Add(this.CmdAdd);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(390, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 114);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre Jugador: ";
            // 
            // BtnJugarA
            // 
            this.BtnJugarA.AutoSize = true;
            this.BtnJugarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJugarA.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugarA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnJugarA.Location = new System.Drawing.Point(154, 83);
            this.BtnJugarA.Name = "BtnJugarA";
            this.BtnJugarA.Size = new System.Drawing.Size(151, 19);
            this.BtnJugarA.TabIndex = 19;
            this.BtnJugarA.TabStop = true;
            this.BtnJugarA.Text = "Jugar Con Amigo";
            this.BtnJugarA.UseVisualStyleBackColor = true;
            this.BtnJugarA.CheckedChanged += new System.EventHandler(this.BtnJugarA_CheckedChanged_1);
            // 
            // BtnJugarS
            // 
            this.BtnJugarS.AutoSize = true;
            this.BtnJugarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJugarS.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugarS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnJugarS.Location = new System.Drawing.Point(23, 83);
            this.BtnJugarS.Name = "BtnJugarS";
            this.BtnJugarS.Size = new System.Drawing.Size(108, 19);
            this.BtnJugarS.TabIndex = 18;
            this.BtnJugarS.TabStop = true;
            this.BtnJugarS.Text = "Jugar Solo:";
            this.BtnJugarS.UseVisualStyleBackColor = true;
            this.BtnJugarS.CheckedChanged += new System.EventHandler(this.BtnJugarS_CheckedChanged_1);
            // 
            // CmdNuevo
            // 
            this.CmdNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdNuevo.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdNuevo.ForeColor = System.Drawing.Color.Maroon;
            this.CmdNuevo.Location = new System.Drawing.Point(206, 52);
            this.CmdNuevo.Name = "CmdNuevo";
            this.CmdNuevo.Size = new System.Drawing.Size(99, 25);
            this.CmdNuevo.TabIndex = 4;
            this.CmdNuevo.Text = "Nuevo_";
            this.CmdNuevo.UseVisualStyleBackColor = true;
            this.CmdNuevo.Click += new System.EventHandler(this.CmdNuevo_Click);
            // 
            // CmdCancela
            // 
            this.CmdCancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdCancela.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancela.ForeColor = System.Drawing.Color.Maroon;
            this.CmdCancela.Location = new System.Drawing.Point(116, 52);
            this.CmdCancela.Name = "CmdCancela";
            this.CmdCancela.Size = new System.Drawing.Size(84, 25);
            this.CmdCancela.TabIndex = 3;
            this.CmdCancela.Text = "Cancela_";
            this.CmdCancela.UseVisualStyleBackColor = true;
            this.CmdCancela.Click += new System.EventHandler(this.CmdCancela_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdAdd.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.ForeColor = System.Drawing.Color.Maroon;
            this.CmdAdd.Location = new System.Drawing.Point(20, 52);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(90, 25);
            this.CmdAdd.TabIndex = 2;
            this.CmdAdd.Text = "Ingresa_";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNombre.Location = new System.Drawing.Point(20, 20);
            this.TxtNombre.MaxLength = 13;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(285, 26);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtContador
            // 
            this.TxtContador.Enabled = false;
            this.TxtContador.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContador.Location = new System.Drawing.Point(636, 8);
            this.TxtContador.Name = "TxtContador";
            this.TxtContador.Size = new System.Drawing.Size(76, 39);
            this.TxtContador.TabIndex = 14;
            this.TxtContador.Text = "0";
            this.TxtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(386, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contador de Tiempo..";
            // 
            // TxtPuntaje1
            // 
            this.TxtPuntaje1.Enabled = false;
            this.TxtPuntaje1.Font = new System.Drawing.Font("Felix Titling", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntaje1.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtPuntaje1.Location = new System.Drawing.Point(433, 205);
            this.TxtPuntaje1.Name = "TxtPuntaje1";
            this.TxtPuntaje1.Size = new System.Drawing.Size(83, 51);
            this.TxtPuntaje1.TabIndex = 3;
            this.TxtPuntaje1.Text = "0";
            this.TxtPuntaje1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPuntaje2
            // 
            this.TxtPuntaje2.Enabled = false;
            this.TxtPuntaje2.Font = new System.Drawing.Font("Felix Titling", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntaje2.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtPuntaje2.Location = new System.Drawing.Point(592, 205);
            this.TxtPuntaje2.Name = "TxtPuntaje2";
            this.TxtPuntaje2.Size = new System.Drawing.Size(83, 51);
            this.TxtPuntaje2.TabIndex = 19;
            this.TxtPuntaje2.Text = "0";
            this.TxtPuntaje2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblteam1
            // 
            this.lblteam1.AutoSize = true;
            this.lblteam1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteam1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblteam1.Location = new System.Drawing.Point(419, 259);
            this.lblteam1.Name = "lblteam1";
            this.lblteam1.Size = new System.Drawing.Size(86, 19);
            this.lblteam1.TabIndex = 20;
            this.lblteam1.Text = "TEAM - 1.....";
            this.lblteam1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblteam2
            // 
            this.lblteam2.AutoSize = true;
            this.lblteam2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteam2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblteam2.Location = new System.Drawing.Point(578, 259);
            this.lblteam2.Name = "lblteam2";
            this.lblteam2.Size = new System.Drawing.Size(91, 19);
            this.lblteam2.TabIndex = 21;
            this.lblteam2.Text = "TEAM - 2.....";
            this.lblteam2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(20, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "* Responde Esta Pregunta *";
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.Enabled = false;
            this.TxtPregunta.Font = new System.Drawing.Font("Felix Titling", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPregunta.Location = new System.Drawing.Point(16, 417);
            this.TxtPregunta.MaxLength = 150;
            this.TxtPregunta.Multiline = true;
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(544, 52);
            this.TxtPregunta.TabIndex = 23;
            this.TxtPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnMaster);
            this.groupBox3.Controls.Add(this.BtnUniversidad);
            this.groupBox3.Controls.Add(this.BtnSecundaria);
            this.groupBox3.Controls.Add(this.BtnNiños);
            this.groupBox3.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(390, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 86);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categorias:";
            // 
            // BtnMaster
            // 
            this.BtnMaster.AutoSize = true;
            this.BtnMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaster.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaster.Location = new System.Drawing.Point(169, 50);
            this.BtnMaster.Name = "BtnMaster";
            this.BtnMaster.Size = new System.Drawing.Size(79, 19);
            this.BtnMaster.TabIndex = 3;
            this.BtnMaster.TabStop = true;
            this.BtnMaster.Text = "master.";
            this.BtnMaster.UseVisualStyleBackColor = true;
            this.BtnMaster.CheckedChanged += new System.EventHandler(this.BtnMaster_CheckedChanged);
            // 
            // BtnUniversidad
            // 
            this.BtnUniversidad.AutoSize = true;
            this.BtnUniversidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUniversidad.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUniversidad.Location = new System.Drawing.Point(169, 25);
            this.BtnUniversidad.Name = "BtnUniversidad";
            this.BtnUniversidad.Size = new System.Drawing.Size(116, 19);
            this.BtnUniversidad.TabIndex = 2;
            this.BtnUniversidad.TabStop = true;
            this.BtnUniversidad.Text = "Universidad.";
            this.BtnUniversidad.UseVisualStyleBackColor = true;
            this.BtnUniversidad.CheckedChanged += new System.EventHandler(this.BtnUniversidad_CheckedChanged);
            // 
            // BtnSecundaria
            // 
            this.BtnSecundaria.AutoSize = true;
            this.BtnSecundaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSecundaria.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecundaria.Location = new System.Drawing.Point(14, 54);
            this.BtnSecundaria.Name = "BtnSecundaria";
            this.BtnSecundaria.Size = new System.Drawing.Size(112, 19);
            this.BtnSecundaria.TabIndex = 1;
            this.BtnSecundaria.TabStop = true;
            this.BtnSecundaria.Text = "Secundaria.";
            this.BtnSecundaria.UseVisualStyleBackColor = true;
            this.BtnSecundaria.CheckedChanged += new System.EventHandler(this.BtnSecundaria_CheckedChanged);
            // 
            // BtnNiños
            // 
            this.BtnNiños.AutoSize = true;
            this.BtnNiños.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNiños.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNiños.Location = new System.Drawing.Point(14, 25);
            this.BtnNiños.Name = "BtnNiños";
            this.BtnNiños.Size = new System.Drawing.Size(67, 19);
            this.BtnNiños.TabIndex = 0;
            this.BtnNiños.TabStop = true;
            this.BtnNiños.Text = "Niños.";
            this.BtnNiños.UseVisualStyleBackColor = true;
            this.BtnNiños.CheckedChanged += new System.EventHandler(this.BtnNiños_CheckedChanged);
            // 
            // TimerContador
            // 
            this.TimerContador.Interval = 1000;
            this.TimerContador.Tick += new System.EventHandler(this.TimerContador_Tick);
            // 
            // panelLetras
            // 
            this.panelLetras.Enabled = false;
            this.panelLetras.Location = new System.Drawing.Point(16, 505);
            this.panelLetras.Name = "panelLetras";
            this.panelLetras.Size = new System.Drawing.Size(696, 54);
            this.panelLetras.TabIndex = 25;
            // 
            // txtLetraEntrada
            // 
            this.txtLetraEntrada.Font = new System.Drawing.Font("Felix Titling", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetraEntrada.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLetraEntrada.Location = new System.Drawing.Point(592, 417);
            this.txtLetraEntrada.MaxLength = 1;
            this.txtLetraEntrada.Name = "txtLetraEntrada";
            this.txtLetraEntrada.Size = new System.Drawing.Size(70, 51);
            this.txtLetraEntrada.TabIndex = 26;
            this.txtLetraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetraEntrada.TextChanged += new System.EventHandler(this.txtLetraEntrada_TextChanged);
            this.txtLetraEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetraEntrada_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(535, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "INGRESA UNA LETRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(16, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(572, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "* PARA JUGAR *   INGRESE LA LETRA  CORRECTA ,  ¡ NO INGRESE LETRA REPETIDA !  ---" +
    ">>>";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(620, 474);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 30;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTurno.Location = new System.Drawing.Point(476, 171);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(0, 15);
            this.lblTurno.TabIndex = 31;
            // 
            // lbljuegoP
            // 
            this.lbljuegoP.AutoSize = true;
            this.lbljuegoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljuegoP.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbljuegoP.Location = new System.Drawing.Point(472, 171);
            this.lbljuegoP.Name = "lbljuegoP";
            this.lbljuegoP.Size = new System.Drawing.Size(177, 16);
            this.lbljuegoP.TabIndex = 32;
            this.lbljuegoP.Text = "C# - JUEGO EN PAUSA - C#";
            this.lbljuegoP.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(724, 625);
            this.Controls.Add(this.lbljuegoP);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLetraEntrada);
            this.Controls.Add(this.panelLetras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TxtPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblteam2);
            this.Controls.Add(this.lblteam1);
            this.Controls.Add(this.TxtPuntaje2);
            this.Controls.Add(this.TxtPuntaje1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picAhorcado5);
            this.Controls.Add(this.picAhorcado6);
            this.Controls.Add(this.picAhorcado4);
            this.Controls.Add(this.picAhorcado3);
            this.Controls.Add(this.picAhorcado2);
            this.Controls.Add(this.picAhorcado1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.CmdPausar);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.CmdJugar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcado C# Beta 0.1.2025       Juego C#   En Visual Studio 13 .                 " +
    "     danielhgsanchez@gmail.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdJugar;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Button CmdPausar;
        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picAhorcado1;
        private System.Windows.Forms.PictureBox picAhorcado2;
        private System.Windows.Forms.PictureBox picAhorcado3;
        private System.Windows.Forms.PictureBox picAhorcado4;
        private System.Windows.Forms.PictureBox picAhorcado6;
        private System.Windows.Forms.PictureBox picAhorcado5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPuntaje1;
        private System.Windows.Forms.TextBox TxtPuntaje2;
        private System.Windows.Forms.Label lblteam1;
        private System.Windows.Forms.Label lblteam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton BtnMaster;
        private System.Windows.Forms.RadioButton BtnUniversidad;
        private System.Windows.Forms.RadioButton BtnSecundaria;
        private System.Windows.Forms.RadioButton BtnNiños;
        private System.Windows.Forms.Button CmdNuevo;
        private System.Windows.Forms.Button CmdCancela;
        private System.Windows.Forms.Timer TimerContador;
        private System.Windows.Forms.Panel panelLetras;
        private System.Windows.Forms.TextBox txtLetraEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton BtnJugarA;
        private System.Windows.Forms.RadioButton BtnJugarS;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lbljuegoP;
    }
}

