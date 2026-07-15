using System.Reflection;

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
                    case 7:

                        int totalGuests = guests.Count();
                        int guestsWithRoom = guests.Count(g => g.roomNumber != "Not Assigned");
                        int totalRoomsCount = rooms.Count();
                        int bookedRoomsCount = rooms.Count(r => !r.isAvailable);

                        Console.WriteLine($"Total Guests: {totalGuests}");
                        Console.WriteLine($"Guests With Room Assigned: {guestsWithRoom}");
                        Console.WriteLine($"Total Rooms: {totalRoomsCount}");
                        Console.WriteLine($"Booked Rooms: {bookedRoomsCount}");


                        List<Guest> activeGuests = guests.Where(g => g.roomNumber != "Not Assigned").ToList();

                        if (activeGuests.Count() == 0)
                        {
                            Console.WriteLine("No active bookings recorded.");
                        }
                        else
                        {

                            double avgNights = activeGuests.Average(g => g.totalNights);
                            Console.WriteLine($"Average Nights (Active Bookings): {avgNights:F2}");


                            List<Guest> topSpenders = activeGuests
                                .OrderByDescending(g => g.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber.ToString() == g.roomNumber).pricePerNight))
                                .Take(3)
                                .ToList();

                            Console.WriteLine("Top 3 Highest Spenders:");
                            foreach (var g in topSpenders)
                            {
                                Room theirRoom = rooms.FirstOrDefault(r => r.roomNumber.ToString() == g.roomNumber);
                                double cost = g.calculateTotalCost(theirRoom.pricePerNight);
                                Console.WriteLine($"{g.guestName} - OMR {cost:F2}");
                            }

                            List<string> summaryLines = activeGuests.Select(g =>
                            {
                                Room linkedRoom = rooms.FirstOrDefault(r => r.roomNumber.ToString() == g.roomNumber);
                                double cost = g.calculateTotalCost(linkedRoom.pricePerNight);
                                return $"{g.guestName} — Room {g.roomNumber} — {g.totalNights} nights — OMR {cost:F2}";
                            }).ToList();

                            Console.WriteLine("Booking Summary:");
                            foreach (string line in summaryLines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        break;

                    case 8:
                        Console.WriteLine("Enter The Room Number: ");
                        int roomIdentifier = int.Parse(Console.ReadLine());
                        Room roomFinder = rooms.FirstOrDefault(r => r.roomNumber == roomIdentifier);

                        if(roomFinder == null)
                        {
                            Console.WriteLine("Error, Room Doesn't Exist.");
                        }
                        else
                        {
                            double oldPrice = roomFinder.pricePerNight;
                            Console.WriteLine("Enter the New Price / Night: ");
                            double pPerNight = double.Parse(Console.ReadLine());
                            if(pPerNight <= 0)
                            {
                                Console.WriteLine("Please Enter A Positive Number.");
                            }
                            else
                            {
                                roomFinder.pricePerNight = pPerNight;
                                Console.WriteLine($"Price has been updated from {oldPrice} to {roomFinder.pricePerNight}");
                            }
                        }
                    break;

                    case 9:
                        Console.WriteLine("Enter a Full / Patrial Name: ");
                        string nameFinder = Console.ReadLine().ToLower();

                        
                        List<Guest> findGuest = guests.Where(g => g.guestName.ToLower().Contains(nameFinder)).ToList();
                        if(findGuest.Count() == 0)
                        {
                            Console.WriteLine("No Guest Matched That Search.");
                        }
                        else
                        {
                            Console.WriteLine($"Found Guests: {findGuest.Count()}");
                            foreach(var guest in findGuest)
                            {
                                guest.displayGuest();
                            }
                        }
                    break;

                    case 10:
                        int singleAmount = rooms.Count(r => r.roomType == "Single");
                        int doubleAmount = rooms.Count(r => r.roomType == "Double");
                        int suiteAmount = rooms.Count(r => r.roomType == "Suite");

                        Console.WriteLine($"Single: {singleAmount} rooms");
                        if (singleAmount == 0)
                        {
                            Console.WriteLine("N/A");
                        }
                        else
                        {
                            double singleAvg = rooms.Where(r => r.roomType == "Single").Average(r => r.pricePerNight);
                            Console.WriteLine($"Average Price: {singleAvg:F2}");
                        }

                        Console.WriteLine($"Double: {doubleAmount} rooms");
                        if (doubleAmount == 0)
                        {
                            Console.WriteLine("N/A");
                        }
                        else
                        {
                            double doubleAvg = rooms.Where(r => r.roomType == "Double").Average(r => r.pricePerNight);
                            Console.WriteLine($"Average Price: {doubleAvg:F2}");
                        }

                        Console.WriteLine($"Suite: {suiteAmount} rooms");
                        if (suiteAmount == 0)
                        {
                            Console.WriteLine("N/A");
                        }
                        else
                        {
                            double suiteAvg = rooms.Where(r => r.roomType == "Suite").Average(r => r.pricePerNight);
                            Console.WriteLine($"Average Price: {suiteAvg:F2}");
                        }

                        double totalAvg = rooms.Average(r => r.pricePerNight);
                        Console.WriteLine($"Overall Average Price: {totalAvg:F2}");

                    break;

                    case 11:
                        Console.WriteLine("Enter Your Guest ID: ");
                        string idGuest = Console.ReadLine();

                        Guest checkout = guests.FirstOrDefault(g => g.guestID == idGuest);

                        if(checkout == null)
                        {
                            Console.WriteLine("Error, Guest Not Found.");
                        }
                        else
                        {
                            Room checkoutRoom = rooms.FirstOrDefault(r => r.roomNumber.ToString() == checkout.roomNumber);

                            double totCost = checkout.calculateTotalCost(checkoutRoom.pricePerNight);
                            Console.WriteLine("------- Final Bill--------");
                            Console.WriteLine($"Guest: {checkout.guestName}");
                            Console.WriteLine($"Room: {checkoutRoom.roomNumber}");
                            Console.WriteLine($"Room Type: {checkoutRoom.roomType}");
                            Console.WriteLine($"Check-In Date: {checkout.checkInDate}");
                            Console.WriteLine($"Nights: {checkout.totalNights}");
                            Console.WriteLine($"Price/Night: {checkoutRoom.pricePerNight:F2}");
                            Console.WriteLine($"Total: {totCost:F2}");

                            Console.WriteLine("Confirm Checkout? (Y/N): ");
                            string confirm = Console.ReadLine();

                            if (confirm.ToUpper() == "Y")
                            {
                                checkoutRoom.isAvailable = true;
                                guests.Remove(checkout);

                                Console.WriteLine($"Checkout complete. Total guests remaining: {guests.Count()}");

                                bool isNowAvailable = rooms.Any(r => r.roomNumber == checkoutRoom.roomNumber && r.isAvailable == true);
                                Console.WriteLine($"Room {checkoutRoom.roomNumber} is now available: {isNowAvailable}");
                            }
                            else
                            {
                                Console.WriteLine("Checkout cancelled. No changes made.");
                            }
                        }

                        break;

                    case 12:
                        List<Room> removableRooms = rooms.Where(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber.ToString())).OrderBy(r => r.roomNumber).ToList();
                        if (removableRooms.Count() == 0)
                        {
                            Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                        }
                        else
                        {
                            Console.WriteLine($"Rooms eligible for removal: {removableRooms.Count()}");
                            foreach (var room in removableRooms)
                            {
                                Console.WriteLine($"Room {room.roomNumber} - {room.roomType} - {room.pricePerNight:F2}");
                            }

                            Console.WriteLine("Confirm removal? (Y/N): ");
                            string confirmRemoval = Console.ReadLine();

                            if (confirmRemoval.ToUpper() == "Y")
                            {
                                
                                int removedCount = rooms.RemoveAll(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber.ToString()));

                                Console.WriteLine($"Removed {removedCount} room(s). Remaining rooms: {rooms.Count()}");

                                List<string> remaining = rooms.Select(r => $"Room {r.roomNumber} - {r.roomType}").ToList();
                                Console.WriteLine("Remaining Rooms:");
                                foreach (string line in remaining)
                                {
                                    Console.WriteLine(line);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Removal cancelled. No changes made.");
                            }
                        }
                        break;

                    case 13:
                        Console.WriteLine("Enter Your Guest ID: ");
                        string guestIdentifier = Console.ReadLine();
                        Guest finder = guests.FirstOrDefault(g => g.guestID == guestIdentifier);
                        if(finder == null)
                        {
                            Console.WriteLine("Error, Guest Not Found.");
                        }
                        else
                        {
                            if(finder.roomNumber == "Not Assigned")
                            {
                                Console.WriteLine("The Guest Doesnt't Have An Active Booking");
                            }
                            else
                            {
                                Console.WriteLine("Enter The Number of Additional Nights: ");
                                int additional = int.Parse(Console.ReadLine());
                                if (additional <= 0)
                                {
                                    Console.WriteLine("Error, Additional Nights Must Be Positive.");
                                }
                                else
                                {
                                    finder.totalNights += additional;
                                    Room targetRoom = rooms.FirstOrDefault(r => r.roomNumber.ToString() == finder.roomNumber);
                                    double newCost = finder.calculateTotalCost(targetRoom.pricePerNight);
                                    Console.WriteLine($"Updated Nights: {finder.totalNights}");
                                    Console.WriteLine($"New Total Cost: {newCost:F2}");
                                }
                            }
                        }

                        break;

                    case 14:
                        List<Guest> ActiveBookings = guests.Where(g => g.roomNumber != "Not Assigned").ToList();
                        if(ActiveBookings.Count() == 0)
                        {
                            Console.WriteLine("No Active Bookings Recorded.");
                        }
                        else
                        {

                        }
                    
                    break;


                }
            }
            while(option != 0);
        }
    }
}
