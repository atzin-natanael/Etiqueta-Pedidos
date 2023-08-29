namespace FireBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TxtFolio = new TextBox();
            Imagen_Codigo = new PictureBox();
            BtnVistaPrevia = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            BtnImprimir = new Button();
            TxtBultos = new TextBox();
            pictureBox1 = new PictureBox();
            Cb_Empacador = new ComboBox();
            Lbhora = new Label();
            TimerHora = new System.Windows.Forms.Timer(components);
            LbFecha = new Label();
            Firma = new Label();
            label1 = new Label();
            TimerMarque = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox11 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Pb_Add = new PictureBox();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            tabPage2 = new TabPage();
            pictureBox12 = new PictureBox();
            ImagenCodigo2 = new PictureBox();
            label6 = new Label();
            BtnImprimirCenefa = new Button();
            label7 = new Label();
            TxtCodigo = new TextBox();
            tabPage3 = new TabPage();
            pictureBox13 = new PictureBox();
            label8 = new Label();
            Btn_Buscar = new Button();
            label9 = new Label();
            Txt_FacturaB = new TextBox();
            tabPage4 = new TabPage();
            Cb_Amazon = new ComboBox();
            Num_Amazon = new NumericUpDown();
            label13 = new Label();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            Btn_Amazon = new Button();
            label12 = new Label();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Pb_Cerrar = new PictureBox();
            Btn_Max = new PictureBox();
            Pb_Min = new PictureBox();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            Print_Amazon = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)Imagen_Codigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Add).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenCodigo2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Num_Amazon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Min).BeginInit();
            SuspendLayout();
            // 
            // TxtFolio
            // 
            TxtFolio.Anchor = AnchorStyles.Top;
            TxtFolio.BackColor = Color.White;
            TxtFolio.CharacterCasing = CharacterCasing.Upper;
            TxtFolio.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtFolio.ForeColor = Color.Black;
            TxtFolio.Location = new Point(155, 167);
            TxtFolio.MaxLength = 9;
            TxtFolio.Multiline = true;
            TxtFolio.Name = "TxtFolio";
            TxtFolio.PlaceholderText = "FOLIO";
            TxtFolio.Size = new Size(200, 31);
            TxtFolio.TabIndex = 1;
            TxtFolio.TextAlign = HorizontalAlignment.Center;
            TxtFolio.KeyDown += TxtFolio_KeyDown;
            // 
            // Imagen_Codigo
            // 
            Imagen_Codigo.Location = new Point(0, 340);
            Imagen_Codigo.Name = "Imagen_Codigo";
            Imagen_Codigo.Size = new Size(175, 65);
            Imagen_Codigo.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagen_Codigo.TabIndex = 7;
            Imagen_Codigo.TabStop = false;
            Imagen_Codigo.Visible = false;
            // 
            // BtnVistaPrevia
            // 
            BtnVistaPrevia.Anchor = AnchorStyles.Top;
            BtnVistaPrevia.BackColor = Color.DarkOrange;
            BtnVistaPrevia.FlatStyle = FlatStyle.Flat;
            BtnVistaPrevia.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVistaPrevia.ForeColor = Color.Black;
            BtnVistaPrevia.Location = new Point(795, 278);
            BtnVistaPrevia.Name = "BtnVistaPrevia";
            BtnVistaPrevia.Size = new Size(139, 38);
            BtnVistaPrevia.TabIndex = 8;
            BtnVistaPrevia.Text = "Vista Previa";
            BtnVistaPrevia.UseVisualStyleBackColor = false;
            BtnVistaPrevia.Visible = false;
            BtnVistaPrevia.Click += BtnVistaPrevia_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // BtnImprimir
            // 
            BtnImprimir.Anchor = AnchorStyles.Top;
            BtnImprimir.BackColor = Color.DodgerBlue;
            BtnImprimir.Cursor = Cursors.Hand;
            BtnImprimir.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnImprimir.ForeColor = Color.Black;
            BtnImprimir.Location = new Point(424, 262);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(184, 68);
            BtnImprimir.TabIndex = 4;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.UseVisualStyleBackColor = false;
            BtnImprimir.Click += BtnImprimir_Click;
            // 
            // TxtBultos
            // 
            TxtBultos.Anchor = AnchorStyles.Top;
            TxtBultos.BackColor = Color.White;
            TxtBultos.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBultos.ForeColor = Color.Black;
            TxtBultos.Location = new Point(155, 234);
            TxtBultos.Multiline = true;
            TxtBultos.Name = "TxtBultos";
            TxtBultos.PlaceholderText = "BULTOS";
            TxtBultos.Size = new Size(200, 31);
            TxtBultos.TabIndex = 3;
            TxtBultos.TextAlign = HorizontalAlignment.Center;
            TxtBultos.KeyDown += TxtBultos_KeyDown;
            TxtBultos.KeyPress += TxtBultos_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Cb_Empacador
            // 
            Cb_Empacador.AllowDrop = true;
            Cb_Empacador.Anchor = AnchorStyles.Top;
            Cb_Empacador.BackColor = Color.White;
            Cb_Empacador.FlatStyle = FlatStyle.Flat;
            Cb_Empacador.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Empacador.ForeColor = Color.Black;
            Cb_Empacador.FormattingEnabled = true;
            Cb_Empacador.ItemHeight = 23;
            Cb_Empacador.Location = new Point(375, 167);
            Cb_Empacador.MaxDropDownItems = 6;
            Cb_Empacador.Name = "Cb_Empacador";
            Cb_Empacador.Size = new Size(469, 31);
            Cb_Empacador.TabIndex = 2;
            Cb_Empacador.KeyDown += Cb_Empacador_KeyDown;
            Cb_Empacador.KeyPress += Cb_Empacador_KeyPress;
            Cb_Empacador.Leave += Cb_Empacador_Leave;
            // 
            // Lbhora
            // 
            Lbhora.Anchor = AnchorStyles.Top;
            Lbhora.AutoSize = true;
            Lbhora.BackColor = Color.Transparent;
            Lbhora.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbhora.ForeColor = Color.WhiteSmoke;
            Lbhora.Location = new Point(8, 3);
            Lbhora.Name = "Lbhora";
            Lbhora.Size = new Size(15, 17);
            Lbhora.TabIndex = 13;
            Lbhora.Text = "0";
            Lbhora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimerHora
            // 
            TimerHora.Enabled = true;
            TimerHora.Interval = 1000;
            TimerHora.Tick += TimerHora_Tick;
            // 
            // LbFecha
            // 
            LbFecha.Anchor = AnchorStyles.Top;
            LbFecha.AutoSize = true;
            LbFecha.BackColor = Color.Transparent;
            LbFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbFecha.ForeColor = Color.WhiteSmoke;
            LbFecha.Location = new Point(8, 20);
            LbFecha.Name = "LbFecha";
            LbFecha.Size = new Size(15, 17);
            LbFecha.TabIndex = 14;
            LbFecha.Text = "0";
            LbFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Firma
            // 
            Firma.Anchor = AnchorStyles.Bottom;
            Firma.AutoSize = true;
            Firma.BackColor = Color.Transparent;
            Firma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Firma.ForeColor = Color.WhiteSmoke;
            Firma.Location = new Point(11, 20);
            Firma.Name = "Firma";
            Firma.Size = new Size(199, 17);
            Firma.TabIndex = 15;
            Firma.Text = "Developed by Atzin Not Found";
            Firma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(87, 37);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 16;
            label1.Text = "2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimerMarque
            // 
            TimerMarque.Enabled = true;
            TimerMarque.Interval = 20;
            TimerMarque.Tick += TimerMarque_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(810, 388);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(202, 498);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(205, 81);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(Firma);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(408, 670);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 57);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Créditos";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(621, 388);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(183, 90);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Bottom;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(822, 484);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(178, 95);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Bottom;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 484);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(193, 98);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Bottom;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(181, 388);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(193, 90);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Bottom;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(415, 364);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(193, 215);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 26;
            pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Bottom;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(613, 501);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(203, 81);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 28;
            pictureBox11.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.CausesValidation = false;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(189, 141);
            label2.Name = "label2";
            label2.Size = new Size(134, 16);
            label2.TabIndex = 29;
            label2.Text = "Escanear Factura";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(495, 141);
            label3.Name = "label3";
            label3.Size = new Size(126, 16);
            label3.TabIndex = 30;
            label3.Text = "Escanear Gafete";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(227, 211);
            label4.Name = "label4";
            label4.Size = new Size(53, 16);
            label4.TabIndex = 31;
            label4.Text = "Bultos";
            // 
            // Pb_Add
            // 
            Pb_Add.Anchor = AnchorStyles.Top;
            Pb_Add.BackColor = Color.Transparent;
            Pb_Add.Cursor = Cursors.Hand;
            Pb_Add.Image = (Image)resources.GetObject("Pb_Add.Image");
            Pb_Add.Location = new Point(36, 77);
            Pb_Add.Name = "Pb_Add";
            Pb_Add.Size = new Size(62, 61);
            Pb_Add.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Add.TabIndex = 33;
            Pb_Add.TabStop = false;
            Pb_Add.Click += Pb_Add_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 53);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 34;
            label5.Text = "Agregar Usuario";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 616);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(Lbhora);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox9);
            tabPage1.Controls.Add(pictureBox11);
            tabPage1.Controls.Add(pictureBox8);
            tabPage1.Controls.Add(pictureBox7);
            tabPage1.Controls.Add(BtnImprimir);
            tabPage1.Controls.Add(Pb_Add);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pictureBox6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(LbFecha);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(TxtFolio);
            tabPage1.Controls.Add(TxtBultos);
            tabPage1.Controls.Add(Cb_Empacador);
            tabPage1.Controls.Add(BtnVistaPrevia);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1000, 585);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inicio";
            tabPage1.Resize += tabPage1_Resize;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(811, 45);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 35;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(pictureBox12);
            tabPage2.Controls.Add(ImagenCodigo2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(BtnImprimirCenefa);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(TxtCodigo);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1000, 585);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cenefa Almacén";
            // 
            // pictureBox12
            // 
            pictureBox12.Anchor = AnchorStyles.Top;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(287, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(445, 138);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 38;
            pictureBox12.TabStop = false;
            // 
            // ImagenCodigo2
            // 
            ImagenCodigo2.Anchor = AnchorStyles.Top;
            ImagenCodigo2.Location = new Point(225, 280);
            ImagenCodigo2.Name = "ImagenCodigo2";
            ImagenCodigo2.Size = new Size(141, 53);
            ImagenCodigo2.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenCodigo2.TabIndex = 37;
            ImagenCodigo2.TabStop = false;
            ImagenCodigo2.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(130, 216);
            label6.Name = "label6";
            label6.Size = new Size(226, 25);
            label6.TabIndex = 36;
            label6.Text = "Ingresa el Código:";
            // 
            // BtnImprimirCenefa
            // 
            BtnImprimirCenefa.Anchor = AnchorStyles.Top;
            BtnImprimirCenefa.BackColor = Color.Purple;
            BtnImprimirCenefa.Cursor = Cursors.Hand;
            BtnImprimirCenefa.FlatStyle = FlatStyle.Flat;
            BtnImprimirCenefa.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnImprimirCenefa.ForeColor = Color.Black;
            BtnImprimirCenefa.Location = new Point(702, 201);
            BtnImprimirCenefa.Name = "BtnImprimirCenefa";
            BtnImprimirCenefa.Size = new Size(144, 54);
            BtnImprimirCenefa.TabIndex = 35;
            BtnImprimirCenefa.Text = "Imprimir";
            BtnImprimirCenefa.UseVisualStyleBackColor = false;
            BtnImprimirCenefa.Click += BtnImprimirCenefa_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(392, 143);
            label7.Name = "label7";
            label7.Size = new Size(276, 35);
            label7.TabIndex = 34;
            label7.Text = "Cenefa Almacén";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.Top;
            TxtCodigo.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCodigo.Location = new Point(404, 213);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(234, 33);
            TxtCodigo.TabIndex = 33;
            TxtCodigo.KeyDown += TxtCodigo_KeyDown;
            TxtCodigo.KeyPress += TxtCodigo_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DimGray;
            tabPage3.Controls.Add(pictureBox13);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(Btn_Buscar);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(Txt_FacturaB);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1000, 585);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Buscar";
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.Top;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(287, 0);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(445, 138);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 43;
            pictureBox13.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(130, 216);
            label8.Name = "label8";
            label8.Size = new Size(226, 25);
            label8.TabIndex = 42;
            label8.Text = "Ingresa el Código:";
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Anchor = AnchorStyles.Top;
            Btn_Buscar.BackColor = Color.DarkTurquoise;
            Btn_Buscar.Cursor = Cursors.Hand;
            Btn_Buscar.FlatStyle = FlatStyle.Flat;
            Btn_Buscar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Buscar.ForeColor = Color.Black;
            Btn_Buscar.Location = new Point(702, 201);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(144, 54);
            Btn_Buscar.TabIndex = 41;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = false;
            Btn_Buscar.Click += Btn_Buscar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Aqua;
            label9.Location = new Point(392, 143);
            label9.Name = "label9";
            label9.Size = new Size(257, 35);
            label9.TabIndex = 40;
            label9.Text = "Buscar Factura";
            // 
            // Txt_FacturaB
            // 
            Txt_FacturaB.Anchor = AnchorStyles.Top;
            Txt_FacturaB.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_FacturaB.Location = new Point(404, 213);
            Txt_FacturaB.Name = "Txt_FacturaB";
            Txt_FacturaB.Size = new Size(234, 33);
            Txt_FacturaB.TabIndex = 39;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.DimGray;
            tabPage4.Controls.Add(Cb_Amazon);
            tabPage4.Controls.Add(Num_Amazon);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(pictureBox10);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(Btn_Amazon);
            tabPage4.Controls.Add(label12);
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1000, 585);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Amazon";
            // 
            // Cb_Amazon
            // 
            Cb_Amazon.Anchor = AnchorStyles.Top;
            Cb_Amazon.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Amazon.FlatStyle = FlatStyle.Flat;
            Cb_Amazon.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Amazon.FormattingEnabled = true;
            Cb_Amazon.Items.AddRange(new object[] { "LOCAL", "FORÁNEO" });
            Cb_Amazon.Location = new Point(342, 236);
            Cb_Amazon.Name = "Cb_Amazon";
            Cb_Amazon.Size = new Size(193, 37);
            Cb_Amazon.TabIndex = 51;
            // 
            // Num_Amazon
            // 
            Num_Amazon.Anchor = AnchorStyles.Top;
            Num_Amazon.BorderStyle = BorderStyle.None;
            Num_Amazon.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Num_Amazon.Location = new Point(596, 236);
            Num_Amazon.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            Num_Amazon.Name = "Num_Amazon";
            Num_Amazon.Size = new Size(83, 33);
            Num_Amazon.TabIndex = 52;
            Num_Amazon.Click += Num_Amazon_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(255, 155, 0);
            label13.Location = new Point(533, 141);
            label13.Name = "label13";
            label13.Size = new Size(146, 35);
            label13.TabIndex = 49;
            label13.Text = "Amazon";
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(287, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(445, 138);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 48;
            pictureBox10.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(45, 238);
            label11.Name = "label11";
            label11.Size = new Size(253, 25);
            label11.TabIndex = 47;
            label11.Text = "Diseño de etiquetas:";
            // 
            // Btn_Amazon
            // 
            Btn_Amazon.Anchor = AnchorStyles.Top;
            Btn_Amazon.BackColor = Color.FromArgb(255, 155, 0);
            Btn_Amazon.Cursor = Cursors.Hand;
            Btn_Amazon.FlatStyle = FlatStyle.Flat;
            Btn_Amazon.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Amazon.ForeColor = Color.FromArgb(28, 25, 25);
            Btn_Amazon.Location = new Point(808, 227);
            Btn_Amazon.Name = "Btn_Amazon";
            Btn_Amazon.Size = new Size(144, 54);
            Btn_Amazon.TabIndex = 53;
            Btn_Amazon.Text = "Imprimir";
            Btn_Amazon.UseVisualStyleBackColor = false;
            Btn_Amazon.Click += Btn_Amazon_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(377, 141);
            label12.Name = "label12";
            label12.Size = new Size(150, 35);
            label12.TabIndex = 45;
            label12.Text = "Etiqueta";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutPanel1.BackColor = Color.SteelBlue;
            FlowLayoutPanel1.Controls.Add(Pb_Cerrar);
            FlowLayoutPanel1.Controls.Add(Btn_Max);
            FlowLayoutPanel1.Controls.Add(Pb_Min);
            FlowLayoutPanel1.Cursor = Cursors.SizeAll;
            FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            FlowLayoutPanel1.Location = new Point(0, -2);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1012, 44);
            FlowLayoutPanel1.TabIndex = 36;
            FlowLayoutPanel1.MouseDown += FlowLayoutPanel1_MouseDown;
            FlowLayoutPanel1.MouseMove += FlowLayoutPanel1_MouseMove;
            FlowLayoutPanel1.MouseUp += FlowLayoutPanel1_MouseUp;
            // 
            // Pb_Cerrar
            // 
            Pb_Cerrar.Anchor = AnchorStyles.Top;
            Pb_Cerrar.BackColor = Color.SteelBlue;
            Pb_Cerrar.Cursor = Cursors.Hand;
            Pb_Cerrar.Image = (Image)resources.GetObject("Pb_Cerrar.Image");
            Pb_Cerrar.Location = new Point(962, 3);
            Pb_Cerrar.Name = "Pb_Cerrar";
            Pb_Cerrar.Size = new Size(47, 31);
            Pb_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Cerrar.TabIndex = 0;
            Pb_Cerrar.TabStop = false;
            Pb_Cerrar.Click += Pb_Cerrar_Click;
            // 
            // Btn_Max
            // 
            Btn_Max.Anchor = AnchorStyles.Top;
            Btn_Max.BackColor = Color.SteelBlue;
            Btn_Max.Cursor = Cursors.Hand;
            Btn_Max.Image = (Image)resources.GetObject("Btn_Max.Image");
            Btn_Max.Location = new Point(923, 3);
            Btn_Max.Name = "Btn_Max";
            Btn_Max.Size = new Size(33, 31);
            Btn_Max.SizeMode = PictureBoxSizeMode.StretchImage;
            Btn_Max.TabIndex = 15;
            Btn_Max.TabStop = false;
            Btn_Max.Click += Btn_Max_Click;
            // 
            // Pb_Min
            // 
            Pb_Min.Anchor = AnchorStyles.Top;
            Pb_Min.BackColor = Color.SteelBlue;
            Pb_Min.Cursor = Cursors.Hand;
            Pb_Min.Image = (Image)resources.GetObject("Pb_Min.Image");
            Pb_Min.Location = new Point(884, 3);
            Pb_Min.Name = "Pb_Min";
            Pb_Min.Size = new Size(33, 31);
            Pb_Min.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Min.TabIndex = 1;
            Pb_Min.TabStop = false;
            Pb_Min.Click += Pb_Min_Click;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // Print_Amazon
            // 
            Print_Amazon.PrintPage += Print_Amazon_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1008, 729);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(Imagen_Codigo);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etiquetas";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)Imagen_Codigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Add).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenCodigo2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Num_Amazon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            FlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Max).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Min).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TxtFolio;
        private PictureBox Imagen_Codigo;
        private Button BtnVistaPrevia;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private Button BtnImprimir;
        private TextBox TxtBultos;
        private PictureBox pictureBox1;
        private ComboBox Cb_Empacador;
        private Label Lbhora;
        private System.Windows.Forms.Timer TimerHora;
        private Label LbFecha;
        private Label Firma;
        private Label label1;
        private System.Windows.Forms.Timer TimerMarque;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private GroupBox groupBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox Pb_Add;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel FlowLayoutPanel1;
        private PictureBox Pb_Cerrar;
        private PictureBox Btn_Max;
        private PictureBox Pb_Min;
        private PictureBox ImagenCodigo2;
        private Label label6;
        private Button BtnImprimirCenefa;
        private Label label7;
        private TextBox TxtCodigo;
        private PictureBox pictureBox12;
        private TabPage tabPage3;
        private PictureBox pictureBox13;
        private Label label8;
        private Button Btn_Buscar;
        private Label label9;
        private TextBox Txt_FacturaB;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private TabPage tabPage4;
        private Label label10;
        private Label label13;
        private PictureBox pictureBox10;
        private Label label11;
        private Button Btn_Amazon;
        private Label label12;
        private ComboBox Cb_Amazon;
        private NumericUpDown Num_Amazon;
        private System.Drawing.Printing.PrintDocument Print_Amazon;
    }
}