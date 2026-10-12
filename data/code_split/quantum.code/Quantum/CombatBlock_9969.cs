// Namespace: Quantum
public struct CombatBlock : IComponent // TypeDefIndex: 9969
{
	// Fields
	[HideInInspector]
	public FP BlockFrames; // 0x10
	[HideInInspector]
	public FP BlockStamina; // 0x18
	[HideInInspector]
	public QBoolean Blocking; // 0x0
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public FP PerfectBlockBufferFrames; // 0x20
	[HideInInspector]
	public FP PerfectBlockLockFrames; // 0x28

	// Methods

	// RVA: 0x20D3B00 Offset: 0x20D2100 VA: 0x1820D3B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D3BF0 Offset: 0x20D21F0 VA: 0x1820D3BF0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D3B80 Offset: 0x20D2180 VA: 0x1820D3B80
	public FP GetValue(Frame frame, CombatBlockVariable variable) { }

	// RVA: 0x20D3C70 Offset: 0x20D2270 VA: 0x1820D3C70
	public void SetValue(Frame frame, CombatBlockVariable variable, FP value) { }
}
