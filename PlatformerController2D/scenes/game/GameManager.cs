using Godot;
using System;

public partial class GameManager : Node2D
{
	audio_manager audioManager;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		audioManager = 	GetNode<audio_manager>("%audioManager");		
		audioManager.Play_BGM();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}