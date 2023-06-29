using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using System.Reflection.Metadata;
using Microsoft.Win32;
using System.Xml;
using System;
using SpreadsheetLight;
using FireBird.Models;
using static FireBird.Data.Lectura_Basededatos;
using DocumentFormat.OpenXml.Drawing;
using Rectangle = System.Drawing.Rectangle;
using System.Runtime.InteropServices;

namespace FireBird
{
    public partial class Form1 : Form
    {
        Cenefa FormularioCenefa;
        string columnadescripcion;
        string columnacliente;
        string ciudad;
        string Buscar_Folio;
        string oficial_nombre;
        string oficial_ciudad;
        string oficial_poblacion;
        int oficial_bultos;
        string oficial_empacador;
        string oficial_cliente;
        string oficial_factura;
        string oficial_importe;
        int contador = 0;
        private List<string> nombres = new() { };

        public Form1()
        {
            InitializeComponent();
            Leer_Datos();
            Cb_Empacador.SelectedIndex = -1;
            FormularioCenefa = new Cenefa();
        }
        public void Leer_Datos()
        {
            string filePath = "C:\\Datos_Surtido\\Claves.txt";

            // Leer el contenido del archivo y asignarlo a una matriz de cadenas
            string[] nombresArray = File.ReadAllLines(filePath);
            nombres = new List<string>(nombresArray);
            Cb_Empacador.DataSource = nombres;
            Cb_Empacador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cb_Empacador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Empacador.AutoCompleteCustomSource.AddRange(nombres.ToArray());
            Cb_Empacador.Text = "";
        }
        static async Task Base(string folio, string empacador, int bultos, string hora, string fecha)
        {
            using (var db = new DatabaseDbContext())
            {
                await db.Database.EnsureCreatedAsync();
                var dato = new Dato()
                {
                    Hora = hora,
                    Fecha = fecha,
                    Factura = folio,
                    Empacador = empacador,
                    Bultos = bultos
                };
                db.Add(dato);
                await db.SaveChangesAsync();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DateTime Actual = DateTime.Now;
            int id = contador + 1;
            using (Font font = new Font("Arial", 8))
            {
                e.Graphics.DrawString(Actual.ToString().ToUpper(), font, Brushes.Black, new PointF(0, 0));
            }
            using (Font font = new Font("Arial", 55, FontStyle.Bold))
            {
                e.Graphics.DrawString(oficial_factura, font, Brushes.Black, new PointF(0, 0));
            }
            using (Font font = new Font("Arial", 12, FontStyle.Bold))
            {
                e.Graphics.DrawString("RUTA: " + oficial_ciudad, font, Brushes.Black, new PointF(0, 80));
            }
            using (Font font = new Font("Arial", 12))
            {
                e.Graphics.DrawString("LOCALIDAD: " + oficial_poblacion, font, Brushes.Black, new PointF(0, 100));
            }
            using (Font font = new Font("Arial", 12, FontStyle.Bold))
            {
                e.Graphics.DrawString("CLIENTE: " + oficial_cliente, font, Brushes.Black, new PointF(0, 120));
            }
            using (Font font = new Font("Arial", 12))
            {
                e.Graphics.DrawString("EMPACADOR: " + oficial_empacador, font, Brushes.Black, new PointF(0, 140));
            }
            using (Font font = new Font("Arial", 16, FontStyle.Bold))
            {
                e.Graphics.DrawString("BULTOS: " + id + " DE " + oficial_bultos, font, Brushes.Black, new PointF(180, 230));
            }
            // Puedes dibujar im�genes de la misma manera:
            Image image = Image.FromFile("C:\\Datos_Surtido\\coriba.png");
            e.Graphics.DrawImage(image, new PointF(0, 160));
            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Imagen_Codigo.Image = mGeneradorCB.Draw(Buscar_Folio, 120);

            Bitmap bm = new Bitmap(Imagen_Codigo.Width, Imagen_Codigo.Height);
            Imagen_Codigo.DrawToBitmap(bm, new Rectangle(0, 0, Imagen_Codigo.Width, Imagen_Codigo.Height));
            e.Graphics.DrawImage(bm, 200, 160);
            bm.Dispose();
            contador++;
            e.HasMorePages = contador < oficial_bultos;
        }
        private void TimerHora_Tick(object sender, EventArgs e)
        {
            Lbhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            LbFecha.Text = DateTime.Now.ToLongDateString();
            Lbhora.Text = Lbhora.Text.ToUpper();
            LbFecha.Text = LbFecha.Text.ToUpper();
        }

        private void TimerMarque_Tick(object sender, EventArgs e)
        {
            if (groupBox1.Right < 0 || (Math.Abs(groupBox1.Width) > groupBox1.Width))
            {
                groupBox1.Left = this.Width;
            }
            groupBox1.Left -= 1;

        }

        private void TxtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Cb_Empacador.Focus();
            }
        }

        private void Cb_Empacador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtBultos.Focus();
            }
        }

        private void TxtBultos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnImprimir.Focus();
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (ClientRectangle.Width > 0 && ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, Color.Gray, Color.Black, 90F))
                {
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void TxtBultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten N�meros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private async void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (TxtFolio.Text != string.Empty && TxtBultos.Text != string.Empty && Cb_Empacador.Text != string.Empty)
            {
                FbConnection con = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
                try
                {
                    // Crear un nuevo hilo y asignarle un m�todo que se ejecutar� en paralelo
                    // Iniciar la ejecuci�n del hilo
                    Buscar_Folio = TxtFolio.Text;
                    con.Open();
                    if ((Buscar_Folio[0] is 'P' && Buscar_Folio[1] is 'L') || (Buscar_Folio[0] is 'P' && Buscar_Folio[1] is 'C'))
                    {
                        string query0 = "SELECT * FROM DOCTOS_PV WHERE (FOLIO LIKE 'PL%' OR FOLIO LIKE 'PC%') AND TIPO_DOCTO = 'F' ORDER BY FECHA DESC";
                        FbCommand command = new FbCommand(query0, con);

                        // Objeto para leer los datos obtenidos
                        FbDataReader reader0 = command.ExecuteReader();
                        bool encontrado = false;
                        oficial_empacador = Cb_Empacador.Text;
                        oficial_bultos = int.Parse(TxtBultos.Text);
                        // Iterar sobre los registros y mostrar los valores
                        while (reader0.Read())
                        {
                            // Acceder a los valores de cada columna por su �ndice o nombre
                            string columna1 = reader0.GetString(0);
                            string columnafecha = reader0.GetString(5);
                            string fechacorta = columnafecha.Substring(0, 10);
                            columnacliente = reader0.GetString(9);
                            string importe = reader0.GetString(23);
                            //  columnadescripcion = reader0.GetString(42);
                            string columna5 = reader0.GetString(4); // Ejemplo de acceso por �ndice (0 representa la primera columna)
                            if (columna5 == Buscar_Folio)
                            {
                                string fact = columna5;
                                oficial_importe = importe;
                                oficial_factura = fact.Remove(2, 1);
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado == false)
                        {
                            MessageBox.Show("FOLIO NO ENCONTRADO", "�ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        reader0.Close();
                        string query11 = "SELECT * FROM DIRS_CLIENTES ORDER BY CLIENTE_ID ASC";
                        FbCommand command11 = new FbCommand(query11, con);
                        FbDataReader reader11 = command11.ExecuteReader();
                        // Iterar sobre los registros y mostrar los valores
                        while (reader11.Read())
                        {
                            string columna11 = reader11.GetString(1);
                            string ruta2 = reader11.GetString(25);
                            if (columna11 == columnacliente)
                            {
                                columnadescripcion = ruta2;
                                break;
                            }
                        }

                        reader11.Close();
                    }

                    else
                    {

                        string query = "SELECT * FROM DOCTOS_VE WHERE (FOLIO LIKE 'PF%' OR FOLIO LIKE 'PE%') AND TIPO_DOCTO = 'F' ORDER BY FECHA DESC";
                        FbCommand command = new FbCommand(query, con);

                        // Objeto para leer los datos obtenidos
                        FbDataReader reader = command.ExecuteReader();
                        bool encontrado = false;
                        oficial_empacador = Cb_Empacador.Text;
                        oficial_bultos = int.Parse(TxtBultos.Text);
                        // Iterar sobre los registros y mostrar los valores
                        while (reader.Read())
                        {
                            // Acceder a los valores de cada columna por su �ndice o nombre
                            string columna1 = reader.GetString(0);
                            string columnafecha = reader.GetString(5);
                            string fechacorta = columnafecha.Substring(0, 10);
                            columnacliente = reader.GetString(8);
                            columnadescripcion = reader.GetString(42);
                            string importe = reader.GetString(26);
                            string columna5 = reader.GetString(4); // Ejemplo de acceso por �ndice (0 representa la primera columna)
                            if ((Buscar_Folio[0] is not 'P' && Buscar_Folio[1] is not 'F') || (Buscar_Folio[0] is not 'P' && Buscar_Folio[1] is not 'E'))
                            {
                                break;
                            }
                            if (columna5 == Buscar_Folio)
                            {
                                string fact = columna5;
                                oficial_importe = importe;
                                oficial_factura = fact.Remove(2, 1);
                                encontrado = true;

                                break;
                            }
                        }
                        if (encontrado == false)
                        {
                            MessageBox.Show("FOLIO NO ENCONTRADO", "�ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        reader.Close();
                    }
                    string query2 = "SELECT * FROM VIAS_EMBARQUE ORDER BY VIA_EMBARQUE_ID ASC";
                    FbCommand command2 = new FbCommand(query2, con);
                    FbDataReader reader2 = command2.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores
                    while (reader2.Read())
                    {
                        string columna11 = reader2.GetString(0);
                        string ruta = reader2.GetString(1);
                        if (columna11 == columnadescripcion)
                        {
                            oficial_ciudad = ruta;
                            break;
                        }
                    }

                    reader2.Close();
                    string query3 = "SELECT * FROM CLIENTES ORDER BY CLIENTE_ID ASC";
                    FbCommand command3 = new FbCommand(query3, con);
                    FbDataReader reader3 = command3.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores
                    while (reader3.Read())
                    {
                        string columna111 = reader3.GetString(0);
                        string cliente = reader3.GetString(1);
                        if (columna111 == columnacliente)
                        {
                            oficial_cliente = cliente;
                            break;
                        }
                    }
                    reader3.Close();
                    string query4 = "SELECT * FROM DIRS_CLIENTES ORDER BY CLIENTE_ID ASC";
                    FbCommand command4 = new FbCommand(query4, con);
                    FbDataReader reader4 = command4.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores
                    while (reader4.Read())
                    {
                        string ciudadid = reader4.GetString(12);
                        string clienteid = reader4.GetString(1);
                        if (clienteid == columnacliente)
                        {
                            ciudad = ciudadid;
                            break;
                        }
                    }
                    reader4.Close();
                    string query5 = "SELECT * FROM CIUDADES ORDER BY CIUDAD_ID ASC";
                    FbCommand command5 = new FbCommand(query5, con);
                    FbDataReader reader5 = command5.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores
                    while (reader5.Read())
                    {
                        string ciudadid = reader5.GetString(0);
                        string cliente_ciudad = reader5.GetString(1);
                        if (ciudadid == ciudad)
                        {
                            oficial_poblacion = cliente_ciudad;
                            break;
                        }
                    }
                    reader5.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                /*
                void Codigo_Barras()
                {
                    Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
                    Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    Imagen_Codigo.Image = mGeneradorCB.Draw(Buscar_Folio, 120);
                }*/
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                    await Base(TxtFolio.Text, Cb_Empacador.Text, int.Parse(TxtBultos.Text), Lbhora.Text, LbFecha.Text);
                    Excel();
                    contador = 0;
                    TxtBultos.Text = string.Empty;
                    TxtFolio.Text = string.Empty;
                    Cb_Empacador.Text = string.Empty;
                    TxtFolio.Select();

                }
                else
                {
                    contador = 0;
                    TxtBultos.Text = string.Empty;
                    TxtFolio.Text = string.Empty;
                    Cb_Empacador.Text = string.Empty;
                    TxtFolio.Select();
                }
            }
            else
            {
                MessageBox.Show("A�n no has llenado todos los campos", "�Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Excel()
        {
            string path = "C:\\Datos_Surtido\\Registro de Empacadores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx";
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                SLDocument sl = new("C:\\Datos_Surtido\\Registro de Empacadores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx", "Sheet1");
                int i = 1;
                while (sl.HasCellValue("A" + i))
                {
                    i++;
                }
                int[] columnas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10};
                foreach (int columna in columnas)
                {
                    sl.SetColumnWidth(columna, 30);
                    if (columna == 1 || columna == 6)
                        sl.SetColumnWidth(columna, 5);
                    if (columna == 2)
                        sl.SetColumnWidth(columna, 10);
                    if (columna == 3 || columna == 5 || columna == 7 || columna == 8 || columna == 9)
                        sl.SetColumnWidth(columna, 30);
                    if (columna == 4 || columna == 9)
                        sl.SetColumnWidth(columna, 15);
                }
                sl.SetCellValue("A" + i, i - 1);
                sl.SetCellValue("B" + i, TxtFolio.Text);
                sl.SetCellValue("C" + i, LbFecha.Text);
                sl.SetCellValue("D" + i, Lbhora.Text);
                sl.SetCellValue("E" + i, Cb_Empacador.Text);
                sl.SetCellValue("F" + i, int.Parse(TxtBultos.Text));
                sl.SetCellValue("G" + i, oficial_cliente);
                sl.SetCellValue("H" + i, oficial_poblacion);
                sl.SetCellValue("I" + i, oficial_ciudad);
                sl.SetCellValue("J" + i, oficial_importe);
                sl.SaveAs("C:\\Datos_Surtido\\Registro de Empacadores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx");
            }
            else if (!fileExist)
            {
                SLDocument oSLDocument = new();
                DataTable table = new();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Folio", typeof(string));
                table.Columns.Add("Fecha", typeof(string));
                table.Columns.Add("Hora", typeof(string));
                table.Columns.Add("Empacador", typeof(string));
                table.Columns.Add("Bultos", typeof(int));
                table.Columns.Add("Cliente", typeof(string));
                table.Columns.Add("Localidad", typeof(string));
                table.Columns.Add("Ruta", typeof(string));
                table.Columns.Add("Importe", typeof(string));
                table.Rows.Add(1, TxtFolio.Text, LbFecha.Text, Lbhora.Text, Cb_Empacador.Text, TxtBultos.Text, oficial_cliente, oficial_poblacion, oficial_ciudad, oficial_importe);
                oSLDocument.ImportDataTable(1, 1, table, true);
                oSLDocument.SaveAs("C:\\Datos_Surtido\\Registro de Empacadores" + DateTime.Now.ToString(" yyyy-MM-dd") + ".xlsx");
            }
        }

        private void BtnVistaPrevia_Click(object sender, EventArgs e)
        {
            if (TxtFolio.Text != string.Empty && TxtBultos.Text != string.Empty && Cb_Empacador.Text != string.Empty)
            {
                BtnImprimir_Click(sender, e);
                contador = 0;
                printPreviewDialog1.Document = printDocument1;
                contador = 0;
                printPreviewDialog1.ShowDialog();
                contador = 0;
            }
            else
            {
                MessageBox.Show("A�n no has llenado todos los campos", "�Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cb_Empacador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void BtnCenefa_Click(object sender, EventArgs e)
        {
            FormularioCenefa.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(Cb_Empacador, "Ingresa primero tu n�mero de empleado");
            tooltip.SetToolTip(TxtFolio, "Ingresa el folio de la factura");
            tooltip.SetToolTip(TxtBultos, "Ingresa el n�mero de bultos");
        }
    }
}