using Godot;
using System;
using System.Runtime.InteropServices;

public partial class ResourcesLoader : Node
{
	public static int actualLevel = 1;
	static PackedScene w1,w2,sp1,sp2, thanks;
	public override void _EnterTree(){
		w1 = (PackedScene)ResourceLoader.Load("res://scenes/levels/winter/1.tscn");
		w2 = (PackedScene)ResourceLoader.Load("res://scenes/levels/winter/2.tscn");
		sp1 = (PackedScene)ResourceLoader.Load("res://scenes/levels/spring/1.tscn");
		sp2 = (PackedScene)ResourceLoader.Load("res://scenes/levels/spring/2.tscn");
		thanks = (PackedScene)ResourceLoader.Load("res://scenes/thanks.tscn");

	}
	
	public static PackedScene GetSceneToAdd(GameManager.SEASON actual){
		switch (actual)
		{
			case GameManager.SEASON.WINTER:
				if(actualLevel == 1)
					return w1;
				else
					return w2;
			case GameManager.SEASON.SPRING:
				if(actualLevel == 1)
					return sp1;
				else
					return sp2;
			default:
				return thanks;
		}
	}
}
