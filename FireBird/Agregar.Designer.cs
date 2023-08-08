namespace FireBird
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            label1 = new Label();
            label3 = new Label();
            Txt_Nombre = new TextBox();
            Txt_Numero = new TextBox();
            Btn_Agregar = new Button();
            Txt_Apellido = new TextBox();
            label2 = new Label();
            Cb_Bandera = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 16);
            label1.TabIndex = 23;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 18);
            label3.Name = "label3";
            label3.Size = new Size(162, 16);
            label3.TabIndex = 22;
            label3.Text = "Número de empleado";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.Anchor = AnchorStyles.Top;
            Txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            Txt_Nombre.CharacterCasing = CharacterCasing.Upper;
            Txt_Nombre.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Nombre.Location = new Point(181, 62);
            Txt_Nombre.Multiline = true;
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.PlaceholderText = "NOMBRE";
            Txt_Nombre.Size = new Size(203, 34);
            Txt_Nombre.TabIndex = 2;
            Txt_Nombre.TextAlign = HorizontalAlignment.Center;
            Txt_Nombre.KeyDown += Txt_Nombre_KeyDown;
            Txt_Nombre.KeyPress += Txt_Nombre_KeyPress;
            // 
            // Txt_Numero
            // 
            Txt_Numero.Anchor = AnchorStyles.Top;
            Txt_Numero.BorderStyle = BorderStyle.FixedSingle;
            Txt_Numero.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Numero.Location = new Point(12, 63);
            Txt_Numero.Multiline = true;
            Txt_Numero.Name = "Txt_Numero";
            Txt_Numero.PlaceholderText = "NÚMERO";
            Txt_Numero.Size = new Size(163, 34);
            Txt_Numero.TabIndex = 1;
            Txt_Numero.TextAlign = HorizontalAlignment.Center;
            Txt_Numero.KeyDown += Txt_Numero_KeyDown;
            Txt_Numero.KeyPress += Txt_Numero_KeyPress;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.Anchor = AnchorStyles.Top;
            Btn_Agregar.BackColor = Color.Green;
            Btn_Agregar.Cursor = Cursors.Hand;
            Btn_Agregar.FlatStyle = FlatStyle.Flat;
            Btn_Agregar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Agregar.Location = new Point(319, 126);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(139, 49);
            Btn_Agregar.TabIndex = 5;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = false;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // Txt_Apellido
            // 
            Txt_Apellido.Anchor = AnchorStyles.Top;
            Txt_Apellido.BorderStyle = BorderStyle.FixedSingle;
            Txt_Apellido.CharacterCasing = CharacterCasing.Upper;
            Txt_Apellido.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Apellido.Location = new Point(390, 63);
            Txt_Apellido.Multiline = true;
            Txt_Apellido.Name = "Txt_Apellido";
            Txt_Apellido.PlaceholderText = "APELLIDO";
            Txt_Apellido.Size = new Size(229, 34);
            Txt_Apellido.TabIndex = 3;
            Txt_Apellido.TextAlign = HorizontalAlignment.Center;
            Txt_Apellido.KeyDown += Txt_Apellido_KeyDown;
            Txt_Apellido.KeyPress += Txt_Apellido_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(597, 18);
            label2.Name = "label2";
            label2.Size = new Size(195, 16);
            label2.TabIndex = 25;
            label2.Text = "¿Eres del área de surtido?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cb_Bandera
            // 
            Cb_Bandera.DisplayMember = "1";
            Cb_Bandera.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Bandera.FlatStyle = FlatStyle.Flat;
            Cb_Bandera.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Bandera.FormattingEnabled = true;
            Cb_Bandera.Items.AddRange(new object[] { "SI", "NO" });
            Cb_Bandera.Location = new Point(652, 62);
            Cb_Bandera.Name = "Cb_Bandera";
            Cb_Bandera.Size = new Size(96, 33);
            Cb_Bandera.TabIndex = 4;
            Cb_Bandera.ValueMember = "1";
            Cb_Bandera.KeyDown += Cb_Bandera_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(489, 18);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 27;
            label4.Text = "Apellido";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(804, 196);
            Controls.Add(label4);
            Controls.Add(Cb_Bandera);
            Controls.Add(label2);
            Controls.Add(Txt_Apellido);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(Txt_Nombre);
            Controls.Add(Txt_Numero);
            Controls.Add(Btn_Agregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Agregar";
            StartPosition = FormStartPosition.Manual;
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox Txt_Nombre;
        private TextBox Txt_Numero;
        private Button Btn_Agregar;
        private TextBox Txt_Apellido;
        private Label label2;
        private ComboBox Cb_Bandera;
        private Label label4;
    }
}