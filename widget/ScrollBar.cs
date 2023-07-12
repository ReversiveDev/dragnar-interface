using Raylib_cs;

class ScrollBar : Widget
{
    int StartY = 0;
    int ScrollY = 0;
    public int Width = 18;
    public int Height = 150;

    public ScrollBar() : base(400, 100) { }

    public override void Update()
    {
        int mx = Raylib.GetMouseX();
        int my = Raylib.GetMouseY();
        int x = (int)Position.X + 2;
        int y = (int)Position.Y + 2 + ScrollY;

        bool isHover = mx >= x && mx <= x + Width && my >= y && my <= y + 24;

        if (isHover)
        {
            GUI.Cursor = MouseCursor.MOUSE_CURSOR_CROSSHAIR;

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                StartY = my - y;
            }
        }

        if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_BUTTON_LEFT))
        {
            StartY = 0;
        }

        if (StartY > 0)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
            {
                ScrollY = my - ((int)Position.Y + 2) - StartY;
                if (ScrollY < 0)
                {
                    ScrollY = 0;
                }
                if (ScrollY + 28 > Height)
                {
                    ScrollY = Height - 28;
                }
            }
        }
    }

    public override void Render()
    {
        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, Width, Height, Color.BLACK);
        Raylib.DrawRectangle((int)Position.X + 2, (int)Position.Y + 2 + ScrollY, 14, 24, Color.GRAY);
    }

}