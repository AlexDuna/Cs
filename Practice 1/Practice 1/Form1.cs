using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AutentificationButton_Click(object sender, EventArgs e)
        {
            if ((UsernameBox.Text == "username") && (PasswordBox.Text == "password"))
            {
                Form f = new Form2();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Utilizator/Parola incorecte!");
        }
    }
}
