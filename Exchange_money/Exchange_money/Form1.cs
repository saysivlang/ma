using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Declare
            float total, kilowat;
            //Input
            //price = 500;
            // kilowat = float.Parse(txtnew.Text) - float.Parse(txtold.Text);
            kilowat = CalculatekM(float.Parse(txtnew.Text), float.Parse(txtold.Text));
            //Process
            //total = price * kilowat;
            total = Calculatetotal(kilowat);
            //Output
            txtconsumtion.Text = kilowat.ToString() + "   KW";
            txtamount.Text = total+ "  Riels";

        }
        private float CalculatekM(float NewMeter, float OldMeter)
        {
            return NewMeter - OldMeter;
        }
        private float Calculatetotal(float kilowat)
        {
            float price = 0.0f, total = 0.0f, grandtotal = 0.0f;
            while (kilowat > 0)
            {
                if (kilowat > 1000)
                {
                    price = 1300; total = (kilowat - 1000) * price; kilowat = kilowat - (kilowat - 1000); listBox1.Items.Add(total);
                }
                else if (kilowat > 500)
                {
                    price = 1100; total = (kilowat - 500) * price; kilowat = kilowat - (kilowat - 500); listBox1.Items.Add(total);
                }
                else if (kilowat > 200)
                {
                    price = 900; total = (kilowat - 200) * price; kilowat = kilowat - (kilowat - 200); listBox1.Items.Add(total);
                }
                else if (kilowat > 100)
                {
                    price = 750; total = (kilowat - 100) * price; kilowat = kilowat - (kilowat - 100); listBox1.Items.Add(total);
                }
                else if (kilowat > 50)
                {
                    price = 550; total = (kilowat - 50) * price; kilowat = kilowat - (kilowat - 50); listBox1.Items.Add(total);
                }
                else
                {
                    price = 350; total = kilowat * price; kilowat = 0;
                }
                grandtotal += total;
            }
            return grandtotal;

        }
    }
}

