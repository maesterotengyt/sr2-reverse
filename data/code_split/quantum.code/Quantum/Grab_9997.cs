// Namespace: Quantum
public struct Grab : IComponent // TypeDefIndex: 9997
{
	// Fields
	public QBoolean Active; // 0x14
	[HideInInspector]
	public QBoolean CanBeGrabbed; // 0x18
	[HideInInspector]
	public QBoolean CanEscapeGrab; // 0x1C
	public EntityRef Entity; // 0x38
	public AssetRefGrabData GrabData; // 0x30
	[HideInInspector]
	public GrabDirection GrabDirection; // 0x4
	[HideInInspector]
	public FPVector3 GrabJointPosition; // 0x68
	[HideInInspector]
	public FPVector3 GrabJointRotation; // 0x80
	[HideInInspector]
	public GrabMode GrabMode; // 0x8
	[HideInInspector]
	public GrabState GrabState; // 0xC
	[HideInInspector]
	public QBoolean GrabbableOnlyByOwner; // 0x20
	[HideInInspector]
	public GrabbedAction GrabbedAction; // 0x0
	[HideInInspector]
	public EntityRef GrabbedEntity; // 0x40
	[HideInInspector]
	public EntityRef GrabberEntity; // 0x48
	[HideInInspector]
	public int JointID; // 0x10
	[HideInInspector]
	public FP RemainingFramesToEscape; // 0x50
	[HideInInspector]
	public QBoolean StrongThrow; // 0x24
	[HideInInspector]
	public QBoolean StrongUse; // 0x28
	[HideInInspector]
	public FPVector2 ThrowDirection; // 0x58

	// Methods

	// RVA: 0x211AB10 Offset: 0x2119110 VA: 0x18211AB10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211AEC0 Offset: 0x21194C0 VA: 0x18211AEC0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x211AD80 Offset: 0x2119380 VA: 0x18211AD80
	internal void Initialize(Frame frame, EntityRef entity, AssetRefGrabData grabData) { }

	// RVA: 0x211ADC0 Offset: 0x21193C0 VA: 0x18211ADC0
	internal void Reset(Frame frame) { }

	// RVA: 0x211AC10 Offset: 0x2119210 VA: 0x18211AC10
	internal FP GetValue(Frame frame, GrabVariable variable) { }

	// RVA: 0x211B090 Offset: 0x2119690 VA: 0x18211B090
	internal void SetValue(Frame frame, GrabVariable variable, FP value) { }

	// RVA: 0x211BAA0 Offset: 0x211A0A0 VA: 0x18211BAA0
	internal void Update(Frame frame) { }

	// RVA: 0x211B2B0 Offset: 0x21198B0 VA: 0x18211B2B0
	internal void StartGrab(Frame frame, CombatSettingsData combatSettingsData, Grab* target) { }

	// RVA: 0x211B700 Offset: 0x2119D00 VA: 0x18211B700
	internal void StopGrab(Frame frame, bool doRebound = True) { }

	// RVA: 0x211A8C0 Offset: 0x2118EC0 VA: 0x18211A8C0
	internal bool CanGrabEntity(Frame frame, CombatEntity target) { }
}
