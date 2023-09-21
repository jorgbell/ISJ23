using Godot;
using System;

public partial class ResourcesLoader : Node
{
	public static PackedScene winterScene,springScene,summerScene,autumnScene;

	public override void _EnterTree(){
		winterScene = (PackedScene)ResourceLoader.Load("res://scenes/levels/winter.tscn");
		springScene = (PackedScene)ResourceLoader.Load("res://scenes/levels/spring.tscn");
		summerScene = (PackedScene)ResourceLoader.Load("res://scenes/levels/summer.tscn");
		autumnScene = (PackedScene)ResourceLoader.Load("res://scenes/levels/autumn.tscn");
	}

			
	public static PackedScene GetSceneToAdd(GameManager.SEASON actual){
		switch (actual)
		{
			case GameManager.SEASON.AUTUMN:
				return autumnScene;
			case GameManager.SEASON.SPRING:
				return springScene;
			case GameManager.SEASON.WINTER:
				return winterScene;
			case GameManager.SEASON.SUMMER:
				return summerScene;
		}
		return null;
	}
}
