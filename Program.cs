using Raylib_cs;

Raylib.InitWindow(800, 450, "raylib [core] example - basic window");
Raylib.SetTargetFPS(60);

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
    Width = 738,
    PlaceHolder = "Escreva sua mensagem aqui."
});
GUI.Widgets.Add(new Button()
{
    Position = new(737, 426),
    Label = "Enviar"
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