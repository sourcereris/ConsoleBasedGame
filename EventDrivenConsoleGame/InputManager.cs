using System.Numerics;
class InputManager
{
    public void ManageKey(ConsoleKeyInfo consoleKeyInfo) 
    {
        switch (consoleKeyInfo.Key)
        {
            case ConsoleKey.Spacebar:
                InputEvents.Invoke_Key_Spacebar_Event();
                break;
            case ConsoleKey.Escape:
                break;
                InputEvents.Invoke_Key_Escape_Event();
            case ConsoleKey.W:
                InputEvents.Invoke_Key_W_Event(new Vector2(0, 1));
                break;
            case ConsoleKey.A:
                InputEvents.Invoke_Key_A_Event(new Vector2(-1, 0));
                break;
            case ConsoleKey.D:
                InputEvents.Invoke_Key_D_Event(new Vector2(1, 0));
                break;
            case ConsoleKey.S:
                InputEvents.Invoke_Key_S_Event(new Vector2(0, -1));
                break;
            default:
                break;
        }
    } 
}