// Namespace: Quantum
public struct EntityRef : IEquatable<EntityRef> // TypeDefIndex: 11590
{
	// Fields
	public const int SIZE = 8;
	[FieldOverlap(0)]
	public int Index; // 0x0
	public int Version; // 0x4
	[FieldOverlap(0)]
	internal ulong Raw; // 0x0
	private const string StringFormat = "E.{0:00000}.{1:000}{2}";
	private const string VersionSeparator = ".";
	private const string Prefix = "E.";
	private const string ActiveSign = "";
	private const string InactiveSign = "-";

	// Properties
	public static EntityRef None { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x81E2E0 Offset: 0x81C8E0 VA: 0x18081E2E0
	public static EntityRef get_None() { }

	// RVA: 0x1FA0950 Offset: 0x1F9EF50 VA: 0x181FA0950
	public bool get_IsValid() { }

	// RVA: 0x93BBD0 Offset: 0x93A1D0 VA: 0x18093BBD0
	public static bool op_Equality(EntityRef a, EntityRef b) { }

	// RVA: 0x6264D0 Offset: 0x624AD0 VA: 0x1806264D0
	public static bool op_Inequality(EntityRef a, EntityRef b) { }

	// RVA: 0x93B7B0 Offset: 0x939DB0 VA: 0x18093B7B0 Slot: 4
	public bool Equals(EntityRef other) { }

	// RVA: 0x21CD0B0 Offset: 0x21CB6B0 VA: 0x1821CD0B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21CD140 Offset: 0x21CB740 VA: 0x1821CD140 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21CD150 Offset: 0x21CB750 VA: 0x1821CD150
	public static void Serialize(void* ptr, FrameSerializer stream) { }

	// RVA: 0x21CD300 Offset: 0x21CB900 VA: 0x1821CD300 Slot: 3
	public override string ToString() { }
}
