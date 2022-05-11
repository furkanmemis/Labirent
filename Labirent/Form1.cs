using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer start = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finish = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        public Form1()
        {
            InitializeComponent();
            startingPoint();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void startingPoint()
        {
            Point stpoint = panel1.Location;
            stpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(stpoint);
            start.Play();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            startingPoint();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            finish.Play();
            MessageBox.Show("Tebrikler");
            Close();
        }
    }
}
