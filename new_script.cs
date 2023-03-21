using Godot;
using System;

public partial class new_script : Node2D
{
	// Declare member variables here
	private Sprite2D sedan_blue;
	private float amplitude = 20f;
	private float frequency = 10f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		// Get the reference to the car AnimatedSprite node
		sedan_blue = GetNode<Sprite2D>("sedan_blue");

		// Set the car's initial position
		sedan_blue.Position = new Vector2(100, 100);
		

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Get the current position of the car
		Vector2 position = sedan_blue.Position;

		// Calculate a new Y position based on a sine and cosine wave
		var time = (float)GetProcessDeltaTime() * frequency;
		var sine_wave = Mathf.Sin(time) * amplitude;
		var cosine_wave = Mathf.Cos(time) * amplitude;
		var new_y = position.Y + (sine_wave + cosine_wave);

		// Set the new position of the car
		sedan_blue.Position = new Vector2(position.X, new_y);
	}
}
