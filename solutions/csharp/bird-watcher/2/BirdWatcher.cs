class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0,2,5,3,7,8,4};

    public int Today() => birdsPerDay[6];

    public void IncrementTodaysCount() => birdsPerDay[6] += 1;

    public bool HasDayWithoutBirds()
    {
        foreach(int birds in birdsPerDay)
        {
            if(birds == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int result = 0;
        for(var i = 0; i < numberOfDays; i++)
        {
            result += birdsPerDay[i];
        }
        return result;
    }

    public int BusyDays()
    {
        int result = 0;
        foreach(int birds in birdsPerDay)
        {
            if(birds >= 5)
                result += 1;
        }
        return result;
    }
}
