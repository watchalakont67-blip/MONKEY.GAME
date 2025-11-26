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
            gameTimer = new System.Windows.Forms.Timer(components);
            banana = new PictureBox();
            bananaSpecial = new PictureBox();
            obstacleNormal = new PictureBox();
            obstacleDangerous = new PictureBox();
            lblScore = new Label();
            obstacleHard = new PictureBox();
            lblGameOver = new Label();
            btnRestart = new Button();
            obstacleDangerous2 = new PictureBox();
            obstacleDangerous3 = new PictureBox();
            btnShop = new Button();
            player = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)banana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bananaSpecial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleHard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += timer1_Tick;
            // 
            // banana
            // 
            banana.BackColor = Color.Transparent;
            banana.Image = (Image)resources.GetObject("banana.Image");
            banana.Location = new Point(3, 1);
            banana.Margin = new Padding(3, 4, 3, 4);
            banana.Name = "banana";
            banana.Size = new Size(77, 91);
            banana.SizeMode = PictureBoxSizeMode.StretchImage;
            banana.TabIndex = 1;
            banana.TabStop = false;
            banana.Click += banana_Click;
            // 
            // bananaSpecial
            // 
            bananaSpecial.BackColor = Color.Transparent;
            bananaSpecial.Image = (Image)resources.GetObject("bananaSpecial.Image");
            bananaSpecial.Location = new Point(77, 1);
            bananaSpecial.Margin = new Padding(3, 4, 3, 4);
            bananaSpecial.Name = "bananaSpecial";
            bananaSpecial.Size = new Size(83, 91);
            bananaSpecial.SizeMode = PictureBoxSizeMode.StretchImage;
            bananaSpecial.TabIndex = 2;
            bananaSpecial.TabStop = false;
            // 
            // obstacleNormal
            // 
            obstacleNormal.BackColor = Color.Transparent;
            obstacleNormal.Image = (Image)resources.GetObject("obstacleNormal.Image");
            obstacleNormal.Location = new Point(157, 1);
            obstacleNormal.Margin = new Padding(3, 4, 3, 4);
            obstacleNormal.Name = "obstacleNormal";
            obstacleNormal.Size = new Size(104, 111);
            obstacleNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleNormal.TabIndex = 3;
            obstacleNormal.TabStop = false;
            // 
            // obstacleDangerous
            // 
            obstacleDangerous.BackColor = Color.Transparent;
            obstacleDangerous.Image = (Image)resources.GetObject("obstacleDangerous.Image");
            obstacleDangerous.Location = new Point(116, 260);
            obstacleDangerous.Margin = new Padding(3, 4, 3, 4);
            obstacleDangerous.Name = "obstacleDangerous";
            obstacleDangerous.Size = new Size(200, 198);
            obstacleDangerous.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleDangerous.TabIndex = 4;
            obstacleDangerous.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Transparent;
            lblScore.Location = new Point(744, 1);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(149, 43);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            lblScore.Click += lblScore_Click;
            // 
            // obstacleHard
            // 
            obstacleHard.BackColor = Color.Transparent;
            obstacleHard.Image = (Image)resources.GetObject("obstacleHard.Image");
            obstacleHard.Location = new Point(252, 1);
            obstacleHard.Margin = new Padding(3, 4, 3, 4);
            obstacleHard.Name = "obstacleHard";
            obstacleHard.Size = new Size(111, 111);
            obstacleHard.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleHard.TabIndex = 6;
            obstacleHard.TabStop = false;
            obstacleHard.Visible = false;
            // 
            // lblGameOver
            // 
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = SystemColors.ButtonFace;
            lblGameOver.Location = new Point(125, 108);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(682, 212);
            lblGameOver.TabIndex = 7;
            lblGameOver.Text = "GAME OVER";
            lblGameOver.Visible = false;
            lblGameOver.Click += lblGameOver_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(719, 511);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(187, 78);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // obstacleDangerous2
            // 
            obstacleDangerous2.BackColor = Color.Transparent;
            obstacleDangerous2.Image = (Image)resources.GetObject("obstacleDangerous2.Image");
            obstacleDangerous2.Location = new Point(706, 240);
            obstacleDangerous2.Margin = new Padding(3, 4, 3, 4);
            obstacleDangerous2.Name = "obstacleDangerous2";
            obstacleDangerous2.Size = new Size(200, 198);
            obstacleDangerous2.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleDangerous2.TabIndex = 9;
            obstacleDangerous2.TabStop = false;
            // 
            // obstacleDangerous3
            // 
            obstacleDangerous3.BackColor = Color.Transparent;
            obstacleDangerous3.Image = (Image)resources.GetObject("obstacleDangerous3.Image");
            obstacleDangerous3.Location = new Point(535, 240);
            obstacleDangerous3.Margin = new Padding(3, 4, 3, 4);
            obstacleDangerous3.Name = "obstacleDangerous3";
            obstacleDangerous3.Size = new Size(200, 198);
            obstacleDangerous3.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleDangerous3.TabIndex = 10;
            obstacleDangerous3.TabStop = false;
            // 
            // btnShop
            // 
            btnShop.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShop.Location = new Point(12, 512);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(147, 77);
            btnShop.TabIndex = 11;
            btnShop.Text = "SHOP";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Visible = false;
            btnShop.Click += btnShop_Click;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.MonkeyDefault;
            player.Location = new Point(379, 441);
            player.Name = "player";
            player.Size = new Size(150, 147);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 12;
            player.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(player);
            Controls.Add(btnShop);
            Controls.Add(lblGameOver);
            Controls.Add(btnRestart);
            Controls.Add(lblScore);
            Controls.Add(banana);
            Controls.Add(obstacleNormal);
            Controls.Add(bananaSpecial);
            Controls.Add(obstacleDangerous);
            Controls.Add(obstacleHard);
            Controls.Add(obstacleDangerous3);
            Controls.Add(obstacleDangerous2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)banana).EndInit();
            ((System.ComponentModel.ISupportInitialize)bananaSpecial).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleHard).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous2).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleDangerous3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox banana;
        private PictureBox bananaSpecial;
        private PictureBox obstacleNormal;
        private PictureBox obstacleDangerous;
        private Label lblScore;
        private PictureBox obstacleHard;
        private Label lblGameOver;
        private Button btnRestart;
        private PictureBox obstacleDangerous2;
        private PictureBox obstacleDangerous3;
        private Button btnShop;
        private PictureBox player;
    }
}
