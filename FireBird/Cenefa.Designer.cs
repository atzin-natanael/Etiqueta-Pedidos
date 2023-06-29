namespace FireBird
{
    partial class Cenefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cenefa));
            TxtCodigo = new TextBox();
            label1 = new Label();
            BtnImprimirCenefa = new Button();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            Imagen_Codigo = new PictureBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)Imagen_Codigo).BeginInit();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCodigo.Location = new Point(178, 67);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(234, 26);
            TxtCodigo.TabIndex = 0;
            TxtCodigo.KeyDown += TxtCodigo_KeyDown;
            TxtCodigo.KeyPress += TxtCodigo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 1;
            label1.Text = "Cenefa Almacén";
            // 
            // BtnImprimirCenefa
            // 
            BtnImprimirCenefa.Anchor = AnchorStyles.Top;
            BtnImprimirCenefa.BackColor = Color.DarkOrange;
            BtnImprimirCenefa.FlatStyle = FlatStyle.Flat;
            BtnImprimirCenefa.Location = new Point(227, 118);
            BtnImprimirCenefa.Name = "BtnImprimirCenefa";
            BtnImprimirCenefa.Size = new Size(116, 34);
            BtnImprimirCenefa.TabIndex = 2;
            BtnImprimirCenefa.Text = "Imprimir";
            BtnImprimirCenefa.UseVisualStyleBackColor = false;
            BtnImprimirCenefa.Click += BtnImprimirCenefa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 70);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingresa el Código:";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Imagen_Codigo
            // 
            Imagen_Codigo.Location = new Point(23, 103);
            Imagen_Codigo.Name = "Imagen_Codigo";
            Imagen_Codigo.Size = new Size(141, 53);
            Imagen_Codigo.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagen_Codigo.TabIndex = 4;
            Imagen_Codigo.TabStop = false;
            Imagen_Codigo.Visible = false;
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
            // Cenefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(562, 164);
            Controls.Add(Imagen_Codigo);
            Controls.Add(label2);
            Controls.Add(BtnImprimirCenefa);
            Controls.Add(label1);
            Controls.Add(TxtCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cenefa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cenefa";
            ((System.ComponentModel.ISupportInitialize)Imagen_Codigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCodigo;
        private Label label1;
        private Button BtnImprimirCenefa;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PictureBox Imagen_Codigo;
        private PrintPreviewDialog printPreviewDialog1;
    }
}