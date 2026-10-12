// Namespace: Quantum
public struct AIVolume : IComponent // TypeDefIndex: 9951
{
	// Fields
	[DrawIf("NeedsBoost.Value", 1, 0, 3)]
	public int BoostAmount; // 0x4
	[Header("Conditionals")]
	[PtrQList(typeof(EntityRef))]
	private Ptr ConditionalEntitiesPtr; // 0x3C
	public QBoolean ConditionalState; // 0x20
	public QBoolean Directional; // 0x24
	[HideInInspector]
	public QBoolean Disabled; // 0x28
	[DrawIf("VolumeDifficulty.Value", 1, 6, 3)]
	public int EasyChance; // 0x8
	[HideInInspector]
	public EntityRef Entity; // 0x50
	public int FrameDelay; // 0xC
	[DrawIf("VolumeType.Value", 5, 2, 3)]
	public int Frames; // 0x10
	[DrawIf("VolumeDifficulty.Value", 4, 6, 3)]
	public int HardChance; // 0x14
	[DrawIf("NeedsItem.Value", 1, 0, 3)]
	public QString64 ItemID; // 0x58
	public QBoolean NeedsBoost; // 0x2C
	public QBoolean NeedsItem; // 0x30
	[DrawIf("VolumeDifficulty.Value", 2, 6, 3)]
	public int NormalChance; // 0x18
	public QBoolean PreventDestroyOnStart; // 0x34
	[DrawIf("VolumeType.Value", 4, 5, 3)]
	public QBoolean Temporary; // 0x38
	[DrawIf("VolumeDifficulty.Value", 8, 6, 3)]
	public int UnfairChance; // 0x1C
	[Header("Difficulty")]
	public Difficulties VolumeDifficulty; // 0x0
	[DrawIf("Directional.Value", 1, 0, 3)]
	public VolumeDirection VolumeDirection; // 0x40
	public VolumeMode VolumeMode; // 0x44
	public VolumeType VolumeType; // 0x48

	// Properties
	public QListPtr<EntityRef> ConditionalEntities { get; set; }

	// Methods

	// RVA: 0x20C6B60 Offset: 0x20C5160 VA: 0x1820C6B60
	public QListPtr<EntityRef> get_ConditionalEntities() { }

	// RVA: 0x8757C0 Offset: 0x873DC0 VA: 0x1808757C0
	public void set_ConditionalEntities(QListPtr<EntityRef> value) { }

	// RVA: 0x20C5DD0 Offset: 0x20C43D0 VA: 0x1820C5DD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C5DC0 Offset: 0x20C43C0 VA: 0x1820C5DC0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20C67C0 Offset: 0x20C4DC0 VA: 0x1820C67C0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20C6840 Offset: 0x20C4E40 VA: 0x1820C6840
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20C5F10 Offset: 0x20C4510 VA: 0x1820C5F10
	public void OnBodyEnter(Frame frame, EntityRef other) { }
}
