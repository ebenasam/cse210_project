using System;


class MindFulness
{
    WaitingDisplay display = new WaitingDisplay();
    public MindFulness()
    {
        Activity newAct = new Activity("Initial Activity");
        SetActivity(newAct.DisplayMenu());
    }

    public void SetActivity(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity("Breathing");
            int numSecondsToRun = breath.DisplayWelcomeMessage();
            breath.DisplayGetReady();
            display.displaySpinner(3);
            display.displayCountDown(4, numSecondsToRun, breath.getActivityList());
            breath.FinishActivity(numSecondsToRun, breath.getActivityName());
            display.displaySpinner(5);
            SetActivity(breath.DisplayMenu());
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity("Reflection");
            int numSecondsToRun = reflect.DisplayWelcomeMessage();
            reflect.setNumberOfSecondsToThink(numSecondsToRun);
            reflect.DisplayGetReady();
            display.displaySpinner(3);
            reflect.getRandomReflectionActivity();
            display.displayCountDown(4, numSecondsToRun, null, "You may begin in ");
            display.displaySpinnerWithText(reflect.getRandomReflectionQuestionActivity(), reflect.getNumberOfSecondsToThink());
            reflect.FinishActivity(numSecondsToRun, reflect.getActivityName());
            display.displaySpinner(5);
            SetActivity(reflect.DisplayMenu());
        }
        else if (choice == 3)
        {
            ListingActivity listing = new ListingActivity("Listing");
            int numSecondsToRun = listing.DisplayWelcomeMessage();
            listing.DisplayGetReady();
            display.displaySpinner(3);
            listing.DisplayActivity();
            display.displayCountDown(4, numSecondsToRun, null, "You may begin in ");
            listing.setListingList(display.GetMultipleLinesWithTimer(numSecondsToRun));
            listing.displayTotalListingCount();
            listing.FinishActivity(numSecondsToRun, listing.getActivityName());
            display.displaySpinner(5);
            SetActivity(listing.DisplayMenu());
        }
        else
        {
            Environment.Exit(0);
        }
    }

    public void SetActivityTime(int seconds)
    {
        
    }
}