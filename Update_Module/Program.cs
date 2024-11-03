using Module;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static string[] REQUIREMENT_OUTPUT_FILES = new string[]
    {
        "./output/Req1.txt",
        "./output/Req2_1.txt",
        "./output/Req2_2.txt",
        "./output/Req3_1.txt",
        "./output/Req3_2.txt",
        "./output/Req5.txt",
    };

    public static void Main(string[] args)
    {
        string roomPath = "data/room_type.csv";
        string accPath = "data/accommodation.csv";
        string roomInAccPath = "data/room_in_accommodation.csv";

        Directory.CreateDirectory("./output");

        ReservationSystem reservationSystem = new ReservationSystem(accPath, roomPath, roomInAccPath);
        // Requirement 1
        List<Accommodation> req1 = reservationSystem.getAccommodations();
        WriteFile(REQUIREMENT_OUTPUT_FILES[0], req1);
        // Requirement 2
        List<Accommodation> req2_1 = reservationSystem.SearchForRoom("City H", 1);
        List<Accommodation> req2_2 = reservationSystem.SearchForRoom("City B", 1);
        WriteFile(REQUIREMENT_OUTPUT_FILES[1], req2_1);
        WriteFile(REQUIREMENT_OUTPUT_FILES[2], req2_2);
        // Requirement 3
        List<Accommodation> req3_1 = reservationSystem.SearchForRoomByRange("data/reservation_3.csv", 10,
            3000, new DateTime(2024, 4, 5), new DateTime(2024, 4, 10), "City H", 1);
        List<Accommodation> req3_2 = reservationSystem.SearchForRoomByRange("data/reservation_3.csv", 10,
            3000, new DateTime(2024, 4, 5), new DateTime(2024, 4, 10), "City B", 1);
        WriteFile(REQUIREMENT_OUTPUT_FILES[3], req3_1);
        WriteFile(REQUIREMENT_OUTPUT_FILES[4], req3_2);
        // Requirement 5
        List<string> req5 = new List<string>();
        try
        {
            Accommodation acc = new Homestay(1, "Cozy Homestay", "123 Main St", "City A", 4.8f);
            Room room = new Room(1, "Single Room", 1, "Standard", 1, 1, 20.0, 50.0);
            double totalPrice = reservationSystem.PerformReservation("data/reservation_5.csv", acc, room,
                new DateTime(2024, 4, 5), new DateTime(2024, 4, 6));
            req5.Add(totalPrice.ToString());
        }
        catch (Exception e)
        {
            req5.Add(e.Message);
        }
        WriteFile(REQUIREMENT_OUTPUT_FILES[7], req5);

    }

    public static bool WriteFile<E>(string path, List<E> rows)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (E row in rows)
                {
                    writer.WriteLine(row.ToString());
                }
            }
            Console.WriteLine("Successfully wrote to the file.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error writing to file.");
            return false;
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot write file.");
            return false;
        }

        return true;
    }
}
