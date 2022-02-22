using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amén
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label1.Parent = pictureBox1;
            panel2.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - button2.Width);
            int y = r.Next(0, this.Height - button2.Height);
            button2.Location = new Point(x, y);
            button1.TabStop = false;
            button2.TabStop = false; 
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if(button2.Location == button1.Location || button2.Location == label1.Location)
            {
                MoverBoton();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
