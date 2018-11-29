using System;

namespace Maze
{
	public class MazeGame{
		public Maze CreateMaze()
        {
            Maze aMaze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door theDoor = new Door(r1,r2);
            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);
            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);
            return aMaze;
        }

		public Maze CreateMaze(MazeBuilder mb)
        {
            Console.WriteLine("MazeGame->CreateMaze(MazeBuilder)");
            mb.BuildMaze();
            mb.BuildRoom(1);
            mb.BuildRoom(2);
            mb.BuildDoor(1,2);
            mb.BuildRoom(3);
            mb.BuildDoor(2,3);
            return mb.GetMaze();
        }
        
	}
}