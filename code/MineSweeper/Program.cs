using System;

namespace MineSweeper
{
    //https://www.nuget.org/packages/SFML.Net/
    //dotnet add MineSweeper package SFML.Net --version 2.5.0

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}
