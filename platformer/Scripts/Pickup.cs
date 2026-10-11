using Godot;

public partial class Pickup : Area2D
{
    [Export] public PickupType Type = PickupType.Coin;
    [Export] public Texture2D CoinTexture;
    [Export] public Texture2D GemTexture;
    [Export] public Texture2D KeyTexture;
    private bool collected = false;

    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;

        GetNode<Sprite2D>("Sprite2D").Texture = Type switch
        {
            PickupType.Gem => GemTexture,
            PickupType.Key => KeyTexture,
            _ => CoinTexture
        };
    }

    private void OnBodyEntered(Node2D body)
    {
        if (collected || body is not Player player || !player.IsActive)
            return;

        collected = true;
        player.OnPickup(Type);
        QueueFree();
    }
}


