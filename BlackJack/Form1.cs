using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;



namespace WarGUI
{
    public partial class Form1 : Form
    {
        
        private bool[] FillDeck = new bool[52];

        private Random rand = new Random();
        private int[] drpcard = new int[8];
        private int[] drccard = new int[8];
        private int pCard, cCard, msum, psum;
        private int myval, hisval;
        private int mypoints, hispoints;
        private PictureBox[] SelectCard;
        private int a;
        public static decimal db = 0;


        public Form1()
        {
            

            InitializeComponent();
            Betting bettingForm = new Betting();
            bettingForm.StartPosition = FormStartPosition.CenterParent;
            bettingForm.ShowDialog();
            //lblBet.Text = "Bet: " + Betting.Bet.ToString("$0.00");
            lblBalance.Text = Betting.Balance.ToString("$0.00");
           // Start.Visible = false;
            btnDrawCard.Visible = true;
            btnReplay.Visible = false;
            button1.Visible = false;
            hit.Visible = false;
            hit2.Visible = false;
            hit3.Visible = false;
            dobledown.Visible = false;
            stay.Visible = false;
            lblBalance.Visible = true;
            group.Visible = true;
            pCard = cCard = -1;
            myval = hisval = 0;
            pbpCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpCard5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcCard5.SizeMode = PictureBoxSizeMode.StretchImage;

            




            SelectCard = new PictureBox[52];
            ResourceManager rm = WarGUI.Properties.Resources.ResourceManager;
            for (int i = 0; i < 52; ++i)
            {

                SelectCard[i] = new PictureBox();
                SelectCard[i].Image = (Image)rm.GetObject("_" + (i + 1).ToString());

            }


            for(int a = 0; a <52; a++)
            {
                if(deckValue[a] == 11)
                {

                }
            }
            
        }
        string[] deck = {     "2 ♠", "3 ♠", "4 ♠", "5 ♠", "6 ♠", "7 ♠", "8 ♠", "9 ♠", "10 ♠", "J ♠", "Q ♠", "K ♠", "A ♠",
                              "2 ♣", "3 ♣", "4 ♣", "5 ♣", "6 ♣", "7 ♣", "8 ♣", "9 ♣", "10 ♣", "J ♣", "Q ♣", "K ♣", "A ♣",
                              "2 ♦", "3 ♦", "4 ♦", "5 ♦", "6 ♦", "7 ♦", "8 ♦", "9 ♦", "10 ♦", "J ♦", "Q ♦", "K ♦", "A ♦",
                              "2 ♥", "3 ♥", "4 ♥", "5 ♥", "6 ♥", "7 ♥", "8 ♥", "9 ♥", "10 ♥", "J ♥", "Q ♥", "K ♥", "A ♥"};
        int[] deckValue = {     2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
                                2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
                                2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
                                2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11};

        private void Start_Click(object sender, EventArgs e)
        {
           /* Betting bettingForm = new Betting();
            bettingForm.StartPosition = FormStartPosition.CenterParent;
            bettingForm.ShowDialog();
            //lblBet.Text = "Bet: " + Betting.Bet.ToString("$0.00");
            lblBalance.Text =  Betting.Balance.ToString("$0.00");
            Start.Visible = false;
            btnDrawCard.Visible = true;
            hit.Visible = false;
            hit2.Visible = false;
            hit3.Visible = false;
            dobledown.Visible = false;
            stay.Visible = false;
            lblBalance.Visible = true;
            group.Visible = true;*/
            

        }

        private void hit_Click(object sender, EventArgs e)
        {
            
            do
            {
                cCard = rand.Next(52);
                drccard[2] = cCard;
            }
            while (FillDeck[cCard]);

            pbcCard3.Image = new Bitmap(SelectCard[cCard].Image);
            FillDeck[cCard] = true;
            hisval = deckValue[cCard];
            psum = psum+hisval;

            btnDrawCard.Visible = false;
            hit.Visible = false;
            hit2.Visible = true;
            hit3.Visible = false;
            dobledown.Visible = false;

            tbMyScore.Text = Convert.ToString("?");
            tbHisScore.Text = Convert.ToString(psum);
            if (psum > 21)
            {
                if (hisval == 11)
                {
                    if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        psum = psum - 10;
                        tbHisScore.Text = Convert.ToString(psum);
                    }
                }
          
                else if(psum>21)
                {
                    MessageBox.Show("유저버스트");
                    btnDrawCard.Visible = false;
                    hit.Visible = false;
                    hit2.Visible = false;
                    dobledown.Visible = false;
                    stay.Visible = false;
                    pbpCard1.Image = new Bitmap(SelectCard[a].Image);
                }
                

                    

                
               
            }
        }


        private void hit2_Click(object sender, EventArgs e)
        {
            
            do
            {
                cCard = rand.Next(52);
                drccard[0] = cCard;
            }
            while (FillDeck[cCard]);

            pbcCard4.Image = new Bitmap(SelectCard[cCard].Image);
            FillDeck[cCard] = true;
            hisval = deckValue[cCard];
            psum = psum + hisval;

            btnDrawCard.Visible = false;
            hit.Visible = false;
            hit2.Visible = false;
            hit3.Visible = true;

            tbMyScore.Text = Convert.ToString("?");
            tbHisScore.Text = Convert.ToString(psum);
            if (psum > 21)
            {
                if (hisval == 11)
                {
                    if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        psum = psum - 10;
                        tbHisScore.Text = Convert.ToString(psum);
                    }
                }
                else if (psum > 21)
                {
                    MessageBox.Show("유저버스트");
                    btnDrawCard.Visible = false;
                    hit.Visible = false;
                    hit2.Visible = false;
                    hit3.Visible = false;
                    dobledown.Visible = false;
                    stay.Visible = false;
                    pbpCard1.Image = new Bitmap(SelectCard[a].Image);

                }
            }
        }

        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
           // Start.BackgroundImage = Properties.Resources.start_on;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            //Start.BackgroundImage = Properties.Resources.start_off;
        }

        private void dobledown_Click(object sender, EventArgs e)
        {
            int im = drpcard[0];
            pbpCard1.Image = new Bitmap(SelectCard[im].Image);
            do
            {
                cCard = rand.Next(52);
                drccard[0] = cCard;
            }
            while (FillDeck[cCard]);

            pbcCard3.Image = new Bitmap(SelectCard[cCard].Image);
            FillDeck[cCard] = true;
            hisval = deckValue[cCard];
            psum = psum + hisval;

            btnDrawCard.Visible = false;
            hit.Visible = false;
            hit2.Visible = false;
            hit3.Visible = false;
            dobledown.Visible = false;

            tbMyScore.Text = Convert.ToString("?");
            tbHisScore.Text = Convert.ToString(psum);
            db = Betting.Bet * 1 / 2;
            if (psum > 21)
            {
                if (hisval == 11)
                {
                    if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        psum = psum - 10;
                        tbHisScore.Text = Convert.ToString(psum);
                    }
                }
                else if (psum > 21)
                {
                    MessageBox.Show("유저버스트");
                    btnDrawCard.Visible = false;
                    hit.Visible = false;
                    hit2.Visible = false;
                    dobledown.Visible = false;
                    stay.Visible = false;
                    pbpCard1.Image = new Bitmap(SelectCard[a].Image);

                }
            }
            
        }

        private void btnDrawCard_MouseMove(object sender, MouseEventArgs e)
        {
            btnDrawCard.BackgroundImage = Properties.Resources.draw2;
        }

        private void btnDrawCard_MouseLeave(object sender, EventArgs e)
        {
            btnDrawCard.BackgroundImage = Properties.Resources.draw1;
        }

        private void hit_MouseMove(object sender, MouseEventArgs e)
        {
            hit.BackgroundImage = Properties.Resources.hit2;
        }

        private void hit_MouseLeave(object sender, EventArgs e)
        {
            hit.BackgroundImage = Properties.Resources.hit1;
        }

        private void hit3_Click(object sender, EventArgs e)
        {
            do
            {
                cCard = rand.Next(52);
                drccard[0] = cCard;
            }
            while (FillDeck[cCard]);

            pbcCard5.Image = new Bitmap(SelectCard[cCard].Image);
            FillDeck[cCard] = true;
            hisval = deckValue[cCard];
            psum = psum + hisval;

            btnDrawCard.Visible = false;
            hit.Visible = false;
            hit2.Visible = false;

            tbMyScore.Text = Convert.ToString("?");
            tbHisScore.Text = Convert.ToString(psum);
            if (psum > 21)
            {
                if (hisval == 11)
                {
                    if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        psum = psum - 10;
                        tbHisScore.Text = Convert.ToString(psum);
                    }
                }
                else if (psum > 21)
                {
                    MessageBox.Show("유저버스트");
                    btnDrawCard.Visible = false;
                    hit.Visible = false;
                    hit2.Visible = false;
                    hit3.Visible = false;
                    dobledown.Visible = false;
                    stay.Visible = false;
                    pbpCard1.Image = new Bitmap(SelectCard[a].Image);

                }
            }

        }

        private void dobledown_MouseMove(object sender, MouseEventArgs e)
        {
            dobledown.BackgroundImage = Properties.Resources.double2;
        }

        private void dobledown_MouseLeave(object sender, EventArgs e)
        {
            dobledown.BackgroundImage = Properties.Resources.double1;
        }

        private void stay_MouseMove(object sender, MouseEventArgs e)
        {
            stay.BackgroundImage = Properties.Resources.stay2;
        }

        private void stay_MouseLeave(object sender, EventArgs e)
        {
            stay.BackgroundImage = Properties.Resources.stay1;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.exit2;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.exit1;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.suffle2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.suffle1;
        }

        private void btnReplay_MouseMove(object sender, MouseEventArgs e)
        {
            btnReplay.BackgroundImage = Properties.Resources.regame2;
        }

        private void btnReplay_MouseLeave(object sender, EventArgs e)
        {
            btnReplay.BackgroundImage = Properties.Resources.regame1;
        }

        private void stay_Click(object sender, EventArgs e)
        {
            int im = drpcard[0];
            pbpCard1.Image = new Bitmap(SelectCard[im].Image);
            if (msum < 17)
            {
                do
                {
                    pCard = rand.Next(52);
                    drpcard[1] = pCard;
                }
                while (drpcard[0] == drpcard[1]);

                pbpCard3.Image = new Bitmap(SelectCard[pCard].Image);
                FillDeck[pCard] = true;
                myval = deckValue[pCard];

                msum = msum + myval;
                if (msum < 17)
                {
                    do
                    {
                        pCard = rand.Next(52);
                        drpcard[1] = pCard;
                    }
                    while (drpcard[0] == drpcard[1]);

                    pbpCard4.Image = new Bitmap(SelectCard[pCard].Image);
                    FillDeck[pCard] = true;
                    myval = deckValue[pCard];

                    msum = msum + myval;
                    if (msum < 17)
                    {
                        do
                        {
                            pCard = rand.Next(52);
                            drpcard[2] = pCard;
                        }
                        while (drpcard[0] == drpcard[1]);

                        pbpCard5.Image = new Bitmap(SelectCard[pCard].Image);
                        FillDeck[pCard] = true;
                        myval = deckValue[pCard];

                        msum = msum + myval;

                        /*if (msum <= 21&&msum>17)
                        {
                            if (msum > psum)
                            {
                                MessageBox.Show("딜러승");

                            }
                            else if (psum > msum)
                            {
                                MessageBox.Show("유저승");
                                Betting.Balance += (Betting.Bet * 3 / 2);
                                lblBalance.Text = Betting.Balance.ToString("$0.00");
                            }
                        }*/
                    }
            
              /*  if (msum <= 21&&msum>17)
                {
                    if (msum > psum)
                    {
                        MessageBox.Show("딜러승");

                    }
                    else if (psum > msum)
                    {
                        MessageBox.Show("유저승");
                        Betting.Balance += (Betting.Bet * 3 / 2);
                        lblBalance.Text = Betting.Balance.ToString("$0.00");
                    }
                }*/
            }

                    
                
            }
           /* if (msum == 21)
            {
                if (msum <= 21)
                {
                    if (msum > psum)
                    {
                        MessageBox.Show("딜러승");

                    }
                    else if (psum > msum)
                    {
                        MessageBox.Show("유저승");
                        Betting.Balance += (Betting.Bet * 3 / 2);
                        lblBalance.Text = Betting.Balance.ToString("$0.00");
                    }
                }
            }*/
                
                tbMyScore.Text = Convert.ToString(msum);
                tbHisScore.Text = Convert.ToString(psum);
                a = drpcard[0];
                pbpCard1.Image = new Bitmap(SelectCard[a].Image);
                if (msum > 21)
                {
                    MessageBox.Show("딜러 버스트");
                    btnDrawCard.Visible = false;
                    hit.Visible = false;
                    hit2.Visible = false;
                    dobledown.Visible = false;
                    stay.Visible = false;
                    Betting.Balance += (Betting.Bet * 3 / 2)+db;
                    lblBalance.Text = Betting.Balance.ToString("$0.00");
                }
                else if(msum == psum)
                {
                    MessageBox.Show("무승부");
                    Betting.Balance += Betting.Bet;
                    lblBalance.Text = Betting.Balance.ToString("$0.00");

                }
            if (msum <= 21)
            {
                if (msum > psum)
                {
                    MessageBox.Show("딜러승");

                }
                else if (psum > msum)
                {
                    MessageBox.Show("유저승");
                    Betting.Balance += (Betting.Bet * 3 / 2+db);
                    lblBalance.Text = Betting.Balance.ToString("$0.00");
                }
            }





            tbMyScore.Text = Convert.ToString(msum);
            btnDrawCard.Visible = false;
            hit.Visible = false;
            hit2.Visible = false;
            dobledown.Visible = false;
            stay.Visible = false;
            msum = 0;
            psum = 0;
            db = 0;

        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            btnDrawCard.Visible = false;
            hit.Visible = true;
            hit2.Visible = false;
            dobledown.Visible = true;
            stay.Visible = true;

            do
                {
                    pCard = rand.Next(52);
                    drpcard[0] = pCard;
                }
                while (FillDeck[pCard]);
                pbpCard1.Image = WarGUI.Properties.Resources.back;

                FillDeck[pCard] = true;
                myval = deckValue[pCard];
                msum = myval;
            if (hisval == 11)
            {
                if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    psum = psum - 10;
                    tbHisScore.Text = Convert.ToString(psum);
                    
                }
            }

            do
                {
                    cCard = rand.Next(52);
                    drccard[0] = cCard;
                }
                while (FillDeck[cCard]);

                pbcCard1.Image = new Bitmap(SelectCard[cCard].Image);
                FillDeck[cCard] = true;
                btnDrawCard.Visible = false;
                hisval = deckValue[cCard];
                psum = hisval;
            do
            {
                pCard = rand.Next(52);
                drpcard[1] = pCard;
            }
            while (FillDeck[pCard]);
            pbpCard2.Image = new Bitmap(SelectCard[pCard].Image);

            FillDeck[pCard] = true;
            myval = deckValue[pCard];
            msum =msum+ myval;
            if (hisval == 11)
            {
                if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    psum = psum - 10;
                    tbHisScore.Text = Convert.ToString(psum);
                }
            }

            do
            {
                cCard = rand.Next(52);
                drccard[1] = cCard;
            }
            while (FillDeck[cCard]);

            pbcCard2.Image = new Bitmap(SelectCard[cCard].Image);
            FillDeck[cCard] = true;
            btnDrawCard.Visible = false;
            hisval = deckValue[cCard];
            psum = psum+hisval;
            if (hisval == 11)
            {
                if (MessageBox.Show("A를 1로 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    psum = psum - 10;
                    tbHisScore.Text = Convert.ToString(psum);
                }
            }

            btnReplay.Visible = true;
                btnDrawCard.Visible = false;
                
            //display points
            tbMyScore.Text = Convert.ToString("?");
            tbHisScore.Text = Convert.ToString(psum);
            button1.Visible = false;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            pCard = cCard = -1;
            myval = hisval = 0;
            mypoints = hispoints = 0;
            for (int i = 0; i < 52; ++i)
                FillDeck[i] = false;
            lblResult.Text = null;
            tbMyScore.Text = null;
            tbHisScore.Text = null;
            pbDeck.Image = WarGUI.Properties.Resources.back;
            pbpCard1.Image = pbpCard2.Image = pbpCard3.Image = pbpCard4.Image = pbpCard5.Image = null;
            pbcCard1.Image = pbcCard2.Image = pbcCard3.Image = pbcCard4.Image = pbcCard5.Image = null;
            Betting bettingForm = new Betting();
            bettingForm.StartPosition = FormStartPosition.CenterParent;
            bettingForm.ShowDialog();
            lblBalance.Text = Betting.Balance.ToString("$0.00");

            btnDrawCard.Visible = true;
            btnReplay.Visible = false;
            button1.Visible = true;
            btnDrawCard.Visible = true;
            hit.Visible = true;
            hit2.Visible = false;
            btnDrawCard.Visible = true;
            btnReplay.Visible = true;
            btnDrawCard.Visible = true;
            hit.Visible = false;
            hit2.Visible = false;
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            do
            {
                pCard = rand.Next(52);
            }
            while (FillDeck[pCard]);

            do
            {
                cCard = rand.Next(52);
            }
            while (FillDeck[cCard]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

            
        }


      
        
    }
}
