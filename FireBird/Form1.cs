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
using DocumentFormat.OpenXml.Wordprocessing;
using Font = System.Drawing.Font;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using static FireBird.Models.GlobalSettings;

namespace FireBird
{
    public partial class Form1 : Form
    {
        //CENEFA
        List<Articulo> Articulos = new();
        string Codigo;
        int oficial_codigo;
        int oficial_rol;
        string oficial_desc;
        bool encontrado2 = false;
        int Codigo_nuevo;
        //MAIN
        int contador_amazon;
        DateTime fechaActual = DateTime.Now;
        string columnadescripcion;
        string condicion;
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
        string oficial_condicion;
        decimal oficial_importe;
        string columnaciudad;
        string Current_Surtidor;
        int Current_Bultos;
        int t;
        int Bultos_repetidos;
        List<string> nombresArray = new();
        string path;
        int contador = 0;
        bool Existe = false;
        bool Pv = false;
        private bool isDragging = false;
        private System.Drawing.Point dragStart;
        Agregar Add;
        private List<string> nombresValor = new() { };

        public Form1()
        {
            InitializeComponent();
            CrearExcel();
            Leer_Datos();
            Cb_Empacador.SelectedIndex = -1;
            Add = new Agregar();
            Cb_Empacador.DropDownHeight = 250;
            Cb_Amazon.SelectedIndex = 0;
        }
        public void Leer_Datos()
        {
            nombresArray.Clear();
            nombresValor.Clear();
            string filePath = "\\\\192.168.0.2\\C$\\clavesSurtido\\Claves.xlsx";
            using (SLDocument documento = new SLDocument(filePath))
            {
                int filas = documento.GetWorksheetStatistics().NumberOfRows;
                for (int i = 2; i < filas + 1; ++i)
                {
                    string temp_name = documento.GetCellValueAsString("A" + i);
                    string temp_value = documento.GetCellValueAsString("B" + i);
                    string temp_status = documento.GetCellValueAsString("C" + i);
                    string name = temp_name + " " + temp_value;
                    nombresArray.Add(name);
                    nombresValor.Add(temp_status);
                }
                documento.CloseWithoutSaving();
            }
            Cb_Empacador.DataSource = nombresArray;
            Cb_Empacador.AutoCompleteMode = AutoCompleteMode.Append;
            Cb_Empacador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Empacador.AutoCompleteCustomSource.AddRange(nombresArray.ToArray());
            //Cb_Empacador.Text = "";
        }
        public void CrearExcel()
        {
            DateTime actual = DateTime.Now;
            if (actual.DayOfWeek.ToString() == "Thursday")
            {
                path = "C:\\Datos_Empaque\\Registro de Empacadores" + DateTime.Now.ToString(" yyyy-MM-dd") + " a" + actual.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
            }
            else
            {
                int contador = 0;
                int valor_dia = (int)actual.DayOfWeek;
                for (; valor_dia >= 0; --valor_dia)
                {
                    contador++;
                    if (valor_dia <= 3 && valor_dia == 0)
                    {
                        contador += 2;
                        DateTime pasada = fechaActual.AddDays(-contador);
                        path = "C:\\Datos_Empaque\\Registro de Empacadores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                        break;
                    }
                    if (valor_dia > 4)
                    {
                        if (valor_dia == 5)
                        {
                            DateTime pasada = fechaActual.AddDays(-contador);
                            path = "C:\\Datos_Empaque\\Registro de Empacadores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                            break;
                        }
                        if (valor_dia == 6)
                        {
                            contador += 1;
                            DateTime pasada = fechaActual.AddDays(-contador);
                            path = "C:\\Datos_Empaque\\Registro de Empacadores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                            break;
                        }
                        if (valor_dia == 7)
                        {
                            contador += 2;
                            DateTime pasada = fechaActual.AddDays(-contador);
                            path = "C:\\Datos_Empaque\\Registro de Empacadores" + pasada.ToString(" yyyy-MM-dd") + " a" + pasada.AddDays(6).ToString(" yyyy-MM-dd") + ".xlsx";
                            break;
                        }
                    }
                }
            }
        }
        void Promedio()
        {
            SLDocument sl = new SLDocument(path);
            // Agregar una nueva hoja
            sl.AddWorksheet("Promedio");
            sl.SelectWorksheet("Promedio");
            int[] columnas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int columna in columnas)
            {
                sl.SetColumnWidth(columna, 30);
            }
            sl.SetCellValue("A1", "SURTIDOR");
            sl.SetCellValue("B1", "PEDIDOS EMPACADOS");
            sl.SetCellValue("C1", "IMPORTE GENERADO");
            sl.SetCellValue("D1", "BULTOS EMPACADOS");
            sl.SetCellValue("E1", "TOTAL DE PEDIDOS");
            sl.SetCellValue("F1", "TOTAL DE IMPORTE");
            sl.SetCellValue("G1", "PORCENTAJE DE PEDIDOS");
            sl.SetCellValue("H1", "PORCENTAJE DE IMPORTE");
            int i = 2;
            int j = 2;
            bool Encontrar = false;
            while (sl.HasCellValue("A" + i))
            {

                if (sl.GetCellValueAsString(i, 1) == Current_Surtidor)
                {
                    if (Existe == true)
                    {
                        Encontrar = true;
                        int Correcto = int.Parse(TxtBultos.Text) - Bultos_repetidos;
                        int Bultos = sl.GetCellValueAsInt32("D" + i);
                        sl.SetCellValue("D" + i, Bultos + Correcto);
                        break;
                    }
                    Encontrar = true;
                    decimal imp = sl.GetCellValueAsDecimal("C" + i);
                    decimal total1 = sl.GetCellValueAsInt32("E2");
                    decimal total2 = sl.GetCellValueAsDecimal("F2");
                    decimal pedidos = sl.GetCellValueAsDecimal("B" + i);
                    int blt = sl.GetCellValueAsInt32("D" + i);
                    sl.SetCellValue("B" + i, pedidos + 1);
                    sl.SetCellValue("C" + i, oficial_importe + imp);
                    sl.SetCellValue("D" + i, Current_Bultos + blt);
                    sl.SetCellValue("E2", 1 + total1);
                    sl.SetCellValue("F2", total2 + oficial_importe);
                    total1 = sl.GetCellValueAsDecimal("E2");
                    total2 = sl.GetCellValueAsDecimal("F2");

                    while (sl.HasCellValue("B" + j))
                    {
                        decimal temp_pedidos = sl.GetCellValueAsDecimal("B" + j);
                        sl.SetCellValue("G" + j, 100 * (temp_pedidos / total1));
                        decimal temp_importe = sl.GetCellValueAsDecimal("C" + j);
                        sl.SetCellValue("H" + j, 100 * (temp_importe / total2));
                        j++;
                    }
                }
                i++;
            }
            if (Encontrar == false)
            {
                decimal total1 = sl.GetCellValueAsDecimal("E2");
                decimal total2 = sl.GetCellValueAsDecimal("F2");
                sl.SetCellValue("A" + i, Current_Surtidor);
                sl.SetCellValue("B" + i, 1);
                sl.SetCellValue("C" + i, oficial_importe);
                int renglones = sl.GetCellValueAsInt32("F" + i);
                sl.SetCellValue("D" + i, Current_Bultos);
                sl.SetCellValue("E2", total1 + 1);
                sl.SetCellValue("F2", total2 + oficial_importe);
                total2 = sl.GetCellValueAsDecimal("F2");
                total1 = sl.GetCellValueAsDecimal("E2");
                while (sl.HasCellValue("C" + j))
                {
                    decimal temp_pedidos = sl.GetCellValueAsDecimal("B" + j);
                    sl.SetCellValue("G" + j, 100 * (temp_pedidos / total1));
                    decimal temp_importe = sl.GetCellValueAsDecimal("C" + j);
                    sl.SetCellValue("H" + j, 100 * (temp_importe / total2));
                    j++;

                }
            }
            SLSheetProtection sp = new SLSheetProtection();
            sp.AllowInsertRows = true;
            sp.AllowInsertColumns = false;
            sp.AllowFormatCells = true;
            sp.AllowDeleteColumns = true;
            sl.ProtectWorksheet(sp);
            // Guardar el archivo con la nueva hoja agregada
            Existe = false;
            sl.SaveAs(path);

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
                e.Graphics.DrawString("BULTOS: " + id + " DE " + oficial_bultos, font, Brushes.Black, new PointF(140, 230));
            }
            // Puedes dibujar imágenes de la misma manera:
            Image image = Image.FromFile("C:\\Datos_Empaque\\coriba.png");
            e.Graphics.DrawImage(image, new PointF(0, 160));
            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Imagen_Codigo.Image = mGeneradorCB.Draw(Buscar_Folio, 120);

            Bitmap bm = new Bitmap(Imagen_Codigo.Width, Imagen_Codigo.Height);
            Imagen_Codigo.DrawToBitmap(bm, new Rectangle(0, 0, Imagen_Codigo.Width, Imagen_Codigo.Height));
            e.Graphics.DrawImage(bm, 140, 160);
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
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    if (ClientRectangle.Width > 0 && ClientRectangle.Height > 0)
        //    {
        //        using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, System.Drawing.Color.Gray, System.Drawing.Color.Black, 90F))
        //        {
        //            e.Graphics.FillRectangle(brush, ClientRectangle);
        //        }
        //    }
        //}

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void TxtBultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private async void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (TxtFolio.Text != string.Empty && TxtBultos.Text != string.Empty && Cb_Empacador.Text != string.Empty)
            {
                bool fileExist = File.Exists(path);
                if (fileExist)
                {
                    SLDocument sl2 = new(path);
                    sl2.SelectWorksheet("Reporte Empaque");
                    t = 2;
                    while (sl2.HasCellValue("B" + t))
                    {
                        if (sl2.GetCellValueAsString("B" + t) == TxtFolio.Text)
                        {
                            Existe = true;
                            int Bultos_repetidos2 = sl2.GetCellValueAsInt32("F" + t);
                            string Current_Surtidor2 = sl2.GetCellValueAsString("E" + t);
                            string hora_repetido = sl2.GetCellValueAsString("D" + t);
                            string fecha_repetido = sl2.GetCellValueAsString("C" + t);
                            DialogResult resultado = MessageBox.Show("LA FACTURA QUE VAS A IMPRIMIR YA HA SIDO EMPACADA POR" + "\n" + Current_Surtidor2 + "\n" + "CON " + Bultos_repetidos2 + " BULTOS" + "\n" + "A LAS " + hora_repetido + " DE " + fecha_repetido + "\n \n \t\t" + "¿DESEAS REIMPRIMIRLA?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (resultado == DialogResult.Cancel)
                            {
                                TxtBultos.Text = string.Empty;
                                Cb_Empacador.Text = string.Empty;
                                TxtFolio.Text = string.Empty;
                                Existe = false;
                                TxtFolio.Focus();
                                return;
                            }
                            break;
                        }
                        t++;
                    }
                }
                FbConnection con = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
                try
                {
                    // Crear un nuevo hilo y asignarle un método que se ejecutará en paralelo
                    // Iniciar la ejecución del hilo
                    Buscar_Folio = TxtFolio.Text;
                    Current_Surtidor = Cb_Empacador.Text;
                    Current_Bultos = int.Parse(TxtBultos.Text);
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
                            // Acceder a los valores de cada columna por su índice o nombre
                            string columna1 = reader0.GetString(0);
                            string columnafecha = reader0.GetString(5);
                            string fechacorta = columnafecha.Substring(0, 10);
                            columnacliente = reader0.GetString(9);
                            string direccion = reader0.GetString(12);
                            decimal importe = reader0.GetDecimal(23);
                            //  columnadescripcion = reader0.GetString(42);
                            string columna5 = reader0.GetString(4); // Ejemplo de acceso por índice (0 representa la primera columna)
                            if (columna5 == Buscar_Folio)
                            {
                                string fact = columna5;
                                oficial_importe = importe;
                                oficial_factura = fact.Remove(2, 1);
                                columnaciudad = direccion;
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado == false)
                        {
                            MessageBox.Show("FOLIO NO ENCONTRADO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        reader0.Close();
                        string query11 = "SELECT * FROM DIRS_CLIENTES ORDER BY CLIENTE_ID ASC";
                        FbCommand command11 = new FbCommand(query11, con);
                        FbDataReader reader11 = command11.ExecuteReader();
                        // Iterar sobre los registros y mostrar los valores
                        while (reader11.Read())
                        {
                            string columna11 = reader11.GetString(0);
                            string ruta2 = reader11.GetString(25);
                            if (columna11 == columnaciudad)
                            {
                                columnadescripcion = ruta2;
                                break;
                            }
                        }

                        reader11.Close();
                    }

                    else
                    {

                        //string query = "SELECT * FROM DOCTOS_VE WHERE (FOLIO LIKE 'PF%' OR FOLIO LIKE 'PE%' OR FOLIO LIKE 'PA%') AND TIPO_DOCTO = 'F' ORDER BY FECHA DESC";
                        string query = "SELECT * FROM DOCTOS_VE WHERE FOLIO = '" + TxtFolio.Text + "' AND ESTATUS = 'N'";
                        FbCommand command = new FbCommand(query, con);

                        // Objeto para leer los datos obtenidos
                        FbDataReader reader = command.ExecuteReader();
                        bool encontrado = false;
                        Pv = true;
                        oficial_empacador = Cb_Empacador.Text;
                        oficial_bultos = int.Parse(TxtBultos.Text);
                        // Iterar sobre los registros y mostrar los valores
                        if (reader.Read())
                        {
                            // Acceder a los valores de cada columna por su índice o nombre
                            string columna1 = reader.GetString(0);
                            string columnafecha = reader.GetString(5);
                            string fechacorta = columnafecha.Substring(0, 10);
                            columnacliente = reader.GetString(8);
                            columnaciudad = reader.GetString(10);
                            columnadescripcion = reader.GetString(42);
                            decimal importe = reader.GetDecimal(26);
                            condicion = reader.GetString(37);
                            string columna5 = reader.GetString(4); // Ejemplo de acceso por índice (0 representa la primera columna)
                            //if ((Buscar_Folio[0] is not 'P' && Buscar_Folio[1] is not 'F') || (Buscar_Folio[0] is not 'C' && Buscar_Folio[1] is not 'F') || (Buscar_Folio[0] is not 'P' && Buscar_Folio[1] is not 'E') || (Buscar_Folio[0] is not 'P' && Buscar_Folio[1] is not 'A'))
                            //{
                            //    return;
                            //}
                            if (columna5 == Buscar_Folio)
                            {
                                string fact = columna5;
                                oficial_importe = importe;
                                oficial_factura = fact.Remove(2, 1);
                                encontrado = true;
                            }
                        }
                        if (encontrado == false)
                        {
                            MessageBox.Show("FOLIO NO ENCONTRADO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        reader.Close();

                        //string query6 = "SELECT * FROM CONDICIONES_PAGO";
                        string query6 = "SELECT * FROM CONDICIONES_PAGO WHERE COND_PAGO_ID ='" + condicion + "'";
                        FbCommand command6 = new FbCommand(query6, con);
                        FbDataReader reader6 = command6.ExecuteReader();
                        // Iterar sobre los registros y mostrar los valores
                        if (reader6.Read())
                        {
                            string condid = reader6.GetString(0);
                            string info_cond = reader6.GetString(1);
                            if (condid == condicion)
                            {
                                oficial_condicion = info_cond;
                            }
                        }
                        reader6.Close();
                    }
                    //string query2 = "SELECT * FROM VIAS_EMBARQUE ORDER BY VIA_EMBARQUE_ID ASC";
                    string query2 = "SELECT * FROM VIAS_EMBARQUE WHERE VIA_EMBARQUE_ID = '" + columnadescripcion + "'";
                    FbCommand command2 = new FbCommand(query2, con);
                    FbDataReader reader2 = command2.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores
                    if (reader2.Read())
                    {
                        string columna11 = reader2.GetString(0);
                        string ruta = reader2.GetString(1);
                        if (columna11 == columnadescripcion)
                        {
                            oficial_ciudad = ruta;
                        }
                    }

                    reader2.Close();
                    //string query3 = "SELECT * FROM CLIENTES ORDER BY CLIENTE_ID ASC";
                    string query3 = "SELECT * FROM CLIENTES WHERE CLIENTE_ID ='" + columnacliente + "'";
                    FbCommand command3 = new FbCommand(query3, con);
                    FbDataReader reader3 = command3.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores
                    if (reader3.Read())
                    {
                        string columna111 = reader3.GetString(0);
                        string cliente = reader3.GetString(1);
                        if (columna111 == columnacliente)
                        {
                            oficial_cliente = cliente;
                        }
                    }
                    reader3.Close();
                    //string query4 = "SELECT * FROM DIRS_CLIENTES ORDER BY CLIENTE_ID ASC";
                    string query4 = "SELECT * FROM DIRS_CLIENTES WHERE DIR_CLI_ID ='" + columnaciudad + "'";
                    FbCommand command4 = new FbCommand(query4, con);
                    FbDataReader reader4 = command4.ExecuteReader();

                    // Iterar sobre los registros y mostrar los valores

                    if (reader4.Read())
                    {
                        string clienteidconsig = reader4.GetString(0);
                        string ciudadconsig = reader4.GetString(12);
                        if (clienteidconsig == columnaciudad)
                        {
                            ciudad = ciudadconsig;
                        }
                    }
                    reader4.Close();
                    if (ciudad != "")
                    {
                        string query5 = "SELECT * FROM CIUDADES WHERE CIUDAD_ID ='" + ciudad + "'";
                        FbCommand command5 = new FbCommand(query5, con);
                        FbDataReader reader5 = command5.ExecuteReader();

                        // Iterar sobre los registros y mostrar los valores
                        if (reader5.Read())
                        {
                            string ciudadid = reader5.GetString(0);
                            string cliente_ciudad = reader5.GetString(1);
                            if (ciudadid == ciudad)
                            {
                                oficial_poblacion = cliente_ciudad;
                            }
                        }
                        reader5.Close();
                    }
                    else
                    {
                        oficial_poblacion = "CIUDAD NO ASIGNADA";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                    contador = 0;
                    TxtBultos.Text = string.Empty;
                    TxtFolio.Text = string.Empty;
                    Cb_Empacador.Text = string.Empty;
                    TxtFolio.Select();
                    return;
                }
                finally
                {
                    con.Close();
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
                    if (Pv == true)
                        Excel();
                    contador = 0;
                    TxtBultos.Text = string.Empty;
                    TxtFolio.Text = string.Empty;
                    Cb_Empacador.Text = string.Empty;
                    Pv = false;
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
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Excel()
        {

            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                SLDocument sl = new(path);
                sl.SelectWorksheet("Reporte Empaque");
                if (Existe == true)
                {
                    Bultos_repetidos = sl.GetCellValueAsInt32("F" + t);
                    Current_Surtidor = sl.GetCellValueAsString("E" + t);

                }
                else
                    Current_Surtidor = Cb_Empacador.Text;

                int[] columnas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
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
                sl.SetCellValue("A" + t, t - 1);
                sl.SetCellValue("B" + t, TxtFolio.Text);
                sl.SetCellValue("C" + t, LbFecha.Text);
                sl.SetCellValue("D" + t, Lbhora.Text);
                sl.SetCellValue("E" + t, Cb_Empacador.Text);
                sl.SetCellValue("F" + t, int.Parse(TxtBultos.Text));
                sl.SetCellValue("G" + t, oficial_cliente);
                sl.SetCellValue("H" + t, oficial_poblacion);
                sl.SetCellValue("I" + t, oficial_ciudad);
                sl.SetCellValue("J" + t, oficial_importe);
                sl.SetCellValue("K" + t, oficial_condicion);
                sl.SaveAs(path);
                if (nombresArray.Contains(Cb_Empacador.Text))
                {
                    int posicion = nombresArray.FindIndex(nombresArray => nombresArray.Contains(Cb_Empacador.Text));
                    if (nombresValor[posicion] == "S")
                    {
                        Promedio();
                    }
                    else
                        return;
                }
            }
            else if (!fileExist)
            {
                SLDocument oSLDocument = new();
                DataTable table = new();
                string actual = oSLDocument.GetCurrentWorksheetName();
                oSLDocument.RenameWorksheet(actual, "Reporte Empaque");
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Folio", typeof(string));
                table.Columns.Add("Fecha", typeof(string));
                table.Columns.Add("Hora", typeof(string));
                table.Columns.Add("Empacador", typeof(string));
                table.Columns.Add("Bultos", typeof(int));
                table.Columns.Add("Cliente", typeof(string));
                table.Columns.Add("Localidad", typeof(string));
                table.Columns.Add("Ruta", typeof(string));
                table.Columns.Add("Importe", typeof(decimal));
                table.Columns.Add("Condicion", typeof(string));
                table.Rows.Add(1, TxtFolio.Text, LbFecha.Text, Lbhora.Text, Cb_Empacador.Text, TxtBultos.Text, oficial_cliente, oficial_poblacion, oficial_ciudad, oficial_importe, oficial_condicion);
                oSLDocument.ImportDataTable(1, 1, table, true);
                oSLDocument.SaveAs(path);

                if (nombresArray.Contains(Cb_Empacador.Text))
                {
                    int posicion = nombresArray.FindIndex(nombresArray => nombresArray.Contains(Cb_Empacador.Text));
                    if (nombresValor[posicion] == "S")
                    {
                        Promedio();
                    }
                    else
                        return;
                }
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
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cb_Empacador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(Cb_Empacador, "Ingresa primero tu número de empleado");
            tooltip.SetToolTip(TxtFolio, "Ingresa el folio de la factura");
            tooltip.SetToolTip(TxtBultos, "Ingresa el número de bultos");
        }

        private void Cb_Empacador_Leave(object sender, EventArgs e)
        {
            if (!nombresArray.Contains(Cb_Empacador.Text) && Cb_Empacador.Text != "")
            {
                MessageBox.Show("Este usuario no está registrado", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cb_Empacador.Text = "";
                Cb_Empacador.Focus();
            }
        }

        private void Pb_Add_Click(object sender, EventArgs e)
        {
            Add.ShowDialog();
            Leer_Datos();
            TxtFolio.Focus();
        }

        private void tabPage1_Resize(object sender, EventArgs e)
        {

        }

        private void Pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else // Si la ventana no está maximizada, maximizarla
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void Pb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStart = e.Location;
            }
        }

        private void FlowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - dragStart.X;
                int deltaY = e.Y - dragStart.Y;

                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void FlowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void BtnImprimirCenefa_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != string.Empty)
            {
                if (!Check.Checked)
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
                            bool encontrado2 = false;
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
                                    encontrado2 = true;
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

                                if (columnaclave == oficial_codigo && rol == 17)
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
                            if (encontrado2 == false)
                            {
                                MessageBox.Show("CÓDIGO NO ENCONTRADO", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            void Codigo_Barras()
                            {
                                Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
                                Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                                ImagenCodigo2.Image = mGeneradorCB.Draw(Codigo_nuevo.ToString(), 120);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            con.Close();
                        }
                        printDialog1.Document = printDocument2;
                        if (printDialog1.ShowDialog() == DialogResult.OK)
                        {
                            printDocument2.Print();
                            TxtCodigo.Text = string.Empty;
                            TxtCodigo.Select();

                        }
                        else
                        {
                            TxtCodigo.Text = string.Empty;
                            TxtCodigo.Select();
                        }
                    } // CODIGO DE BARRAS
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
                        finally
                        {
                            con.Close();
                        }
                        void Codigo_Barras()
                        {
                            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
                            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                            ImagenCodigo2.Image = mGeneradorCB.Draw(Codigo.ToString(), 120);
                        }
                        printDialog1.Document = printDocument2;
                        if (printDialog1.ShowDialog() == DialogResult.OK)
                        {
                            printDocument2.Print();
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
                    if (TxtCodigo.Text != string.Empty && TxtCodigo2.Text != string.Empty)
                    {
                        if (int.Parse(TxtCodigo.Text) > int.Parse(TxtCodigo2.Text))
                        {
                            MessageBox.Show("Orden Incorrecto", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        FbConnection con = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
                        try
                        {
                            con.Open();
                            string query101 = "SELECT * FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO BETWEEN '" + TxtCodigo.Text + "' AND '" + TxtCodigo2.Text + "'  ORDER BY CLAVE_ARTICULO ASC";
                            FbCommand command1 = new FbCommand(query101, con);
                            FbDataReader reader101 = command1.ExecuteReader();
                            while (reader101.Read())
                            {
                                string tamanio = reader101.GetString(1);
                                int tam = tamanio.Length;
                                if (tam == 6)
                                {
                                    GlobalSettings.Instance.Clave_articulo_id = reader101.GetString(2);
                                    Query2();

                                    Articulo variables = new Articulo
                                    {
                                        Codigo = reader101.GetString(1),
                                        Descripcion = GlobalSettings.Instance.Descripcion

                                    };
                                    Articulos.Add(variables);
                                }

                            }
                            reader101.Close();
                            if (Articulos.Count >= 20)
                            {
                                DialogResult resultado2 = MessageBox.Show("ESTÁS SEGURO QUE DESEAS IMPRIMIR" + "\n" + Articulos.Count + "\n" + "ETIQUETAS ", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                                if (resultado2 == DialogResult.Cancel)
                                {
                                    //TxtCodigo.Text = string.Empty;
                                    //TxtCodigo2.Text = string.Empty;                                 
                                    TxtCodigo.Focus();
                                    Articulos.Clear();
                                    return;
                                }
                            }
                            printDialog1.Document = printDocument3;
                            if (printDialog1.ShowDialog() == DialogResult.OK)
                            {
                                printDocument3.Print();
                                Articulos.Clear();
                            }
                            else
                            {
                                Articulos.Clear();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                        finally
                        {
                            con.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Campos vacíos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtCodigo.Text = string.Empty;
            TxtCodigo2.Text = string.Empty;
            TxtCodigo.Focus();
        }
        public void Query2()
        {
            FbConnection con2 = new FbConnection("User=SYSDBA;" + "Password=C0r1b423;" + "Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;" + "DataSource=192.168.0.11;" + "Port=3050;" + "Dialect=3;" + "Charset=UTF8;");
            try
            {
                con2.Open();
                string query2 = "SELECT * FROM ARTICULOS WHERE ARTICULO_ID = '" + GlobalSettings.Instance.Clave_articulo_id + "'";
                FbCommand command2 = new FbCommand(query2, con2);
                FbDataReader reader102 = command2.ExecuteReader();
                if (reader102.Read())
                {
                    GlobalSettings.Instance.Descripcion = reader102.GetString(1);
                }
                reader102.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                con2.Close();
            }

        }
        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Check.Checked)
                {
                    BtnImprimirCenefa.Focus();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    TxtCodigo2.Focus();
                }
            }

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

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font font = new Font("Arial", 75, FontStyle.Bold))
            {
                e.Graphics.DrawString(Codigo, font, Brushes.Black, new PointF(0, 0));
            }
            using (Font font = new Font("Arial", 16, FontStyle.Bold))
            {
                Rectangle DestinationRectangle = new Rectangle(0, 100, 410, 160);
                using (StringFormat sf = new StringFormat())
                {
                    e.Graphics.DrawString(oficial_desc, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, DestinationRectangle, sf);
                }

            }

            // Image image = Image.FromFile("C:\\Datos_Surtido\\coriba.png");
            //e.Graphics.DrawImage(image, new PointF(0, 160));
            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            ImagenCodigo2.Image = mGeneradorCB.Draw(Codigo, 120);

            Bitmap bm = new Bitmap(ImagenCodigo2.Width, ImagenCodigo2.Height);
            ImagenCodigo2.DrawToBitmap(bm, new Rectangle(0, 0, ImagenCodigo2.Width, ImagenCodigo2.Height));
            e.Graphics.DrawImage(bm, 130, 180);
            bm.Dispose();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_FacturaB.Text != string.Empty)
            {
                bool fileExist = File.Exists(path);
                if (fileExist)
                {
                    bool encontrado = false;
                    SLDocument sl = new(path);
                    sl.SelectWorksheet("Reporte Empaque");
                    int i = 2;
                    while (sl.HasCellValue("B" + i))
                    {
                        if (Txt_FacturaB.Text == sl.GetCellValueAsString("B" + i))
                        {
                            MessageBox.Show("ESTA FACTURA LA EMPACÓ " + sl.GetCellValueAsString("E" + i) + "\n" + "EL " + sl.GetCellValueAsString("C" + i) + " A LAS " + sl.GetCellValueAsString("D" + i) + "\n" + "CON " + sl.GetCellValueAsString("F" + i) + " BULTOS", "Resultado");
                            Txt_FacturaB.Text = string.Empty;
                            Txt_FacturaB.Focus();
                            encontrado = true;
                            return;
                        }
                        i++;
                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show("No se ha encontrado esa factura", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_FacturaB.Text = string.Empty;
                        Txt_FacturaB.Focus();
                        return;
                    }
                    sl.SaveAs(path);
                }
                else if (!fileExist)
                {
                    MessageBox.Show("Aún no has empacado esa factura", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_FacturaB.Text = string.Empty;
                    Txt_FacturaB.Focus();
                }
            }
            else
            {
                MessageBox.Show("Aún no has llenado todos los campos", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_FacturaB.Focus();
            }
        }

        private void Btn_Amazon_Click(object sender, EventArgs e)
        {
            contador_amazon = 0;
            //printPreviewDialog1.Document = Print_Amazon;
            //printPreviewDialog1.ShowDialog();
            printDialog1.Document = Print_Amazon;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                Print_Amazon.Print();
                Num_Amazon.Value = 1;
            }
            else
            {
                Num_Amazon.Value = 1;
                Cb_Amazon.Select();
            }
        }

        private void Print_Amazon_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font font = new Font("Arial", 55, FontStyle.Bold))
            {
                e.Graphics.DrawString("AMAZON", font, Brushes.Black, new PointF(15, 0));
            }
            if (Cb_Amazon.Text == "LOCAL")
            {
                using (Font font = new Font("Arial", 45, FontStyle.Bold))
                {
                    e.Graphics.DrawString(Cb_Amazon.Text, font, Brushes.Black, new PointF(10, 100));
                }
            }
            else
            {
                using (Font font = new Font("Arial", 32, FontStyle.Bold))
                {
                    e.Graphics.DrawString(Cb_Amazon.Text, font, Brushes.Black, new PointF(10, 100));
                }
            }
            Image image = Image.FromFile("C:\\Datos_Empaque\\coriba.png");
            e.Graphics.DrawImage(image, new PointF(250, 85));

            Pen pen = new Pen(System.Drawing.Color.Black, 2);
            e.Graphics.DrawLine(pen, new System.Drawing.Point(30, 230), new System.Drawing.Point(350, 230));
            contador_amazon++;
            e.HasMorePages = contador_amazon < Num_Amazon.Value;
        }

        private void Num_Amazon_Click(object sender, EventArgs e)
        {
            Num_Amazon.Select(0, Num_Amazon.Text.Length);
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Check.Checked)
            {
                TxtCodigo2.Visible = true;
            }
            else if (!Check.Checked)
            {
                TxtCodigo2.Visible = false;
            }
        }
        private int paginaActual = 0;
        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            while (paginaActual < Articulos.Count)
            {
                // Limpia el lienzo antes de imprimir la página actual
                e.Graphics.Clear(System.Drawing.Color.White); // Puedes cambiar el color de fondo según tus necesidades

                var articulo = Articulos[paginaActual];
                // Imprimir los datos del artículo en esta página
                using (Font font = new Font("Arial", 75, FontStyle.Bold))
                {
                    e.Graphics.DrawString(articulo.Codigo, font, Brushes.Black, new PointF(0, 0));
                }
                using (Font font = new Font("Arial", 16, FontStyle.Bold))
                {
                    Rectangle DestinationRectangle = new Rectangle(0, 100, 410, 160);
                    using (StringFormat sf = new StringFormat())
                    {
                        e.Graphics.DrawString(articulo.Descripcion, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, DestinationRectangle, sf);
                    }

                }

                // Image image = Image.FromFile("C:\\Datos_Surtido\\coriba.png");
                //e.Graphics.DrawImage(image, new PointF(0, 160));
                Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
                Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                ImagenCodigo2.Image = mGeneradorCB.Draw(articulo.Codigo, 120);

                Bitmap bm = new Bitmap(ImagenCodigo2.Width, ImagenCodigo2.Height);
                ImagenCodigo2.DrawToBitmap(bm, new Rectangle(0, 0, ImagenCodigo2.Width, ImagenCodigo2.Height));
                e.Graphics.DrawImage(bm, 130, 180);
                bm.Dispose();

                paginaActual++;

                // Si quedan más artículos, indica que hay más páginas
                if (paginaActual < Articulos.Count)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false; // No hay más páginas para imprimir
                    paginaActual = 0; // Restablece la página actual para futuras impresiones
                }

                return; // Sale del evento de impresión para imprimir la página actual
            }
        }

        private void TxtCodigo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCodigo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                BtnImprimirCenefa.Focus();


            }
        }

        private void conexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ubicaciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dMicrosipDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}