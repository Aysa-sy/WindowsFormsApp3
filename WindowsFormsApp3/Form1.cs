using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "")
            {
                if (txt_Family.Text != "")
                {
                    if (txt_Age.Text != "")
                    {
                        if (txt_Address.Text != "")
                        {
                            string txt = txt_Name.Text + " " + txt_Family.Text + " " + txt_Age.Text + " " + txt_Address.Text;
                            MessageBox.Show(txt);
                        }
                        else
                        {
                            MessageBox.Show("نام وارد نشده");
                        }
                    }
                    else
                    {
                        MessageBox.Show("فامیلی وارد نشده");
                    }
                }
                else
                {
                    MessageBox.Show("سن وارد نشده");
                }
            }
            else
            {
                MessageBox.Show("آدرس وارد نشده");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
