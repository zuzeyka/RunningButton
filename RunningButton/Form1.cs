using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButton
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= button1.Location.X && e.X <= button1.Location.X + button1.Width || e.Y >= button1.Location.Y && e.Y <= button1.Location.Y + button1.Height)
            {
                button1.Location = new Point(random.Next(0, this.Size.Width - button1.Width), random.Next(0, this.Size.Height - button1.Height));
            }
        }
    }
}
