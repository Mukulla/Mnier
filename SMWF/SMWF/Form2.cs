using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMWF
{
    public partial class Form2 : Form
    {
        private Form1 Form1Ref = null;
        public void GetConto(Form1 F1)
        {
            Form1Ref = F1;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1Ref.DeleteButtons();

            Glo.GSizes.Primis = Func.GetNumberFromString(textBox1.Text);
            Func.CheckLimitataAream(ref Glo.GSizes.Primis, 10, 48);

            Glo.GSizes.Secundus = Func.GetNumberFromString(textBox2.Text);
            Func.CheckLimitataAream(ref Glo.GSizes.Secundus, 10, 30);

            Glo.CountMines = Func.GetNumberFromString(textBox3.Text);
            int LimitMines = (int)(Glo.GSizes.Primis * Glo.GSizes.Secundus * 0.67);
            Func.CheckLimitataAream(ref Glo.CountMines, 5, LimitMines);

            Glo.LiberumElementis = Glo.GSizes.Primis * Glo.GSizes.Secundus - Glo.CountMines;

            Form1Ref.NewCustomGame();           
            Form1Ref.timer1.Enabled = true;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1Ref.timer1.Enabled = true;

            this.Close();
        }
    }
}
