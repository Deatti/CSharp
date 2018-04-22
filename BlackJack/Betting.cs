using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGUI
{
    public partial class Betting : Form
    {
        public static decimal Bet = 50;
        public static decimal Balance = 500;

        public Betting()
        {
            InitializeComponent();
        }

        private void Betting_Load(object sender, EventArgs e)
        {
            lblBalance.Text = "Balance: $" + Balance.ToString("#0.00");
            numBet.Maximum = Balance;
        }

        private void cmdBet_Click(object sender, EventArgs e)
        {
            Bet = numBet.Value;
            if (Balance == 0)
            {
                MessageBox.Show(null, "이런...돈이 다떨어졌네요..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else if (Bet > Balance)
                MessageBox.Show("죄송합니다 배팅액이..$" + Bet + " 요많큼 " +
                   "부족합니다", "적은금액을배팅해주세요");
            else
            {
                Balance -= Bet;
                lblBalance.Text = Balance.ToString();
                this.Close();
            }
        }
    }
}

