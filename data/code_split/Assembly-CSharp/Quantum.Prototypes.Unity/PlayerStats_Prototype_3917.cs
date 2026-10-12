// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PlayerStats))]
[Serializable]
public class PlayerStats_Prototype : PrototypeAdapter<PlayerStats_Prototype> // TypeDefIndex: 3917
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean IsNPC; // 0x18
	[HideInInspector]
	public int RoundsWon; // 0x1C
	[HideInInspector]
	[DynamicCollection]
	public HitEvent_Prototype[] HitHistory; // 0x20
	[HideInInspector]
	public QBoolean TriggeredBigAir; // 0x28
	[HideInInspector]
	public QBoolean TriggeredFloorIsLava; // 0x2C
	[HideInInspector]
	public FP BigAirFrames; // 0x30
	[HideInInspector]
	public int RegisteredGrappleSwingsInAir; // 0x38
	public FP StillAliveTimer; // 0x40
	public FP StillAliveMargin; // 0x48
	[HideInInspector]
	public FP StillAliveCurrentTimer; // 0x50
	[HideInInspector]
	public FP AliveTimer; // 0x58
	[HideInInspector]
	public FP SuperSpeedCooldownFrames; // 0x60
	[HideInInspector]
	public FP BigAirCooldownFrames; // 0x68
	[HideInInspector]
	public int RocketsHit; // 0x70
	[HideInInspector]
	public int BombsHit; // 0x74
	[HideInInspector]
	public int FreezeRaysHit; // 0x78
	[HideInInspector]
	public int CratesHit; // 0x7C
	[HideInInspector]
	public int InvinciDrillsHit; // 0x80
	[HideInInspector]
	public int FireBallsHit; // 0x84
	[HideInInspector]
	public int ShockWavesHit; // 0x88
	[HideInInspector]
	public int GoldenHooksHit; // 0x8C
	[DynamicCollection]
	public ExperienceEventData_Prototype[] ExperienceEventDataList; // 0x90

	// Methods

	// RVA: 0x67CE10 Offset: 0x67B410 VA: 0x18067CE10 Slot: 5
	public sealed override PlayerStats_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67D030 Offset: 0x67B630 VA: 0x18067D030
	public void .ctor() { }
}
