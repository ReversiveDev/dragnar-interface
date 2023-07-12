using Raylib_cs;

Raylib.InitWindow(800, 450, "raylib [core] example - basic window");
Raylib.SetTargetFPS(60);

// GUI.Widgets.Add(new Button()
// {
//     Label = "Press Me"
// });
// GUI.Widgets.Add(new ScrollBar());
// GUI.Widgets.Add(new CheckBox());
GUI.Widgets.Add(new ListBox()
{
    Position = new(0, 327),
    Height = 100,
    Width = 800
});
GUI.Widgets.Add(new InputBox
{
    Position = new(0, 426),
    Width = 800
});

while (!Raylib.WindowShouldClose())
{
    GUI.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RAYWHITE);

    GUI.Render();

    Raylib.EndDrawing();
}

Raylib.CloseWindow();