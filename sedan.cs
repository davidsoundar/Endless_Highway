using Godot;
using System;

public partial class sedan : Node2D
{
	private AnimationPlayer animationPlayer;

	public override void _Ready()
	{
		animationPlayer = GetNode<AnimationPlayer>("SedanVintage/sedan");

	}

	public override void _Process(double delta)
	{
		animationPlayer.Play("sedan");
	}
}
