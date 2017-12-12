using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InharitanceDesctop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           PhenotypeForm phenotypeForm = new PhenotypeForm();
            phenotypeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenCalculator calc = new GenCalculator();
             calc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenotypeForm genotype = new GenotypeForm();
            genotype.Show();
        }
    }
}
