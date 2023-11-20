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
    public partial class EscolherHorarioOpo : Form
    {
        public EscolherHorarioOpo()
        {
            InitializeComponent();
        }

        private void bt_setemeiaOpo_Click(object sender, EventArgs e)
        {
            EscolherPoltronaOpo pop = new EscolherPoltronaOpo();
            pop.ShowDialog();
            Close();
        }

        private void bt_onzemeiaOpo_Click(object sender, EventArgs e)
        {
            EscolherPoltronaOpo pop = new EscolherPoltronaOpo();
            pop.ShowDialog();
            Close();
        }

        private void bt_oitoOpo_Click(object sender, EventArgs e)
        {
            EscolherPoltronaOpo pop = new EscolherPoltronaOpo();
            pop.ShowDialog();
            Close();
        }
    }
}
