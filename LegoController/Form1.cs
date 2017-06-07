using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoController
{
    public partial class GUI : Form
    {
        bool MouseDown = false;
        MainBrick _brick;
        public GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Controller activated");
            _brick = new MainBrick();
            //await _brick.Connect_Brick();
        }

        private void _ForwardClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Moving forward");
        }

        private void _LeftClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Turning left");
        }

        private void _BackwardClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Moving backward");
        }

        private void _RightClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Turning right");
        }
    }
}
