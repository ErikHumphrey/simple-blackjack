/* ______  _               _     _               _    
  | ___ \| |             | |   (_)             | |   
  | |_/ /| |  __ _   ___ | | __ _   __ _   ___ | | __
  | ___ \| | / _` | / __|| |/ /| | / _` | / __|| |/ /
  | |_/ /| || (_| || (__ |   < | || (_| || (__ |   < 
  \____/ |_| \__,_| \___||_|\_\| | \__,_| \___||_|\_\
                              _/ |                   
                             |__/                      */

/* Author: Erik Humphrey
 * Project title: Project 15 - Simple 21 / Virtual Blackjack
 * Date started: November 27rd
 * Executable name: HumphreyErikBlackjack.exe
 * Description: Blackjack / twenty-one game based on probability versus a computer AND the dealer
*/

/*** Notes ***
 * User refers to the human player
 * CPU refers to the computer
 * Redundant code, ahoy!
 * 
 *** KNOWN BUGS ***
 * Game breaks, especially when Standing. Don't know why, since all outcomes are still tested possible. Would fix with more time.
        I added an error message for when this happens.
 * MAJOR: Game breaks if computer draws less cards due to having less than 16 points
 * Computer will sometimes draw cards 1, 2, and 4 without drawing card 3
 * 
 *** WHAT I ADDED ***
 * Betting/jackpot system
 * Six outcomes: Win by higher number, Win by <21, Lose by lower number, Lose by >21, Good Draw, Bad Draw
 * All outcomes happen at end, it is not tallied when the card is drawn
 * It should be pretty hard to cheat
 * 
 *** WHAT I DIDN'T ADD ***
 * Kings, queens, jack, ace
 * Card images
 * Hitting beyond 4 cards 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErikBlackjack
{
    public partial class frmBlackjack : Form
    {
        // Global declarations
        int cpuFourSidedDieRoll;
        Random rnd = new Random();
        int gamePhase = 1;
        string userOutcome;
        int cardUser1;
        int cardUser2;
        int cardUser3;
        int cardUser4;
        int cardCPU1;
        int cardCPU2;
        int cardCPU3;
        int cardCPU4;
        int scoreUser = 0;
        int scoreCPU = 0;

        public frmBlackjack()
        {
            InitializeComponent();
        }

        private void frmBlackjack_Load(object sender, EventArgs e)
        {
            this.Width = 510; // Starting width of the form, just in case.
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            if (gamePhase == 1)
            {
                btnPlaceBet.Enabled = true;
                txtUserBetEntry.ReadOnly = false;
                txtCPUBetEntry.Text = "...";
                txtUserBetEntry.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                DialogResult wantsNewGame = MessageBox.Show("Are you sure you want to start a new game? All progress will be lost!", "New game", MessageBoxButtons.YesNo);
                if (wantsNewGame == DialogResult.Yes)
                {
                    // Reset properties etc for the new game
                    btnPlaceBet.Visible = true;
                    txtUserBetEntry.BackColor = System.Drawing.Color.IndianRed;
                    txtUserBetEntry.ForeColor = System.Drawing.SystemColors.WindowText;
                    txtCPUBetEntry.Text = "...";
                    txtUserBetEntry.ReadOnly = false;
                    lblBlackjackSplash.Visible = true;
                    lblJackpot.Visible = false;
                    this.Width = 510;
                    lblCardCPU1.Text = null;
                    lblCardCPU2.Text = null;
                    lblCardCPU3.Text = null;
                    lblCardCPU4.Text = null;
                    lblCardUser1.Text = null;
                    lblCardUser2.Text = null;
                    lblCardUser3.Text = null;
                    lblCardUser4.Text = null;
                    gamePhase = 1;
                    lblObstructCPU1.Visible = true;
                    lblObstructCPU2.Visible = true;
                    lblObstructCPU3.Visible = true;
                    txtUserBetEntry.Clear();
                    lblChildrenCantGamble.Location = new Point(371, 6);
                    lblJackpot.Text = "Jackpot: $";
                    lblScoreUser.Text = "Player score: ";
                    lblScoreCPU.Text = "Computer score: ";
                    scoreCPU = 0;
                    scoreUser = 0;
                }
            }
        }

        // Only allow digits to be typed as bets, like in a NumericUpDown. No minus sign/decimal point/letters.

        private void txtUserBetEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            // Configurable min/max bets
            const int MINIMUM_BET = 1000;
            const int MAXIMUM_BET = 9999;

            // Check if bet exceeds max or does not exceed minimum
            if (Int32.Parse(txtUserBetEntry.Text) < MINIMUM_BET)
            {
                MessageBox.Show("The minimum bet is " + MINIMUM_BET + ".", "Bet too low", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUserBetEntry.Text = string.Empty; // Clear the bet
            }

            else if (Int32.Parse(txtUserBetEntry.Text) > MAXIMUM_BET)
            {
                MessageBox.Show("The maximum bet is " + MAXIMUM_BET + ".", "Bet too high", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserBetEntry.Text = string.Empty;
            }
            else
            {
                int userBet = Int32.Parse(txtUserBetEntry.Text);
                int computerBet = 0;

                lblScoreUser.Text = lblScoreUser.Text + "0";
                lblBlackjackSplash.Visible = false;
                lblJackpot.Visible = true;
                btnPlaceBet.Visible = false;
                txtUserBetEntry.ReadOnly = true;
                txtUserBetEntry.BackColor = System.Drawing.Color.Brown;
                txtUserBetEntry.ForeColor = System.Drawing.Color.White;

                computerBet = rnd.Next(1000, MAXIMUM_BET + 1);
                txtCPUBetEntry.Text = computerBet.ToString(); // Not converted to currency, no decimals are used
                int jackpot = userBet + computerBet;
                lblJackpot.Text = lblJackpot.Text + jackpot;

                MessageBox.Show(
                "You bet $" + txtUserBetEntry.Text +
                "\r\nComputer bets $" + computerBet +
                "\r\n\r\nJackpot set to $" + (jackpot) + "\r\nFirst two cards will be dealt to players.",
                "Blackjack", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cpuFourSidedDieRoll = rnd.Next(1, 5); // Computer will have a 25% chance to hit again during phase 3

                // Draw two cards with a value of 1-10 for the player
                lblCardUser1.Text = (rnd.Next(1, 11)).ToString();
                lblCardUser2.Text = (rnd.Next(1, 11)).ToString();

                // Update user score with sum of first two card values
                int totalTwoCards = Int32.Parse(lblCardUser1.Text) + Int32.Parse(lblCardUser2.Text);
                lblScoreUser.Text = "Player score: " + totalTwoCards.ToString();

                // Draw the computer's cards
                lblCardCPU1.Text = (rnd.Next(1, 11)).ToString();
                lblCardCPU2.Text = (rnd.Next(1, 11)).ToString();

                // Allow the player to make a move
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                gamePhase = 2;

            }
        }

        // User clicks Hit button.

        private void btnHit_Click(object sender, EventArgs e)
        {
            /* With two cards, the computer will hit based on the number being below 16 or not.
             * With three cards, the computer will hit based on a 25% chance. */

            // User hits with two cards
            if (gamePhase == 2)
            {
                lblCardUser3.Text = (rnd.Next(1, 11)).ToString();
                int totalThreeCards = Int32.Parse(lblCardUser1.Text) + Int32.Parse(lblCardUser2.Text) + Int32.Parse(lblCardUser3.Text);
                lblScoreUser.Text = "Player score: " + totalThreeCards.ToString();
                // Computer will hit and get a third card if the value of its first two cards is less than 16
                if (Int32.Parse(lblCardCPU1.Text) + Int32.Parse(lblCardCPU2.Text) < 16)
                    lblCardCPU3.Text = (rnd.Next(1, 11)).ToString();
                gamePhase = 3;
            }

            // User hits with 3 cards
            else if (gamePhase == 3)
            {
                this.Width = this.Width + 64; // Make the form wider to fit the new card slots
                lblChildrenCantGamble.Left += 64; // Move the gambling notice to the right accordingly
                lblCardUser4.Text = (rnd.Next(1, 11)).ToString();
                int totalFourCards = Int32.Parse(lblCardUser1.Text) + Int32.Parse(lblCardUser2.Text) + Int32.Parse(lblCardUser3.Text) + Int32.Parse(lblCardUser4.Text);
                lblScoreUser.Text = "Player score: " + totalFourCards.ToString();

                // If the computer rolled a 1 at the start, show and display a value on a fourth card.
                if (cpuFourSidedDieRoll == 1)
                {
                    lblCardCPU4.Text = (rnd.Next(1, 11)).ToString();
                }

                // Prevent any more hitting or betting
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                // Unobstruct the computer's cards
                lblObstructCPU1.Visible = false;
                lblObstructCPU2.Visible = false;
                lblObstructCPU3.Visible = false;

                // Attempt to parse card text so it doesn't crash with the lack of a third or fourth card
                bool checkUser3;
                bool checkUser4;
                bool checkCPU3;
                bool checkCPU4;

                Int32.TryParse(lblCardUser1.Text, out cardUser1);
                Int32.TryParse(lblCardUser2.Text, out cardUser2);
                checkUser3 = Int32.TryParse(lblCardUser3.Text, out cardUser3);
                checkUser4 = Int32.TryParse(lblCardUser4.Text, out cardUser4);

                Int32.TryParse(lblCardCPU1.Text, out cardCPU1);
                Int32.TryParse(lblCardCPU2.Text, out cardCPU2);
                checkCPU3 = Int32.TryParse(lblCardCPU3.Text, out cardCPU3);
                checkCPU4 = Int32.TryParse(lblCardCPU4.Text, out cardCPU4);

                // Add the values of each player's cards
                scoreUser = cardUser1 + cardUser2 + cardUser3 + cardUser4;
                scoreCPU = cardCPU1 + cardCPU2 + cardCPU3 + cardCPU4;

                // Reveal computer score in label
                lblScoreCPU.Text = lblScoreCPU.Text + scoreCPU;

                string results = "You scored " + scoreUser + " points" +
                             "\r\nComputer scored " + scoreCPU + " points"
                           + "\r\n\r\n";

                // User loses by going over 21 points 
                if (scoreCPU < 21 && scoreUser > 21)
                {
                    userOutcome = "Game over";
                    MessageBox.Show(results + "Player went over 21.\r\nComputer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                // Computer loses by going over 21 points
                else if (scoreCPU > 21 && scoreUser < 21)
                {
                    userOutcome = "You win";
                    MessageBox.Show(results + "Computer went over 21.\r\nPlayer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                // User wins by having more points than computer
                else if (scoreUser > scoreCPU && scoreUser < 21)
                {
                    userOutcome = "You win";
                    MessageBox.Show(results + "You win the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                // Computer wins by having more points than user
                else if (scoreUser < scoreCPU && scoreCPU > 21)
                {
                    userOutcome = "Game over";
                    MessageBox.Show(results + "Computer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                // User and computer win by having equal points below 21
                else if (scoreUser == scoreCPU && scoreUser < 21)
                {
                    userOutcome = "Good draw!";
                    MessageBox.Show(results + "Both players win!\r\nJackpot is split amongst players", userOutcome, MessageBoxButtons.OK);
                }
                // User and computer lose by having points above 21
                else if (scoreUser > 21 && scoreCPU > 21)
                {
                    userOutcome = "Bad draw!";
                    MessageBox.Show(results + "Both players lose!\r\nDealer wins the jackpot!", userOutcome, MessageBoxButtons.OK);
                }
                // Sloppy coding results in the game to end with no result for some reason
                else
                {
                    MessageBox.Show("An error occurred, and for some reason the game's outcome could not be determined. Start a new game, you'll be luckier next time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the program
        }

        // Player clicks stand button, not drawing a card and ending the game.
        // Not flawless.

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (gamePhase == 2)
            {
                // Computer will hit and get a third card if the value of its first two cards is less than 16
                if (Int32.Parse(lblCardCPU1.Text) + Int32.Parse(lblCardCPU2.Text) < 16)
                    lblCardCPU3.Text = (rnd.Next(1, 11)).ToString();

                // Game ends (computer can only ever get a fourth card if the user got at least 3 cards)

                btnHit.Enabled = false;
                btnStand.Enabled = false;

                lblObstructCPU1.Visible = false;
                lblObstructCPU2.Visible = false;
                lblObstructCPU3.Visible = false;

                bool checkUser3;
                bool checkUser4;
                bool checkCPU3;
                bool checkCPU4;

                Int32.TryParse(lblCardUser1.Text, out cardUser1);
                Int32.TryParse(lblCardUser2.Text, out cardUser2);
                checkUser3 = Int32.TryParse(lblCardUser3.Text, out cardUser3);
                checkUser4 = Int32.TryParse(lblCardUser4.Text, out cardUser4);

                Int32.TryParse(lblCardCPU1.Text, out cardCPU1);
                Int32.TryParse(lblCardCPU2.Text, out cardCPU2);
                checkCPU3 = Int32.TryParse(lblCardCPU3.Text, out cardCPU3);
                checkCPU4 = Int32.TryParse(lblCardCPU4.Text, out cardCPU4);
                scoreUser = cardUser1 + cardUser2 + cardUser3 + cardUser4;
                scoreCPU = cardCPU1 + cardCPU2 + cardCPU3 + cardCPU4;

                lblScoreCPU.Text = lblScoreCPU.Text + scoreCPU;

                string results = "You scored " + scoreUser + " points" +
                             "\r\nComputer scored " + scoreCPU + " points"
                           + "\r\n\r\n";

                if (scoreCPU < 21 && scoreUser > 21)
                {
                    userOutcome = "Game over";
                    MessageBox.Show(results + "Player went over 21.\r\nComputer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreCPU > 21 && scoreUser < 21)
                {
                    userOutcome = "You win";
                    MessageBox.Show(results + "Computer went over 21.\r\nPlayer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser > scoreCPU && scoreUser < 21)
                {
                    userOutcome = "You win";
                    MessageBox.Show(results + "You win the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser < scoreCPU && scoreCPU > 21)
                {
                    userOutcome = "Game over";
                    MessageBox.Show(results + "Computer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser == scoreCPU && scoreUser < 21)
                {
                    userOutcome = "Good draw!";
                    MessageBox.Show(results + "Both players win!\r\nJackpot is split amongst players", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser > 21 && scoreCPU > 21)
                {
                    userOutcome = "Bad draw!";
                    MessageBox.Show(results + "Both players lose!\r\nDealer wins the jackpot!", userOutcome, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("An error occurred, and for some reason the game's outcome could not be determined. Start a new game, you'll be luckier next time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (gamePhase == 3)
            {
                if (cpuFourSidedDieRoll == 1)
                {
                    this.Width = this.Width + 64;
                    lblChildrenCantGamble.Left = 64;
                    lblCardCPU4.Text = (rnd.Next(1, 11)).ToString();
                }

                btnHit.Enabled = false;
                btnStand.Enabled = false;

                bool checkUser3;
                bool checkUser4;
                bool checkCPU3;
                bool checkCPU4;

                lblObstructCPU1.Visible = false;
                lblObstructCPU2.Visible = false;
                lblObstructCPU3.Visible = false;

                Int32.TryParse(lblCardUser1.Text, out cardUser1);
                Int32.TryParse(lblCardUser2.Text, out cardUser2);
                checkUser3 = Int32.TryParse(lblCardUser3.Text, out cardUser3);
                checkUser4 = Int32.TryParse(lblCardUser4.Text, out cardUser4);

                Int32.TryParse(lblCardCPU1.Text, out cardCPU1);
                Int32.TryParse(lblCardCPU2.Text, out cardCPU2);
                checkCPU3 = Int32.TryParse(lblCardCPU3.Text, out cardCPU3);
                checkCPU4 = Int32.TryParse(lblCardCPU4.Text, out cardCPU4);
                scoreUser = cardUser1 + cardUser2 + cardUser3 + cardUser4;
                scoreCPU = cardCPU1 + cardCPU2 + cardCPU3 + cardCPU4;

                lblScoreCPU.Text = lblScoreCPU.Text + scoreCPU;

                string results = "You scored " + scoreUser + " points" +
                             "\r\nComputer scored " + scoreCPU + " points"
                           + "\r\n\r\n";

                if (scoreCPU < 21 && scoreUser > 21)
                {
                    userOutcome = "Game over";
                    MessageBox.Show(results + "Player went over 21.\r\nComputer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreCPU > 21 && scoreUser < 21)
                {
                    userOutcome = "You win";
                    MessageBox.Show(results + "Computer went over 21.\r\nPlayer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser > scoreCPU && scoreUser < 21)
                {
                    userOutcome = "You win";
                    MessageBox.Show(results + "You win the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser < scoreCPU && scoreCPU > 21)
                {
                    userOutcome = "Game over";
                    MessageBox.Show(results + "Computer wins the jackpot", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser == scoreCPU && scoreUser < 21)
                {
                    userOutcome = "Good draw!";
                    MessageBox.Show(results + "Both players win!\r\nJackpot is split amongst players", userOutcome, MessageBoxButtons.OK);
                }
                else if (scoreUser > 21 && scoreCPU > 21)
                {
                    userOutcome = "Bad draw!";
                    MessageBox.Show(results + "Both players lose!\r\nDealer wins the jackpot!", userOutcome, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("An error occurred, and for some reason the game's outcome could not be determined. Start a new game, you'll be luckier next time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
