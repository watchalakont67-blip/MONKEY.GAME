using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g16556155a51651_5m62151651m51646e661
{
    public partial class ShopForm : Form
    {
        int christmasCost = 2;
        int halloweenCost = 2;
        int ninjaCost = 2;
        int knightCost = 2;
        int hawaiiCost = 2;
        int studentCost = 2;
        int gymCost = 2;
        int monkeyCost = 0;
        int kamenRiderv1Cost = 2;
        int kamenRiderv2Cost = 2;
        int kamenRiderWCost = 2;

        private Form1 parentForm;
        public ShopForm(Form1 callingForm)
        {
            InitializeComponent();
            parentForm = callingForm;
            lblMoney.Text = "Your Money: " + parentForm.money;
            lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;

            this.DoubleBuffered = true;

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyNinja_Click(object sender, EventArgs e)
        {

            string characterName = "Ninja";

            if (parentForm.money >= ninjaCost)
            {
                parentForm.money -= ninjaCost; // หักเงิน
                parentForm.activeCharacter = characterName; // เปลี่ยนตัวละครที่ใช้งาน
                lblMoney.Text = "Your Money: " + parentForm.money; // อัปเดตการแสดงผล
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + ninjaCost + " money.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCharacterStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyChristmas_Click(object sender, EventArgs e)
        {
            string characterName = "Christmas"; // ชื่อตัวละครใหม่

            if (parentForm.money >= christmasCost)
            {
                // ทำการซื้อ
                parentForm.money -= christmasCost;
                parentForm.activeCharacter = characterName;

                // อัปเดต UI และแสดงข้อความ
                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + christmasCost + " money.");
            }
        }

        private void btnBuyHalloween_Click(object sender, EventArgs e)
        {
            string characterName = "Halloween"; // ชื่อตัวละครใหม่

            if (parentForm.money >= halloweenCost)
            {
                // ทำการซื้อ
                parentForm.money -= halloweenCost;
                parentForm.activeCharacter = characterName;

                // อัปเดต UI และแสดงข้อความ
                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + halloweenCost + " money.");
            }
        }

        private void btnBuyKnight_Click(object sender, EventArgs e)
        {
            string characterName = "Knight";

            if (parentForm.money >= knightCost)
            {

                parentForm.money -= knightCost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + knightCost + " money.");
            }
        }

        private void btnBuyHawaii_Click(object sender, EventArgs e)
        {
            string characterName = "Hawaii";

            if (parentForm.money >= hawaiiCost)
            {

                parentForm.money -= hawaiiCost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + hawaiiCost + " money.");
            }
        }

        private void btnBuyStudent_Click(object sender, EventArgs e)
        {
            string characterName = "Student";

            if (parentForm.money >= studentCost)
            {

                parentForm.money -= studentCost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + studentCost + " money.");
            }
        }

        private void btnBuyGym_Click(object sender, EventArgs e)
        {
            string characterName = "Gym";

            if (parentForm.money >= gymCost)
            {

                parentForm.money -= gymCost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + gymCost + " money.");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string characterName = "Monkey";

            if (parentForm.money >= monkeyCost)
            {

                parentForm.money -= monkeyCost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + monkeyCost + " money.");
            }
        }

        private void btnBuyV1_Click(object sender, EventArgs e)
        {
            string characterName = "KamenV1";

            if (parentForm.money >= kamenRiderv1Cost)
            {

                parentForm.money -= kamenRiderv1Cost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + kamenRiderv1Cost + " money.");
            }
        }

        private void btnBuyV2_Click(object sender, EventArgs e)
        {
            string characterName = "KamenV2";

            if (parentForm.money >= kamenRiderv2Cost)
            {

                parentForm.money -= kamenRiderv2Cost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + kamenRiderv2Cost + " money.");
            }
        }

        private void btnBuyW_Click(object sender, EventArgs e)
        {
            string characterName = "KamenW";

            if (parentForm.money >= kamenRiderWCost)
            {

                parentForm.money -= kamenRiderWCost;
                parentForm.activeCharacter = characterName;


                lblMoney.Text = "Your Money: " + parentForm.money;
                lblCharacterStatus.Text = "Active: " + parentForm.activeCharacter;
                MessageBox.Show("Purchased " + characterName + "!");
            }
            else
            {
                MessageBox.Show("Not enough money! You need " + kamenRiderWCost + " money.");
            }
        }
    }
}

