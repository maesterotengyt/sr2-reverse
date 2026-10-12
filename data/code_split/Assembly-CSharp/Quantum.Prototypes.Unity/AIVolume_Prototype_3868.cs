// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(AIVolume))]
[Serializable]
public class AIVolume_Prototype : PrototypeAdapter<AIVolume_Prototype> // TypeDefIndex: 3868
{
	// Fields
	public QBoolean PreventDestroyOnStart; // 0x10
	[HideInInspector]
	public QBoolean Disabled; // 0x14
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	public VolumeType_Prototype VolumeType; // 0x20
	public VolumeMode_Prototype VolumeMode; // 0x24
	[DrawIf("VolumeType.Value", 5, 2, 3)]
	public int Frames; // 0x28
	public int FrameDelay; // 0x2C
	[DrawIf("VolumeType.Value", 4, 5, 3)]
	public QBoolean Temporary; // 0x30
	[Header("Difficulty")]
	public Difficulties_Prototype VolumeDifficulty; // 0x34
	[DrawIf("VolumeDifficulty.Value", 1, 6, 3)]
	public int EasyChance; // 0x38
	[DrawIf("VolumeDifficulty.Value", 2, 6, 3)]
	public int NormalChance; // 0x3C
	[DrawIf("VolumeDifficulty.Value", 4, 6, 3)]
	public int HardChance; // 0x40
	[DrawIf("VolumeDifficulty.Value", 8, 6, 3)]
	public int UnfairChance; // 0x44
	[Header("Conditionals")]
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] ConditionalEntities; // 0x48
	public QBoolean ConditionalState; // 0x50
	public QBoolean NeedsBoost; // 0x54
	[DrawIf("NeedsBoost.Value", 1, 0, 3)]
	public int BoostAmount; // 0x58
	public QBoolean NeedsItem; // 0x5C
	[DrawIf("NeedsItem.Value", 1, 0, 3)]
	public QString64 ItemID; // 0x60
	public QBoolean Directional; // 0xA0
	[DrawIf("Directional.Value", 1, 0, 3)]
	public VolumeDirection_Prototype VolumeDirection; // 0xA4

	// Methods

	// RVA: 0x670B20 Offset: 0x66F120 VA: 0x180670B20 Slot: 5
	public sealed override AIVolume_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x670D30 Offset: 0x66F330 VA: 0x180670D30
	public void .ctor() { }
}
