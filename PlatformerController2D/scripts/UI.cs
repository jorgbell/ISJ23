using Godot;
using System;

public partial class UI : CanvasLayer
{
	public Label score_label;
	int score = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		score_label = GetNode<Label>("%Score");
		update_UI();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsKeyPressed(Key.Space)){
			add_points(100);
		}
	}
	
	//llamar a esto con señales
	public void add_points(int points){
		score += points;
		update_UI();
	}
	
	public void update_UI(){
		score_label.Text = score.ToString();		
	}
	
}
