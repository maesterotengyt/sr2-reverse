// Namespace: Quantum.Prototypes
[Prototype(typeof(GameEntity))]
[Serializable]
public sealed class GameEntity_Prototype : ComponentPrototype<GameEntity> // TypeDefIndex: 10803
{
	// Fields
	[HideInInspector]
	public GameEntityType_Prototype EntityType; // 0x18
	[HideInInspector]
	public int ID; // 0x1C
	[HideInInspector]
	public MapEntityId Entity; // 0x20
	public AssetRefGameEntityData GameEntityData; // 0x28
	[HideInInspector]
	public MapEntityId Owner; // 0x30
	[HideInInspector]
	public MapEntityId OriginalOwner; // 0x34
	[HideInInspector]
	public MapEntityId LastSpawned; // 0x38
	[HideInInspector]
	public QBoolean Visible; // 0x3C
	[HideInInspector]
	public int CostumeIndex; // 0x40
	public int FacingDirection; // 0x44
	[HideInInspector]
	public FP SmoothRotationStart; // 0x48
	[HideInInspector]
	public FP Rotation; // 0x50
	[HideInInspector]
	public FP RootRotation; // 0x58
	[HideInInspector]
	public FP Scale; // 0x60
	[HideInInspector]
	public FPVector2 RotationPivot; // 0x68
	[HideInInspector]
	[DynamicCollection]
	public ObjectVisibilityData_Prototype[] ObjectsVisibility; // 0x78
	[HideInInspector]
	[DynamicCollection]
	public SlotAttachmentData_Prototype[] SlotAttachments; // 0x80
	[HideInInspector]
	public QBoolean UseTransform3D; // 0x88
	[HideInInspector]
	public FPVector3 Position3D; // 0x90
	[Degrees]
	[HideInInspector]
	public FPVector3 Rotation3D; // 0xA8
	[HideInInspector]
	public int ActiveEntityTint; // 0xC0
	[HideInInspector]
	public int ActiveGameplayTint; // 0xC4
	[HideInInspector]
	public int ActiveStatusTint; // 0xC8
	[HideInInspector]
	public int ActiveOverallTint; // 0xCC

	// Methods

	// RVA: 0x21054E0 Offset: 0x2103AE0 VA: 0x1821054E0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2105760 Offset: 0x2103D60 VA: 0x182105760
	public void Materialize(Frame frame, ref GameEntity result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21056D0 Offset: 0x2103CD0 VA: 0x1821056D0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2105B70 Offset: 0x2104170 VA: 0x182105B70
	public void .ctor() { }
}
