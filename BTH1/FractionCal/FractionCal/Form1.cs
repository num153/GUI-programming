using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCal
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Fraction a, b, kq;
            a = new Fraction();
            kq = new Fraction();
            try
            {
                a.Numerator = int.Parse(txtNum1.Text);
                a.Denominator = int.Parse(txtDeno1.Text);
                b = new Fraction(int.Parse(txtNum2.Text), int.Parse(txtDeno2.Text));
                kq = a.Add(b);
                txtNumRs.Text = kq.Numerator.ToString();
                txtDenoRs.Text = kq.Denominator.ToString();
            }catch(FormatException  ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
    public class Fraction
    {
        private int numerator, denominator;
        //Constructor
        public Fraction()
        {
            numerator = 0; denominator = 0;
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //Property
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public Fraction Add(Fraction a)
        {
            Fraction k = new Fraction();
            k.numerator = this.numerator * a.denominator + this.denominator * a.numerator;
            k.denominator = this.denominator * a.denominator;
            return k;
        }
    }
}
