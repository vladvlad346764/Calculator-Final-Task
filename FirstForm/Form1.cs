using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;


namespace FirstForm
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void NormalCalc_Click(object sender, EventArgs e)
        {
            Calc Calculator = new Calc();
            Calculator.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngCalc_Click(object sender, EventArgs e)
        {
            IngCalc ICalculator = new IngCalc();
            ICalculator.ShowDialog();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            
        }

        private void светлыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void темныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }
    }
}
