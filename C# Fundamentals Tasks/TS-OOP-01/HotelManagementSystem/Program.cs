namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            Room room1 = new Room(201, "Single", 65.00);
            rooms.Add(room1);
            Room room2 = new Room(202, "Single", 65.00);
            rooms.Add(room2);
            Room room3 = new Room(203, "Double", 85.00);
            rooms.Add(room3);
            Room room4 = new Room(204, "Double", 85.00);
            rooms.Add(room4);
            Room room5 = new Room(205, "Suite", 100.00);
            rooms.Add(room5);
            Room room6 = new Room(206, "Suite", 100.00);
            rooms.Add(room6);

            int option = -1;
            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("==============================================");
                Console.WriteLine("Enter Your Choice: ");

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                switch (option) {
                    //Case 01 Add New Room
                    case 1:
                        Console.WriteLine("Enter a Room Number: ");
                        int selectedRoom = int.Parse(Console.ReadLine());
                        if (selectedRoom <= 0)
                        {
                            Console.WriteLine("Room Number Must Be Positive.");
                        }
                        else if (rooms.Any(r => r.roomNumber == selectedRoom))
                        {
                            Console.WriteLine("Error: Room Already Exists.");
                        }
                        else
                        {
                            Console.WriteLine("Enter The Room Type: ");
                            string roomType = Console.ReadLine();
                            Console.WriteLine("Enter The Room Price / Night: ");
                            double price = double.Parse(Console.ReadLine());
                            if (price <= 0)
                            {
                                Console.WriteLine("Error, Price Must Be Positive.");
                            }
                            else
                            {
                                Room newRoom = new Room(selectedRoom, roomType, price);
                                rooms.Add(newRoom);
                                Console.WriteLine($"Sucessfully Added New Room. Total rooms:{rooms.Count}");
                            }
                        }
                    break;

                    case 2:
                        Console.WriteLine("Please Enter Your Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Your Checkin Date: ");
                        string date = Console.ReadLine();
                        Console.WriteLine("Number of Nights: ");
                        int nights = int.Parse(Console.ReadLine()); ;
                       
                        if(nights <= 0)
                        {
                            Console.WriteLine("Error, Nights have to be positive.");
                        }
                        else
                        {
                            string guestID = "G" + (guests.Count + 1).ToString("000");
                            Guest newGuest = new Guest(guestID, name, date, nights);
                            guests.Add(newGuest);
                            Console.WriteLine();
                            Console.WriteLine($"Guest Details: \n- {newGuest.guestID}\n- {newGuest.guestName}\n- {newGuest.checkInDate}\n- {newGuest.totalNights}");
                        }
                    break;

                    case 3:
                        Console.WriteLine("Enter Your Guest ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Your Desired Room: ");
                        int roomID = int.Parse(Console.ReadLine());

                        Guest foundGuest = guests.FirstOrDefault(g => g.guestID == id);
                        Room foundRoom = rooms.FirstOrDefault(r => r.roomNumber == roomID);
                        

                        if(foundRoom == null)
                        {
                            Console.WriteLine("Error, Enter a Valid Room Number.");
                        }
                        else if (foundGuest == null)
                        {
                            Console.WriteLine("Error, Enter a Valid ID");
                        }
                        else if(foundRoom.isAvailable == false)
                        {
                            Console.WriteLine("Room is Currently Booked.");
                        }
                        else
                        {
                            foundGuest.roomNumber = roomID.ToString();
                            foundRoom.isAvailable = false;
                            double totalPrice = foundGuest.calculateTotalCost(foundRoom.pricePerNight);
                            Console.WriteLine($"Booking Confirmed. {foundGuest.guestName} is in Room {foundRoom.roomNumber}");
                            Console.WriteLine($"Total Cost is: {totalPrice}");
                        }
                    break;

                    case 4:
                        if (rooms.Count() == 0)
                        {
                            Console.WriteLine("No Room has been Added yet.");
                        }
                        else
                        {
                            Console.WriteLine($"Total Rooms: {rooms.Count()}");
                            List<Room> orderedRooms = rooms.OrderBy(r => r.roomNumber).ToList();
                            foreach (var space in orderedRooms)
                            {
                                space.displayRoom();
                            }

                        }
                        break;

                    case 5:
                        if(guests.Count() == 0)
                        {
                            Console.WriteLine("No Guests Have Been Registered Yet.");
                        }
                        else
                        {
                            Console.WriteLine($"Guest Count: {guests.Count()}");
                            List<Guest> guestList = guests.OrderBy(g => g.guestName).ToList();
                            foreach(var visitor in guestList)
                            {
                                visitor.displayGuest();
                            }
                        }

                    break;

                    case 6:
                        Console.WriteLine("Select an Option: ");
                        Console.WriteLine("1. Show All Available Rooms");
                        Console.WriteLine("2. Filter By Room Type");
                        Console.WriteLine("3. Filter By Max Price");
                        Console.WriteLine("4. Room Price Statistics");
                        Console.WriteLine("0. Back");

                        int subOption = int.Parse(Console.ReadLine());
                        switch (subOption)
                        {
                            case 1:
                                List<Room> allRooms = rooms.Where(r => r.isAvailable == true).OrderBy(r => r.pricePerNight).ToList(); 
                                if (allRooms.Count() == 0)
                                {
                                    Console.WriteLine("No Rooms Found For The Selected Criteria.");
                                }
                                else
                                {
                                    Console.WriteLine($"Available Rooms: {allRooms.Count()}");
                                    foreach (var availableRooms in allRooms)
                                    {
                                        availableRooms.displayRoom();
                                    }
                                }
                                
                                break;

                            case 2:
                                Console.WriteLine("Enter a Room Type: ");
                                string roomSelect = Console.ReadLine();
                                List<Room> filteredRoom = rooms.Where(r => r.roomType == roomSelect).ToList();
                                if (filteredRoom.Count() == 0)
                                {
                                    Console.WriteLine("No Rooms Found For The Selected Criteria.");
                                }
                                else
                                {
                                    foreach (var room in filteredRoom)
                                    {
                                        room.displayRoom();
                                    }
                                }
                                break;

                            case 3:
                                Console.WriteLine("Enter a Maximum Price: ");
                                double maxPrice = double.Parse(Console.ReadLine());
                               
                                List<Room> filter = rooms.Where(r => r.pricePerNight <= maxPrice).OrderBy(r => r.pricePerNight).ToList();
                                if (filter.Count() == 0)
                                {
                                    Console.WriteLine("No Rooms Found For The Selected Criteria.");
                                }
                                else
                                {

                                    foreach (var room in filter)
                                    {
                                        room.displayRoom();
                                    }
                                }
                            break;

                            case 4:
                                int totalRooms = rooms.Count();
                                double avgPrice = rooms.Average(r => r.pricePerNight);
                                double upperPrice = rooms.Max(r => r.pricePerNight);
                                double minPrice = rooms.Min(r => r.pricePerNight);

                                Console.WriteLine($"Total Rooms: {totalRooms}");
                                Console.WriteLine($"Average Price: {avgPrice:F2}");
                                Console.WriteLine($"Highest Price: {upperPrice:F2}");
                                Console.WriteLine($"Lowest Price: {minPrice:F2}");
                                break;

                            case 0:

                            break;

                            default:
                                Console.WriteLine("Invalid option.");
                            break;
                        }


                    break;
                }
            }
            while(option != 0);
        }
    }
}
