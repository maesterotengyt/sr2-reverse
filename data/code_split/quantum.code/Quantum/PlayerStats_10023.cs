// Namespace: Quantum
public struct PlayerStats : IComponent // TypeDefIndex: 10023
{
	// Fields
	public const int SIZE = 128;
	public const int ALIGNMENT = 8;
	[HideInInspector]
	public FP AliveTimer; // 0x48
	[HideInInspector]
	public FP BigAirCooldownFrames; // 0x50
	[HideInInspector]
	public FP BigAirFrames; // 0x58
	[HideInInspector]
	public int BombsHit; // 0x0
	[HideInInspector]
	public int CratesHit; // 0x4
	public EntityRef Entity; // 0x40
	[PtrQList(typeof(ExperienceEventData))]
	private Ptr ExperienceEventDataListPtr; // 0x34
	[HideInInspector]
	public int FireBallsHit; // 0x8
	[HideInInspector]
	public int FreezeRaysHit; // 0xC
	[HideInInspector]
	public int GoldenHooksHit; // 0x10
	[HideInInspector]
	[PtrQList(typeof(HitEvent))]
	private Ptr HitHistoryPtr; // 0x38
	[HideInInspector]
	public int InvinciDrillsHit; // 0x14
	[HideInInspector]
	public QBoolean IsNPC; // 0x28
	[HideInInspector]
	public int RegisteredGrappleSwingsInAir; // 0x18
	[HideInInspector]
	public int RocketsHit; // 0x1C
	[HideInInspector]
	public int RoundsWon; // 0x20
	[HideInInspector]
	public int ShockWavesHit; // 0x24
	[HideInInspector]
	public FP StillAliveCurrentTimer; // 0x60
	public FP StillAliveMargin; // 0x68
	public FP StillAliveTimer; // 0x70
	[HideInInspector]
	public FP SuperSpeedCooldownFrames; // 0x78
	[HideInInspector]
	public QBoolean TriggeredBigAir; // 0x2C
	[HideInInspector]
	public QBoolean TriggeredFloorIsLava; // 0x30

	// Properties
	public QListPtr<ExperienceEventData> ExperienceEventDataList { get; set; }
	public QListPtr<HitEvent> HitHistory { get; set; }

	// Methods

	// RVA: 0x212B250 Offset: 0x2129850 VA: 0x18212B250
	public QListPtr<ExperienceEventData> get_ExperienceEventDataList() { }

	// RVA: 0x5061F0 Offset: 0x5047F0 VA: 0x1805061F0
	public void set_ExperienceEventDataList(QListPtr<ExperienceEventData> value) { }

	// RVA: 0x212B290 Offset: 0x2129890 VA: 0x18212B290
	public QListPtr<HitEvent> get_HitHistory() { }

	// RVA: 0x8757D0 Offset: 0x873DD0 VA: 0x1808757D0
	public void set_HitHistory(QListPtr<HitEvent> value) { }

	// RVA: 0x2129390 Offset: 0x2127990 VA: 0x182129390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2128A70 Offset: 0x2127070 VA: 0x182128A70
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2129930 Offset: 0x2127F30 VA: 0x182129930
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2129D00 Offset: 0x2128300 VA: 0x182129D00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x212B180 Offset: 0x2129780 VA: 0x18212B180
	public void Update(Frame frame) { }

	// RVA: 0x21298B0 Offset: 0x2127EB0 VA: 0x1821298B0
	public void NotifyAcoladeVFX(Frame frame, int vfxID) { }

	// RVA: 0x21284B0 Offset: 0x2126AB0 VA: 0x1821284B0
	public void AliveCounter(Frame frame) { }

	// RVA: 0x2128D40 Offset: 0x2127340 VA: 0x182128D40
	public void DodgeEvent(Frame frame) { }

	// RVA: 0x212A9A0 Offset: 0x2128FA0 VA: 0x18212A9A0
	public void SuperSpeedEvent(Frame frame) { }

	// RVA: 0x21281C0 Offset: 0x21267C0 VA: 0x1821281C0
	public void AddHurtEvent(Frame frame, HitType hitType, EntityRef attackOwner) { }

	// RVA: 0x21299B0 Offset: 0x2127FB0 VA: 0x1821299B0
	public void RevengeEvent(Frame frame, HitType hitType, EntityRef damagedEntity) { }

	// RVA: 0x2129500 Offset: 0x2127B00 VA: 0x182129500
	public void HitEvent(Frame frame, HitType hitType, EntityRef damagedEntity) { }

	// RVA: 0x2128F00 Offset: 0x2127500 VA: 0x182128F00
	public void DoubleCombo(Frame frame) { }

	// RVA: 0x212AF20 Offset: 0x2129520 VA: 0x18212AF20
	public void TripleCombo(Frame frame) { }

	// RVA: 0x2128A80 Offset: 0x2127080 VA: 0x182128A80
	public void DeflectedEvent(Frame frame) { }

	// RVA: 0x2128520 Offset: 0x2126B20 VA: 0x182128520
	public void BlockEvent(Frame frame) { }

	// RVA: 0x212ABA0 Offset: 0x21291A0 VA: 0x18212ABA0
	public void TauntEvent(Frame frame) { }

	// RVA: 0x212AD00 Offset: 0x2129300 VA: 0x18212AD00
	public void TreasureEvent(Frame frame) { }

	// RVA: 0x21286E0 Offset: 0x2126CE0 VA: 0x1821286E0
	public void CheckAirAccolades(Frame frame) { }

	// RVA: 0x21290C0 Offset: 0x21276C0 VA: 0x1821290C0
	public int GetExperienceEventIndex(Frame frame, int ID) { }

	// RVA: 0x212A010 Offset: 0x2128610 VA: 0x18212A010
	public void StayAliveEvent(Frame frame) { }

	// RVA: 0x2128C50 Offset: 0x2127250 VA: 0x182128C50
	private FP DistanceToLine(FPVector2 point, FPVector2 lineStart, FPVector2 lineEnd) { }
}
