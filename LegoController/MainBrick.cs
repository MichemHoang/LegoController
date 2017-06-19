//using System;

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
        private int _pickUp, _dropOff;
        private int Turn, Forward;
        private uint Time;
        private bool StopS = false;

        public MainBrick()
        {
        }

        public MainBrick(int A, string SerialPortName)
        {
            Turn = 10;
            Forward = 10;
            _dropOff = -50;
            _pickUp = 50;
            Time = 200;
            if (A == 1) Ev3Brick = new Brick(new BluetoothCommunication(SerialPortName));
            else Ev3Brick = new Brick(new UsbCommunication());
            Ev3Brick.BrickChanged += Ev3Brick_BrickChanged;
        }

        //
        //Brick Connection
        // 

        public void Disconnect_Brick()
        {
            Ev3Brick.Disconnect();
        }

        public async Task Connect_Brick()
        {
            await Ev3Brick.DirectCommand.SelectFontAsync(FontType.Medium);
            Ev3Brick.Ports[InputPort.Two].SetMode(ColorMode.Color);
            await Ev3Brick.ConnectAsync();
            await Ev3Brick.DirectCommand.PlayToneAsync(50, 1000, 300);
        }

        //
        //Control Brick
        //

        public async Task DropOff(bool EmergencyBrake)
        {
            await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A, _dropOff, 1500, EmergencyBrake);
        }

        public async Task PickUp(bool EmergencyBrake)
        {
            await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A, _pickUp, 1500, EmergencyBrake);
        }

        public async Task MoveForwad(bool EmergencyBrake, int power, uint time, int Mode)
        {
            switch (Mode)
            {
                case 1: await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C | OutputPort.B, power, time, EmergencyBrake); break;
                case 2: await Ev3Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.C | OutputPort.B, power); break;
            }
        }

        public async Task MoveBackward(bool EmergencyBrake, int power, uint time, int Mode)
        {
            switch (Mode)
            {
                case 1: await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C | OutputPort.B, -power, time, EmergencyBrake); break;
                case 2: await Ev3Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.C | OutputPort.B, -power); break;
            }
        }

        public async Task TurnRight(bool EmergencyBrake, int power, uint time)
        {
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, -power, time, EmergencyBrake);
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, +power, time, EmergencyBrake);
            await Ev3Brick.BatchCommand.SendCommandAsync();
        }

        public async Task TurnLeft(bool EmergencyBrake, int power, uint time)
        {
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, +power, time, EmergencyBrake);
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, -power, time, EmergencyBrake);
            await Ev3Brick.BatchCommand.SendCommandAsync();
        }

        public async Task Stop()
        {
            StopS = true;
            await Ev3Brick.DirectCommand.StopMotorAsync(OutputPort.C | OutputPort.B, true);
        }

        public async Task FollowPath()
        {
            bool CheckPickUp = false;
            int PreviousColor = 20;
            int CurrentColor = 20;
            StopS = false;
            int SensorDistance = (int)Ev3Brick.Ports[InputPort.One].SIValue;
            while (CurrentColor != 0 && !StopS)
            {
                CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                if (CurrentColor == 7 || CurrentColor == 1)
                {
                    await MoveForwad(true, Forward, Time, 1);
                    Debug.WriteLine("Moving forward");
                    PreviousColor = 1;
                }
                if (CurrentColor == 4 || (CurrentColor == 6 && PreviousColor == 4))
                {
                    Debug.WriteLine("Turning right");
                    await TurnRight(true, Turn, Time);
                    PreviousColor = 4;
                }
                if (CurrentColor == 5 || (CurrentColor == 6 && PreviousColor == 5))
                {
                    Debug.WriteLine("Turning left");
                    await TurnLeft(true, Turn, Time);
                    PreviousColor = 5;
                }
                if (PreviousColor == 1 && CurrentColor == 6)
                {
                    if (CheckPickUp)
                    {
                        await DropOff(true);
                    }
                    else
                    {
                        await PickUp(true);
                        await TurnRight(true, 40, 500);
                        await MoveForwad(true, 10, 1000, 1);
                        CheckPickUp = true;
                        CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                    }
                }
            }
        }

        //
        //Brick Communication
        //

        public async Task Send_text(string Mess)
        {
            await Ev3Brick.DirectCommand.DrawTextAsync(Color.Foreground, 1, 1, Mess);
        }

        private void Ev3Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
        }
    }
}