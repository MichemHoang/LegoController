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
            this.PickUp = new System.Windows.Forms.Button();
            this.DropOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(34, 73);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(50, 52);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Left";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this._LeftClicked);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(128, 73);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(50, 52);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this._RightClicked);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(81, 122);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(50, 52);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this._BackwardClicked);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(81, 24);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(50, 52);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "Up";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this._ForwardClicked);
            // 
            // PickUp
            // 
            this.PickUp.Location = new System.Drawing.Point(403, 73);
            this.PickUp.Name = "PickUp";
            this.PickUp.Size = new System.Drawing.Size(75, 23);
            this.PickUp.TabIndex = 4;
            this.PickUp.Text = "PickUp";
            this.PickUp.UseVisualStyleBackColor = true;
            this.PickUp.Click += new System.EventHandler(this.PickUp_Click);
            // 
            // DropOff
            // 
            this.DropOff.Location = new System.Drawing.Point(403, 102);
            this.DropOff.Name = "DropOff";
            this.DropOff.Size = new System.Drawing.Size(75, 23);
            this.DropOff.TabIndex = 5;
            this.DropOff.Text = "DropOff";
            this.DropOff.UseVisualStyleBackColor = true;
            this.DropOff.Click += new System.EventHandler(this.DropOff_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(551, 352);
            this.Controls.Add(this.PickUp);
            this.Controls.Add(this.DropOff);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.UpButton);
            this.Name = "GUI";
            this.Text = "Lego Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button PickUp;
        private System.Windows.Forms.Button DropOff;
    }
}

