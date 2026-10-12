// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Combat))]
[Serializable]
public class Combat_Prototype : PrototypeAdapter<Combat_Prototype> // TypeDefIndex: 3877
{
	// Fields
	public QBoolean Active; // 0x10
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	[HideInInspector]
	public AssetRefCombatData CombatData; // 0x20
	[HideInInspector]
	public EntityHitFilter_Prototype HitFilter; // 0x28
	[HideInInspector]
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] EntitiesHit; // 0x30
	[HideInInspector]
	[DynamicCollection]
	public HitBox_Prototype[] HitBoxes; // 0x38
	[HideInInspector]
	[DynamicCollection]
	public HurtBox_Prototype[] HurtBoxes; // 0x40
	[HideInInspector]
	public QBoolean KnockedOut; // 0x48
	[HideInInspector]
	public QBoolean IsDown; // 0x4C
	[HideInInspector]
	public FP HitLagFrames; // 0x50
	[HideInInspector]
	public FP HitStunFrames; // 0x58
	[HideInInspector]
	public FP WeightForKnockback; // 0x60
	[HideInInspector]
	public HitInfo_Prototype LastInflictedHit; // 0x68
	[HideInInspector]
	public HitInfo_Prototype LastReceivedHit; // 0x70
	[HideInInspector]
	public SimpleAABB_Prototype RedirectAndReflectRect; // 0x78
	[HideInInspector]
	public SimpleAABB_Prototype HitBoxesRect; // 0x80
	[HideInInspector]
	public SimpleAABB_Prototype HurtBoxesRect; // 0x88
	[HideInInspector]
	public QBoolean IsIntangible; // 0x90
	[HideInInspector]
	public FP IntangibilityFrames; // 0x98
	[HideInInspector]
	public QBoolean IsInvincible; // 0xA0
	[HideInInspector]
	public FP InvincibilityFrames; // 0xA8
	[HideInInspector]
	public QBoolean RedirectedByAnything; // 0xB0
	[HideInInspector]
	public QBoolean CanBeRedirected; // 0xB4
	[HideInInspector]
	public QBoolean CanBeReflected; // 0xB8
	[HideInInspector]
	[LocalReference]
	public EntityPrototype LastRedirector; // 0xC0
	[HideInInspector]
	[LocalReference]
	public EntityPrototype LastReflector; // 0xC8
	[HideInInspector]
	public FP RedirectAngle; // 0xD0
	[HideInInspector]
	[LocalReference]
	public EntityPrototype OwnerOverride; // 0xD8
	[HideInInspector]
	public QBoolean AffectedByFlinchlessHits; // 0xE0
	public int HitlagFramesOverride; // 0xE4

	// Methods

	// RVA: 0x672DF0 Offset: 0x6713F0 VA: 0x180672DF0 Slot: 5
	public sealed override Combat_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x673130 Offset: 0x671730 VA: 0x180673130
	public void .ctor() { }
}
