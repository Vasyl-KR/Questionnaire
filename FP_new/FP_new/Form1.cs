using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FP_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            MaximizeBox = false;
        }
        public bool Regexp(string re, TextBox tb, Label lb1)
        {
            Regex redex = new Regex(re);
            if (redex.IsMatch(tb.Text))
            {
                lb1.ForeColor = Color.Green;
                lb1.Text = "ok";
                return true;
            }
            else
            {
                lb1.ForeColor = Color.Red;
                lb1.Text = "невірні дані";
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(Regexp(@"^[А-Яа-яЁёЇїІіЄєҐґ']+$", textBox1, label4) && Regexp(@"^[А-Яа-яЁёЇїІіЄєҐґ']+$", textBox2, label5))
            {
                Data.Value = this.textBox1.Text + " " + this.textBox2.Text;
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
