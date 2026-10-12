// Namespace: Quantum
public struct NavMeshRegionMask : IEquatable<NavMeshRegionMask> // TypeDefIndex: 11695
{
	// Fields
	public const int SIZE = 8;
	private ulong _regions; // 0x0

	// Properties
	public static NavMeshRegionMask Default { get; }
	public bool HasValidRegions { get; }
	public bool IsMainArea { get; }

	// Methods

	// RVA: 0x1E629E0 Offset: 0x1E60FE0 VA: 0x181E629E0
	public static NavMeshRegionMask get_Default() { }

	// RVA: 0x221BEC0 Offset: 0x221A4C0 VA: 0x18221BEC0
	public static NavMeshRegionMask Combine(NavMeshRegionMask a, NavMeshRegionMask b) { }

	// RVA: 0x221BFB0 Offset: 0x221A5B0 VA: 0x18221BFB0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x93BBC0 Offset: 0x93A1C0 VA: 0x18093BBC0
	public void .ctor(ulong regions) { }

	// RVA: 0x1FA0950 Offset: 0x1F9EF50 VA: 0x181FA0950
	public bool get_HasValidRegions() { }

	// RVA: 0x8E8FF0 Offset: 0x8E75F0 VA: 0x1808E8FF0
	public bool get_IsMainArea() { }

	// RVA: 0x221BF50 Offset: 0x221A550 VA: 0x18221BF50
	public bool IsRegionEnabled(int region) { }

	// RVA: 0x221BF70 Offset: 0x221A570 VA: 0x18221BF70
	public bool IsSubset(NavMeshRegionMask other) { }

	// RVA: 0x221BEB0 Offset: 0x221A4B0 VA: 0x18221BEB0
	public void Clear() { }

	// RVA: 0x93B7B0 Offset: 0x939DB0 VA: 0x18093B7B0 Slot: 4
	public bool Equals(NavMeshRegionMask other) { }

	// RVA: 0x221BED0 Offset: 0x221A4D0 VA: 0x18221BED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x221BF30 Offset: 0x221A530 VA: 0x18221BF30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x93B910 Offset: 0x939F10 VA: 0x18093B910 Slot: 3
	public override string ToString() { }

	// RVA: 0x221BF80 Offset: 0x221A580 VA: 0x18221BF80
	public void Serialize(ByteStream stream, bool write) { }
}
