using Raylib_cs;

class InputBox : Widget
{
    bool Focused = false;
    int CursorX = 0;
    string Buffer = "";
    public int Width = 150;

    public InputBox() : base(100, 100)
    {
    }

    public override void Update()
    {
        int x = Raylib.GetMouseX();
        int y = Raylib.GetMouseY();

        bool isHover = x >= Position.X && x <= Position.X + Width && y >= Position.Y && y <= Position.Y + 24;

        if (isHover)
        {
            GUI.Cursor = MouseCursor.MOUSE_CURSOR_CROSSHAIR;
        }

        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
        {
            Focused = isHover;
        }

        int key = Raylib.GetCharPressed();

        if (Focused)
        {
            if ((key >= 32) && (key <= 125))
            {
                Buffer += (char)key;
                CursorX++;
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_BACKSPACE) && Buffer.Length > 0)
            {
                Buffer = Buffer[..(Buffer.Length - 1)];
                CursorX--;
            }
        }
    }

    public override void Render()
    {
        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, Width, 24, Color.BLACK);

        int absWidth = Raylib.MeasureText(Buffer[..CursorX], 18);
        int textWidth = Math.Min(absWidth, Width - 14);
        int offsetX = textWidth - absWidth;

        Raylib.BeginScissorMode((int)Position.X, (int)Position.Y, Width, 24);
        Raylib.DrawText(Buffer, (int)Position.X + 5 + offsetX, (int)Position.Y + 4, 18, Color.BLACK);
        Raylib.EndScissorMode();

        if (Focused)
        {
            Raylib.DrawLine((int)Position.X + 6 + textWidth, (int)Position.Y + 3, (int)Position.X + 6 + textWidth, (int)Position.Y + 20, Color.RED);
        }

    }

}