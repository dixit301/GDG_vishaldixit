using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_app4
{
    public partial class WELCOME_IN : Form
    {
        public WELCOME_IN()
        {
            InitializeComponent();
            const LED_Price = 100
            const DiwaliLights_Price = 50
            const Calculator_Price = 200
            const Clock_Price = 80
            Dim mcSubTotal as double
            Dim mcTotal as double
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (!comboBox1.Items.Contains(s))
            {
                comboBox1.Items.Add(s);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PrintControllerWithStatusDialog txtQuantity 
                .Text = ""
                .Focus()
                End With

                lblItemAmount.Text = ""
                lblSubTotal.Text = ""
                lblTax.Text = ""
                lblTotal.Text = ""

                radClock.Checked = false
                radCalculator.Checked = false
                radLED.Checked = false
                radDiwaliLights.Checked = false
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
