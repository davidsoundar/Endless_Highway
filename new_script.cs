using Godot;
using System;

public partial class new_script : Node2D
{
	// Declare member variables here
	private Sprite2D sedan_blue;
	private float amplitude = 20f;
	private float frequency = 10f;

	public override void _Ready()
	{

		sedan_blue = GetNode<Sprite2D>("sedan_blue");

		sedan_blue.Position = new Vector2(100, 100);
		

	}

	public override void _Process(double delta)
	{
		Vector2 position = sedan_blue.Position;

		var time = (float)GetProcessDeltaTime() * frequency;
		var sine_wave = Mathf.Sin(time) * amplitude;
		var cosine_wave = Mathf.Cos(time) * amplitude;
		var new_y = position.Y + (sine_wave + cosine_wave);

		sedan_blue.Position = new Vector2(position.X, new_y);
	}
}
