using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MineSweeper
{
    class Game
    {
        MinesBoard map;
        public void Start()
        {
            map = new MinesBoard();
            RenderWindow window = new RenderWindow(new SFML.Window.VideoMode(1000, 800), "MineSweeper");
            window.SetFramerateLimit(60);
            
            window.Closed += Window_Closed;

            window.MouseButtonPressed += MouseButtonPressed;

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(new Color(43, 130, 53));

                //code here
                map.Draw(window);

                //
                window.Display();
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
