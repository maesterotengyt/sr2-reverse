// Namespace: Quantum.Prototypes
[Prototype(typeof(Jump))]
[Serializable]
public sealed class Jump_Prototype : ComponentPrototype<Jump> // TypeDefIndex: 10820
{
	// Fields
	public MapEntityId Entity; // 0x18
	public AssetRefJumpSettingsData JumpData; // 0x20
	[HideInInspector]
	public int JumpAnticipationFrames; // 0x28
	[HideInInspector]
	public QBoolean DoShortJump; // 0x2C
	[HideInInspector]
	public JumpType_Prototype ActiveJump; // 0x30
	[HideInInspector]
	public FP JumpImpulseFrames; // 0x38
	[HideInInspector]
	public FPVector2 JumpImpulseVelocity; // 0x40
	[HideInInspector]
	public FPVector2 ReferenceLeftStick; // 0x50
	[HideInInspector]
	public QBoolean OnWallSlide; // 0x60
	[HideInInspector]
	public QBoolean TouchingFrontWall; // 0x64
	[HideInInspector]
	public QBoolean TouchingBackWall; // 0x68

	// Methods

	// RVA: 0x2107F90 Offset: 0x2106590 VA: 0x182107F90 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108170 Offset: 0x2106770 VA: 0x182108170
	public void Materialize(Frame frame, ref Jump result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21080E0 Offset: 0x21066E0 VA: 0x1821080E0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21081F0 Offset: 0x21067F0 VA: 0x1821081F0
	public void .ctor() { }
}
