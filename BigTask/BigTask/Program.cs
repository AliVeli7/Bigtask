using System;

namespace BigTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            Room room1 = new Room();
            Room room2 = new Room();


            room2.IsAvailable = false;
            Room room3 = new Room();
            Room room4 = new Room(); 
            Room room5 = new Room();
            Room room6 = new Room();
            room.IsAvailable = false;
            Hotel LAGrande = new Hotel();
           
            LAGrande.Name = "La Grande";
            LAGrande.AddRoom(room);
            LAGrande.AddRoom(room1);
            LAGrande.AddRoom(room2);
            LAGrande.AddRoom(room3);
            LAGrande.AddRoom(room4);
            LAGrande.AddRoom(room5);
            LAGrande.AddRoom(room6);

            LAGrande[1] = new Room();
            Console.WriteLine(LAGrande[1]);

            LAGrande.MAkeReservation(3);



            
            




        }
    }
}
