namespace Beregningsverktøy_for_Elektro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ohmskalk_Click(object sender, EventArgs e)
        {
            OhmsKalkulator OhmsKalkulator = new OhmsKalkulator();
            OhmsKalkulator.ShowDialog();
        }

        private void buttonSpenningsfall_Click(object sender, EventArgs e)
        {
            Spenningsfall SpenningsFall = new Spenningsfall();
            SpenningsFall.ShowDialog(); 
        }
    }
}