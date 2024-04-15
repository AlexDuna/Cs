using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataLabel.Text = System.DateTime.Today.ToLongDateString();
        }

        private void TrimiteButton_Click(object sender, EventArgs e)
        {
            string nume = NumeBox.Text;
            string prenume = PrenumeBox.Text;
            string varsta = VarstaBox.Text;

            //verificam ca nu cumva aceste campuri sa fie goale
            if (NumeBox.Text == "" || PrenumeBox.Text == "" || VarstaBox.Text == "")
                MessageBox.Show("Completati toate campurile! Este obligatoriu!");
            else
            {
                //verificam ca primele doua campuri sa contina doar litere
                if (!Regex.Match(NumeBox.Text, "^[A-Z][a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Numele este invalid!", "Trebuie sa contina doar litere.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumeBox.Focus();
                    return;
                }
                if (!Regex.Match(PrenumeBox.Text, "^[A-Z][a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Prenumele este invalid!", "Trebuie sa contina doar litere.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumeBox.Focus();
                    return;
                }


                //validare varsta sa contina doar cifre
                if (!System.Text.RegularExpressions.Regex.IsMatch(VarstaBox.Text, @"^[0-9]*$"))
                {
                    MessageBox.Show("Dati o varsta valida!");
                    VarstaBox.Text = VarstaBox.Text.Remove(VarstaBox.Text.Length - 1);
                }
                string judet = JudeteBox.SelectedItem.ToString();

                string gen;
                if (MasculinCheck.Checked == true)
                    gen = MasculinCheck.Text;
                else
                    gen = FemininCheck.Text;

                //crearea listei de limbaje de programare cunoscute
                string limbaje_programare = "";
                if (CsCheck.Checked)
                    limbaje_programare = limbaje_programare + " " + CsCheck.Text;
                if (CpCheck.Checked)
                    limbaje_programare = limbaje_programare + " " + CpCheck.Text;
                if (CCheck.Checked)
                    limbaje_programare = limbaje_programare + " " + CCheck.Text;
                if(JavaCheck.Checked)
                    limbaje_programare = limbaje_programare + " " + JavaCheck.Text;
                if(GDScriptCheck.Checked)
                    limbaje_programare = limbaje_programare + " " + GDScriptCheck.Text;

                string linie = nume +" "+ prenume + " " + gen + " " + judet + " " + limbaje_programare;
                AfisareBox.Items.Add(linie);
            }
        }
    }
}
