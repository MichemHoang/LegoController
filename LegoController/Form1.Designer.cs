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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.UpButton.Location = new System.Drawing.Point(34, 73);
            this.UpButton.Name = "button1";
            this.UpButton.Size = new System.Drawing.Size(50, 52);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "button1";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this._LeftClicked);
            // 
            // button2
            // 
            this.RightButton.Location = new System.Drawing.Point(128, 73);
            this.RightButton.Name = "button2";
            this.RightButton.Size = new System.Drawing.Size(50, 52);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "button2";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this._RightClicked);
            // 
            // button3
            // 
            this.DownButton.Location = new System.Drawing.Point(81, 122);
            this.DownButton.Name = "button3";
            this.DownButton.Size = new System.Drawing.Size(50, 52);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "button3";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this._BackwardClicked);
            // 
            // button4
            // 
            this.LeftButton.Location = new System.Drawing.Point(81, 24);
            this.LeftButton.Name = "button4";
            this.LeftButton.Size = new System.Drawing.Size(50, 52);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "button4";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this._ForwardClicked);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(551, 352);
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
    }
}

