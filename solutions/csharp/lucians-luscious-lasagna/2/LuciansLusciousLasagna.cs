class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int a)
    {
        return ExpectedMinutesInOven() - a;
    }

    public int PreparationTimeInMinutes(int b)
    {
        return b * 2;
    }

    public int ElapsedTimeInMinutes( int c, int d)
    {
        return PreparationTimeInMinutes(c) + d;
    }
}



