public class Car
{
    public EnumCarType type;
    public String userName;
    public DateTime entryTime;
    public DateTime leavingTime;

    public Car(EnumCarType type, string userName)
    {
        this.type = type;
        this.userName = userName;
    }

    public int ParingHours()
    {
        int hours = entryTime.Hour - leavingTime.Hour;
        return hours;
    }
}



