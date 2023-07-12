using Raylib_cs;

class ListBox : Widget
{
    readonly ScrollBar scrollBar = new() {
        Position = new(332, 200),
        Height = 200
    };
    public int Height = 200;
    public int Width = 200;

    public ListBox() : base(150, 200) {

    }

    public override void Update()
    {
        int mx = Raylib.GetMouseX();
        int my = Raylib.GetMouseY();

        scrollBar.Position.X = Position.X + Width - scrollBar.Width;
        scrollBar.Position.Y = Position.Y;
        scrollBar.Height = Height;
        scrollBar.Update();
    }

    public override void Render()
    {
        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, Width, Height, Color.BLACK);
    

        scrollBar.Render();
    }

}