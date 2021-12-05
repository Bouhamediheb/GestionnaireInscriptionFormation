using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnairedeFormation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Welcome!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Pas Encore Accessible !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Pas Encore Accessible !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Pas Encore Accessible !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Pas Encore Accessible !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Planification();
            this.Hide();
            var form2 = new Planification();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = @"d:\\Formation.txt";

            if (!File.Exists(path))
            {
                
                DialogResult res = MessageBox.Show("Aucune Formation Enregistrée !");

            }

            else
            {
                var myForm3 = new Affichage();
                this.Hide();
                var form4 = new Affichage();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
        }

        
    }
}
