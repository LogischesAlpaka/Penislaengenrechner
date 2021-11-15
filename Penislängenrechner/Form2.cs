using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penislängenrechner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           MessageBox.Show("Dieses Programm ist eine Satire. Ich überneme keine Haftung für eventuelle Schäden bei Nutzung des Programmes. Dieses Programm darf unentgeltlich mit Freunden und Familie geteilt werden.", "Hinweis", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            label7.Text = "";
            label11.Text = "";
           if (DateTime.Today.Month == 11)
           {
                MessageBox.Show("Es ist NoNutNovember, Freunde!", "NNN", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           }
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zum Ermitteln deiner Penisgröße legst Du ein Maßband um den erigierten Penis und misst den Umfang. Die Penislänge misst du, indem du deinen erigierten Penis von der Wurzel bis zur Eichel misst.", "Hilfe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double laenge = Convert.ToDouble(textBox1.Text);
                double umfang = Convert.ToDouble(textBox2.Text);

                if (laenge > 30)
                {
                    MessageBox.Show("Du hast eine sehr unrealistische Penislänge eingegeben! Einige Features sind nicht verfügbar.", "LÜGNER!" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }

                textBox4.Text = Convert.ToString(Convert.ToInt32(umfang)/Math.PI);

                if (laenge > 13.12)
                {
                    label7.Text = "Deine Länge liegt über dem weltweiten Durchschnitt von 13,12cm!";
                }
                if (laenge < 13.12)
                {
                    label7.Text = "Deine Länge liegt unter dem weltweiten Durchschnitt von 13,12cm!";
                }

                progressBar1.Value = Convert.ToInt32(laenge);

                if (umfang > 0)
                {
                    textBox3.Text = "< 45";
                }
                if (umfang > 9.0)
                {
                    textBox3.Text = "45";
                }
                if (umfang > 9.6)
                {
                    textBox3.Text = "47";
                }
                if (umfang > 10.2)
                {
                    textBox3.Text = "49";
                }
                if (umfang > 10.8)
                {
                    textBox3.Text = "52";
                }
                if (umfang > 11.4)
                {
                    textBox3.Text = "53";
                }
                if (umfang > 11.6)
                {
                    textBox3.Text = "55";
                }
                if (umfang > 12.0)
                {
                    textBox3.Text = "57";
                }
                if (umfang > 12.6)
                {
                    textBox3.Text = "60";
                }
                if (umfang > 13.2)
                {
                    textBox3.Text = "64";
                }
                if (umfang > 14)
                {
                    textBox3.Text = "72";
                }


            }
            catch
            {
                
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();

}
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string person1_name = textBox5.Text;
                string person2_name = textBox8.Text;
                double person1_laenge = Convert.ToDouble(textBox6.Text);
                double person2_laenge = Convert.ToDouble(textBox7.Text);
                if (person1_laenge > person2_laenge)
                {
                    label11.Text = person1_name + " hat den längeren!";
                }
                if (person2_laenge > person1_laenge)
                {
                    label11.Text = person2_name + " hat den längeren!";
                }
                if (person1_laenge == person2_laenge)
                {
                    label11.Text = person1_name + " und " + person2_name + " haben gleichlange Penisse.";
                }
            }
            catch
            {
                label11.Text = "Ungültige Eingabe!";
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1dQuNJ20YsYT3BZ_ZF2iDqJvIZZjS_lxU?usp=sharing");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
