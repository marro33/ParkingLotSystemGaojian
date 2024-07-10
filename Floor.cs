public class Floor
{
    // spots: 0,1,2,3.... 0:no car 1: parking a car
    public int[] spots;
    public SensorSystem sensorSystem = new SensorSystem();
    public Dashbord dashbord = new Dashbord();

    public bool haveFreeSpots()
    {
        sensorSystem.scanSensors(spots);
        foreach (var spot in spots)
        {
            if (spot == 0) return true;
        }
        return false;
    }
}



