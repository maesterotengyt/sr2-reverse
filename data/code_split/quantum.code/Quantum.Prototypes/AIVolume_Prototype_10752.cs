// Namespace: Quantum.Prototypes
[Prototype(typeof(AIVolume))]
[Serializable]
public sealed class AIVolume_Prototype : ComponentPrototype<AIVolume> // TypeDefIndex: 10752
{
	// Fields
	public QBoolean PreventDestroyOnStart; // 0x18
	[HideInInspector]
	public QBoolean Disabled; // 0x1C
	[HideInInspector]
	public MapEntityId Entity; // 0x20
	public VolumeType_Prototype VolumeType; // 0x24
	public VolumeMode_Prototype VolumeMode; // 0x28
	[DrawIf("VolumeType.Value", 5, 2, 3)]
	public int Frames; // 0x2C
	public int FrameDelay; // 0x30
	[DrawIf("VolumeType.Value", 4, 5, 3)]
	public QBoolean Temporary; // 0x34
	[Header("Difficulty")]
	public Difficulties_Prototype VolumeDifficulty; // 0x38
	[DrawIf("VolumeDifficulty.Value", 1, 6, 3)]
	public int EasyChance; // 0x3C
	[DrawIf("VolumeDifficulty.Value", 2, 6, 3)]
	public int NormalChance; // 0x40
	[DrawIf("VolumeDifficulty.Value", 4, 6, 3)]
	public int HardChance; // 0x44
	[DrawIf("VolumeDifficulty.Value", 8, 6, 3)]
	public int UnfairChance; // 0x48
	[Header("Conditionals")]
	[DynamicCollection]
	public MapEntityId[] ConditionalEntities; // 0x50
	public QBoolean ConditionalState; // 0x58
	public QBoolean NeedsBoost; // 0x5C
	[DrawIf("NeedsBoost.Value", 1, 0, 3)]
	public int BoostAmount; // 0x60
	public QBoolean NeedsItem; // 0x64
	[DrawIf("NeedsItem.Value", 1, 0, 3)]
	public QString64 ItemID; // 0x68
	public QBoolean Directional; // 0xA8
	[DrawIf("Directional.Value", 1, 0, 3)]
	public VolumeDirection_Prototype VolumeDirection; // 0xAC

	// Methods

	// RVA: 0x20FC260 Offset: 0x20FA860 VA: 0x1820FC260 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC4C0 Offset: 0x20FAAC0 VA: 0x1820FC4C0
	public void Materialize(Frame frame, ref AIVolume result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC430 Offset: 0x20FAA30 VA: 0x1820FC430 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FC700 Offset: 0x20FAD00 VA: 0x1820FC700
	public void .ctor() { }
}
