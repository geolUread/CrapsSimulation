using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

//This is a Craps Simulation game.In this game the user inputs the number of simulation they want run.
//The program will run upto 100 simulations.The maximum value can be edited in the upDownValue properties
//if the user wants to run more simulations.
//The program then runs, recording each games:
//-Dice value of die 1 and die 2
//-Sum of both dices
//-Whether or not Passing bet or don't pass bet won
//-The loss of both bets if dices rolls a 12 


//Released: March 15. 2021
//Updated: April 15. 2021
//Creator: GeolUread

namespace Craps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            output.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int sim = 0;
            if (numericUpDown1.Value == 0)
            {
                errorLabel.Visible = true;
            }
            else
            {
                //Converts the string into a integer
                sim = Convert.ToInt32(numericUpDown1.Value);
                crapsSimulation(sim);
                output.Visible = true;
            }
        }

        //This is used to kill the process in another function--an object of the process.
        System.Diagnostics.Process process = null;      

        private void retryButton_Click(object sender, EventArgs e)
        {
            output.Visible = false;
            start.Visible = true;
            //process.Kill();         //This stops the notepad from processing--effectively closing it
            numericUpDown1.Value = 0;
        }

        private void textFileButton_Click(object sender, EventArgs e)
        {
            //This opens the textfile application when clicked
            process = System.Diagnostics.Process.Start("C:\\...\\Craps_Data.txt");    
        }

        //--------------------------------------------------------------------------
        //Functions
        Random rnd1 = new Random();
        
        //Function to return the total of two dices rolled

        int die1Value()
        {
            int value = rnd1.Next(1, 7);
            return value;
        }

        int die2Value()
        {
            int value = rnd1.Next(1, 7);
            return value;
        }

        int roll(int x, int y)
        {
            int total = x + y;
            return total;
        }

        void crapsSimulation(int simNo)
        {
            int pTotal = 0; int dpTotal = 0;  int equalLossTotal = 0;  int total = simNo;       //Variable to display on the form

            //Arrays to hold the data to be transfered into excel file
            int[] diceNumbers = new int[simNo];        //Dyanmic array for dices
            int[] die1 = new int[simNo];
            int[] die2 = new int[simNo];

            int[] passWins = new int[simNo];            //Dynamic array for pass wins
            int[] dontPassWins = new int[simNo];      //Dynamic array for don't pass wins
            int[] equalLossWins = new int[simNo];

            int[] win = new int[simNo];                     //Passer win = 1, don't passer win = 2, equalLoss = 3
            int[] rolls = new int[simNo];

            //Variables
            int point = 0; int seven = 0;                   //Point, seven, p = passing, dp = don't pass, and diceRoll 
            int diceRoll = -1;

            for (int i = 0; i < simNo; i++)
            {
                int p = 0; int dp = 0; int equalLoss = 0;

                int x = die1Value(); int y = die2Value();
                diceRoll = roll(x, y);                               //Dice has been rolled for each simulation

                die1[i] = x; die2[i] = y;
                diceNumbers[i] = diceRoll;

                if (diceRoll == 7 || diceRoll == 11)      //If-else statement specific dice conditions
                {
                    p++;     dp = 0;    equalLoss = 0;                                    //Passing bet wins
                    win[i] = 1;
                    rolls[i] = 0;
                }
                else if (diceRoll == 2 || diceRoll == 3)
                {
                    dp++;    p = 0; equalLoss = 0;                                  //Don't pass bet wins
                    win[i] = 2;
                    rolls[i] = 0;
                }
                else if (diceRoll == 12)
                {
                    p = 0; dp = 0;   equalLoss = 1;                        //Both passing and don't passing lose
                    win[i] = 3;
                    rolls[i] = 0;
                }
                else
                {
                    point = diceRoll;                       //Set point to the diceRolled value
                    int temp;                           //Temp will be the variable the user has to get to equal point to win
                    bool done = false;
                    int pointRoll = 0;
                    while (!done)
                    {
                        x = die1Value(); y = die2Value();
                        temp = roll(x, y);                               //Dice has been rolled for each simulation
                        
                        if (temp == 7)
                        {
                            seven++;
                            dp++; p = 0; equalLoss = 0;
                            win[i] = 2;
                            done = true;
                        }
                        else if (temp == point)
                        {
                            p++;    dp = 0;  equalLoss = 0;
                            win[i] = 1;
                            done = true;
                        }
                        pointRoll++;
                    }

                    rolls[i] = pointRoll;
                }

                passWins[i] = p;
                dontPassWins[i] = dp;
                equalLossWins[i] = equalLoss;

                dpTotal = dpTotal + dp;          pTotal = pTotal + p;   equalLossTotal = equalLossTotal + equalLoss;
                transferData(total, die1, die2, diceNumbers, passWins, dontPassWins, equalLossWins, win, rolls);
            }//End of for-loop

            //Apply the info onto labels
            passerTLabel.Text = Convert.ToString(pTotal);

            dPasserTLabel.Text = Convert.ToString(dpTotal);

            equalLossLabel.Text = Convert.ToString(equalLossTotal);

            totalSim.Text = Convert.ToString(total);
        }


        //The following function will input the data from the simulation into an text file
        void transferData(int limit, int[] die1, int[] die2, int[] sum, int[] pwin, int[] dpwin, int[] twelve, int[] win, int[] roll)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\...\\Craps_Data.txt");   
            sw.WriteLine("# Rolls\tDie1\tDie2\tSum\tPWin\tDPWin\tTwelve\tCategoryWin\tPRolls");
            for (int i = 0; i < limit; i++)
            {
                sw.WriteLine(i + 1+"\t"+ die1[i]+ "\t"+die2[i]+ "\t"+sum[i]+ "\t"+pwin[i]+ "\t"+dpwin[i]+ "\t"+twelve[i]+"\t"+win[i]+"\t"+"\t"+roll[i]);
            }
            sw.Close();
        }
    }

}
