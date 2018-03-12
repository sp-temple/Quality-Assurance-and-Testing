using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_TicTacToe
{
    public class TicTacToe
    {
        //Declarations//
        private BoardToken playerTurn;  // Enum value will represent the player turn
        private const int ROWS = 3;     // The amount of rows the tic tac board will have
        private const int COLUMNS = 3;  // The amount of columns the tic tac board will have
        private BoardToken[,] board;    // Will use a board based of the enum values

        // Will be used for the tic tac toe board
        public enum BoardToken
        {
            /** 
                - Board tokens (Empty,  " X's ", and " O's ") are set to a number 
                  that will indicate a status for that token 
            **/
            Empty = 0, // Represents an empty space
            X = 1,     // Represents an "X"
            O = 2      // Represents an "O"
        }

        // 1st Method
        public void CreateBoard()
        {
            /** 
                - Using the enum to make a copy of the board using 3 columns and 3 rows
                  that will be used in a GUI
            **/
            BoardToken[,] boardCopy = new BoardToken[ROWS, COLUMNS];

            /**
                - Goes through each of the rows and columns and copy the "board" to 
                  "boardCopy"
            **/
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLUMNS; col++)
                {
                    boardCopy[row, col] = board[row, col];
                }
            }

        }

        // 2nd Method
        public bool IsTurn(BoardToken value)
        {
            /**
                Checks to see if the "playerturn" is the value of the enum which
                designate an X or an O
            **/ 
            if (playerTurn == value)
                return true;
            else
                return false;
        }

        // 3rd Method
        public bool ChangePlayer()
        {

            // Switch turns after placing a board token for the designated player
            if (playerTurn == BoardToken.X)
                playerTurn = BoardToken.O;
            else if (playerTurn == BoardToken.O)
                playerTurn = BoardToken.X;

            return true;

        }

        // 4th Method
        public bool MakeMove(int row, int col)
        {   
            // If the game is not over
            if (!(GameOver()))
            {
                // If the board space is empty
                if (board[row, col] == BoardToken.Empty)
                {
                    // The board space will be filled with what the player chose for their turn 
                    board[row, col] = playerTurn;
                    // would also probably need to call changeplayer, not exactly sure though...

                    return true;
                }
            }

            return false;
        }

        // 5th Method
        public bool SpaceInUse(int row, int col)
        {
            // If the board space is not empty
            if (board[row, col] != BoardToken.Empty)
            {
                // The board space is in use
                return false;
            }
            // The board space is not in use
            return true;
        }

        public bool GameOver()
        {
            return true;
        }
    }
}
