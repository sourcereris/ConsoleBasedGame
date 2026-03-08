using System;
using System.Collections.Generic;
using System.Text;

enum GameState
{
    MainMenu,
    Playing,
    GameOver
}
 
static class GameData
{
    public static double Score = 0;
    public static double time = 0;

    public static GameState currentState;

    public static bool IsPlaying = true;

    public const int WIDTH = 120;
    public const int HEIGHT = 30;

    public static double btn1 = 0.1f;
    public static double btn2 = 0f;
    public static double btn3 = 0f;
    public static double btn4 = 0f;
    public static double btn5 = 0f;
    public static double btn6 = 0f;

    public static double allbtns = btn1 + btn2 + btn3 + btn4 + btn5 + btn6 ;

}
