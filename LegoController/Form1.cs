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
                await _brick.MoveForwad(true, -40, 2000, 2);
                Debug.WriteLine("Moving forward");
                OutputMess.Clear();
                OutputMess.AppendText("Moving forward");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private async void _LeftClicked(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.TurnLeft(true, -30, 1500);
                Debug.WriteLine("Turning left");
                OutputMess.Clear();
                OutputMess.AppendText("Turning left");
            }
            else MessageBox.Show("Pls Type in port");
        }
        private async void _BackwardClicked(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.MoveBackward(true, -30, 2000, 2);
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
                await _brick.TurnRight(true, -30, 1500);
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

        private async void StopButton_Click(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                await _brick.Stop();
                OutputMess.Clear();
                OutputMess.AppendText("Stop");
            }
            else MessageBox.Show("Pls Type in port");
        }

        private void BluetoothPort_TextChanged(object sender, EventArgs e)
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
                    Connect_to_Brick = true;
                }
                catch (ArgumentException EG)
                {
                    MessageBox.Show("Pls dont type in Bs");
                }
                catch (System.IO.IOException EM)
                {
                    MessageBox.Show("Port doesnt exist");
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                _brick.Disconnect_Brick();
                PortSpecified = false;
                Connect_to_Brick = false;
            }
            else MessageBox.Show("Pls Type in port");
        }

        private async void SendMess_Click(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                string Mess = InputMessage.Text;
                await _brick.Send_text(Mess);
                InputMessage.Clear();
            }
            else MessageBox.Show("Pls Type in port");
        }
        private async void Follow_path_Click(object sender, EventArgs e)
        {
            if (Connect_to_Brick)
            {
                OutputMess.Clear();
                OutputMess.AppendText("Following path");
                await _brick.FollowPath();
            } else MessageBox.Show("Pls Type in port");
        }
    }
}
