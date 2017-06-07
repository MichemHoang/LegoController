﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System.Diagnostics;

namespace LegoController
{
    class MainBrick
    {
        private Brick Ev3Brick;
        private int _forward, _backward;
        private bool EmerBrake;
        private uint _time = 300;

        public MainBrick()
        {
            _forward = 40;
            _backward = -30;
            EmerBrake = false;
        }
        public MainBrick(int A)
        {
            _forward = 40;
            _backward = -30;
            EmerBrake = false;
            if (A == 1) Ev3Brick = new Brick(new BluetoothCommunication("COM3"));
            else Ev3Brick = new Brick(new UsbCommunication());
            Ev3Brick.BrickChanged += Ev3Brick_BrickChanged;
        }

        public async Task Connect_Brick()
        {
            await Ev3Brick.ConnectAsync();
            await Ev3Brick.DirectCommand.PlayToneAsync(100, 1000, 300);
        }

        public async Task MoveForwad(bool EmergencyBrake)
        {
            await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C | OutputPort.D, _forward, _time, EmergencyBrake);
        }

        public async Task MoveBackward(bool EmergencyBrake)
        {
            await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C | OutputPort.D, _backward, _time, EmergencyBrake);
        }

        public async Task TurnRight(bool EmergencyBrake)
        {
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, +30, 150, EmergencyBrake);
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, -30, 150, EmergencyBrake);
            await Ev3Brick.BatchCommand.SendCommandAsync();
        }

        public async Task TurnLeft(bool EmergencyBrake)
        {
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, -30, 150, EmergencyBrake);
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, +30, 150, EmergencyBrake);
            await Ev3Brick.BatchCommand.SendCommandAsync();
        }

        private void Ev3Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
            Debug.WriteLine("Brick Change");
        }



    }
}