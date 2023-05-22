using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=pos;Uid=root;Pwd=;");
        MySqlCommand comando;
        //el obj para recibir datos de SELECT
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        //class ConnectionDB
        //{

        //    MySql.Data.MySqlClient.MySqlConnection conn;
        //    string myConnectionString;
        //    static string host = "localhost";
        //    static string port = "3306";
        //    static string userDB = "root";
        //    static string database = "pos";
        //    static string password = " ";
        //    public static string strProvider = "server=" + host + ";Port=" + port + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            textCodigo.TabIndex = 0;
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            LogoImagen.Width = this.Width;
            LogoImagen.Location = new Point (Top,Top);
            HoraFecha.Location = new Point(Left, (this.Height - HoraFecha.Height));
            BananaLabel.Location = new Point((this.Width - BananaLabel.Width), (this.Height - BananaLabel.Height));
            DesarrolladoLabel.Location = new Point( (this.Width - DesarrolladoLabel.Width - BananaLabel.Width), (this.Height - DesarrolladoLabel.Height));
            dataGridProductos.Location = new Point ((10), (LogoImagen.Height));
            dataGridProductos.Width = this.Width - 20;
            dataGridProductos.Height = (this.Height/8) * 5;
            dataGridProductos.ReadOnly = true;
            dataGridProductos.Columns.Add("Cantidad","Cantidad");
            dataGridProductos.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridProductos.Columns[0].Width = ((dataGridProductos.Width) / 100) * 10;
            dataGridProductos.Columns.Add("Nombre", "Nombre");
            dataGridProductos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridProductos.Columns[1].Width = ((dataGridProductos.Width) / 2);
            dataGridProductos.Columns.Add("Precio", "Precio");
            dataGridProductos.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridProductos.Columns[2].Width = ((dataGridProductos.Width) / 100) * 20;
            dataGridProductos.Columns.Add("Total", "Total");
            dataGridProductos.Columns[3].HeaderCell.Style.Font = new Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridProductos.Columns[3].Width = ((dataGridProductos.Width) / 100) * 20;
            textCantidad.Enabled = false;
            textCantidad.Location = new Point(this.Width -  textCantidad.Width, this.Height - HoraFecha.Height - textCantidad.Height);
            textCodigo.Location = new Point((10), this.Height - HoraFecha.Height - textCodigo.Height);
            textCodigo.Width = this.Width - textCantidad.Width;
            labelPago.Location = new Point((this.Width / 8) * 7, (this.Height/16)*13);
            textPago.Enabled = false;
            textPago.Location = new Point((this.Width/128)*118, (this.Height/16)*13);
            textPago.Width = labelTotal.Width - 25;
            labelTotal.Location = new Point((this.Width/8)*7, (this.Height/8)*7);
            buttonPagar.Location = new Point(this.Width - buttonPagar.Width - 10, this.Height - textCodigo.Height - buttonPagar.Height - HoraFecha.Height);
            buttonTotal.Location = new Point( 10,this.Height - textCodigo.Height - buttonTotal.Height - HoraFecha.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " "+ DateTime.Now.ToLongDateString();
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)13)
                {
                    if (textCodigo.Text.Length >= 1)
                    {
                        MessageBox.Show("SELECT * FROM productos WHERE codigo = " + "'" + textCodigo.Text + "'");
                        textCantidad.Enabled = true;
                        textCantidad.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error en codigo.");
                    }

                }
                if (e.KeyChar == (char)32)
                {
                    textPago.Enabled = true;
                    textPago.Focus();
                }
            }

        private void tab(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                e.IsInputKey = true;
        }

        private void EntCant(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (textCantidad.Text.Length >= 1)
                {
                    MessageBox.Show("Cantidad: " + "'" + textCantidad.Text + "'");
                    con.Open();
                    comando = new MySqlCommand("SELECT * FROM productos WHERE codigo='" + textCodigo.Text + "'");
                    comando.Connection = con;
                    dr = comando.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            var myString = dr.GetString(0);
                            dataGridProductos.Font = new Font("Arial", 10F);
                            dataGridProductos.Rows.Add(new object[] { textCantidad.Text.ToString(),
                                                          dr.GetString(1),
                                                          dr.GetFloat(2),
                                                          Int32.Parse(textCantidad.Text.ToString()) * dr.GetFloat(2)
                                                          });
                        }
                        double recibir = 0;
                        for (int i = 0; i < dataGridProductos.Rows.Count - 1; i++)
                        {
                            double total = Convert.ToDouble(dataGridProductos.Rows[i].Cells[0].Value.ToString()) * Convert.ToDouble(dataGridProductos.Rows[i].Cells[2].Value.ToString());
                            recibir += total;
                        }
                        labelTotal.Text = "Total: $" + recibir.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Error. Favor de verificar codigo y cantidad.");
                }
                con.Close();
                textCantidad.Clear();
                textCodigo.Clear();
                textCodigo.Focus();
            }
        }

        private void textPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                double recibir = 0;
                for (int i = 0; i < dataGridProductos.Rows.Count - 1; i++)
                {
                    double total = Convert.ToDouble(dataGridProductos.Rows[i].Cells[0].Value.ToString()) * Convert.ToDouble(dataGridProductos.Rows[i].Cells[2].Value.ToString());
                    recibir += total;
                }
                double feria = Convert.ToDouble(textPago.Text) - recibir ;
                if (feria < 0)
                {
                    MessageBox.Show("Error en el pago");
                }
                else
                {
                    MessageBox.Show("Venta Exitosa. Su cambio es $" + feria + ". Gracias, vuelva pronto :).");
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    dataGridProductos.Rows.Clear();
                    dataGridProductos.ReadOnly = true;
                    textPago.Clear();
                    labelTotal.Text = "Total: $0.00";
                    textCodigo.Enabled = true;
                    textCodigo.Focus();
                }
            }
        }

        int proCant, proPre, proTot, pos = 160;

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            double recibir = 0;
            for (int i = 0; i < dataGridProductos.Rows.Count - 1; i++)
            {
                double total = Convert.ToDouble(dataGridProductos.Rows[i].Cells[0].Value.ToString()) * Convert.ToDouble(dataGridProductos.Rows[i].Cells[2].Value.ToString());
                recibir += total;
            }
            double feria = Convert.ToDouble(textPago.Text) - recibir;
            if (feria < 0)
            {
                MessageBox.Show("Error en el pago");
            }
            else
            {
                MessageBox.Show("Venta Exitosa. Su cambio es $" + feria + ". Gracias, vuelva pronto :).");
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                dataGridProductos.Rows.Clear();
                dataGridProductos.ReadOnly = true;
                textPago.Clear();
                labelTotal.Text = "Total: $0.00";
                textCodigo.Enabled = true;
                textCodigo.Focus();
            }
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            textPago.Enabled = true;
            textPago.Focus();
        }

        string proNom;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //System.Drawing.Image img = System.Drawing.Image.FromFile("C:\Users\aneth\Downloads\ChangarroLogo.jpg");
            //Point loc = new Point(Top, Top);
            //e.Graphics.DrawImage(img, loc);
            Bitmap myBitmap1 = new Bitmap(LogoImagen.Width, LogoImagen.Height);
            LogoImagen.DrawToBitmap(myBitmap1, new Rectangle(0, 0, LogoImagen.Width ,LogoImagen.Height));
            e.Graphics.DrawImage(myBitmap1, 0,0, 285, LogoImagen.Height);
            e.Graphics.DrawString("CANT. NOMBRE PRECIO TOTAL", new Font ("Arial", 12), Brushes.Red, new Point(15,140));
            foreach (DataGridViewRow row in dataGridProductos.Rows)
            {
                proCant = Convert.ToInt32(row.Cells[0].Value);
                proNom = "" + row.Cells[1].Value;
                proPre = Convert.ToInt32(row.Cells[2].Value);
                proTot = Convert.ToInt32(row.Cells[3].Value);
                e.Graphics.DrawString("" + proCant, new Font("Arial", 10), Brushes.Black, new Point(30, pos));
                e.Graphics.DrawString("" + proNom, new Font("Arial", 6), Brushes.Black, new Point(65, pos));
                e.Graphics.DrawString("" + proPre, new Font("Arial", 10), Brushes.Black, new Point(160, pos));
                e.Graphics.DrawString("" + proTot, new Font("Arial", 10), Brushes.Black, new Point(230, pos));
                pos = pos + 20;
            }
            double recibir = 0;
            for (int i = 0; i < dataGridProductos.Rows.Count - 1; i++)
            {
                double total = Convert.ToDouble(dataGridProductos.Rows[i].Cells[0].Value.ToString()) * Convert.ToDouble(dataGridProductos.Rows[i].Cells[2].Value.ToString());
                recibir += total;
            }
            e.Graphics.DrawString("Total: $" + recibir, new Font ("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150,pos + 50));
            e.Graphics.DrawString(HoraFecha.Text, new Font("Arial", 6), Brushes.Black, new Point(Left, 550));
            pos = 160;
        }
    }
}
