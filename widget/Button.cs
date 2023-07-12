using Raylib_cs;

class Button : Widget
{
    public string Label = "Button";
    public int LeftPadding = 5;
    public int RightPadding = 5;

    public Button() : base(50, 50)
    {

    }

    public override void Update()
    {
        int x = Raylib.GetMouseX();
        int y = Raylib.GetMouseY();

        int width = Raylib.MeasureText(Label, 18);

        bool isHover = x >= Position.X && x <= Position.X + width + LeftPadding + RightPadding && y >= Position.Y && y <= Position.Y + 24;

        if (isHover)
        {
            GUI.Cursor = MouseCursor.MOUSE_CURSOR_CROSSHAIR;
        }
    }

    public override void Render()
    {
        int width = Raylib.MeasureText(Label, 18);

        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, width + LeftPadding + RightPadding, 24, Color.BLACK);
        Raylib.DrawText(Label, (int)Position.X + 5, (int)Position.Y + 4, 18, Color.BLACK);
    }


}

