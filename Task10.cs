using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox3.Text)))
            {

                MessageBox.Show("Please enter your First Name");
                return;
            }
            if ((string.IsNullOrEmpty(textBox4.Text)))
            {
                MessageBox.Show("Please enter Your Second name");
                return;
            }
            MessageBox.Show("Form Submitted Successfully");
        }
    }
}