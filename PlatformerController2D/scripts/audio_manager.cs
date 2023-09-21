using Godot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class audio_manager : Node
{
	AudioStreamPlayer bgm;
	public override void _Ready()
	{
		bgm = GetNode<AudioStreamPlayer>("%bgm");		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void Play_BGM(){
		if(!bgm.Playing) bgm.Play();
	}
	public void Stop_BGM(){
		if(!bgm.Playing) bgm.Play();
	}
}
