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

        private async void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Controller activated");
            _brick = new MainBrick(1);
            await _brick.Connect_Brick();
        }

        private async void _ForwardClicked(object sender, EventArgs e)
        {
            await _brick.MoveForwad(true);
            Debug.WriteLine("Moving forward");
        }

        private async void _LeftClicked(object sender, EventArgs e)
        {
            await _brick.TurnLeft(true);
            Debug.WriteLine("Turning left");
        }

        private async void _BackwardClicked(object sender, EventArgs e)
        {
            await _brick.MoveBackward(true);
            Debug.WriteLine("Moving backward");
        }

        private async void _RightClicked(object sender, EventArgs e)
        {
            await _brick.TurnRight(true);
            Debug.WriteLine("Turning right");

        }
        private async void PickUp_Click(object sender, EventArgs e)
        {
            await _brick.PickUp(false);
            Debug.WriteLine("Picking Up");
        }
        private async void DropOff_Click(object sender, EventArgs e)
        {
            await _brick.DropOff(false);
        }
    }
}
