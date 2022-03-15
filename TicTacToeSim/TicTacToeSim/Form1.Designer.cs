
namespace TicTacToeSim
{
    partial class Form1
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
            this.directionsLabel = new System.Windows.Forms.Label();
            this.winOutputLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.xAndOsLabel0 = new System.Windows.Forms.Label();
            this.xAndOsLabel1 = new System.Windows.Forms.Label();
            this.xAndOsLabel2 = new System.Windows.Forms.Label();
            this.xAndOsLabel3 = new System.Windows.Forms.Label();
            this.xAndOsLabel4 = new System.Windows.Forms.Label();
            this.xAndOsLabel5 = new System.Windows.Forms.Label();
            this.xAndOsLabel6 = new System.Windows.Forms.Label();
            this.xAndOsLabel7 = new System.Windows.Forms.Label();
            this.xAndOsLabel8 = new System.Windows.Forms.Label();
            this.ticTacToeGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // directionsLabel
            // 
            this.directionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.Location = new System.Drawing.Point(15, 9);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(394, 38);
            this.directionsLabel.TabIndex = 0;
            this.directionsLabel.Text = "Click Play to start the Game!\r\n X or O?  The computer will tell which is the winn" +
    "er!\r\n";
            this.directionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winOutputLabel
            // 
            this.winOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winOutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.winOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.winOutputLabel.Location = new System.Drawing.Point(15, 381);
            this.winOutputLabel.Name = "winOutputLabel";
            this.winOutputLabel.Size = new System.Drawing.Size(394, 38);
            this.winOutputLabel.TabIndex = 1;
            this.winOutputLabel.Text = "PRESS PLAY TO SEE WHO WINS!";
            this.winOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.playButton.Location = new System.Drawing.Point(15, 434);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(126, 43);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "&Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.clearButton.Location = new System.Drawing.Point(149, 434);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 43);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.exitButton.Location = new System.Drawing.Point(283, 434);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 43);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // xAndOsLabel0
            // 
            this.xAndOsLabel0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel0.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel0.Location = new System.Drawing.Point(76, 78);
            this.xAndOsLabel0.Name = "xAndOsLabel0";
            this.xAndOsLabel0.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel0.TabIndex = 5;
            this.xAndOsLabel0.Text = "T";
            this.xAndOsLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel1
            // 
            this.xAndOsLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel1.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel1.Location = new System.Drawing.Point(179, 78);
            this.xAndOsLabel1.Name = "xAndOsLabel1";
            this.xAndOsLabel1.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel1.TabIndex = 6;
            this.xAndOsLabel1.Text = "I";
            this.xAndOsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel2
            // 
            this.xAndOsLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel2.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel2.Location = new System.Drawing.Point(282, 78);
            this.xAndOsLabel2.Name = "xAndOsLabel2";
            this.xAndOsLabel2.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel2.TabIndex = 7;
            this.xAndOsLabel2.Text = "C";
            this.xAndOsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel3
            // 
            this.xAndOsLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel3.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel3.Location = new System.Drawing.Point(76, 175);
            this.xAndOsLabel3.Name = "xAndOsLabel3";
            this.xAndOsLabel3.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel3.TabIndex = 8;
            this.xAndOsLabel3.Text = "T";
            this.xAndOsLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel4
            // 
            this.xAndOsLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel4.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel4.Location = new System.Drawing.Point(179, 175);
            this.xAndOsLabel4.Name = "xAndOsLabel4";
            this.xAndOsLabel4.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel4.TabIndex = 9;
            this.xAndOsLabel4.Text = "A";
            this.xAndOsLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel5
            // 
            this.xAndOsLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel5.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel5.Location = new System.Drawing.Point(282, 175);
            this.xAndOsLabel5.Name = "xAndOsLabel5";
            this.xAndOsLabel5.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel5.TabIndex = 10;
            this.xAndOsLabel5.Text = "C";
            this.xAndOsLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel6
            // 
            this.xAndOsLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel6.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel6.Location = new System.Drawing.Point(76, 277);
            this.xAndOsLabel6.Name = "xAndOsLabel6";
            this.xAndOsLabel6.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel6.TabIndex = 11;
            this.xAndOsLabel6.Text = "T";
            this.xAndOsLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel7
            // 
            this.xAndOsLabel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel7.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel7.Location = new System.Drawing.Point(179, 277);
            this.xAndOsLabel7.Name = "xAndOsLabel7";
            this.xAndOsLabel7.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel7.TabIndex = 12;
            this.xAndOsLabel7.Text = "O";
            this.xAndOsLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAndOsLabel8
            // 
            this.xAndOsLabel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xAndOsLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xAndOsLabel8.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAndOsLabel8.Location = new System.Drawing.Point(282, 277);
            this.xAndOsLabel8.Name = "xAndOsLabel8";
            this.xAndOsLabel8.Size = new System.Drawing.Size(75, 76);
            this.xAndOsLabel8.TabIndex = 13;
            this.xAndOsLabel8.Text = "E";
            this.xAndOsLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticTacToeGroupBox
            // 
            this.ticTacToeGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ticTacToeGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ticTacToeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ticTacToeGroupBox.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticTacToeGroupBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ticTacToeGroupBox.Location = new System.Drawing.Point(54, 55);
            this.ticTacToeGroupBox.Name = "ticTacToeGroupBox";
            this.ticTacToeGroupBox.Size = new System.Drawing.Size(325, 314);
            this.ticTacToeGroupBox.TabIndex = 14;
            this.ticTacToeGroupBox.TabStop = false;
            this.ticTacToeGroupBox.Text = "Tic Tac Toe Randomizer Board";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(426, 493);
            this.Controls.Add(this.xAndOsLabel8);
            this.Controls.Add(this.xAndOsLabel7);
            this.Controls.Add(this.xAndOsLabel6);
            this.Controls.Add(this.xAndOsLabel5);
            this.Controls.Add(this.xAndOsLabel4);
            this.Controls.Add(this.xAndOsLabel3);
            this.Controls.Add(this.xAndOsLabel2);
            this.Controls.Add(this.xAndOsLabel1);
            this.Controls.Add(this.xAndOsLabel0);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.winOutputLabel);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.ticTacToeGroupBox);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Randomizer Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.Label winOutputLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label xAndOsLabel0;
        private System.Windows.Forms.Label xAndOsLabel1;
        private System.Windows.Forms.Label xAndOsLabel2;
        private System.Windows.Forms.Label xAndOsLabel3;
        private System.Windows.Forms.Label xAndOsLabel4;
        private System.Windows.Forms.Label xAndOsLabel5;
        private System.Windows.Forms.Label xAndOsLabel6;
        private System.Windows.Forms.Label xAndOsLabel7;
        private System.Windows.Forms.Label xAndOsLabel8;
        private System.Windows.Forms.GroupBox ticTacToeGroupBox;
    }
}

