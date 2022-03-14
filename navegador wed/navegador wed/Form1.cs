using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador_wed
{
    public partial class Form1 : Form
    {
        List<string> favoritos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnretroseder_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnrepetir_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btncasa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(TBbuscador.Text);
        }

        private void TBbuscador_Click(object sender, EventArgs e)
        {

        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            actualizacmd();
        }
       private void actualizacmd()
        {
            foreach(string direccion in favoritos)
            {
                cmdFavoritos.Items.Add(direccion);
            }
        }

        private void cmdFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmdFavoritos.SelectedItem.ToString());
        }
    }
}
