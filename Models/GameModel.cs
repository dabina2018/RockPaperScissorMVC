using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;



namespace MyFirstMVC.Models
{
    public class GameModel
    {
        
        //Class properties
        private Timer _timer;
        public Timer timer1
        {
            get { return _timer; }
            set 
            { 
                _timer = new Timer(new TimerCallback(GamePlay));
                //_timer.Change(0, 5000);
            }
                        
        }
                
        //-----declaring the variables for this game
         public int rounds = 3; // 3 rounds per game
         public int _ticker = 5; // 5 seconds per round

         //-----player choice options stored inside of an array
         string[] computerChoice = { "rock", "paper", "scissor", "paper" };
         
        public int randomNumber;
         string command;
         Random rnd = new Random();
         string playerChoice;
         int playerWins = 0;
         int computerWins = 0;
          
        

        public void GamePlay(object state)
        {
            //roundNumLabel.Text = Convert.ToString(rounds);
            _ticker--; //reduce the timeby1
            //timerCntLabel.Text = Convert.ToString(_ticker); //show the time on the screen
            if (_ticker < 1)//if the time is less then one second
            {
                timer1.Change(0,5000); //timer will restart if its less than one second left

                _ticker = 5; // set the timer back to 5 seconds
                randomNumber = rnd.Next(0, 3); // randomize the number again
                command = computerChoice[randomNumber]; // computer choice will be the random number

                //a switch statment will show the computer choice and change the picture box accordingly
                //TO DO html image ref tags
                switch (command)
                {
                    case "rock":
                        //pictureBox2.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        //pictureBox2.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        //pictureBox2.Image = Properties.Resources.scissor;
                        break;

                    default:
                        break;
                }

                //if there are still more rounds to play, the chcek game function will run
                if (rounds > 1)
                {
                    checkGame();
                }
                //if no rounds remaining to play, go to final decision engine
                else
                {
                    decisionEngine();
                }

            }
            
        }

        private void checkGame()
        {
            if (playerChoice == "rock" && command == "paper")
            {
                //MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "paper" && command == "rock")
            {
                //MessageBox.Show("player Wins");
                playerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "paper" && command == "scissor")
            {
               //MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();

            }
            else if (playerChoice == "scissor" && command == "paper")
            {
                //MessageBox.Show("Player Wins");
                playerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "scissor" && command == "rock")
            {
                //MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "rock" && command == "scissor")
            {
                //MessageBox.Show("Player Wins");
                playerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "rock" && command == "paper")
            {
                //MessageBox.Show("Computer Wins");
                computerWins++;
                rounds--;
                nextRound();
            }
            else if (playerChoice == "none")
            {
                //MessageBox.Show(player1NameLabel.Text + "Make a choice");
                nextRound();
            }
            else
            {
                //MessageBox.Show("Draw");
                nextRound();
            }

        }

        private void decisionEngine()
        {
            if (playerWins > computerWins)
            {
                //winnerLabel.Text = player1NameLabel.Text + "Wins the game";

            }
            else
            {
                //winnerLabel.Text = " Computer wins the game";
            }
        }

        private void nextRound()
        {
            playerChoice = "none";
            //pictureBox1.Image = Properties.Resources.question;
            timer1.Change(0,5000);
            //pictureBox2.Image = Properties.Resources.question;
        }

       
        

    }
}