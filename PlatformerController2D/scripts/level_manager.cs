using Godot;
using System;

public partial class level_manager : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		PackedScene actualScene = ResourcesLoader.GetSceneToAdd(GameManager.actualSeason);
		Node2D node = actualScene.Instantiate<Node2D>();
		AddChild(node);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
