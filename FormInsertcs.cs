using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBChemical
{
    public partial class FormInsertcs : Form
    {
        private Form1 ParentForm { get; set; }
        public FormInsertcs(Form1 parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
        }
        public async void ButtonInsert_Click(object sender, EventArgs e)
        {
            GetData();
            await ParentForm.Insert();
            Close();
        }
        private void GetData()
        {
            ParentForm.Element.Name = textBoxName.Text;
            ParentForm.Element.Symbol = textBoxSymbol.Text;
            ParentForm.Element.NuclearCharge = textBoxNuclearCharge.Text;
            ParentForm.Element.MolarMass = textBoxMolarMass.Text;
            ParentForm.Element.AtomicRadius = textBoxAtomicRadius.Text;
            ParentForm.Element.DebyeTemperature = textBoxDebyeTemperature.Text;

        }
    }
}
