public class Receipt
{
    public int Hours;
    public int Fee;
    public bool payOrnot = false;

    public void Pay()
    {
        this.payOrnot = true;
    }

    public Receipt(int hours, int fee)
    {
        Hours = hours;
        Fee = fee;
    }
}



