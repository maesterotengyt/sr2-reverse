// Namespace: Quantum
public struct RuntimeStatusEffect // TypeDefIndex: 9939
{
	// Fields
	public int NameId; // 0x0
	public EntityRef OriginEntity; // 0x18
	public int OriginId; // 0x4
	public FP RemainingFrames; // 0x20
	public AssetRefStatusEffectBase StatusEffectData; // 0x10
	public int Type; // 0x8

	// Methods

	// RVA: 0x20D22A0 Offset: 0x20D08A0 VA: 0x1820D22A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D2320 Offset: 0x20D0920 VA: 0x1820D2320
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
