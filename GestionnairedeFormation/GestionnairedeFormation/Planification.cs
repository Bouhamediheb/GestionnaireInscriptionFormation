using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnairedeFormation
{
    public partial class Planification : Form
    {
        public Planification()
        {
            InitializeComponent();
        }

        private void Planification_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "" && numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
            {
                for (i = 0; i <= 100; i++)
                {
                    progressBar1.Value = 0;
                    progressBar1.Value = progressBar1.Value + i;
                }
                Thread.Sleep(2000);

                StreamWriter sw = new StreamWriter("d:\\Formation.txt", append: true);
                sw.Write("Nom Formation : "+textBox1.Text+"\n");
                sw.Write("Obectif Formation : "+textBox2.Text + "\n");
                sw.Write("Profil Ciblé : "+ comboBox1.SelectedItem + "\n");
                sw.Write("Nombre Participant : " + numericUpDown1.Value + "\n");
                sw.Write("Date et Heure : "+dateTimePicker1.Value + "\n");
                sw.Write("Budget Formation : "+numericUpDown2.Value + "\n");
                sw.Write("Lieu Formation : "+textBox3.Text + "\n");
                sw.Write("Nom Formateur : "+textBox5.Text + "\n");
                sw.Write("Les Invités : "+textBox6.Text + "\n");
                sw.Write("-----------------\n");
                sw.Close();

                DialogResult res = MessageBox.Show("Formation Enregistrée @ D://Formation.txt !");
                


                
            }
            else
            {
                DialogResult res3 = MessageBox.Show("Veuillez vérifier tous les champs !");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i;
            
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "" && numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
            {
                for (i = 0; i <= 100; i++)
                {
                    progressBar1.Value = 0;
                    progressBar1.Value = progressBar1.Value + i;
                }
                Thread.Sleep(2000);

                DialogResult res = MessageBox.Show("Formation Enregistrée avec succées !");
                


                
            }
            else
            {
                DialogResult res3 = MessageBox.Show("Veuillez vérifier tous les champs !");
            }
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
