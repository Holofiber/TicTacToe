using System;
using System.Collections.Generic;

namespace TicTacToe.Libr
{

    public class GameBoard
    {
        List<int> checkWinList = new List<int>();
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
            int j, i, lineSize = 3;
            var checkWinner = false;
            

            var playerX = "X";
            var playerO = "Y";


            int axisX = PlayerTurn.x;
            int axisY = PlayerTurn.y;


            for (i = axisX + 1; i < axisX + lineSize; i++)
            {
                checkHorizontal(i);
                checkVertical(i);
                checkDiagonal1(i);
            }


           
           

            return checkWinner;
        }

        public void checkVertical(int i)
        {

        }

        public void checkHorizontal(int i)
        {
        }

        public void checkDiagonal1(int i)
        {
        }

        public void checkWin(int i)
        {
            checkWinList.Add(i);
        }

        public void cleanList(int i)
        {
            checkWinList.Clear();
        }
    }
}