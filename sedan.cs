using Godot;
using System;

public partial class sedan : Node2D
{
	private AnimationPlayer animationPlayer;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Get a reference to the AnimationPlayer node
		animationPlayer = GetNode<AnimationPlayer>("SedanVintage/sedan");

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Play the "sedan" animation in the AnimationPlayer
		animationPlayer.Play("sedan");
	}
}
