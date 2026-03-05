using System;
using System.Collections.Generic;
using System.Text;

static class Utils_UI 
{
    public static char[,] _backBuffer = new char[GameData.WIDTH, GameData.HEIGHT];

    public static void DrawBox(int x, int y, int width, int height) 
    {
        int rightEdge = x + width - 1;
        int bottomEdge = y + height - 1;

        // Corners
        SetPixel(x, y, '┌');
        SetPixel(rightEdge, y, '┐');
        SetPixel(x, bottomEdge, '└');
        SetPixel(rightEdge, bottomEdge, '┘');

        // Top and Bottom Walls
        for (int i = 1; i < width - 1; i++)
        {
            SetPixel(x + i, y, '─');
            SetPixel(x + i, bottomEdge, '─');
        }

        // Side Walls
        for (int i = 1; i < height - 1; i++)
        {
            SetPixel(x, y + i, '│');
            SetPixel(rightEdge, y + i, '│');
        }
    }
    public static void SetPixel(int x, int y, char c)
    {
        // Viewport Clipping: If the coordinate is off-screen, silently ignore it.
        if (x >= 0 && x < GameData.WIDTH && y >= 0 && y < GameData.HEIGHT)
        {
            _backBuffer[x, y] = c;
        }
    }
    public static void DrawText(int x, int y, string text) 
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (x + i < GameData.WIDTH) // Prevent overflow
            {
                _backBuffer[x + i, y] = text[i];
            }
        }
    }

    private static char[] _rowBuffer = new char[GameData.WIDTH];

    public static void RenderBuffer() //uses string builder for better performance
    {
        for (int y = 0; y < GameData.HEIGHT; y++)
        {

            Console.SetCursorPosition(0, y); //works as /n

            for (int x = 0; x < GameData.WIDTH; x++)
            {
                _rowBuffer[x] = _backBuffer[x, y];
            }

            // row WITHOUT /n
            Console.Write(_rowBuffer);
        }
    }

    public static void ClearBackBuffer() 
    {
        for (int x = 0; x < GameData.WIDTH; x++)
        {
            for (int y = 0; y < GameData.HEIGHT; y++)
            {
                _backBuffer[x, y] = ' ';
            }
        }
    }
}