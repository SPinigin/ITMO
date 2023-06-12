using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class DialogWindow : Form
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        public string KoefficientA
        {
            get { return textBoxKoeffA.Text; }
            set { textBoxKoeffA.Text = value; }
        }

        public string KoefficientB
        {
            get { return textBoxKoeffB.Text; }
            set { textBoxKoeffB.Text = value; }
        }

        public string KoefficientC
        {
            get { return textBoxKoeffC.Text; }
            set { textBoxKoeffC.Text = value; }
        }

        public string KorniUravneniya()
        {
            double koefA = double.Parse(textBoxKoeffA.Text);
            double koefB = double.Parse(textBoxKoeffB.Text);
            double koefC = double.Parse(textBoxKoeffC.Text);
            double X1, X2, dicriminant;
            string otvet;
            if (koefA == 0)
            {
                X1 = -koefC / koefB;
                otvet = "1 корень: X = " + X1;
                if (koefB == 0)
                    otvet = "Уравнение не имеет корней!";
            }
            else
            {
                dicriminant = koefB * koefB - 4 * koefA * koefC;
                if (dicriminant > 0)
                {
                    X1 = Math.Round((-koefB + Math.Sqrt(dicriminant)) / (2 * koefA), 4);
                    X2 = Math.Round((-koefB - Math.Sqrt(dicriminant)) / (2 * koefA), 4);
                    otvet = "2 корня: X1 = " + X1 + ", X2 = " + X2;
                }
                else
                {
                    if (dicriminant == 0)
                    {
                        X1 = Math.Round(-koefB / (2 * koefA), 4);
                        otvet = "1 корень: X = " + X1;
                    }
                    else
                        otvet = "Уравнение не имеет корней!";
                }
            }
            return otvet;
        }

        private void textBoxKoeffA_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKoeffA.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxKoeffA.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле \"Коэффициент a\" должно быть числом");
                }
            }
        }

        private void textBoxKoeffB_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKoeffB.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxKoeffB.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле \"Коэффициент b\" должно быть числом");
                }
            }
        }

        private void textBoxKoeffC_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKoeffC.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxKoeffC.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле \"Коэффициент c\" должно быть числом");
                }
            }
        }
    }
}