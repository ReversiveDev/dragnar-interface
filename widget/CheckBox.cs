using Raylib_cs;

class CheckBox : Widget
{
    bool IsChecked = false;

    public CheckBox() : base(280, 50) { }

    public override void Update()
    {
        int x = Raylib.GetMouseX();
        int y = Raylib.GetMouseY();

        bool isHover = x >= Position.X && x <= Position.X + 24 && y >= Position.Y && y <= Position.Y + 24;

        if (isHover)
        {
            GUI.Cursor = MouseCursor.MOUSE_CURSOR_CROSSHAIR;

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                IsChecked = !IsChecked;
            }
        }
    }

    public override void Render()
    {
        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, 24, 24, Color.BLACK);
        if(IsChecked)
            Raylib.DrawRectangle((int)Position.X + 3, (int)Position.Y + 3, 18, 18, Color.GRAY);
    }

}