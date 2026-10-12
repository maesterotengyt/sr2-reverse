// Namespace: 
[CreateAssetMenu(menuName = "ScriptableObjects/ShapesVisualizerData", order = 0)]
public class StellarCollisionsVisualizerData : ScriptableObject // TypeDefIndex: 3660
{
	// Fields
	[Header("Hitbox")]
	public Color HitboxLow; // 0x18
	public Color HitboxMedium; // 0x28
	public Color HitboxHigh; // 0x38
	public Color HitboxFlinchless; // 0x48
	public Color RedirectHitBox; // 0x58
	public Color ReflectHitBox; // 0x68
	public Color GrabHitBox; // 0x78
	public Color GrabHitHitBox; // 0x88
	[Header("Hurtbox")]
	public Color HurtboxDefault; // 0x98
	public Color HurtboxArmor; // 0xA8
	public Color HurtboxSuperArmor; // 0xB8
	public Color HurtboxScalingArmor; // 0xC8
	public Color HurtboxInvincible; // 0xD8
	public Color HurtboxIntangible; // 0xE8
	public Color HurtboxBlock; // 0xF8
	[Header("Environment Collision Box")]
	public Color ECBDiamondColor; // 0x108
	[Range(0.01, 1)]
	public float ECBDiamondThickness; // 0x118
	public Color ECBRootColor; // 0x11C
	[Range(0.01, 1)]
	public float ECBRootSize; // 0x12C
	[Range(0.01, 1)]
	public float ECBRootThickness; // 0x130

	// Methods

	// RVA: 0x61B5E0 Offset: 0x619BE0 VA: 0x18061B5E0
	public void .ctor() { }
}
