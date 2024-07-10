public class FeeCalculatorSystem
{
    public static int electricFeePerHour = 1;
    public static int oilFeePerHour = 2;
    public static Receipt CalculateFee(Car car)
    {
        var fee = 0;
        if (car.type == EnumCarType.electric)
        {
            fee = car.ParingHours() * electricFeePerHour;
        }
        else
        {
            fee = car.ParingHours() * oilFeePerHour;
        }

        return new Receipt(car.ParingHours(), fee);
    }
}



