using Godot;
using System;

public partial class character_body_2d : CharacterBody2D
{
	public const float Speed = 400.0f;
	public const float JumpVelocity = -450.0f;
	private AnimatedSprite2D sprite;
	public bool isLeft;
	
	public override void _Ready()
	{
	   sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}
	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;
			sprite.Play("fall");

		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
			velocity.Y = JumpVelocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
		
		//flips sprite for animation
		if (velocity.X > 0)
		{
			sprite.FlipH = false;
		}
		else if (velocity.X < 0)
		{
			sprite.FlipH = true;
		}
		//animation
		if (velocity.X == 0 && velocity.Y == 0)
		{
			if (sprite.Animation != "defualt")
			{
				sprite.Play("default");
			}
		}
		
	}
}
