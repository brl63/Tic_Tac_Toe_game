using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.Properties;

namespace tic_tac_toe
{

    public partial class Form1 : Form
    {
        const string PlayerX = "X";
        const string PlayerO = "O";
        const string EmptyTag = "?";
        public Form1()
        {
            InitializeComponent();
        }


        private bool CheckIfButtonClickedalready(object sender)
        {
            if (((Button)sender).Tag.ToString()!=EmptyTag)
            {
                MessageBox.Show("That button already in use choose another one");
                return true;
            }
            return false;

        }
        private void TurnPlayer( object sender)
        {
            string Turn = lblTurn.Tag.ToString();

            if (Turn == PlayerX)
            {
                lblTurn.Tag = PlayerO;
                ((Button)sender).Tag = PlayerX;
                lblTurn.Text = "PlayerO";
            }
            else
            {
                lblTurn.Tag = PlayerX;
                ((Button)sender).Tag =PlayerO;
                lblTurn.Text = "PlayerX";
            }
        }
        private void SwitchImages(object sender) 
        {
            string Turn = lblTurn.Tag.ToString();

            if (Turn == PlayerX)
            {
                ((Button)sender).Image = Resources.X;
                return;

            }
            else
            {

                ((Button)sender).Image = Resources.O;
            }
        }

        private void PlayTurn(object sender)
        {

            SwitchImages(sender);
            TurnPlayer(sender);
            ViewWinnerDetails();
        }
        private void RestartGame()
        {
            foreach (Control ctrl in pnlGame.Controls)
            {
                if(ctrl is Button btn)
                {
                    btn.Tag = EmptyTag;
                    btn.Image = Resources.question_mark_96;
                    btn.Enabled = true;
                    btn.BackColor = Color.Transparent;
                }
            }
                lblTurn.Tag = PlayerX;
                lblTurn.Text = "PlayerX";
                lblWinner.Text = "In Progress";
                lblWinner.Tag = EmptyTag;
        }

        private enum enWinner
        {
            NULL=0, X = 1 ,O , draw
        }
        
        private enWinner ConvertTagToWinner(string Tag)
        {
            if (Tag == PlayerX)
            {
                return enWinner.X;
            }
            else if (Tag == PlayerO)
            {
                return enWinner.O;
            }
            else { return enWinner.draw; }
        }
        private enWinner CheckWinnerInRows()
        {
            if (btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag && btn1.Tag.ToString() != EmptyTag)
            {
                btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.GreenYellow;
                return ConvertTagToWinner(btn1.Tag.ToString());
            }
            else if (btn4.Tag == btn5.Tag && btn5.Tag == btn6.Tag && btn4.Tag.ToString() != EmptyTag)
            {
                btn4.BackColor = btn5.BackColor = btn6.BackColor = Color.GreenYellow;

                return ConvertTagToWinner(btn4.Tag.ToString());

            }
            else if (btn7.Tag == btn8.Tag && btn8.Tag == btn9.Tag && btn7.Tag.ToString() != EmptyTag)
            {
                btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.GreenYellow;


                return ConvertTagToWinner(btn7.Tag.ToString());

            }
            else
            {
                return enWinner.NULL;
            }


        }
        private enWinner CheckWinnerInColumns()
        {
            if (btn1.Tag == btn4.Tag && btn4.Tag == btn7.Tag && btn1.Tag.ToString() != EmptyTag)
            {
                btn1.BackColor = btn4.BackColor = btn7.BackColor = Color.GreenYellow;

                return ConvertTagToWinner(btn1.Tag.ToString());
            }
            else if (btn2.Tag == btn5.Tag && btn5.Tag == btn8.Tag && btn2.Tag.ToString() != EmptyTag)
            {

                btn2.BackColor = btn5.BackColor = btn8.BackColor = Color.GreenYellow;

                return ConvertTagToWinner(btn2.Tag.ToString());

            }
            else if (btn3.Tag == btn6.Tag && btn6.Tag == btn9.Tag && btn3.Tag.ToString() != EmptyTag)
            {
                btn3.BackColor = btn6.BackColor = btn9.BackColor = Color.GreenYellow;

                return ConvertTagToWinner(btn3.Tag.ToString());

            }
            else
            {
                return enWinner.NULL;
            }
        }

        private enWinner CheckWinnerInDiagonals()
        {
            if (btn1.Tag == btn5.Tag && btn5.Tag == btn9.Tag && btn1.Tag.ToString() != EmptyTag)
            {
                btn1.BackColor = btn5.BackColor = btn9.BackColor = Color.GreenYellow;

                return ConvertTagToWinner(btn1.Tag.ToString());
            }
            else if (btn3.Tag == btn5.Tag && btn5.Tag == btn7.Tag && btn3.Tag.ToString() != EmptyTag)
            {
                btn3.BackColor = btn5.BackColor = btn7.BackColor = Color.GreenYellow;

                return ConvertTagToWinner(btn3.Tag.ToString());

            }
            else
            {
                return enWinner.NULL;
            }
        }
        private void StopGame()
        {
            foreach (Control ctrl in pnlGame.Controls)
            {
                if(ctrl is Button btn)
                {
                    btn.Enabled = false;
                }
            }
        }

        private bool IsItDraw()
        {
            if (IsAllbuttonsChecked()) 
            {

                return true;

            }
            return false;
        }
        private bool IsAllbuttonsChecked()
        {
            foreach (Control ctrl in pnlGame.Controls)
            {
                if(ctrl is Button btn)
                {
                    if (btn.Tag.ToString() == EmptyTag)
                    {
                        return false;
                    }
                }
            }
            return true ;
        }
        private enWinner CheckWinner()
        {
            enWinner WinnerInRows = CheckWinnerInRows();
            if (WinnerInRows!= enWinner.NULL)
            {
                StopGame();
                return WinnerInRows;
            }

            enWinner WinnerInColumns = CheckWinnerInColumns();

            if (WinnerInColumns != enWinner.NULL)
            {
                StopGame();
                return WinnerInColumns;
            }

            enWinner WinnerInDiagonals = CheckWinnerInDiagonals();
            
            if(WinnerInDiagonals != enWinner.NULL)
            {
                StopGame();
                return WinnerInDiagonals;
            }

            if (IsItDraw())
            {
                StopGame();
                return enWinner.draw;
            }
            else
            {
                
            return enWinner.NULL;
            }
        }
        public void ViewWinnerDetails()
        {
            enWinner Winner = CheckWinner();

            switch (Winner)
            {
                case enWinner.NULL:
                    return;
                case enWinner.X:
                    lblWinner.Text = "PlayerX";
                    lblWinner.Tag = PlayerX;
                    MessageBox.Show("Player X Wins");
                    
                    break;
                case enWinner.O:
                    lblWinner.Text = "PlayerO";
                    lblWinner.Tag = PlayerO;
                    MessageBox.Show("Player O Wins");
                    break;
                default:
                    lblWinner.Text = "Draw";
                    lblWinner.Tag = "Draw";
                    MessageBox.Show("Its A Draw");
                    break;

                    
            }
                
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void btnClick(object sender, EventArgs e)
        {
            if (CheckIfButtonClickedalready(sender))
            {
                return;
            }
            PlayTurn(sender);
        }
    }
}
