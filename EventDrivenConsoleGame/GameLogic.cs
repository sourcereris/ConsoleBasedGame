using System;
using System.Collections.Generic;
using System.Text;

public static class GameLogic
{

    public static void TimeIncrement() 
    {
        GameData.time += KTime.DeltaTime;
    }
    public static void AddScore()
    {
        GameData.Score += 10;
    }
}