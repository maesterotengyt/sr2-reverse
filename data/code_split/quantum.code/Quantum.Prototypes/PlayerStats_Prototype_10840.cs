// Namespace: Quantum.Prototypes
[Prototype(typeof(PlayerStats))]
[Serializable]
public sealed class PlayerStats_Prototype : ComponentPrototype<PlayerStats> // TypeDefIndex: 10840
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean IsNPC; // 0x1C
	[HideInInspector]
	public int RoundsWon; // 0x20
	[HideInInspector]
	[DynamicCollection]
	public HitEvent_Prototype[] HitHistory; // 0x28
	[HideInInspector]
	public QBoolean TriggeredBigAir; // 0x30
	[HideInInspector]
	public QBoolean TriggeredFloorIsLava; // 0x34
	[HideInInspector]
	public FP BigAirFrames; // 0x38
	[HideInInspector]
	public int RegisteredGrappleSwingsInAir; // 0x40
	public FP StillAliveTimer; // 0x48
	public FP StillAliveMargin; // 0x50
	[HideInInspector]
	public FP StillAliveCurrentTimer; // 0x58
	[HideInInspector]
	public FP AliveTimer; // 0x60
	[HideInInspector]
	public FP SuperSpeedCooldownFrames; // 0x68
	[HideInInspector]
	public FP BigAirCooldownFrames; // 0x70
	[HideInInspector]
	public int RocketsHit; // 0x78
	[HideInInspector]
	public int BombsHit; // 0x7C
	[HideInInspector]
	public int FreezeRaysHit; // 0x80
	[HideInInspector]
	public int CratesHit; // 0x84
	[HideInInspector]
	public int InvinciDrillsHit; // 0x88
	[HideInInspector]
	public int FireBallsHit; // 0x8C
	[HideInInspector]
	public int ShockWavesHit; // 0x90
	[HideInInspector]
	public int GoldenHooksHit; // 0x94
	[DynamicCollection]
	public ExperienceEventData_Prototype[] ExperienceEventDataList; // 0x98

	// Methods

	// RVA: 0x210C7E0 Offset: 0x210ADE0 VA: 0x18210C7E0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210C9F0 Offset: 0x210AFF0 VA: 0x18210C9F0
	public void Materialize(Frame frame, ref PlayerStats result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210C960 Offset: 0x210AF60 VA: 0x18210C960 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210CE20 Offset: 0x210B420 VA: 0x18210CE20
	public void .ctor() { }
}
