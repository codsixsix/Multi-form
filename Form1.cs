using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String email, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = Convert.ToString(textBox1.Text);
            password = Convert.ToString(textBox2.Text);
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                MessageBox.Show("Log in Success");
                Form2 next = new Form2();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Log in Failed");
                this.Hide();
            }
            
        }
    }
}
