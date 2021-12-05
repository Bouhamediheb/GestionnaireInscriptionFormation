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
    public partial class Affichage : Form
    {
        public Affichage()
        {
            InitializeComponent();
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            richTextBox1.Text = File.ReadAllText("d:\\Formation.txt");
            
        }

        private void Affichage_Load(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionFont = new Font("Verdana", 35, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Menu();
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
