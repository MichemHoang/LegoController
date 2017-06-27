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
        private bool StopSignal = false;
        private int CurrentColor = 20;
        bool CheckPickUp;

        public MainBrick()
        {
        }

        public MainBrick(int A, string SerialPortName)
        {
            _dropOff = 40;
            _pickUp = -40;
            CheckPickUp = false;
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
                case 1: await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C | OutputPort.B, -power, time, EmergencyBrake); break;
                case 2: await Ev3Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.C | OutputPort.B, -power); break;
            }
        }

        public async Task MoveBackward(bool EmergencyBrake, int power, uint time, int Mode)
        {
            switch (Mode)
            {
                case 1: await Ev3Brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C | OutputPort.B, power, time, EmergencyBrake); break;
                case 2: await Ev3Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.C | OutputPort.B, power); break;
            }
        }

        public async Task TurnRight(bool EmergencyBrake, int power, uint time)
        {
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, +power, time, EmergencyBrake);
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, -power, time, EmergencyBrake);
            await Ev3Brick.BatchCommand.SendCommandAsync();
        }

        public async Task TurnLeft(bool EmergencyBrake, int power, uint time)
        {
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, -power, time, EmergencyBrake);
            Ev3Brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, +power, time, EmergencyBrake);
            await Ev3Brick.BatchCommand.SendCommandAsync();
        }

        public async Task Stop()
        {
            StopSignal = true;
            await Ev3Brick.DirectCommand.StopMotorAsync(OutputPort.C | OutputPort.B, true);
        }

        //Color Value
        //Black   = 1;
        //Brown   = 7;
        //Yellow  = 4;
        //Red     = 5;
        //White   = 0;
        
        public async Task FollowPath()
        {
            int PreviousColor = 20;
            int cnt = 0;
            StopSignal = false;
            int SensorDistance = (int)Ev3Brick.Ports[InputPort.Three].SIValue;
            while (CurrentColor != 0 && !StopSignal)
            {
                SensorDistance = (int)Ev3Brick.Ports[InputPort.Three].SIValue;
                if (SensorDistance < 30) break;
                CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                if (CurrentColor == 6) cnt++;
                else cnt = 0;
                Debug.WriteLine("Current color = {0}", CurrentColor);
                if (CurrentColor == 7 || CurrentColor == 1 )
                {
                    Debug.WriteLine("Moving forward");
                    await MoveForwad(true, 20, 30, 1);
                    PreviousColor = 1;
                    System.Threading.Thread.Sleep(32);
                }
                else //safeguards for when running into white area 
                if (CurrentColor == 4 || (CurrentColor == 6 && PreviousColor == 4) && cnt < 4)
                {
                    Debug.WriteLine("Turn right");
                    await TurnRight(true, 17, 30);
                    System.Threading.Thread.Sleep(32);
                    PreviousColor = 4;
                }
                else  //safeguards for when running into white area 
                if (CurrentColor == 5 || (CurrentColor == 6 && PreviousColor == 5) && cnt < 4)
                {
                    Debug.WriteLine("Turn Left");
                    await TurnLeft(true, 17, 30);
                    System.Threading.Thread.Sleep(32);
                    PreviousColor = 5;
                }
                else if (PreviousColor == 1 && CurrentColor == 6 || cnt > 4)
                {
                    Debug.WriteLine("IN AREA");
                    if (CheckPickUp)
                    {
                        await MoveBackward(true, 30, 600, 1);
                        System.Threading.Thread.Sleep(1500);
                        await TurnLeft(true, 20, 300);
                        System.Threading.Thread.Sleep(1500);
                        await DropOff(true);
                        System.Threading.Thread.Sleep(1500);
                        await MoveBackward(true, 30, 600, 1);
                        System.Threading.Thread.Sleep(1500);
                        await TurnRight(true, 20, 350);
                        System.Threading.Thread.Sleep(1500);
                        Debug.WriteLine("Turning right");
                        await MoveForwad(true, 40, 1500, 1);
                        System.Threading.Thread.Sleep(1500);
                        CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                        PreviousColor = 0;
                        while (CurrentColor == 6 && !StopSignal)
                        {
                            await TurnRight(true, 10, 50);
                            System.Threading.Thread.Sleep(60);
                            CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                        }
                    }
                    else
                    {
                            await PickUp(true);
                            CheckPickUp = true;
                            System.Threading.Thread.Sleep(1000);
                            Debug.WriteLine("picking up");
                            await TurnRight(true, 15, 1000);
                            System.Threading.Thread.Sleep(1500);
                            Debug.WriteLine("Turning right");
                            await MoveForwad(true, 35, 1000, 1);
                            System.Threading.Thread.Sleep(1000);
                            CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                            PreviousColor = 0;
                            while (CurrentColor == 6 && !StopSignal)
                            {
                                await TurnRight(true, 10, 50);
                                System.Threading.Thread.Sleep(60);
                                CurrentColor = (int)Ev3Brick.Ports[InputPort.Two].SIValue;
                            }
                        
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
            //Debug.WriteLine("Current color = {0}", CC);
            //int SensorDistance = (int)Ev3Brick.Ports[InputPort.Three].SIValue;
            // Debug.WriteLine("Distance = {0}", SensorDistance);
        }
    }

}
