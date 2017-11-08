using System;

namespace TicTacToe.Libr
{
    public class GameBoard
    {
        private string emptyCell = "*";

        private readonly string[,] ticTac;

        public string[,] TicTacData
        {
            get { return ticTac; }
        }
        public GameBoard()
        {
            ticTac = new string[3, 3];

            ClearGameBoard();
        }



        public void ClearGameBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                {
                    var s = emptyCell;
                    ticTac[i, j] = s;
                }
            }
        }

        public void PrintBoard()
        {
            System.Console.WriteLine("Tic Tac Toe board");


            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    System.Console.Write(ticTac[i, j] + "\t");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
        }

        public void WritePlayerTutnInBoard(Player player, PlayerTurn turn)
        {
            ticTac[turn.X, turn.Y] = player.Name;
        }

        public bool CheckWin()
        {
            int i, n = 3;
            var checkWinner = false;

            var playerX = "X";
            var playerO = "Y";

            
            for (i = 0; i < n; i++)
            { 
                //horizontall
                if ((ticTac[i, 0] == ticTac[i, 1]) &&
                    (ticTac[i, 1] == ticTac[i, 2]) &&
                    (ticTac[i, 0] != emptyCell))
                {
                    checkWinner = (true);
                }   
                
                //vertical
                if ((ticTac[0, i] == ticTac[1, i]) &&
                    (ticTac[1, i] == ticTac[2, i]) &&
                    (ticTac[0, i] != emptyCell))
                {
                    checkWinner = (true);
                }
            }
            
            //diagonal
            if (ticTac[1, 1] != emptyCell)
            {
                if ((ticTac[0, 0] == ticTac[1, 1]) &&
                    (ticTac[1, 1] == ticTac[2, 2]))
                {
                    checkWinner = (true);
                }

                if ((ticTac[0, 2] == ticTac[1, 1]) &&
                    (ticTac[1, 1] == ticTac[2, 0]))
                {
                    checkWinner = (true);
                }
            }

            return checkWinner;
        }
    }
}
