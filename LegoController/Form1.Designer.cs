namespace LegoController
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.PickUpButton = new System.Windows.Forms.Button();
            this.DropOffButton = new System.Windows.Forms.Button();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ConnectionGroup = new System.Windows.Forms.GroupBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectDescript = new System.Windows.Forms.Label();
            this.BlueToothPort = new System.Windows.Forms.TextBox();
            this.InputGroup = new System.Windows.Forms.GroupBox();
            this.SendMess = new System.Windows.Forms.Button();
            this.InputMessage = new System.Windows.Forms.TextBox();
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.OutputMess = new System.Windows.Forms.TextBox();
            this.ControlGroup.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            this.InputGroup.SuspendLayout();
            this.OutputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpButton
            // 
            this.UpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpButton.Location = new System.Drawing.Point(40, 68);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(50, 52);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Left";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this._LeftClicked);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(134, 68);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(50, 52);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this._RightClicked);
            // 
            // DownButton
            // 
            this.DownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.Location = new System.Drawing.Point(87, 117);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(50, 52);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this._BackwardClicked);
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(87, 19);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(50, 52);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "Up";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this._ForwardClicked);
            // 
            // PickUpButton
            // 
            this.PickUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpButton.Location = new System.Drawing.Point(31, 188);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(53, 23);
            this.PickUpButton.TabIndex = 4;
            this.PickUpButton.Text = "PickUp";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Click += new System.EventHandler(this.PickUp_Click);
            // 
            // DropOffButton
            // 
            this.DropOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropOffButton.Location = new System.Drawing.Point(143, 188);
            this.DropOffButton.Name = "DropOffButton";
            this.DropOffButton.Size = new System.Drawing.Size(53, 23);
            this.DropOffButton.TabIndex = 5;
            this.DropOffButton.Text = "DropOff";
            this.DropOffButton.UseVisualStyleBackColor = true;
            this.DropOffButton.Click += new System.EventHandler(this.DropOff_Click);
            // 
            // ControlGroup
            // 
            this.ControlGroup.Controls.Add(this.button1);
            this.ControlGroup.Controls.Add(this.StopButton);
            this.ControlGroup.Controls.Add(this.LeftButton);
            this.ControlGroup.Controls.Add(this.DropOffButton);
            this.ControlGroup.Controls.Add(this.PickUpButton);
            this.ControlGroup.Controls.Add(this.DownButton);
            this.ControlGroup.Controls.Add(this.RightButton);
            this.ControlGroup.Controls.Add(this.UpButton);
            this.ControlGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlGroup.Location = new System.Drawing.Point(317, 18);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(222, 279);
            this.ControlGroup.TabIndex = 6;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "CONTROL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "FollowPath";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Follow_path_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(87, 217);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(57, 23);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ConnectionGroup
            // 
            this.ConnectionGroup.Controls.Add(this.DisconnectButton);
            this.ConnectionGroup.Controls.Add(this.ConnectButton);
            this.ConnectionGroup.Controls.Add(this.ConnectDescript);
            this.ConnectionGroup.Controls.Add(this.BlueToothPort);
            this.ConnectionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionGroup.Location = new System.Drawing.Point(32, 18);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Size = new System.Drawing.Size(279, 145);
            this.ConnectionGroup.TabIndex = 7;
            this.ConnectionGroup.TabStop = false;
            this.ConnectionGroup.Text = "Connection";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.Location = new System.Drawing.Point(152, 111);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(111, 23);
            this.DisconnectButton.TabIndex = 3;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(16, 111);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(130, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectDescript
            // 
            this.ConnectDescript.AutoSize = true;
            this.ConnectDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectDescript.Location = new System.Drawing.Point(13, 23);
            this.ConnectDescript.Name = "ConnectDescript";
            this.ConnectDescript.Size = new System.Drawing.Size(144, 13);
            this.ConnectDescript.TabIndex = 1;
            this.ConnectDescript.Text = "Port for bluetooth connection";
            // 
            // BlueToothPort
            // 
            this.BlueToothPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueToothPort.Location = new System.Drawing.Point(16, 45);
            this.BlueToothPort.Multiline = true;
            this.BlueToothPort.Name = "BlueToothPort";
            this.BlueToothPort.Size = new System.Drawing.Size(247, 60);
            this.BlueToothPort.TabIndex = 0;
            this.BlueToothPort.TextChanged += new System.EventHandler(this.BluetoothPort_TextChanged);
            // 
            // InputGroup
            // 
            this.InputGroup.Controls.Add(this.SendMess);
            this.InputGroup.Controls.Add(this.InputMessage);
            this.InputGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputGroup.Location = new System.Drawing.Point(29, 169);
            this.InputGroup.Name = "InputGroup";
            this.InputGroup.Size = new System.Drawing.Size(128, 175);
            this.InputGroup.TabIndex = 8;
            this.InputGroup.TabStop = false;
            this.InputGroup.Text = "Input";
            // 
            // SendMess
            // 
            this.SendMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMess.Location = new System.Drawing.Point(6, 124);
            this.SendMess.Name = "SendMess";
            this.SendMess.Size = new System.Drawing.Size(113, 24);
            this.SendMess.TabIndex = 1;
            this.SendMess.Text = "Send";
            this.SendMess.UseVisualStyleBackColor = true;
            this.SendMess.Click += new System.EventHandler(this.SendMess_Click);
            // 
            // InputMessage
            // 
            this.InputMessage.Location = new System.Drawing.Point(6, 21);
            this.InputMessage.Multiline = true;
            this.InputMessage.Name = "InputMessage";
            this.InputMessage.Size = new System.Drawing.Size(113, 87);
            this.InputMessage.TabIndex = 0;
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.OutputMess);
            this.OutputGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputGroup.Location = new System.Drawing.Point(163, 169);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(148, 171);
            this.OutputGroup.TabIndex = 9;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "Output";
            // 
            // OutputMess
            // 
            this.OutputMess.Location = new System.Drawing.Point(6, 21);
            this.OutputMess.Multiline = true;
            this.OutputMess.Name = "OutputMess";
            this.OutputMess.ReadOnly = true;
            this.OutputMess.Size = new System.Drawing.Size(136, 127);
            this.OutputMess.TabIndex = 0;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(551, 352);
            this.Controls.Add(this.OutputGroup);
            this.Controls.Add(this.InputGroup);
            this.Controls.Add(this.ConnectionGroup);
            this.Controls.Add(this.ControlGroup);
            this.Name = "GUI";
            this.Text = "Lego Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlGroup.ResumeLayout(false);
            this.ConnectionGroup.ResumeLayout(false);
            this.ConnectionGroup.PerformLayout();
            this.InputGroup.ResumeLayout(false);
            this.InputGroup.PerformLayout();
            this.OutputGroup.ResumeLayout(false);
            this.OutputGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button PickUpButton;
        private System.Windows.Forms.Button DropOffButton;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.GroupBox ConnectionGroup;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label ConnectDescript;
        private System.Windows.Forms.TextBox BlueToothPort;
        private System.Windows.Forms.GroupBox InputGroup;
        private System.Windows.Forms.TextBox InputMessage;
        private System.Windows.Forms.Button SendMess;
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.TextBox OutputMess;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button button1;
    }
}

