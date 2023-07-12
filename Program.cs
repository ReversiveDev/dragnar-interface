using Raylib_cs;

Raylib.InitWindow(800, 450, "raylib [core] example - basic window");
Raylib.SetTargetFPS(60);

GUI.Widgets.Add(new InputBox
{
    Width = 200
});
GUI.Widgets.Add(new Button()
{
    Label = "Press Me"
});
GUI.Widgets.Add(new ScrollBar());
GUI.Widgets.Add(new ListBox());
GUI.Widgets.Add(new CheckBox());

while (!Raylib.WindowShouldClose())
{
    GUI.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RAYWHITE);

    GUI.Render();

    Raylib.EndDrawing();
}

Raylib.CloseWindow();