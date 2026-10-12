// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(GameEntity))]
[Serializable]
public class GameEntity_Prototype : PrototypeAdapter<GameEntity_Prototype> // TypeDefIndex: 3897
{
	// Fields
	[HideInInspector]
	public GameEntityType_Prototype EntityType; // 0x10
	[HideInInspector]
	public int ID; // 0x14
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	public AssetRefGameEntityData GameEntityData; // 0x20
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Owner; // 0x28
	[HideInInspector]
	[LocalReference]
	public EntityPrototype OriginalOwner; // 0x30
	[HideInInspector]
	[LocalReference]
	public EntityPrototype LastSpawned; // 0x38
	[HideInInspector]
	public QBoolean Visible; // 0x40
	[HideInInspector]
	public int CostumeIndex; // 0x44
	public int FacingDirection; // 0x48
	[HideInInspector]
	public FP SmoothRotationStart; // 0x50
	[HideInInspector]
	public FP Rotation; // 0x58
	[HideInInspector]
	public FP RootRotation; // 0x60
	[HideInInspector]
	public FP Scale; // 0x68
	[HideInInspector]
	public FPVector2 RotationPivot; // 0x70
	[HideInInspector]
	[DynamicCollection]
	public ObjectVisibilityData_Prototype[] ObjectsVisibility; // 0x80
	[HideInInspector]
	[DynamicCollection]
	public SlotAttachmentData_Prototype[] SlotAttachments; // 0x88
	[HideInInspector]
	public QBoolean UseTransform3D; // 0x90
	[HideInInspector]
	public FPVector3 Position3D; // 0x98
	[Degrees]
	[HideInInspector]
	public FPVector3 Rotation3D; // 0xB0
	[HideInInspector]
	public int ActiveEntityTint; // 0xC8
	[HideInInspector]
	public int ActiveGameplayTint; // 0xCC
	[HideInInspector]
	public int ActiveStatusTint; // 0xD0
	[HideInInspector]
	public int ActiveOverallTint; // 0xD4

	// Methods

	// RVA: 0x676F40 Offset: 0x675540 VA: 0x180676F40 Slot: 5
	public sealed override GameEntity_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677100 Offset: 0x675700 VA: 0x180677100
	public void .ctor() { }
}
