using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Reset();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jokerBack_Click(object sender, EventArgs e)
        {
            intro.Visible = false;
            outro.Visible = true;

            jokerBack.Visible = false;

            jokerName.Visible = true;
            twoDiamondsName.Visible = false;
            tenClubsName.Visible = false;
            queenHeartsName.Visible = false;
            aceSpadeName.Visible = false;

            exit.Visible = true;
            reset.Visible = true;
        }

        private void twoDiamondsBack_Click(object sender, EventArgs e)
        {
            intro.Visible = false;
            outro.Visible = true;

            twoDiamondsBack.Visible = false;

            jokerName.Visible = false;
            twoDiamondsName.Visible = true;
            tenClubsName.Visible = false;
            queenHeartsName.Visible = false;
            aceSpadeName.Visible = false;

            exit.Visible = true;
            reset.Visible = true;
        }

        private void tenClubsBack_Click(object sender, EventArgs e)
        {
            intro.Visible = false;
            outro.Visible = true;

            tenClubsBack.Visible = false;

            jokerName.Visible = false;
            twoDiamondsName.Visible = false;
            tenClubsName.Visible = true;
            queenHeartsName.Visible = false;
            aceSpadeName.Visible = false;

            exit.Visible = true;
            reset.Visible = true;

            exit.Visible = true;
            reset.Visible = true;
        }

        private void queenHeartsBack_Click(object sender, EventArgs e)
        {
            intro.Visible = false;
            outro.Visible = true;

            queenHeartsBack.Visible = false;

            jokerName.Visible = false;
            twoDiamondsName.Visible = false;
            tenClubsName.Visible = false;
            queenHeartsName.Visible = true;
            aceSpadeName.Visible = false;

            exit.Visible = true;
            reset.Visible = true;

        }

        private void aceSpadeBack_Click(object sender, EventArgs e)
        {
            intro.Visible = false;
            outro.Visible = true;

            aceSpadeBack.Visible = false;

            jokerName.Visible = false;
            twoDiamondsName.Visible = false;
            tenClubsName.Visible = false;
            queenHeartsName.Visible = false;
            aceSpadeName.Visible = true;

            exit.Visible = true;
            reset.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            outro.Visible = false; 
            intro.Visible = true;

            exit.Visible = false;
            reset.Visible = false; 

            jokerName.Visible = false;
            twoDiamondsName.Visible = false;
            tenClubsName.Visible = false;
            queenHeartsName.Visible = false;
            aceSpadeName.Visible = false;

            jokerBack.Visible = true;
            twoDiamondsBack.Visible = true;
            tenClubsBack.Visible = true;
            queenHeartsBack.Visible = true;
            aceSpadeBack.Visible = true;

        }
    }
}

