using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MinesweeperNeverDie
{
    /*
        0 is empty
        1-8 is number
        9 is mine
        10 is unrevealed square
        11 is flag
    */
    class MinesBoard
    {
        private int row { get; set; }
        private int col { get; set; }
        private int mines { get; set; }

        int flag = 0;
        public bool gameOver = false;
        public bool gameWin = false;
        public int nhanPham;
        int[,] board;

        List<Sprite> cells = new List<Sprite>();
        int[,] boardRevealed;

        bool fistclick = true;
        List<Texture> textures = new List<Texture>()
        {
            new Texture("Resources/cell-null.PNG"),
            new Texture("Resources/1.PNG"),
            new Texture("Resources/2.PNG"),
            new Texture("Resources/3.PNG"),
            new Texture("Resources/4.PNG"),
            new Texture("Resources/5.PNG"),
            new Texture("Resources/6.PNG"),
            new Texture("Resources/7.PNG"),
            new Texture("Resources/8.PNG"),
            new Texture("Resources/clanbomber.PNG"),
            new Texture("Resources/cell.PNG"),
            new Texture("Resources/flag.PNG"),
        };

        public MinesBoard(int row, int col, int mines)
        {
            this.row = row;
            this.col = col;
            this.mines = mines;

            InitArray(out boardRevealed, 10);
            InitArray(out board, 0);

            //InitMinesInBoard();
            RenderBoard();
        }
        private void RenderBoard()
        {
            //Console.WriteLine("Render ne");
            int x, y;
            int positionCellX = 40;
            int positionCellY = 40;

            for (y = 0; y < this.row; y++)
            {
                for (x = 0; x < this.col; x++)
                {
                    Sprite cell = new Sprite(textures[boardRevealed[y, x]]);
                    cell.Position = new Vector2f(positionCellX += 40, positionCellY);
                    cells.Add(cell);
                }
                positionCellY += 40;
                positionCellX = 40;
            }
        }
        public void Draw(RenderWindow window)
        {
            int i;
            for (i = 0; i < cells.Count; i++)
            {
                window.Draw(cells[i]);
            }
        }
        public void Click(MouseButtonEventArgs e)
        {
            int cellIndex = -1;
            int countCell = 0;

            //check điểm click thuộc mặt phẳng nào
            for (int _cellIndex = 0; _cellIndex < cells.Count; _cellIndex++)
            {
                if (cells[_cellIndex].GetGlobalBounds().Contains(e.X, e.Y))
                {
                    cellIndex = _cellIndex;
                    break;
                }
            }

            bool clicked = false;
            //get index cell in board[,]
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (countCell == cellIndex)
                    {
                        if (!clicked)
                            //check fistclick to init Board
                            if (fistclick)
                            {
                                InitMinesInBoard(i, j);
                                OpenCell(i, j);
                                fistclick = false;
                                //re-RenderBoard
                                RenderBoard();
                            }
                            else
                            {
                                if (e.Button == Mouse.Button.Left && !gameOver)
                                {
                                    if (board[i, j] == 9)
                                    {
                                        if (nhanPham >= 100)
                                        {
                                            gameOver = true;//bao thua de Game() tru
                                            boardRevealed[i, j] = 9;
                                            RenderBoard();
                                            boardRevealed[i, j] = 11;
                                            RenderBoard();
                                        }
                                        else
                                        {
                                            boardRevealed[i, j] = 9;

                                            //RenderBoardMines()
                                            for (int _i = 0; _i < row; _i++)
                                            {
                                                for (int _j = 0; _j < col; _j++)
                                                {
                                                    if (board[_i, _j] == 9)
                                                        boardRevealed[_i, _j] = 9;
                                                }
                                            }
                                            RenderBoard();
                                            Console.WriteLine("Game Over");
                                            gameOver = true;
                                        }
                                    }
                                    else
                                    if (boardRevealed[i, j] != 11 && boardRevealed[i, j] != 0)
                                    {
                                        OpenCell(i, j);
                                        //re-RenderBoard
                                        RenderBoard();
                                    }
                                }

                                if (e.Button == Mouse.Button.Right && !gameOver)
                                    if (boardRevealed[i, j] == 10 && flag < mines)
                                    {
                                        boardRevealed[i, j] = 11;
                                        flag++;
                                        if(flag == mines)
                                            CheckWin();
                                        //re-RenderBoard
                                        RenderBoard();
                                    }
                                    else
                                    if (boardRevealed[i, j] == 11)
                                    {
                                        boardRevealed[i, j] = 10;
                                        flag--;

                                        //re-RenderBoard
                                        RenderBoard();
                                    }
                            }
                        clicked = true;
                        break;
                    }
                    countCell++;
                }
            }
            countCell = 0;
        }

        private void InitArray(out int[,] array, int numberDefault)
        {
            array = new int[this.row, this.col];
            for (int _i = 0; _i < this.row; _i++)
            {
                for (int _j = 0; _j < this.col; _j++)
                {
                    array[_i, _j] = numberDefault;
                }
            }
        }
        private void InitMinesInBoard(int _x, int _y)
        {
            Random rnd = new Random();
            int count = 0;

            while (count < mines)
            {
                int r = 0, c = 0;
                //rải mine ngẫu nhiên nhưng tránh lần click đầu tiên
                do
                {
                    r = rnd.Next(0, this.row - 1);
                    c = rnd.Next(0, this.col - 1);
                }
                while (r == _x && c == _y);

                if ((!(board[r, c] == 9)))
                {
                    board[r, c] = 9;
                    count++;
                    //chắc chắn rằng xung quanh ô click đầu tiên không có mine
                    if (CountAroundMines(_x, _y) > 0)
                    {
                        board[r, c] = 0;
                        count--;
                    }
                }
            }
        }
        public bool OpenCell(int _row, int _col)
        {
            if (board[_row, _col] == 9) return false;//if loop in here thì stop

            int countMines = CountAroundMines(_row, _col);
            if (countMines > 0)
            {
                //add to board and boardRevealed
                board[_row, _col] = countMines;
                //show Cell
                boardRevealed[_row, _col] = countMines;
                return false;
            }
            else
            {
                board[_row, _col] = -1;//-1 khong duyet nua
                //show Cell
                boardRevealed[_row, _col] = 0;
                //thuat toan loang
                if (board[_row, _col] == 0 || boardRevealed[_row, _col] == 0)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if (i != 0 || j != 0)
                            {
                                if (_row + i >= 0 && _row + i < row && _col + j >= 0 && _col + j < col)// Nếu ô nằm trong board
                                {
                                    if (!Enumerable.Range(0, 8).Contains(boardRevealed[_row + i, _col + j]))// Nếu ô chưa được mở
                                        OpenCell(_row + i, _col + j);
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        private int CountAroundMines(int _row, int _col)
        {
            int count = 0;
            int r1 = _row == 0 ? 0 : -1;
            int c1 = _col == 0 ? 0 : -1;
            int r2 = _row == row - 1 ? 1 : 2;
            int c2 = _col == col - 1 ? 1 : 2;

            for (; r1 < r2; r1++)
                for (int j = c1; j < c2; j++)
                {
                    if (board[_row + r1, _col + j] == 9)
                        count++;
                }
            return count;
        }
        private void CheckWin()
        {
            if (gameOver) return;

            int cellMines = 0;
            for (int _i = 0; _i < row; _i++)
            {
                for (int _j = 0; _j < col; _j++)
                {
                    if (boardRevealed[_i, _j] == 11)
                        if(board[_i, _j] == 9)
                            cellMines++;
                }
            }
            if (cellMines == mines)
            {
                gameWin = true;
                gameOver = true;//ngưng việc user click
                Console.WriteLine("You win");
            }
        }
    }
}
