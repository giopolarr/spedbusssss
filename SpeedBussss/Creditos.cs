using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedBussss
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void bt_voltarCred_Click(object sender, EventArgs e)
        {
            TelaInicial cred = new TelaInicial();
            this.Hide();
            cred.ShowDialog();
        }
    }
}
