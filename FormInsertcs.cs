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
            ParentForm.Element.NuclearCharge = textBoxMassa.Text;
            ParentForm.Element.AtomicRadius = textBox1.Text;
            ParentForm.Element.DebyeTemperature= textBox2.Text;
            ParentForm.Element.Symbol = textBox3.Text;
            ParentForm.Element.MolarMass = textBox4.Text;

        }
    }
}
