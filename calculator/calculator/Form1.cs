using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        String Operation = "";
        double firstnum, Secondnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if(b.Text ==".")
            {
                if (!txtDisplay.Text.contains("."))
                    txtDisplay.Text = txtDisplay.text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.text + b.Text;
            }
        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
