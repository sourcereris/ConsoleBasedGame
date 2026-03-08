using System;
using System.Collections.Generic;
using System.Text;

public static class GameLogic
{
    static GameLogic()
    {
        GameEvents.ButtonUpgrade += ButtonUpgrade;
    }

    private static double timestep = 0;
    public static void TimeIncrement() 
    {
        timestep += KTime.DeltaTime;
        if (timestep > 0.5)
        {
            AddScore();
            timestep = 0.0;
        }
    }
    public static void AddScore()
    {
        GameData.Score += GameData.allbtns;
    }

    static void ButtonUpgrade(int buttonNumber) 
    {
        switch (buttonNumber) 
        {
            case 1: GameData.btn1 *= 2; break;
            case 2: GameData.btn2 *= 2; break;
            case 3: GameData.btn3 *= 2; break;
            case 4: GameData.btn4 *= 2; break;
            case 5: GameData.btn5 *= 2; break;
            case 6: GameData.btn6 *= 2; break;
        }
    }
}