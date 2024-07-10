public class ParingLot
{
    public List<Floor> floors = new List<Floor>();

    public List<Car> cars = new List<Car>();

    public void openDoor() { }
    public void closeDoor() { }


    public bool checkParkingCar(Car car)
    {
        List<Floor> availableFloor = new List<Floor>();
        // loop the foors check available
        foreach (var floor in floors)
        {
            if (floor.haveFreeSpots()) availableFloor.Add(floor);
        }
        if (availableFloor != null)
        {
            // entryTime;
            car.entryTime = DateTime.Now;

            return true;
        }
        else
        {
            return false;
        }
    }

    public Car checkUnParking(Car car)
    {
        foreach (var c in cars)
        {
            if (c.userName == car.userName) return c;
        }
        return null;
    }

}



