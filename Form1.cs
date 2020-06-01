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

            outro.Visible = false; //exit greeting is not visible

            exit.Visible = false;
            reset.Visible = false; //exit and reset buttons are not visible

            jokerName.Visible = false;
            twoDiamondsName.Visible = false;
            tenClubsName.Visible = false;
            queenHeartsName.Visible = false;
            aceSpadeName.Visible = false; //all card names are not yet showing



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
            outro.Visible = false;

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
    }
}
