// Namespace: Quantum
public struct GameEntity : IComponent // TypeDefIndex: 9993
{
	// Fields
	public const int SIZE = 192;
	public const int ALIGNMENT = 8;
	[HideInInspector]
	public int ActiveEntityTint; // 0x4
	[HideInInspector]
	public int ActiveGameplayTint; // 0x8
	[HideInInspector]
	public int ActiveOverallTint; // 0xC
	[HideInInspector]
	public int ActiveStatusTint; // 0x10
	[HideInInspector]
	public int CostumeIndex; // 0x14
	[HideInInspector]
	public EntityRef Entity; // 0x38
	[HideInInspector]
	public GameEntityType EntityType; // 0x0
	public int FacingDirection; // 0x18
	public AssetRefGameEntityData GameEntityData; // 0x30
	[HideInInspector]
	public int ID; // 0x1C
	[HideInInspector]
	public EntityRef LastSpawned; // 0x40
	[HideInInspector]
	[PtrQList(typeof(ObjectVisibilityData))]
	private Ptr ObjectsVisibilityPtr; // 0x28
	[HideInInspector]
	public EntityRef OriginalOwner; // 0x48
	[HideInInspector]
	public EntityRef Owner; // 0x50
	[HideInInspector]
	public FPVector3 Position3D; // 0x88
	[HideInInspector]
	public FP RootRotation; // 0x58
	[HideInInspector]
	public FP Rotation; // 0x60
	[HideInInspector]
	public FPQuaternion Rotation3D; // 0xA0
	[HideInInspector]
	public FPVector2 RotationPivot; // 0x78
	[HideInInspector]
	public FP Scale; // 0x68
	[HideInInspector]
	[PtrQList(typeof(SlotAttachmentData))]
	private Ptr SlotAttachmentsPtr; // 0x2C
	[HideInInspector]
	public FP SmoothRotationStart; // 0x70
	[HideInInspector]
	public QBoolean UseTransform3D; // 0x20
	[HideInInspector]
	public QBoolean Visible; // 0x24

	// Properties
	public QListPtr<ObjectVisibilityData> ObjectsVisibility { get; set; }
	public QListPtr<SlotAttachmentData> SlotAttachments { get; set; }

	// Methods

	// RVA: 0x20E3C10 Offset: 0x20E2210 VA: 0x1820E3C10
	public QListPtr<ObjectVisibilityData> get_ObjectsVisibility() { }

	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void set_ObjectsVisibility(QListPtr<ObjectVisibilityData> value) { }

	// RVA: 0x20E3C50 Offset: 0x20E2250 VA: 0x1820E3C50
	public QListPtr<SlotAttachmentData> get_SlotAttachments() { }

	// RVA: 0x11DAC00 Offset: 0x11D9200 VA: 0x1811DAC00
	public void set_SlotAttachments(QListPtr<SlotAttachmentData> value) { }

	// RVA: 0x20E2EB0 Offset: 0x20E14B0 VA: 0x1820E2EB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E2BE0 Offset: 0x20E11E0 VA: 0x1820E2BE0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20E32E0 Offset: 0x20E18E0 VA: 0x1820E32E0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20E3360 Offset: 0x20E1960 VA: 0x1820E3360
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20E3150 Offset: 0x20E1750 VA: 0x1820E3150
	public void Initialize(GameEntityData gameEntityData, EntityRef entity, GameEntityType entityType, HashString entityName) { }

	// RVA: 0x20E2EA0 Offset: 0x20E14A0 VA: 0x1820E2EA0
	public void Enable(Frame frame) { }

	// RVA: 0x20E2E90 Offset: 0x20E1490 VA: 0x1820E2E90
	public void Disable(Frame frame) { }

	// RVA: 0x20E3B90 Offset: 0x20E2190 VA: 0x1820E3B90
	public void Update(Frame frame) { }

	// RVA: 0x20E3870 Offset: 0x20E1E70 VA: 0x1820E3870
	private void UpdateActiveState(Frame frame, bool active) { }

	// RVA: 0x20E3030 Offset: 0x20E1630 VA: 0x1820E3030
	public FP GetValue(GameEntityVariable variable) { }

	// RVA: 0x20E3650 Offset: 0x20E1C50 VA: 0x1820E3650
	public void SetValue(Frame frame, GameEntityVariable variable, FP value) { }

	// RVA: 0x20E3B40 Offset: 0x20E2140 VA: 0x1820E3B40
	public void UpdateVisibility(Frame frame, bool visible) { }

	// RVA: 0x20E3AE0 Offset: 0x20E20E0 VA: 0x1820E3AE0
	public void UpdateFacingDirection(Frame frame, GameEntity* gameEntity, int facingDirection) { }

	// RVA: 0x20E31C0 Offset: 0x20E17C0 VA: 0x1820E31C0
	public void InvertFacingDirection(Frame frame, GameEntity* gameEntity) { }

	// RVA: 0x20E3230 Offset: 0x20E1830 VA: 0x1820E3230
	public FPVector2 LocalToWorldPoint(FPVector2 position, FPVector2 point, bool ignoreScale = False) { }

	// RVA: 0x20E2BF0 Offset: 0x20E11F0 VA: 0x1820E2BF0
	public FPVector2 ConvertToRelativePoint(FPVector2 point, bool ignoreScale = False) { }
}
