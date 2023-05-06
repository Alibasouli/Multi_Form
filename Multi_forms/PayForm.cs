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
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
         public Form1 form;
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;  
        }

        
        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("فیلد ها را به طور کامل پر کنید");
            }
            else
            {
                form.listBox1.Items.Add("شماره دانشجویی" + " " + textBox1.Text + "به مبلغ" + " " + textBox2.Text);
                sf.Hide();
                this.Hide();

                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
