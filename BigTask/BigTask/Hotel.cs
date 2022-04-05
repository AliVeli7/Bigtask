using System;
using System.Collections.Generic;
using System.Text;

namespace BigTask
{
    class Hotel
    {
        public string Name;
        Room[] Rooms = new Room[1];


        public void AddRoom(Room room)
        {
            Rooms[Rooms.Length-1] = room;
            Array.Resize(ref Rooms, Rooms.Length + 1);
        }


        public void MAkeReservation(int? roomId)
        {

            if (!(roomId is null))
            {
                if (!(Rooms[(int)roomId - 1] is null))
                {
                    if ((Rooms[(int)roomId - 1].IsAvailable))
                    {
                        Console.WriteLine("Room is AVAilablee");
                    }
                    else
                    {
                        throw new NullReferenceException("Room is not Avaliable");
                    }
                }

            }
            
        }


        public Room this[int index]
        {
            get
            {
                if (index > Rooms.Length - 1)
                {
                    throw new OutOfCapasityException("This index is not exist");
                }
                else if (Rooms[index] == null)
                {
                    throw new EmptyBookException("This index is not set");
                }
                return Rooms[index];

            }
            set
            {
                if (index >= 0 && index <= Rooms.Length - 1)
                {
                    Rooms[index] = value;
                }
            }

        }
    }
}
