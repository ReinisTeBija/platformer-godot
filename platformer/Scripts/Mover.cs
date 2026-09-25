using Godot;
using System;

public partial class Mover : Node2D
{
	[Export] public float Speed = 200.0f;
	// Called when the node enters the scene tree for the first time.
	public override void _PhysicsProcess(double delta)
	{
		Position += new Vector2(Speed, 0) * (float)delta;
		if (Position.X > 1200)
			Position = new Vector2(80, Position.Y);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
