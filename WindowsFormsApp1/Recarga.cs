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
    public partial class Recarga : Form
    {
        public Recarga()
        {
            InitializeComponent();
        }
        private void Recarga_Load(object sender, EventArgs e)
        {
            webBrowserRecarga.Navigate("www.libreria.unison.mx/");
            webBrowserRecarga.ScriptErrorsSuppressed = true;

        }

        private void webBrowserRecarga_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text= "Liberia Unison";
        }
    }
}
