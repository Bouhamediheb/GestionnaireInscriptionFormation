using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnairedeFormation
{
    public partial class Form1 : Form
    {
        
        bool firstClick = true;
        bool firstClick1 = true;

        public Form1()
        {

            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int a = 30;
            string infoUSR;
            string infoPW;
            infoUSR = textBox1.Text;
            infoPW = textBox2.Text;
            
            if (infoUSR == "ADMIN" && infoPW == "ADMIN")
            {
                
                for (i = 0; i <= 100 ; i++)
                {
                    progressBar1.Value = 0;
                    progressBar1.Value = progressBar1.Value + i;
                    

                }
                
                DialogResult res = MessageBox.Show("Bienvenue !");
               
                this.Hide();
                var form2 = new Menu();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                

            }
            else
            {
                DialogResult res = MessageBox.Show("Erreur Authentification !");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (firstClick)
            {
                textBox1.Text = string.Empty;
                firstClick = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            if (firstClick1)
            {
                textBox2.Text = string.Empty;
                firstClick1 = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if ((bool)Properties.Settings.Default["FirstRun"] == true)
            {

                DialogResult x = MessageBox.Show("Programme codé par: Bouhamed Iheb , Karim Hachicha , Bilel Belguith\nCodé avec langage C# sur Visual Studio\nCe Programme va traiter le cas de planification de formation !");
                DialogResult y = MessageBox.Show("Pour le login en tant que Administrateur :\nNom Utilisateur : ADMIN \nMot De Passe : ADMIN \nVeuillez tapez en MAJUSCULE .");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
