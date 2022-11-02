using System.ComponentModel;
using System.Configuration;
using System.Globalization;

namespace CS311_Project2_CBN
{
    public partial class Form1 : Form
    {
        private double bank, bet;
        private int point;
        private bool firstRoll;

        public Form1()
        {
            InitializeComponent();
            bank = 100.00;
            firstRoll = true;
            lblBankBalance.Text = bank.ToString("C");
        }//end constructor

        private int[] rollDice()
        {
            var rand = new Random();
            int[] dice = new int[2];
            dice[0] = rand.Next(1,6);
            dice[1] = rand.Next(1,6);
            return dice;
        }//end rollDice

        private void calculate_score()
        {
            int[] dice = rollDice();
            int sum = dice[0] + dice[1];

            lblDiceValue1.Text = dice[0].ToString();
            lblDiceValue2.Text = dice[1].ToString();

            if(firstRoll)
            {
                switch (sum)
                {
                    case 7:
                    case 11:
                        lblResult.Text = "You win!";
                        bank += bet;
                        break;
                    case 2:
                    case 3:
                    case 12:
                        lblResult.Text = "You lose!";
                        bank -= bet;
                        break;
                    default:
                        point = sum;
                        firstRoll = false;
                        lblResult.Text = "Point is " + point;
                        break;
                }//end switch
            }//end if
            else
            {
                int[] newDice = rollDice();
                int newSum = newDice[0] + newDice[1];

                lblDiceValue1.Text = newDice[0].ToString();
                lblDiceValue2.Text = newDice[1].ToString();

                if (newSum == 7)
                {
                    lblResult.Text = "You lose!";
                    bank -= bet;
                    firstRoll = true;
                }//end if
                else if (newSum == point)
                {
                    lblResult.Text = "You win!";
                    bank += bet;
                    firstRoll = true;
                }//end else if    
            }//end else        

            lblBankBalance.Text = bank.ToString("C");
        }//end calculate_score

        private void btnRoll_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\$?\-?([1-9]{1}[0-9]{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))$|^\-?\$?([1-9]{1}\d{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))$|^\(\$?([1-9]{1}\d{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))\)$");

            if (!regex.IsMatch(txtEnterBet.Text))
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterBet.SelectAll();
            }//end if
            else if (regex.IsMatch(txtEnterBet.Text))
            {    
                bet = double.Parse(txtEnterBet.Text.Trim(new char[] {'$'})); 
            
                if (bank >= bet && bank != 0 && bet != 0)
                {
                    calculate_score();
                }//end if
                else lblResult.Text = "You don't have enough money.";
            }//end else if
        }//end btnRoll_Click
    }//end class
}//end namespace