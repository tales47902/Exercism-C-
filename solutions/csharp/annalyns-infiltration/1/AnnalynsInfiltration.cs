static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        knightIsAwake = true;
        if (knightIsAwake == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = false;
        if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        archerIsAwake = false;
        prisonerIsAwake = true;
        if (archerIsAwake == false && prisonerIsAwake == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = false;
        petDogIsPresent = false;
        if (archerIsAwake == false &&  petDogIsPresent == true)
        {
            return true;
        }
        else if (petDogIsPresent == false && prisonerIsAwake == true && archerIsAwake == false && knightIsAwake == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

