using Godot;

// Area2D zona, kurā mainās spēlētāja gravitācija (piem., mēness zema gravitācija).
public partial class GravityZone : Area2D
{
    // 1.0 = normāla gravitācija, 0.4 = zema (mēness), 2.0 = smaga
    [Export] public float GravityMultiplier = 0.4f;

    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
        BodyExited += OnBodyExited;
    }

    private void OnBodyEntered(Node2D body)
    {
        if (body is Player player)
            player.GravityMultiplier = GravityMultiplier;
    }

    private void OnBodyExited(Node2D body)
    {
        if (body is Player player)
            player.GravityMultiplier = 1.0f;
    }
}
