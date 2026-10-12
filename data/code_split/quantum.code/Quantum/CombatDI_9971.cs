// Namespace: Quantum
public struct CombatDI : IComponent // TypeDefIndex: 9971
{
	// Fields
	[HideInInspector]
	public QBoolean CalculateDI; // 0x4
	[HideInInspector]
	public FP DIAngle; // 0x10
	public EntityRef Entity; // 0x8
	[HideInInspector]
	public FPVector2 SDI; // 0x18
	[HideInInspector]
	public int TriggeredSDIs; // 0x0

	// Methods

	// RVA: 0x20D3F40 Offset: 0x20D2540 VA: 0x1820D3F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D4020 Offset: 0x20D2620 VA: 0x1820D4020
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D3FB0 Offset: 0x20D25B0 VA: 0x1820D3FB0
	public FP GetValue(Frame frame, CombatDIVariable variable) { }

	// RVA: 0x20D40C0 Offset: 0x20D26C0 VA: 0x1820D40C0
	public void SetValue(Frame frame, CombatDIVariable variable, FP value) { }
}
