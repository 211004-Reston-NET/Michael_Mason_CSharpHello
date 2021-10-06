namespace HouseFunction
{
    public class House
    {
        // fields
        // encapsulation - controlling access to data
        private string owner;
        private string ghost;
        private int roomCount;

        // constructor
        public House()
        {
            owner = "Sarah Winchester";
            ghost = "Clyde The Evil Ghost";
            roomCount = 161;
        }

        // property/accessors, mutators
        public string Owner 
        { 
            get => owner;
            set => owner = value;
        }
        public string Ghost
        { 
            get => ghost;
            set => ghost = value;
        }
        public int RoomCount
        {
            get => roomCount;
            set => roomCount = value;
        }
    }
}