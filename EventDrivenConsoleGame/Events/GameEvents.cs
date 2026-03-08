using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public static class GameEvents 
{
    public static event Action<int>? ButtonUpgrade;

    public static void Invoke_Button_Upgrade_Event(int buttonNumber)
        => ButtonUpgrade?.Invoke(buttonNumber);
}
