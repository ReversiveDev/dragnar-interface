using Raylib_cs;

static class GUI
{
    public static List<Widget> Widgets = new List<Widget>();
    public static MouseCursor Cursor = MouseCursor.MOUSE_CURSOR_DEFAULT;

    public static void Render()
    {
        foreach (var widget in Widgets)
        {
            widget.Render();

        }
    }

    public static void Update()
    {
        GUI.Cursor = MouseCursor.MOUSE_CURSOR_DEFAULT;

        foreach (var widget in Widgets)
        {
            widget.Update();
        }

        Raylib.SetMouseCursor(GUI.Cursor);
    }

}