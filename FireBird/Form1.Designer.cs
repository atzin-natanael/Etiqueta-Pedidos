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
            BtnCenefa = new Button();
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
            SuspendLayout();
            // 
            // TxtFolio
            // 
            TxtFolio.Anchor = AnchorStyles.Top;
            TxtFolio.BackColor = Color.White;
            TxtFolio.CharacterCasing = CharacterCasing.Upper;
            TxtFolio.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtFolio.ForeColor = Color.Black;
            TxtFolio.Location = new Point(181, 143);
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
            Imagen_Codigo.Location = new Point(12, 72);
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
            BtnVistaPrevia.Location = new Point(857, 357);
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
            BtnImprimir.BackColor = Color.Black;
            BtnImprimir.Cursor = Cursors.Hand;
            BtnImprimir.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnImprimir.ForeColor = Color.White;
            BtnImprimir.Location = new Point(408, 269);
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
            TxtBultos.Location = new Point(181, 196);
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
            pictureBox1.Location = new Point(285, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 113);
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
            Cb_Empacador.Location = new Point(408, 143);
            Cb_Empacador.MaxDropDownItems = 1;
            Cb_Empacador.Name = "Cb_Empacador";
            Cb_Empacador.Size = new Size(469, 31);
            Cb_Empacador.TabIndex = 2;
            Cb_Empacador.KeyDown += Cb_Empacador_KeyDown;
            Cb_Empacador.KeyPress += Cb_Empacador_KeyPress;
            // 
            // Lbhora
            // 
            Lbhora.Anchor = AnchorStyles.Top;
            Lbhora.AutoSize = true;
            Lbhora.BackColor = Color.Transparent;
            Lbhora.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbhora.ForeColor = Color.WhiteSmoke;
            Lbhora.Location = new Point(64, 9);
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
            LbFecha.Location = new Point(12, 24);
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
            Firma.Location = new Point(9, 20);
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
            pictureBox2.Location = new Point(-6, 439);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(607, 556);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(193, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(193, 455);
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
            pictureBox5.Location = new Point(607, 439);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(193, 98);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Bottom;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(803, 439);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(193, 98);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Bottom;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-6, 556);
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
            pictureBox8.Location = new Point(193, 556);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(205, 98);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Bottom;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(408, 439);
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
            pictureBox11.Location = new Point(803, 556);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(193, 98);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 28;
            pictureBox11.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(213, 115);
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
            label3.Location = new Point(568, 115);
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
            label4.Location = new Point(254, 177);
            label4.Name = "label4";
            label4.Size = new Size(53, 16);
            label4.TabIndex = 31;
            label4.Text = "Bultos";
            // 
            // BtnCenefa
            // 
            BtnCenefa.Anchor = AnchorStyles.Top;
            BtnCenefa.BackColor = Color.DarkOrange;
            BtnCenefa.Cursor = Cursors.Hand;
            BtnCenefa.FlatStyle = FlatStyle.Flat;
            BtnCenefa.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCenefa.ForeColor = Color.Black;
            BtnCenefa.Location = new Point(181, 357);
            BtnCenefa.Name = "BtnCenefa";
            BtnCenefa.Size = new Size(166, 48);
            BtnCenefa.TabIndex = 32;
            BtnCenefa.Text = "Cenefa Almacén";
            BtnCenefa.UseVisualStyleBackColor = false;
            BtnCenefa.Click += BtnCenefa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1008, 729);
            Controls.Add(BtnCenefa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(LbFecha);
            Controls.Add(Lbhora);
            Controls.Add(Cb_Empacador);
            Controls.Add(pictureBox1);
            Controls.Add(TxtBultos);
            Controls.Add(BtnImprimir);
            Controls.Add(BtnVistaPrevia);
            Controls.Add(Imagen_Codigo);
            Controls.Add(TxtFolio);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
            ResumeLayout(false);
            PerformLayout();
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
        private Button BtnCenefa;
    }
}