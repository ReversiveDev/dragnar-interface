using System.Numerics;

class Widget
{
    public Vector2 Position;

    public Widget(int x, int y)
    {
        Position.X = x;
        Position.Y = y;
    }

    public Widget(Vector2 Position)
    {
        this.Position = Position;
    }

    public virtual void Render()
    {

    }

    public virtual void Update()
    {

    }

}