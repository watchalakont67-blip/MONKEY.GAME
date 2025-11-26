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
            int ninjaCost = 50;
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
    }
}

