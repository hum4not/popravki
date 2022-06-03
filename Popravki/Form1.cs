using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popravki
{
    public partial class form1 : Form
    {
        private static int counter = 0;
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setinvis();
        }

        private void setinvis()
        {

        }

        private void move()
        {
            counter++;
            Random rand = new Random();
            int x1 = rand.Next(400);
            int y1 = rand.Next(400);
            button1.Location = new Point(x1, y1);
            if(counter == 10)
            {
                button1.Hide();
            }
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            move();
        }

        private void button1_MouseHover(object sender, MouseEventArgs e)
        {
            move();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за ваш голос!", "Кремль");
        }
    }
}
