using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            LogoImagen.Location = new Point (Top,Top);
            TienditaLabel.Location = new Point(this.Width / 2 - TienditaLabel.Width / 2, 0);
            HoraFecha.Location = new Point(Left, (this.Height - HoraFecha.Height));
            BananaLabel.Location = new Point((this.Width - BananaLabel.Width), (this.Height - BananaLabel.Height));
            DesarrolladoLabel.Location = new Point( (this.Width - DesarrolladoLabel.Width - BananaLabel.Width), (this.Height - DesarrolladoLabel.Height));
            dataGridProductos.Location = new Point ((10), (LogoImagen.Height));
            dataGridProductos.Width = this.Width - 20;
            dataGridProductos.Height = (this.Height/8) * 5;
            dataGridProductos.Columns.Add("Cantidad","Cantidad");
            dataGridProductos.Columns[0].Width = ((dataGridProductos.Width) / 100) * 10;
            dataGridProductos.Columns.Add("Nombre", "Nombre");
            dataGridProductos.Columns[1].Width = ((dataGridProductos.Width) / 2);
            dataGridProductos.Columns.Add("Precio", "Precio");
            dataGridProductos.Columns[2].Width = ((dataGridProductos.Width) / 100) * 20;
            dataGridProductos.Columns.Add("Total", "Total");
            dataGridProductos.Columns[3].Width = ((dataGridProductos.Width) / 100) * 20;
            textCodigo.Location = new Point((10), this.Height - HoraFecha.Height - textCodigo.Height);
            textCodigo.Width = this.Width - 20;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " "+ DateTime.Now.ToLongDateString();
        }
    }
}
