using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beregningsverktøy_for_Elektro.Data;

namespace Beregningsverktøy_for_Elektro
{
    public partial class OhmsKalkulator : Form
    {
        bool erResatt = true;
        int antallTekstBokser = 0;
        private void buttonOhmKalkuler_Click(object sender, EventArgs e)
        {
            ValiderTekstbokser();
            if (erResatt == true)
            {
                if (antallTekstBokser == 2)
                {
                    double spenning, motstand, effekt, ampere;
                    BeregneOhmsLov BeregneOhmsLov = new BeregneOhmsLov();

                    Double.TryParse(textBoxSpenning.Text, out spenning);
                    Double.TryParse(textBoxEffekt.Text, out effekt);
                    Double.TryParse(textBoxAmpere.Text, out ampere);
                    Double.TryParse(textBoxMotstand.Text, out motstand);

                    BeregneOhmsLov.beregneOhmsLov(spenning, effekt, ampere, motstand);
                    textBoxAmpere.Text = BeregneOhmsLov.beregnetAmpere.ToString();
                    textBoxSpenning.Text = BeregneOhmsLov.beregnetSpenning.ToString();
                    textBoxMotstand.Text = BeregneOhmsLov.beregnetMotstand.ToString();
                    textBoxEffekt.Text = BeregneOhmsLov.beregnetEffekt.ToString();
                    erResatt = false;
                }
                else
                {
                    MessageBox.Show("Bruk KUN 2 verdier for å beregne.");
                }
            } else
            {
                MessageBox.Show("Du må trykke på resetknappen for å kalkulere på nytt!");
            }
        }

        public OhmsKalkulator()
        {
            InitializeComponent();
        }

        private void ValiderTekstbokser()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (!string.IsNullOrEmpty(c.Text))
                    {
                        antallTekstBokser++;
                    }
                }
            }
        }
        private void buttonOhmNullstill_Click(object sender, EventArgs e)
        {
            erResatt = true;
            antallTekstBokser = 0;
            Validering Validering = new Validering();
            Validering.Nullstill(this);
        }

        private void buttonOhmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class BeregneOhmsLov
    {
        public double beregnetSpenning, beregnetEffekt, beregnetAmpere, beregnetMotstand;
        public void beregneOhmsLov(double spenning = 0, double effekt = 0, double ampere = 0, double motstand = 0)
        {
            if (motstand == 0 && effekt == 0)
            {
                beregnetMotstand = (spenning / ampere);
                beregnetEffekt = (spenning * ampere);
                beregnetAmpere = ampere;
                beregnetSpenning = spenning;
            }
            if (ampere == 0 && effekt == 0)
            {
                beregnetAmpere = (spenning / motstand);
                beregnetEffekt = (beregnetAmpere * spenning);
                beregnetSpenning = spenning;
                beregnetMotstand = motstand;
            }
            if (ampere == 0 && motstand == 0)
            {
                beregnetAmpere = (effekt / spenning);
                beregnetMotstand = (spenning / beregnetAmpere);
                beregnetSpenning = spenning;
                beregnetEffekt = effekt;
            }
            if (spenning == 0 && effekt == 0)
            {
                beregnetSpenning = (ampere * motstand);
                beregnetEffekt = (motstand * ampere * ampere);
                beregnetAmpere = ampere;
                beregnetMotstand = motstand;
            }
            if (spenning == 0 && motstand == 0)
            {
                beregnetSpenning = (effekt / ampere);
                beregnetMotstand = (effekt / (ampere * ampere));
                beregnetAmpere = ampere;
                beregnetEffekt = effekt;
            }
            if (spenning == 0 && ampere == 0)
            {
                beregnetSpenning = Math.Sqrt(effekt * motstand);
                beregnetAmpere = Math.Sqrt(effekt / motstand);
                beregnetMotstand = motstand;
                beregnetEffekt = effekt;
            }
        }
    }

}
