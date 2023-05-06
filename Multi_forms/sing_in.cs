using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class sing_in : Form
    {
        public sing_in()
        {
            InitializeComponent();
            form.sign = this;
        }
        Form1 form = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("رمز یا نام کاربری اشتباه است");
            }
                
            
            
        }
    }
}
