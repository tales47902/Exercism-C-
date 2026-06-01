class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int a)
    {
        return ExpectedMinutesInOven() - RemainingMinutesInOven(a);
    }

    public int PreparationTimeInMinutes(int b)
    {
        return PreparationTimeInMinutes(b) * 2;
    }

    public int ElapsedTimeInMinutes(int c, int d)
    {
        return c + d;
    }
}

class Program
{
    static void Main() 
    {
        var lasagna = new Lasagna();
        lasagna.RemainingMinutesInOven(30);
        lasagna.PreparationTimeInMinutes(2);
        lasagna.ElapsedTimeInMinutes(3, 20);
    }
}