namespace Maze
{
    public  class StandardMazeBuilder:MazeBuilder
    {
        private Maze currentMaze { get; set; }
        public override void BuildMaze()
        {
            currentMaze = new Maze();
        }
        public override void BuildRoom(int RoomNumber)
        {
            if(currentMaze.RoomNo(RoomNumber) == null)
            {
                Room room = new Room(RoomNumber);
                currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }

        }
        public override void BuildDoor(int RoomNumber1,int RoomNumber2)
        {
            Room r1 = currentMaze.RoomNo(RoomNumber1);
            Room r2 = currentMaze.RoomNo(RoomNumber2);
            Door door = new Door(r1,r2);
            r1.SetSide(CommonWall(r1,r2),door);
            r2.SetSide(CommonWall(r2,r1),door);
        }

        protected Direction CommonWall(Room r1, Room r2)
        {
            if(r1.roomNumber<r2.roomNumber)
                return Direction.East;
            else
                return Direction.West;
        }

        public override Maze GetMaze()
        {
            return currentMaze;
        }
    }
}