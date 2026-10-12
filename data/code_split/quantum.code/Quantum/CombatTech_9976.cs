// Namespace: Quantum
public struct CombatTech : IComponent // TypeDefIndex: 9976
{
	// Fields
	[HideInInspector]
	public QBoolean DetectTechLock; // 0x0
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public FP TechBufferFrames; // 0x10
	[HideInInspector]
	public FP TechLockFrames; // 0x18

	// Methods

	// RVA: 0x20D46C0 Offset: 0x20D2CC0 VA: 0x1820D46C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D4760 Offset: 0x20D2D60 VA: 0x1820D4760
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D4710 Offset: 0x20D2D10 VA: 0x1820D4710
	public FP GetValue(Frame frame, CombatTechVariable variable) { }

	// RVA: 0x20D47C0 Offset: 0x20D2DC0 VA: 0x1820D47C0
	public void SetValue(Frame frame, CombatTechVariable variable, FP value) { }
}
