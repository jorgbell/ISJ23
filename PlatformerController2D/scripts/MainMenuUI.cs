using Godot;
using System;

public partial class MainMenuUI : CanvasLayer
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnClick(){
		GetTree().ChangeSceneToFile("res://scenes/game/game.tscn");
	}
	public void GoToCredits(){
		GetTree().ChangeSceneToFile("res://scenes/ui/credits.tscn");
	}
}
