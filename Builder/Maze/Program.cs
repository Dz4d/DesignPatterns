using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            //wrong code
            MazeGame mazeGame = new MazeGame();
            Maze maze = mazeGame.CreateMaze();
            maze.ShowMaze();
            Console.WriteLine("");
            //builder
            MazeGame mazeGameMB = new MazeGame();
            MazeBuilder mazeBuilder = new StandardMazeBuilder();
            Maze mazeMB = mazeGameMB.CreateMaze(mazeBuilder);
            mazeMB.ShowMaze();
        }
    }
}
