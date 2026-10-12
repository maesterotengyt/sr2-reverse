// Namespace: Quantum
public struct TrapDoor : IComponent // TypeDefIndex: 10058
{
	// Fields
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public QBoolean IsOn; // 0x4
	public FP OffRotation; // 0x10
	public FP OnRotation; // 0x18
	public FP RotationSpeed; // 0x20
	public QString64 SwitchIDToReact; // 0x28
	[HideInInspector]
	public int SwitchIDToReactHash; // 0x0

	// Methods

	// RVA: 0x2135D60 Offset: 0x2134360 VA: 0x182135D60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2135F40 Offset: 0x2134540 VA: 0x182135F40
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2136010 Offset: 0x2134610 VA: 0x182136010
	public void Update(Frame frame) { }

	// RVA: 0x2135CE0 Offset: 0x21342E0 VA: 0x182135CE0
	public void Activate(Frame frame) { }

	// RVA: 0x2135D20 Offset: 0x2134320 VA: 0x182135D20
	public void Deactivate(Frame frame) { }

	// RVA: 0x2135DE0 Offset: 0x21343E0 VA: 0x182135DE0
	private void PlayActivationVFX(Frame frame) { }
}
