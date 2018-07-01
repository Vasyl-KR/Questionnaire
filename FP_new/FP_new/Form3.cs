using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace FP_new
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label1.Text = "Шановний(а) " + Data.Value;
            List<Image> images = new List<Image>();
            DirectoryInfo di = new DirectoryInfo(@"D:\SS\Projects\FP_new\jpg"); 
            FileInfo[] finfos = di.GetFiles("*.jpg", SearchOption.AllDirectories);
            foreach (FileInfo fi in finfos)
            {
                images.Add(Image.FromFile(fi.FullName));
            }
            Random random = new Random();
            pictureBox1.Image = images[random.Next(0, images.Count - 1)];
        
        }
        
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
