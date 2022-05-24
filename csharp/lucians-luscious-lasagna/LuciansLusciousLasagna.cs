class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int minutesInOven = 40;
        
        return minutesInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int minutesInOven)
    {
        int minutesCooking = 10;

        int timeRemaining = minutesInOven - minutesCooking;

        return timeRemaining;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int Layer)
    {
        int layerPrepTime = 2;

        int preparationTime = Layer * layerPrepTime;

        return preparationTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int preparationTime, int timeRemaining)
    {
        int preparationPerLayer = preparationTime * 4;
        int totalWorkingTime = preparationPerLayer + timeRemaining;

        return totalWorkingTime;
    }
}
