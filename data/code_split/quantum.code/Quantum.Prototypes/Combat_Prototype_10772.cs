// Namespace: Quantum.Prototypes
[Prototype(typeof(Combat))]
[Serializable]
public sealed class Combat_Prototype : ComponentPrototype<Combat> // TypeDefIndex: 10772
{
	// Fields
	public QBoolean Active; // 0x18
	public MapEntityId Entity; // 0x1C
	[HideInInspector]
	public AssetRefCombatData CombatData; // 0x20
	[HideInInspector]
	public EntityHitFilter_Prototype HitFilter; // 0x28
	[HideInInspector]
	[DynamicCollection]
	public MapEntityId[] EntitiesHit; // 0x30
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
	public MapEntityId LastRedirector; // 0xBC
	[HideInInspector]
	public MapEntityId LastReflector; // 0xC0
	[HideInInspector]
	public FP RedirectAngle; // 0xC8
	[HideInInspector]
	public MapEntityId OwnerOverride; // 0xD0
	[HideInInspector]
	public QBoolean AffectedByFlinchlessHits; // 0xD4
	public int HitlagFramesOverride; // 0xD8

	// Methods

	// RVA: 0x2100340 Offset: 0x20FE940 VA: 0x182100340 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2100610 Offset: 0x20FEC10 VA: 0x182100610
	public void Materialize(Frame frame, ref Combat result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2100580 Offset: 0x20FEB80 VA: 0x182100580 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2100F50 Offset: 0x20FF550 VA: 0x182100F50
	public void .ctor() { }
}
