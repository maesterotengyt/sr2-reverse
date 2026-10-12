// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Jump))]
[Serializable]
public class Jump_Prototype : PrototypeAdapter<Jump_Prototype> // TypeDefIndex: 3905
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public AssetRefJumpSettingsData JumpData; // 0x18
	[HideInInspector]
	public int JumpAnticipationFrames; // 0x20
	[HideInInspector]
	public QBoolean DoShortJump; // 0x24
	[HideInInspector]
	public JumpType_Prototype ActiveJump; // 0x28
	[HideInInspector]
	public FP JumpImpulseFrames; // 0x30
	[HideInInspector]
	public FPVector2 JumpImpulseVelocity; // 0x38
	[HideInInspector]
	public FPVector2 ReferenceLeftStick; // 0x48
	[HideInInspector]
	public QBoolean OnWallSlide; // 0x58
	[HideInInspector]
	public QBoolean TouchingFrontWall; // 0x5C
	[HideInInspector]
	public QBoolean TouchingBackWall; // 0x60

	// Methods

	// RVA: 0x677F20 Offset: 0x676520 VA: 0x180677F20 Slot: 5
	public sealed override Jump_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677FF0 Offset: 0x6765F0 VA: 0x180677FF0
	public void .ctor() { }
}
