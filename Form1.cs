using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazinga_
{
    public partial class Form1 : Form
    {
        Image[] imgSheldon = new Image[]
        {
            Properties.Resources.rock,
            Properties.Resources.paper,
            Properties.Resources.scissors,
            Properties.Resources.lizard,
            Properties.Resources.prosperity,
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbDescriptionPlayer_Click(object sender, EventArgs e)
        {

        }

        private void ClickPlay(object sender, EventArgs e)
        { //caching --> conversão do sender para botão
            Button bt = (Button)sender;
            PicPlayer.Image = bt.BackgroundImage;
            Coup CoupPlayer = ReturnCoupPlayer(Convert.ToInt32(bt.Tag));
            Coup CoupSheldon = ReturnCoupSheldon();
            Scoreboard Scoreboard = ReturnWinner(CoupPlayer, CoupSheldon);
        }
        private Scoreboard ReturnWinner(Coup Player, Coup Sheldon)
        {
            if (Player == Coup.Rock)
            {
                if (Sheldon == Coup.Paper)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Scissors)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Lizard)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Prosperity)
                {
                    return Scoreboard.VictorySheldon;
                }

            }
            else if (Player == Coup.Paper)
            {
                if (Sheldon == Coup.Rock)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Scissors)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Lizard)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Prosperity)
                {
                    return Scoreboard.VictoryPlayer;
                }

            }
            else if (Player == Coup.Scissors)
            {
                if (Sheldon == Coup.Rock)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Paper)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Lizard)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Prosperity)
                {
                    return Scoreboard.VictoryPlayer;
                }

            }
            else if (Player == Coup.Lizard)
            {
                if (Sheldon == Coup.Rock)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Paper)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Scissors)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Prosperity)
                {
                    return Scoreboard.VictoryPlayer;
                }

            }
            else if (Player == Coup.Prosperity)
            {
                if (Sheldon == Coup.Rock)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Paper)
                {
                    return Scoreboard.VictorySheldon;
                }
                else if (Sheldon == Coup.Scissors)
                {
                    return Scoreboard.VictoryPlayer;
                }
                else if (Sheldon == Coup.Lizard)
                {
                    return Scoreboard.VictorySheldon;
                }

            }

            return Scoreboard.Draw;

        }
        private Coup ReturnCoupPlayer(int choice)
        {
            return (Coup)choice;
        }
        private Coup ReturnCoupSheldon()
        {
            Random rnd = new Random();
            int choice = rnd.Next(5);
            PicSheldon.Image = imgSheldon[choice];
            return (Coup)choice;
        }

    }

    enum Coup
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2,
        Lizard = 3,
        Prosperity = 4
    }

    enum Scoreboard
    {
        VictorySheldon,
        VictoryPlayer,
        Draw
    }
}