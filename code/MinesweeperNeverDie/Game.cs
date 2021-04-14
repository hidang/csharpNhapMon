using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperNeverDie
{
    class Game
    {
        public delegate void TriggerGameOver(int nhanPham);
        public delegate void SetNhanPhamNe(int nhanPham);
        public delegate int GetNhanPham();
        
        MinesBoard map;
        //col is row and row is col...
        public void Start(int col, int row, int mines, TriggerGameOver TriggerGameOverNe, GetNhanPham GetNhanPhamNe, SetNhanPhamNe SetNhanPhamNe, uint xVideoMode, uint yVideoMode)
        {
            map = new MinesBoard(row, col, mines);
            RenderWindow window = new RenderWindow(new SFML.Window.VideoMode(xVideoMode, yVideoMode), "MineSweeper");
            window.SetFramerateLimit(60);

            window.Closed += Window_Closed;
            window.MouseButtonPressed += MouseButtonPressed;
            bool oneLoop = true;
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(new Color(43, 130, 53));
                //handle game
                map.Draw(window);

                map.nhanPham = GetNhanPhamNe();//truyen nhanpham realtime vao game

                if (map.gameOver && !map.gameWin)
                {
                    int nhanPham = GetNhanPhamNe();
                    if (nhanPham >= 100) 
                    {
                        SetNhanPhamNe(nhanPham - 100);
                        map.gameOver = false;
                    }
                    else if (oneLoop)
                    {
                        oneLoop = false;
                        TriggerGameOverNe(0);//game over
                    }
                }

                if (map.gameWin && oneLoop)
                {
                    oneLoop = false;
                    Random rnd = new Random();
                    int nhanPham = rnd.Next(1, 50);
                    TriggerGameOverNe(nhanPham);
                }
                //------------
                window.Display();
            }
            if (!map.gameWin)
            {
                TriggerGameOverNe(0);//thoat game luc dang choi
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Close();
        }

        // Function called when a mouse is pressed
        private void MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            var window = (Window)sender;
            map.Click(e);
        }
    }
}
