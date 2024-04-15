using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_pentru_un_fluturas_de_salar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalariuButton_Click(object sender, EventArgs e)
        {
            double salariu = double.Parse(SalariuBox.Text);
            double cfs = (salariu / 1000) * 5;
            double cas = (salariu / 1000) * 105;
            double cass = (salariu / 1000) * 55;
            double impozit =((salariu - cfs - cas - cass - 180) / 1000) * 160;
            double cas_angajator = (salariu / 1000) * 208;
            double cfs_angajator = (salariu / 1000) * 50;
            double cfci = (salariu / 1000) * 85;
            double cfgpcs = (salariu / 10000) * 25;
            double cass_angajator = (salariu / 1000) * 52;
            double cfambp = (salariu / 1000) * 4;

            CFS.Text = cfs.ToString();
            CAS.Text = cas.ToString();
            CASS.Text = cass.ToString();
            Impozit.Text = impozit.ToString();
            CAS_angajator.Text = cas_angajator.ToString();
            CFS_angajator.Text = cfs_angajator.ToString();
            CFCI.Text = cfci.ToString();
            CFGPCS.Text = cfgpcs.ToString();
            CASS_angajator.Text = cass_angajator.ToString();
            CFAMBP.Text = cfambp.ToString();
        }
    }
}
