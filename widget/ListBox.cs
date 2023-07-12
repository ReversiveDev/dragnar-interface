using Raylib_cs;
using System.Numerics;

class ListBox : Widget
{
    ScrollBar scrollBar = new() {
        Position = new Vector2(332, 200),
        Height = 200
    };

    public ListBox() : base(150, 200) {

    }

    public override void Update()
    {
        int mx = Raylib.GetMouseX();
        int my = Raylib.GetMouseY();

        scrollBar.Update();
    }

    public override void Render()
    {
        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, 200, 200, Color.BLACK);
    

        scrollBar.Render();
    }

}