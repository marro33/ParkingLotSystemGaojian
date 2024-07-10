
using System.Drawing;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

public class Program
{
    /*
    Design Parking Lot System

    A parking lot or car park is a dedicated cleared area that is intended for parking vehicles.

    "System Requirements"
    We will focus on the following set of requirements while designing the parking lot:

    - The parking lot has only one entry and one exit.
    - The parking lot should have multiple floors where customers can park their cars.
    - Each parking floor will have many parking spots.
    - Each floor will have several display board showing the number of empty spots.
    - Cars have two types -- 'electric' and 'petrol'. 
    - Electric cars charge $1 per hour
    - Petrol cars charge $2 per hour
    - Customers can get the receipt and pay for the parking fee based on car type and parking time.

    - [optional] For the members of the parking lot, they can receive the message notification on their phone when entering and leaving the parking lot

    Please design and implement the main objects/interfaces/properties for the two use cases:
    1. Parking the car
    2. Unparking the car
    */

    private static void Main(string[] args)
    {
        var parkingLot = new ParingLot();
        var floor1 = new Floor();
        floor1.spots = new int[4];
        parkingLot.floors.Add(floor1);


        // when get in. scan a new car by photo
        var car = new Car(EnumCarType.electric, "Hu ACG1096");
        // decide parking
        if (parkingLot.checkParkingCar(car))
        {
            Console.WriteLine("welcome");
            parkingLot.openDoor();
            // in
            parkingLot.cars.Add(car);
            parkingLot.closeDoor();
        }
        else
        {
            Console.WriteLine("sorry, no parking spots available");
        }


        //background working
        while (true)
        {
            foreach (var floor in parkingLot.floors)
            {
                floor.haveFreeSpots();
            }
        }

        // unParking
        car = new Car(EnumCarType.electric, "Hu ACG1096");
        var carInSystem = parkingLot.checkUnParking(car);
        if (carInSystem != null)
        {
            var receipt = FeeCalculatorSystem.CalculateFee(carInSystem);
            // Pay
            receipt.Pay();
            if (receipt.payOrnot)
            {
                parkingLot.openDoor();
                // out
                parkingLot.closeDoor();
            }
            else
            {
                Console.WriteLine("Please pay the parking fee");
            }
        }
        else
        {
            Console.WriteLine("No entry record, please call the admin");
        }

    }
}



