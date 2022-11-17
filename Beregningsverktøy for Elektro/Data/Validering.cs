using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beregningsverktøy_for_Elektro.Data
{
    internal class Validering
    {
        public void Nullstill(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    Nullstill(c);
            foreach (Control c in ctrl.Controls)
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                else
                    Nullstill(c);
            foreach (Control c in ctrl.Controls)
                if (c is RichTextBox)
                    ((RichTextBox)c).Clear();
                else
                    Nullstill(c);
        }

        public bool formValidering(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
                if (c is TextBox || c is ComboBox)
                    if (string.IsNullOrEmpty(c.Text))
                        return false;
            return true;
        }
    }
}
