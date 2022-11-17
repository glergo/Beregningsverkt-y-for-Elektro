using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beregningsverktøy_for_Elektro.Data;

namespace Beregningsverktøy_for_Elektro
{
    public partial class Spenningsfall : Form
    {
        public string[] images = { @"..\..\..\images\kravspenningsfall.jpg", 
                                   @"..\..\..\images\kravspenningsfalltilleggf.jpg" };

        // hente metode for å resette former.
        Validering Validering = new Validering();
        public Spenningsfall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validering.formValidering(this) == true)
            {
                double deltaU, deltaUP;
                int faseU = Convert.ToInt32(textBoxSpenning.Text);
                BeregneSpenningsfall BeregneSpenningsfall = new BeregneSpenningsfall();
                double.TryParse(textBoxCosphi.Text, out double cosphi);
                double.TryParse(textBoxLengde.Text, out double kabelLengde);
                double.TryParse(textBoxStrom.Text, out double strom);
                double.TryParse(comboBoxTverrsnitt.Text, out double tverrsnitt);
                double.TryParse(comboBoxLedere.Text, out double antallLedere);
                string resitivitet = comboBoxResitivitet.Text;


                deltaU = BeregneSpenningsfall._deltaU(cosphi, resitivitet, kabelLengde, strom, antallLedere, tverrsnitt);
                deltaUP = BeregneSpenningsfall._deltaUProsent(deltaU, faseU);
                richTextBoxResultatAU.Text = "∆U = Ib x ρ x lengde x ledere x cos φ / areal = " + strom + " x " + resitivitet + " x " + kabelLengde + " x " + antallLedere + " x " + cosphi + " / " + tverrsnitt + " = " + deltaU;
                richTextBoxResultatAUP.Text = "∆U% = ∆U x 100 / U = " + deltaU + " x " + "100" + " / " + faseU + " = " + deltaUP;
            } else
            {
                MessageBox.Show("Fyll ut alle felter!");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Browser Browser = new Browser();
            Browser.OpenBrowser("https://lovdata.no/forskrift/1998-11-06-1060/§27");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ImageViewer ImageViewer = new ImageViewer();
            ImageViewer.pictureBox.Image = Image.FromFile(images[0]);
            ImageViewer.Width = ImageViewer.readExif(images[0])[0];
            ImageViewer.Height = ImageViewer.readExif(images[0])[1];
            ImageViewer.pictureBox.Height = ImageViewer.Height;
            ImageViewer.pictureBox.Width = ImageViewer.Width;
            ImageViewer.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ImageViewer ImageViewer = new ImageViewer();
            ImageViewer.pictureBox.Image = Image.FromFile(images[1]);
            ImageViewer.Width = ImageViewer.readExif(images[1])[0];
            ImageViewer.Height = ImageViewer.readExif(images[1])[1];
            ImageViewer.pictureBox.Height = ImageViewer.Height;
            ImageViewer.pictureBox.Width = ImageViewer.Width;
            ImageViewer.Show();
        }

        private void buttonNullstill_Click(object sender, EventArgs e)
        {
            Validering.Nullstill(this);
        }

        private void buttonLukk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class BeregneSpenningsfall
    {
        private double deltaU, deltaUProsent;

        public double _deltaU(double cosphi, string resitivitet, double kabelLengde, double strom, double antallLedere, double tverrsnitt)
        {
            double Rho = 0;
            if (resitivitet == "Cu (0,0172)")
                Rho = 0.0172;
            if (resitivitet == "Al  (0,0264)")
                Rho = 0.0264;

            if (antallLedere == 2)
                deltaU = ((strom * Rho * kabelLengde * antallLedere * cosphi) / tverrsnitt);
            if (antallLedere == 3)
                deltaU = ((strom * Rho * kabelLengde * Math.Sqrt(antallLedere) * cosphi) / tverrsnitt);
            return deltaU;
        }

        public double _deltaUProsent(double deltaU, int faseU)
        {
            deltaUProsent = ((deltaU * 100) / faseU);
            return deltaUProsent;
        }
    }
}
