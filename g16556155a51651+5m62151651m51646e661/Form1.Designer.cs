namespace g16556155a51651_5m62151651m51646e661
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            banana = new PictureBox();
            bananaSpecial = new PictureBox();
            obstacleNormal = new PictureBox();
            obstacleDangerous = new PictureBox();
            lblScore = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)banana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bananaSpecial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(326, 256);
            player.Name = "player";
            player.Size = new Size(138, 144);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += timer1_Tick;
            // 
            // banana
            // 
            banana.Image = (Image)resources.GetObject("banana.Image");
            banana.Location = new Point(81, 45);
            banana.Name = "banana";
            banana.Size = new Size(67, 68);
            banana.SizeMode = PictureBoxSizeMode.StretchImage;
            banana.TabIndex = 1;
            banana.TabStop = false;
            banana.Click += banana_Click;
            // 
            // bananaSpecial
            // 
            bananaSpecial.Image = (Image)resources.GetObject("bananaSpecial.Image");
            bananaSpecial.Location = new Point(211, 45);
            bananaSpecial.Name = "bananaSpecial";
            bananaSpecial.Size = new Size(73, 68);
            bananaSpecial.SizeMode = PictureBoxSizeMode.StretchImage;
            bananaSpecial.TabIndex = 2;
            bananaSpecial.TabStop = false;
            // 
            // obstacleNormal
            // 
            obstacleNormal.Image = (Image)resources.GetObject("obstacleNormal.Image");
            obstacleNormal.Location = new Point(347, 48);
            obstacleNormal.Name = "obstacleNormal";
            obstacleNormal.Size = new Size(78, 65);
            obstacleNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleNormal.TabIndex = 3;
            obstacleNormal.TabStop = false;
            // 
            // obstacleDangerous
            // 
            obstacleDangerous.Image = (Image)resources.GetObject("obstacleDangerous.Image");
            obstacleDangerous.Location = new Point(488, 45);
            obstacleDangerous.Name = "obstacleDangerous";
            obstacleDangerous.Size = new Size(78, 68);
            obstacleDangerous.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleDangerous.TabIndex = 4;
            obstacleDangerous.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(660, 20);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(98, 32);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            lblScore.Click += lblScore_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblScore);
            Controls.Add(obstacleDangerous);
            Controls.Add(obstacleNormal);
            Controls.Add(bananaSpecial);
            Controls.Add(banana);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)banana).EndInit();
            ((System.ComponentModel.ISupportInitialize)bananaSpecial).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox banana;
        private PictureBox bananaSpecial;
        private PictureBox obstacleNormal;
        private PictureBox obstacleDangerous;
        private Label lblScore;
        private PictureBox pictureBox1;
    }
}
