using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_color
{
    public partial class Form1 : Form
    {

        public Random a;
        public int v1;
        public Random b;
        public Random c;
        public int v2;
        public int v3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                a = new Random();
                v1 = Convert.ToInt32(a.Next(255));
            });

            Task.Run(() => 
            {

                b = new Random();
                v2 = Convert.ToInt32(a.Next(255));

            });

            Task.Run(() =>
            {

                c = new Random();
                v3 = Convert.ToInt32(a.Next(255));

            });


            this.BackColor = Color.FromArgb(v1, v2, v3);
            label1.Text = "RGB(" + v1 + "," + v2 + "," + v3 + ")";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
