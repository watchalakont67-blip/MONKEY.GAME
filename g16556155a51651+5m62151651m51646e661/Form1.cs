using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace g16556155a51651_5m62151651m51646e661
{
    public partial class Form1 : Form
    {
        bool goLeft;
        bool goRight;
        int score = 0;


        int playerSpeed = 12;
        int itemSpeed = 5;
        int itemSpecialSpeed = 8;

        int obstacleNormalSpeed = 7;
        int obstacleHardSpeed = 7;
        int obstacleDangerousSpeed = 8;

        int nextSpawnScore = 30;
        Random rand = new Random();
    
        public Form1()
        {
            InitializeComponent();
            ResetBanana();
            ResetSpecialBanana();
            ResetObstacleNormal();
            ResetObstacleHard();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGame();
            gameTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;


            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight && player.Left < this.ClientSize.Width - player.Width)
            {
                player.Left += playerSpeed;
            }


            banana.Top += itemSpeed;
            bananaSpecial.Top += itemSpecialSpeed;
            obstacleNormal.Top += obstacleNormalSpeed;
            obstacleHard.Top += obstacleHardSpeed;




            if (score >= nextSpawnScore)
            {
                obstacleDangerous.Top = -100;
                obstacleDangerous.Left = rand.Next(0, this.ClientSize.Width - obstacleDangerous.Width);
                obstacleDangerous.Visible = true;

                obstacleDangerous2.Top = -100;
                obstacleDangerous2.Left = rand.Next(0, this.ClientSize.Width - obstacleDangerous2.Width);
                obstacleDangerous2.Visible = true;

                obstacleDangerous3.Top = -100;
                obstacleDangerous3.Left = rand.Next(0, this.ClientSize.Width - obstacleDangerous3.Width);
                obstacleDangerous3.Visible = true;

                nextSpawnScore += 30;
            }


            if (obstacleDangerous.Visible == true)
            {
                obstacleDangerous.Top += obstacleDangerousSpeed;
                if (player.Bounds.IntersectsWith(obstacleDangerous.Bounds))
                {
                    GameOver();
                    return;
                }
                if (obstacleDangerous.Top > this.ClientSize.Height)
                {
                    obstacleDangerous.Visible = false; // ซ่อนเมื่อตกจอ
                }
            }

            if (obstacleDangerous2.Visible == true)
            {
                obstacleDangerous2.Top += obstacleDangerousSpeed;
                if (player.Bounds.IntersectsWith(obstacleDangerous2.Bounds))
                {
                    GameOver();
                    return;
                }
                if (obstacleDangerous2.Top > this.ClientSize.Height)
                {
                    obstacleDangerous2.Visible = false; // ซ่อนเมื่อตกจอ
                }
            }
            if (obstacleDangerous3.Visible == true)
            {
                obstacleDangerous3.Top += obstacleDangerousSpeed;
                if (player.Bounds.IntersectsWith(obstacleDangerous3.Bounds))
                {
                    GameOver();
                    return;
                }

                if (obstacleDangerous3.Top > this.ClientSize.Height)
                {
                    obstacleDangerous3.Visible = false; // ซ่อนเมื่อตกจอ
                }
            }                       
            if (player.Bounds.IntersectsWith(banana.Bounds))
            {
                score += 1;
                ResetBanana();
            }


            if (player.Bounds.IntersectsWith(bananaSpecial.Bounds))
            {
                score += 10;
                ResetSpecialBanana();
            }


            if (player.Bounds.IntersectsWith(obstacleNormal.Bounds))
            {
                score -= 2;
                ResetObstacleNormal();
            }

            if (player.Bounds.IntersectsWith(obstacleHard.Bounds))
            {
                score -= 8; 
                ResetObstacleHard();
            }

            if (banana.Top > this.ClientSize.Height) ResetBanana();
            if (bananaSpecial.Top > this.ClientSize.Height) ResetSpecialBanana();
            if (obstacleNormal.Top > this.ClientSize.Height) ResetObstacleNormal();                               
            if (obstacleHard.Top > this.ClientSize.Height) ResetObstacleHard();
          
            if (score < 0)
            {
                GameOver();

            }
        }
        private void GameOver()
        {
            gameTimer.Stop();
            lblGameOver.Text = "GAME OVER\nScore: " + score;

            lblGameOver.Visible = true;
            btnRestart.Visible = true;

            return;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }

        private void banana_Click(object sender, EventArgs e)
        {

        }
        private void ResetBanana()
        {
            banana.Left = rand.Next(0, this.ClientSize.Width - banana.Width);
            banana.Top = rand.Next(-100, -50);
        }

        private void ResetSpecialBanana()
        {
            bananaSpecial.Left = rand.Next(0, this.ClientSize.Width - bananaSpecial.Width);
            bananaSpecial.Top = rand.Next(-300, -150);
        }

        private void ResetObstacleNormal() 
        {

            obstacleNormal.Left = rand.Next(0, this.ClientSize.Width - obstacleNormal.Width);
            obstacleNormal.Top = rand.Next(-150, -50);
        }
        private void ResetObstacleHard()
        {
            obstacleHard.Left = rand.Next(0, this.ClientSize.Width - obstacleHard.Width);       
            obstacleHard.Top = rand.Next(-400, -200);
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;

            gameTimer.Start();
            SetupGame();
       
            lblGameOver.Visible = false;
            btnRestart.Visible = false;

            this.Focus();
        }
        private void SetupGame()
        {
            player.Location = new Point((this.ClientSize.Width - player.Width) / 2, this.ClientSize.Height - player.Height - 10);

            ResetBanana();        
            ResetSpecialBanana();   
            ResetObstacleNormal();  
            ResetObstacleHard();

            nextSpawnScore = 30;
            obstacleHard.Visible = true;
            obstacleDangerous.Visible = false;
            obstacleDangerous2.Visible = false; 
            obstacleDangerous3.Visible = false;
            
            obstacleDangerous.Top = -100;
            obstacleDangerous2.Top = -100; 
            obstacleDangerous3.Top = -100;

            playerSpeed = 12;
            goLeft = false;
            goRight = false;
        }      
    }
}



