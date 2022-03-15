using System;
using System.Windows.Forms;

namespace TicTacToeSim
{
    public partial class Form1 : Form
    {
        //global variables
        //hold data for tictactoe game
        string[,] txtArray;
        int[,] numArray;

        //hold count x & y
        int xCount;
        int oCount;

        public Form1()
        {
            InitializeComponent();
            //method to set up board
            SetUp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetUp()
        {
            //array to hold x/o
            txtArray = new string[3, 3];
            //array to hold index
            numArray = new int[3, 3];

        }

        //array to hold randomized letters based on RNG Rando 0 = O and 1 = X
        private void RandomArray()
        {
            Random rando = new Random();
            //as long as index is less than 3, add new letter to col
            for (int col = 0; col < 3; col++)
            {
                //as long as the index is less than 3, add new letter to row
                for (int row = 0; row < 3; row++)
                {
                    numArray[col, row] = rando.Next(0, 2);

                    //if the numArray at index col,row is... 
                    switch (numArray[col, row])
                    { 
                    
                        // is 0, then print letter O to txtArray and add 1 to oCount
                        case 0:
                            txtArray[col, row] = "O";
                            oCount++;
                            break;

                        //is 1, then print letter X to txtArray and add 1 to xCount
                        default:
                            txtArray[col, row] = "X";
                            xCount++;
                            break;
                    }
                }
            }
        }

        //prints the values held in txtArray to the form's output labels 
        private void ShowXandO()
        {
            //display randomized X & O 
            xAndOsLabel0.Text = txtArray[0, 0];
            xAndOsLabel1.Text = txtArray[0, 1];
            xAndOsLabel2.Text = txtArray[0, 2];
            xAndOsLabel3.Text = txtArray[1, 0];
            xAndOsLabel4.Text = txtArray[1, 1];
            xAndOsLabel5.Text = txtArray[1, 2];
            xAndOsLabel6.Text = txtArray[2, 0];
            xAndOsLabel7.Text = txtArray[2, 1];
            xAndOsLabel8.Text = txtArray[2, 2];
        }
        //checks for win diagonally, per col, per row
        //diagonal winner?
        private Boolean IsDiagWin(string val)
        {
            //check diag right to left vals
            if ((txtArray[0, 2] == txtArray[1, 1]) &&
                (txtArray[1, 1] == txtArray[2, 0]))
            {
                if (txtArray[1, 1].Equals(val))
                    return true;
            }

            //check diag left to right vals
            if ((txtArray[0, 0] == txtArray[1, 1]) &&
                (txtArray[1, 1] == txtArray[2, 2]))
            {
                if (txtArray[0, 0].Equals(val))
                    return true;
            }
            return false;
        }

        //column winner?
        private Boolean IsColWin(string val)
        {
            //iterate over and col check vals
            for (int x = 0; x < 3; x++)
            {
                if ((txtArray[0, x] == txtArray[1, x]) &&
                    (txtArray[1, x] == txtArray[2, x]))
                {
                    if (txtArray[x, 0].Equals(val))
                        return true;
                }
            }
            return false;
        }

        //row winner?
        private Boolean IsRowWin(string val)
        {
            //iterate over and check row vals
            for (int x = 0; x < 3; x++)
            {
                if ((txtArray[x, 0] == txtArray[x, 1]) &&
                    (txtArray[x, 0] == txtArray[x, 2]))
                {
                    if (txtArray[x, 0].Equals(val))
                        return true;
                }
            }
            return false;
        }

        //prints the winning X or O, and if tied.
        private void IsWinner()
        {
            if ((IsDiagWin("X")) || (IsColWin("X")) || (IsRowWin("X")))
            {
                winOutputLabel.Text = "The X has Won!";
            }
            else if ((IsDiagWin("O")) || (IsColWin("O")) || (IsRowWin("O")))
            {
                winOutputLabel.Text = "The O has Won!";
            }
            else
                winOutputLabel.Text = "X and O have Tied!";
        }

        private void clearGame()
        {
            xAndOsLabel0.Text = "T";
            xAndOsLabel1.Text = "I";
            xAndOsLabel2.Text = "C";
            xAndOsLabel3.Text = "T";
            xAndOsLabel4.Text = "A";
            xAndOsLabel5.Text = "C";
            xAndOsLabel6.Text = "T";
            xAndOsLabel7.Text = "O";
            xAndOsLabel8.Text = "E";
            winOutputLabel.Text = "PRESS PLAY TO TRY AGAIN!";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                clearGame();
                SetUp();
                RandomArray();
                ShowXandO();
                IsWinner();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
