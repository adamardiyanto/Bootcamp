namespace NumberLibrary;
static class Number
{
    public static double RandomNumber()
    {
        Random randomNumber = new Random();
        return randomNumber.NextDouble();
    }

    public static double getRound (double value)
    {
        return Math.Round(value);
    }

    public static double getTruncate (double value)
    {
        return Math.Truncate(value);
    }

    public static double getFloor (double value)
    {
        return Math.Floor(value);
    }

    public static double getCeiling (double value)
    {
        return Math.Ceiling(value);
    }
}