using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBird
{
    public partial class Cenefa : Form
    {
        string Codigo;
        int oficial_codigo;
        int oficial_rol;
        string oficial_desc;
        bool encontrado = false;
        int Codigo_nuevo;
        public Cenefa()
        {
            InitializeComponent();
        }

        private void BtnImprimirCenefa_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != string.Empty)
            {
                if (TxtCodigo.Text.Length > 6)
                {
                    FbConnection con = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
                    try
                    {
                        Codigo = TxtCodigo.Text;
                        con.Open();
                        string query = "SELECT * FROM CLAVES_ARTICULOS ORDER BY CLAVE_ARTICULO_ID";
                        FbCommand command = new FbCommand(query, con);

                        // Objeto para leer los datos obtenidos
                        FbDataReader reader = command.ExecuteReader();
                        bool encontrado = false;
                        //oficial_codigo = Cb_Empacador.Text;
                        //oficial_bultos = int.Parse(TxtBultos.Text);
                        // Iterar sobre los registros y mostrar los valores
                        while (reader.Read())
                        {
                            // Acceder a los valores de cada columna por su índice o nombre
                            int temp = reader.GetInt32(2);
                            string col2 = reader.GetString(1);
                            int rol = reader.GetInt32(3);
                            if (Codigo == col2)
                            {
                                oficial_codigo = temp;
                                encontrado = true;
                                break;
                            }
                        }
                        reader.Close();
                        string query2 = "SELECT * FROM CLAVES_ARTICULOS ORDER BY ROL_CLAVE_ART_ID ASC";
                        FbCommand command2 = new FbCommand(query2, con);
                        FbDataReader reader2 = command2.ExecuteReader();

                        // Iterar sobre los registros y mostrar los valores
                        while (reader2.Read())
                        {
                            int columnaclave = reader2.GetInt32(2);
                            int rol = reader2.GetInt32(3);
                            string codigotemp = reader2.GetString(1);

                            if (columnaclave == oficial_codigo && rol == 17 )
                            {
                                Codigo_nuevo = int.Parse(codigotemp);
                                Codigo = Codigo_nuevo.ToString();
                                break;
                            }
                        }

                        reader2.Close();
                        string query3 = "SELECT * FROM ARTICULOS ORDER BY ARTICULO_ID";
                        FbCommand command3 = new FbCommand(query3, con);
                        FbDataReader reader3 = command3.ExecuteReader();

                        // Iterar sobre los registros y mostrar los valores
                        while (reader3.Read())
                        {
                            int columna11 = reader3.GetInt32(0);
                            string descripcion = reader3.GetString(1);
                            if (columna11 == oficial_codigo)
                            {
                                oficial_desc = descripcion;
                                Codigo_Barras();
                                break;
                            }
                        }

                        reader3.Close();
                        if (encontrado == false)
                        {
                            MessageBox.Show("CÓDIGO NO ENCONTRADO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        void Codigo_Barras()
                        {
                            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
                            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                            Imagen_Codigo.Image = mGeneradorCB.Draw(Codigo_nuevo.ToString(), 120);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    printDialog1.Document = printDocument1;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                        TxtCodigo.Text = string.Empty;
                        TxtCodigo.Select();

                    }
                    else
                    {
                        TxtCodigo.Text = string.Empty;
                        TxtCodigo.Select();
                    }
                }
                else
                {
                    FbConnection con = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
                    try
                    {
                        // Crear un nuevo hilo y asignarle un método que se ejecutará en paralelo
                        Thread hilo = new Thread(Codigo_Barras);
                        // Iniciar la ejecución del hilo
                        Codigo = TxtCodigo.Text;
                        hilo.Start();
                        con.Open();
                        string query = "SELECT * FROM CLAVES_ARTICULOS ORDER BY CLAVE_ARTICULO_ID";
                        FbCommand command = new FbCommand(query, con);

                        // Objeto para leer los datos obtenidos
                        FbDataReader reader = command.ExecuteReader();
                        bool encontrado = false;
                        //oficial_codigo = Cb_Empacador.Text;
                        //oficial_bultos = int.Parse(TxtBultos.Text);
                        // Iterar sobre los registros y mostrar los valores
                        while (reader.Read())
                        {
                            // Acceder a los valores de cada columna por su índice o nombre
                            int temp = reader.GetInt32(2);
                            string col2 = reader.GetString(1);
                            if (Codigo == col2)
                            {
                                oficial_codigo = temp;
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado == false)
                        {
                            MessageBox.Show("CÓDIGO NO ENCONTRADO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        reader.Close();
                        hilo.Join();
                        string query2 = "SELECT * FROM ARTICULOS ORDER BY ARTICULO_ID";
                        FbCommand command2 = new FbCommand(query2, con);
                        FbDataReader reader2 = command2.ExecuteReader();

                        // Iterar sobre los registros y mostrar los valores
                        while (reader2.Read())
                        {
                            int columna11 = reader2.GetInt32(0);
                            string descripcion = reader2.GetString(1);
                            if (columna11 == oficial_codigo)
                            {
                                oficial_desc = descripcion;
                                break;
                            }
                        }

                        reader2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    void Codigo_Barras()
                    {
                        Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
                        Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                        Imagen_Codigo.Image = mGeneradorCB.Draw(Codigo.ToString(), 120);
                    }
                    printDialog1.Document = printDocument1;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                        TxtCodigo.Text = string.Empty;
                        TxtCodigo.Select();

                    }
                    else
                    {
                        TxtCodigo.Text = string.Empty;
                        TxtCodigo.Select();
                    }
                }
            }
            else
            {
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                TxtCodigo.Text = string.Empty;
            
        }

            private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
                {
                    MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
       

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnImprimirCenefa.Focus();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font font = new Font("Arial", 75, FontStyle.Bold))
            {
                e.Graphics.DrawString(Codigo, font, Brushes.Black, new PointF(0, 0));
            }
            using (Font font = new Font("Arial", 12, FontStyle.Bold))
            {
                Rectangle DestinationRectangle = new Rectangle(0, 100, 410, 160);
                using (StringFormat sf = new StringFormat())
                {
                    e.Graphics.DrawString(oficial_desc, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, DestinationRectangle, sf);
                }

            }

            // Image image = Image.FromFile("C:\\Datos_Surtido\\coriba.png");
            //e.Graphics.DrawImage(image, new PointF(0, 160));
            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Imagen_Codigo.Image = mGeneradorCB.Draw(Codigo, 120);

            Bitmap bm = new Bitmap(Imagen_Codigo.Width, Imagen_Codigo.Height);
            Imagen_Codigo.DrawToBitmap(bm, new Rectangle(0, 0, Imagen_Codigo.Width, Imagen_Codigo.Height));
            e.Graphics.DrawImage(bm, 130, 180);
            bm.Dispose();
        }
    }
}
