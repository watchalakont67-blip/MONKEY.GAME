using System.Numerics;

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
        int obstacleDangerousSpeed = 10;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetBanana();
            ResetSpecialBanana();
            ResetObstacleNormal();
            ResetObstacleDangerous();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            obstacleDangerous.Top += obstacleDangerousSpeed;




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


            if (player.Bounds.IntersectsWith(obstacleDangerous.Bounds))
            {
                score -= 8;
                ResetObstacleDangerous();
            }



            if (banana.Top > this.ClientSize.Height) ResetBanana();
            if (bananaSpecial.Top > this.ClientSize.Height) ResetSpecialBanana();


            if (obstacleNormal.Top > this.ClientSize.Height)
            {
                ResetObstacleNormal();
            }


            if (obstacleDangerous.Top > this.ClientSize.Height)
            {
                ResetObstacleDangerous();
            }
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

        private void ResetObstacleNormal() // <-- แก้ไขชื่อ
        {
            // ใช้ obstacleNormal.Left และ .Top
            obstacleNormal.Left = rand.Next(0, this.ClientSize.Width - obstacleNormal.Width);
            obstacleNormal.Top = rand.Next(-150, -50);
        }

        // <-- ใหม่: ฟังก์ชันสำหรับสุ่มอุปสรรคอันตราย -->
        private void ResetObstacleDangerous()
        {
            obstacleDangerous.Left = rand.Next(0, this.ClientSize.Width - obstacleDangerous.Width);
            // ตั้งค่า Top ให้ติดลบเยอะๆ เพื่อให้โผล่มาไม่บ่อยเท่าอันธรรมดา
            obstacleDangerous.Top = rand.Next(-500, -250);
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}



