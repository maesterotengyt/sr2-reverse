// Namespace: Photon.Deterministic
public struct RNGSession // TypeDefIndex: 17517
{
	// Fields
	public const int SIZE = 16;
	public const uint MAX = 4294967295;
	private ulong state; // 0x0
	private ulong inc; // 0x8

	// Methods

	// RVA: 0x20BF660 Offset: 0x20BDC60 VA: 0x1820BF660
	public FP NextInclusive(FP minInclusive, FP maxInclusive) { }

	// RVA: 0x20BF840 Offset: 0x20BDE40 VA: 0x1820BF840
	public int Next(int minInclusive, int maxExclusive) { }

	// RVA: 0x20BF5D0 Offset: 0x20BDBD0 VA: 0x1820BF5D0
	public int NextInclusive(int minInclusive, int maxInclusive) { }

	// RVA: 0x20BF7C0 Offset: 0x20BDDC0 VA: 0x1820BF7C0
	private uint NextUnbiased(uint max) { }

	// RVA: 0x20BFBC0 Offset: 0x20BE1C0 VA: 0x1820BFBC0
	public void .ctor(int seed) { }

	// RVA: 0x20BF770 Offset: 0x20BDD70 VA: 0x1820BF770
	internal uint NextUInt32() { }

	// RVA: 0x20BF9B0 Offset: 0x20BDFB0 VA: 0x1820BF9B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20BF8F0 Offset: 0x20BDEF0 VA: 0x1820BF8F0
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x20BF590 Offset: 0x20BDB90 VA: 0x1820BF590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20BF720 Offset: 0x20BDD20 VA: 0x1820BF720
	private static ulong NextSplitMix64(ref ulong x) { }
}
