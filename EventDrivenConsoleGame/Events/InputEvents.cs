using System;
using System.Collections.Generic;
using System.Numerics;

static class InputEvents
{
    public static event Action<Vector2>? Key_W_Event;
    public static event Action<Vector2>? Key_D_Event;
    public static event Action<Vector2>? Key_A_Event;
    public static event Action<Vector2>? Key_S_Event;

    public static event Action? Key_Spacebar_Event;
    public static event Action? Key_Escape_Event;

    public static void Invoke_Key_W_Event(Vector2 v) => Key_W_Event?.Invoke(v);
    public static void Invoke_Key_D_Event(Vector2 v) => Key_D_Event?.Invoke(v);
    public static void Invoke_Key_A_Event(Vector2 v) => Key_A_Event?.Invoke(v);
    public static void Invoke_Key_S_Event(Vector2 v) => Key_S_Event?.Invoke(v);
    public static void Invoke_Key_Spacebar_Event() => Key_Spacebar_Event?.Invoke();
    public static void Invoke_Key_Escape_Event() => Key_Escape_Event?.Invoke();

}