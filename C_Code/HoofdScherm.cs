using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Code
{
    public partial class HoofdScherm : Form
    {   //Storage maybe make more elegant later?
        private Noise.ArrayObject HoofdSchermArray;


        public HoofdScherm()
        {
            InitializeComponent();
        }

        private void bttnCreateArray_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Create array pressed.");
            txtboxStatus.Text = "Created Array";
            Boolean controle = true;
            int x = 0;
            int y = 0;
            try
            {
                x = Int32.Parse(txtboxDimensieX.Text);
                y = Int32.Parse(txtboxDimensieY.Text);
            }
            catch(FormatException)
            {
                controle = false;
                txtboxStatus.Text = "Either x or y isn't convertible to INT";
            }
            if (controle)
            {
                HoofdSchermArray = new Noise.ArrayObject(x, y);
            }
        }

        private void bttnShowArray_Click(object sender, EventArgs e)
        {
            /*Console.WriteLine("Show array pressed");*/
            txtboxStatus.Text = "Showing array";
            string test = HoofdSchermArray.GetArray();
            txtboxShowArray.Text = test;
        }
    }
}
