using System.Text;

namespace TicTacToeApp.Logic
{
    public class TicTacToeBoard
    {
        private char[,] _board = new char[3, 3];

        public TicTacToeBoard()
        {
            char space = ' ';
            int maxRowIndex = _board.GetUpperBound(0);
            int maxColIndex = _board.GetUpperBound(1);
            for (int i = 0; i <= maxRowIndex; i++)
            {
                for (int j = 0; j <= maxColIndex; j++)
                {
                    _board[i, j] = space;
                }
            }
        }

        public char this[int i, int j]
        {
            get { return _board[i, j]; }
        }

        public bool InsertX(int row, int column)
        {
            bool result = false;
            if(row >= 0 && row <= _board.GetUpperBound(0) && column >= 0 && column <= _board.GetUpperBound(1))
            {
                if(_board[row, column] == ' ')
                {
                    _board[row, column] = 'X';
                    result = true;
                } 
            }

            return result;
        }

        public bool InsertO(int row, int column)
        {
            bool result = false;
            if (row >= 0 && row <= _board.GetUpperBound(0) && column >= 0 && column <= _board.GetUpperBound(1))
            {
                if (_board[row, column] == ' ')
                {
                    _board[row, column] = 'O';
                    result = true;
                }
            }

            return result;
        }

        public char ReportResult()
        {

            char result = 'N';
            if (XWins())
            {
                result = 'X';
            }
            else if (OWins())
            {
                result = 'O';
            }
            else if (BoardFull())
            {
                result = 'D';
            }
            
            
            return result;
        }

        private bool BoardFull()
        {
            bool result = false;
            int count = 0;
            char space = ' ';
            int maxRowIndex = _board.GetUpperBound(0);
            int maxColIndex = _board.GetUpperBound(1);
            for (int i = 0; i <= maxRowIndex; i++)
            {
                for (int j = 0; j <= maxColIndex; j++)
                {
                    if(_board[i, j] != space)
                    {
                        count++;
                    }
                }
            }
            if(count == 9)
            {
                result = true;
            }
            return result;
        }

        private bool XWins()
        {
            bool result = false;
            if(_board[0, 0] == 'X' && _board[0, 1] == 'X' && _board[0, 2] == 'X')
            {
                result = true;
            }
            else if(_board[1, 0] == 'X' && _board[1, 1] == 'X' && _board[1, 2] == 'X')
            {
                result = true;
            }
            else if (_board[2, 0] == 'X' && _board[2, 1] == 'X' && _board[2, 2] == 'X')
            {
                result = true;
            }
            else if (_board[0, 0] == 'X' && _board[1, 0] == 'X' && _board[2, 0] == 'X')
            {
                result = true;
            }
            else if (_board[0, 1] == 'X' && _board[1, 1] == 'X' && _board[2, 1] == 'X')
            {
                result = true;
            }
            else if (_board[0, 2] == 'X' && _board[1, 2] == 'X' && _board[2, 2] == 'X')
            {
                result = true;
            }
            else if (_board[0, 0] == 'X' && _board[1, 1] == 'X' && _board[2, 2] == 'X')
            {
                result = true;
            }
            else if (_board[0, 2] == 'X' && _board[1, 2] == 'X' && _board[2, 0] == 'X')
            {
                result = true;
            }
            return result;
        }

        private bool OWins()
        {
            bool result = false;
            if (_board[0, 0] == 'O' && _board[0, 1] == 'O' && _board[0, 2] == 'O')
            {
                result = true;
            }
            else if (_board[1, 0] == 'O' && _board[1, 1] == 'O' && _board[1, 2] == 'O')
            {
                result = true;
            }
            else if (_board[2, 0] == 'O' && _board[2, 1] == 'O' && _board[2, 2] == 'O')
            {
                result = true;
            }
            else if (_board[0, 0] == 'O' && _board[1, 0] == 'O' && _board[2, 0] == 'O')
            {
                result = true;
            }
            else if (_board[0, 1] == 'O' && _board[1, 1] == 'O' && _board[2, 1] == 'O')
            {
                result = true;
            }
            else if (_board[0, 2] == 'O' && _board[1, 2] == 'O' && _board[2, 2] == 'O')
            {
                result = true;
            }
            else if (_board[0, 0] == 'O' && _board[1, 1] == 'O' && _board[2, 2] == 'O')
            {
                result = true;
            }
            else if (_board[0, 2] == 'O' && _board[1, 2] == 'O' && _board[2, 0] == 'O')
            {
                result = true;
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder board = new StringBuilder();
            board.Append(" " + _board[0, 0].ToString() + " |");
            board.Append(" " + _board[0, 1].ToString() + " |");
            board.Append(" " + _board[0, 2].ToString() + " " + Environment.NewLine);
            board.Append("---+---+---" + Environment.NewLine);
            board.Append(" " + _board[1, 0].ToString() + " |");
            board.Append(" " + _board[1, 1].ToString() + " |");
            board.Append(" " + _board[1, 2].ToString() + " " + Environment.NewLine);
            board.Append("---+---+---" + Environment.NewLine);
            board.Append(" " + _board[2, 0].ToString() + " |");
            board.Append(" " + _board[2, 1].ToString() + " |");
            board.Append(" " + _board[2, 2].ToString() + " ");
            return board.ToString();
        }

    }
}