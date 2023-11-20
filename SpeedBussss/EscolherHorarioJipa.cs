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
    public partial class EscolherHorarioJipa : Form
    {
        public EscolherHorarioJipa()
        {
            InitializeComponent();
        }

        private void bt_setemeiaJipa_Click(object sender, EventArgs e)
        {
            EscolherPoltronaJipaSeteMeia pop = new EscolherPoltronaJipaSeteMeia();
            pop.ShowDialog();
            Close();
        }

        private void bt_onzemeiaJipa_Click(object sender, EventArgs e)
        {
            EscolherPoltronaJipaOnzemeia pop = new EscolherPoltronaJipaOnzemeia();
            pop.ShowDialog();
            Close();
        }

        private void bt_oitoJipa_Click(object sender, EventArgs e)
        {
            EscolherPoltronaJipaOito pop = new EscolherPoltronaJipaOito();
            pop.ShowDialog();
            Close();
        }
    }
}
