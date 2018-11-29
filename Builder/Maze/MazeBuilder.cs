namespace Maze
{
    public abstract class MazeBuilder
    {
        public virtual void BuildMaze(){}
        public virtual void BuildRoom(int RoomNumber){}
        public virtual void BuildDoor(int RoomNumber1,int RoomNumber2){}
        public abstract Maze GetMaze();
    }
}