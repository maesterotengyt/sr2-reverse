// Namespace: Quantum
[Serializable]
public struct StatusEffectAttributeModifier // TypeDefIndex: 9946
{
	// Fields
	public StatusEffectModifierOperation Operation; // 0x4
	[HideInInspector]
	public int OriginId; // 0x0
	public FP Value; // 0x8

	// Methods

	// RVA: 0x20D3040 Offset: 0x20D1640 VA: 0x1820D3040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D3080 Offset: 0x20D1680 VA: 0x1820D3080
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
