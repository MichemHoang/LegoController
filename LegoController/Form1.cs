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
        string BluetoothPortName = "";
        MainBrick _brick;
        bool Connect_to_Brick = false;
        bool PortSpecified = false;

        public GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Controller activated");
            _brick = new MainBrick();
        }

        private async void _ForwardClicked(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.MoveForwad(true, 40, 4000, 1);
                Debug.WriteLine("Moving forward");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private async void _LeftClicked(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.TurnLeft(true);
                Debug.WriteLine("Turning left");
            }
            else MessageBox.Show("Pls Type in port");
        }
        private async void _BackwardClicked(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.MoveBackward(true);
                Debug.WriteLine("Moving backward");
                OutputMess.Clear();
                OutputMess.AppendText("Moving backward");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private async void _RightClicked(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.TurnRight(true);
                Debug.WriteLine("Turning right");
                OutputMess.Clear();
                OutputMess.AppendText("Turning right");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private async void PickUp_Click(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.PickUp(false);
                Debug.WriteLine("Picking Up");
                OutputMess.Clear();
                OutputMess.AppendText("Picking Up");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private async void DropOff_Click(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.DropOff(false);
                OutputMess.Clear();
                OutputMess.AppendText("Droping off");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PortSpecified = true;
            BluetoothPortName = BlueToothPort.Text;
            OutputMess.Clear();
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (PortSpecified)
            {
                try
                {
                    _brick = new MainBrick(1, BluetoothPortName);
                    await _brick.Connect_Brick();
                }
                catch (ArgumentException EG)
                {
                    MessageBox.Show("Incorrect port");
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            _brick.Disconnect_Brick();
            PortSpecified = false;
            Connect_to_Brick = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _brick.Stop();
        }
        
    }
}
