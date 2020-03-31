using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: David Porteš
namespace OriginalChessClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //wtg - white time game
        //btg - black time game
        //btp - black time pause
        //wtp - white time pause
        //tapt - time add per turn
        //xxxl - label
        //xxxtxt - textbox
        //ttxt = Turn textbox


        private void startb_Click(object sender, EventArgs e)
        {
            //hide buttons and unhide labels 
            wtgl.Visible = true;
            btgl.Visible = true;
            btgtxt.Visible = true;
            wtgtxt.Visible = true;
            btpl.Visible = false;
            btptxt.Visible = false;
            wtpl.Visible = false;
            wtptxt.Visible = false;
            taptl.Visible = false;
            tapttxt.Visible = false;
            startb.Visible = false;
            ttxt.Visible = true;

            //Timer for white
            counterW = Convert.ToInt32(wtptxt.Value) * 60;           
            timer1.Interval = 1000; // 1 second
            TimeSpan counterW2 = TimeSpan.FromSeconds(counterW);
            wtgtxt.Text = counterW2.ToString(@"hh\:mm\:ss");

            //Timer for black
            counterB = Convert.ToInt32(btptxt.Value) * 60;
            timer2.Interval = 1000; // 1 second
            TimeSpan counterB2 = TimeSpan.FromSeconds(counterB);
            btgtxt.Text = counterB2.ToString(@"hh\:mm\:ss");

            //Unfocus button, so you  can press space and game will start
            this.Focus();
        }
        //WHITE TIMER TICK
        private void timer1_Tick(object sender, EventArgs e)
        {
            //-1s in timer
            counterW--;
            //update timer with each tick
            TimeSpan counterW2 = TimeSpan.FromSeconds(counterW);
            wtgtxt.Text = counterW2.ToString(@"hh\:mm\:ss");
            //when timer hits 0, stop timers and show Lost message
            if (counterW == 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Černý vyhrál, bílému došel čas");
            }

        }

        //BLACK TIMER TICK
        private void timer2_Tick(object sender, EventArgs e)
        {
            //-1s in timer
            counterB--;
            //update timer with each tick
            TimeSpan counterB2 = TimeSpan.FromSeconds(counterB);
            btgtxt.Text = counterB2.ToString(@"hh\:mm\:ss");
            //when timer hits 0, stop timers and show Lost message
            if (counterB == 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Bílý vyhrál, černýmu došel čas");
            }

        }
        int counterW; // preset time from user for White
        int counterB;// preset time from user for black            
        string turn = "white"; // White = White, Black = Black
        int pause = 0; //0= play, 1 = pause
        int start = 0;// 0=game has not started, 1= Game started
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {                     
            //When you press space you swap turns
            if (e.KeyCode == Keys.Space)
            {
                //preventing start game getting X s for starting game 
                if (start == 0)
                {
                        timer1.Start();
                        start = 1;
                        turn = "white";
                }
                else
                {
                    //IF TURN == 0 [If it´s white turn when you press clock] swap turn to Black -> White pressing clocks and Black timer starting
                    if (turn == "white")
                    {

                        timer1.Stop();
                        timer2.Start();
                        turn = "black";
                        counterW += Convert.ToInt32(tapttxt.Value);
                        TimeSpan counterW2 = TimeSpan.FromSeconds(counterW);
                        wtgtxt.Text = counterW2.ToString(@"hh\:mm\:ss");

                    }
                    //Else it has to be TURN black and swap turn to White -> Black pressing clock and White timer starting
                    else
                    {
                        timer2.Stop();
                        timer1.Start();
                        turn = "white";
                        counterB += Convert.ToInt32(tapttxt.Value);
                        TimeSpan counterB2 = TimeSpan.FromSeconds(counterB);
                        btgtxt.Text = counterB2.ToString(@"hh\:mm\:ss");
                    }
                }
                //If turn is white, write into txt "Na tahu je bílý"
                if(turn == "white")
                {
                   ttxt.Text = "Na tahu je bílý";
                }
                //Else turn is black, write into txt "Na tahu je černý"
                else
                {
                    ttxt.Text = "Na tahu je černý";
                }
            }
            //Pause game
            if(e.KeyCode == Keys.P)
            { //If game is not paused, pause timers and show message "Hra pozastavena"
                if(pause==0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Hra pozastavena");
                    pause = 1;
                }
                //if game is paused 
                else
                {//and it was White turn, start timer for white
                    if (turn == "white")
                    {
                        timer1.Start();
                    }
                    //and it was Black turn, start timer for black
                    else
                    {
                        timer2.Start();
                    }
                    pause = 0;
                }
            }
        }
    }
}

